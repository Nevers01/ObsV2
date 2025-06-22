using Obs.Core.Helper;
using Obs.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Obs.Ui
{
    public partial class AddForm : Form
    {
        private object _entity;
        private Type _entityType;
        private Dictionary<string, Control> _controls = new();

        public AddForm(Type entityType)
        {
            InitializeComponent();
            _entityType = entityType;
            Load += AddForm_Load;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            _entity = Activator.CreateInstance(_entityType); // yeni boş nesne

            int y = 20;
            foreach (var prop in _entityType.GetProperties())
            {
                if (string.Equals(prop.Name, "Id", StringComparison.OrdinalIgnoreCase))
                    continue;

                Label label = new()
                {
                    Text = prop.Name,
                    Location = new Point(10, y),
                    Width = 120
                };
                this.Controls.Add(label);

                Control input;

                if (prop.Name.ToLower() == "auth")
                {
                    ComboBox cmb = new ComboBox
                    {
                        Name = prop.Name,
                        Location = new Point(140, y),
                        Width = 150,
                        DropDownStyle = ComboBoxStyle.DropDownList
                    };

                    using var context = new ObsDbContext();
                    var roller = context.Set<Authority>().ToList();
                    cmb.DataSource = roller;
                    cmb.DisplayMember = "AuthName";
                    cmb.ValueMember = "AuthName";

                    input = cmb;
                }
                else if (prop.PropertyType == typeof(bool))
                {
                    input = new CheckBox
                    {
                        Name = prop.Name,
                        Location = new Point(140, y)
                    };
                }
                else
                {
                    input = new TextBox
                    {
                        Name = prop.Name,
                        Location = new Point(140, y),
                        Width = 150
                    };
                }

                _controls[prop.Name] = input;
                this.Controls.Add(input);
                y += 35;
            }

            Button saveButton = new()
            {
                Text = "Kaydet",
                Location = new Point(140, y),
                Width = 100
            };
            saveButton.Click += SaveButton_Click;
            this.Controls.Add(saveButton);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            foreach (var kvp in _controls)
            {
                var prop = _entityType.GetProperty(kvp.Key);
                if (prop == null || !prop.CanWrite) continue;

                try
                {
                    if (kvp.Value is TextBox txt)
                    {
                        // Boşsa uyar
                        if (string.IsNullOrWhiteSpace(txt.Text))
                        {
                            MessageBox.Show($"'{prop.Name}' alanı boş bırakılamaz.");
                            txt.Focus();
                            return;
                        }

                        object value = Convert.ChangeType(txt.Text, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                        prop.SetValue(_entity, value);
                    }
                    else if (kvp.Value is CheckBox chk)
                    {
                        prop.SetValue(_entity, chk.Checked);
                    }
                    else if (kvp.Value is ComboBox cmb)
                    {
                        var selected = cmb.SelectedValue?.ToString();
                        if (string.IsNullOrWhiteSpace(selected))
                        {
                            MessageBox.Show($"'{prop.Name}' alanı boş bırakılamaz.");
                            cmb.Focus();
                            return;
                        }

                        prop.SetValue(_entity, selected);
                    }
                }
                catch
                {
                    MessageBox.Show($"'{prop.Name}' alanı geçersiz değer içeriyor.");
                    return;
                }
            }

            using var context = new ObsDbContext();
            context.Add(_entity);
            context.SaveChanges();

            MessageBox.Show("Kayıt başarıyla eklendi.");
            this.Close();
        }
    }
}
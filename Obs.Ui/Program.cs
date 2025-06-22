using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Obs.Core.Helper;
using Microsoft.EntityFrameworkCore;

namespace Obs.Ui
{
    internal static class Program
    {
        public static IHost AppHost { get; private set; }

        [STAThread]
        private static void Main()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json");
                })
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<ObsDbContext>(options =>
                        options.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection")));
                })
                .Build();

            ApplicationConfiguration.Initialize();

            var loginForm = new Loginform();
            var result = loginForm.ShowDialog();

            Form nextForm = null;

            if (result == DialogResult.OK)
                nextForm = new AdminForm();
            else if (result == DialogResult.Retry)
                nextForm = new UserForm();

            if (nextForm != null)
                Application.Run(nextForm);
            else
                Application.Exit();
        }
    }
}
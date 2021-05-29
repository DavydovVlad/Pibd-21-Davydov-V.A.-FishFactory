using CannedFactoryBusinessLogic.HelperModels;
using System;
using System.Threading;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CannedFactoryBusinessLogic.BusinessLogics;
using CannedFactoryBusinessLogic.Interfaces;
using CannedFactoryDatabaseImplement.Implements;

namespace CannedFactoryRestApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IClientStorage, ClientStorage>();
            services.AddTransient<IOrderStorage, OrderStorage>();
            services.AddTransient<ICannedStorage, CannedStorage>();
			services.AddTransient<IMessageInfoStorage, MessageInfoStorage>();
            services.AddTransient<OrderLogic>();
            services.AddTransient<ClientLogic>();
            services.AddTransient<CannedLogic>();
			services.AddTransient<MailLogic>();
            MailLogic.MailConfig(new MailConfig
            {
                SmtpClientHost = Configuration["SmtpClientHost"],
                SmtpClientPort = Convert.ToInt32(Configuration["SmtpClientPort"]),
                MailLogin = Configuration["MailLogin"],
                MailPassword = Configuration["MailPassword"],
            });

            var timer = new Timer(new TimerCallback(MailCheck), new MailCheckInfo
            {
                PopHost = Configuration["PopHost"],
                PopPort = Convert.ToInt32(Configuration["PopPort"]),
                Storage = new MessageInfoStorage(),
                ClientStorage = new ClientStorage()
            }, 0, 100000);
            services.AddControllers().AddNewtonsoftJson();
        }
		
		private static void MailCheck(object obj)
        {
            MailLogic.MailCheck((MailCheckInfo)obj);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) { app.UseDeveloperExceptionPage(); }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
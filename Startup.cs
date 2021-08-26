using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using WebSchoolAPI.Models;
using WebSchoolAPI.Repositories;
using WebSchoolAPI.Repositories.CourseRepository;
using WebSchoolAPI.Repositories.StudentRepository;
using WebSchoolAPI.Repositories.TeacherRepository;
using WebSchoolAPI.Repositories.UniversityRepository;

namespace WebSchoolAPI
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

            services.AddControllers();

            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IUniversityRepository, UniversityRepository>();

            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddDbContext<SchoolDbContext>(o =>
            o.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
         
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

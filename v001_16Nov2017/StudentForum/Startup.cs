using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentForum.Startup))]
namespace StudentForum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

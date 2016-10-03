using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_25_ValidateUserInformation.Startup))]
namespace Lab_25_ValidateUserInformation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

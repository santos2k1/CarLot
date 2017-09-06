using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarLot.Startup))]
namespace CarLot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

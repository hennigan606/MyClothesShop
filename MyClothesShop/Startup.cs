using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyClothesShop.Startup))]
namespace MyClothesShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

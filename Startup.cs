using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InventoryShoes.Startup))]
namespace InventoryShoes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

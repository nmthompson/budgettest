using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BudgetCommerce.Startup))]
namespace BudgetCommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelReview.Startup))]
namespace TravelReview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

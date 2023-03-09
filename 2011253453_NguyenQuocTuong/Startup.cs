using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2011253453_NguyenQuocTuong.Startup))]
namespace _2011253453_NguyenQuocTuong
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

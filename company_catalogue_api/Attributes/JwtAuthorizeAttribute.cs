using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using company_catalogue_api.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace company_catalogue_api.Attributes
{
    public class JwtAuthorizeAttribute : TypeFilterAttribute
    {
        public JwtAuthorizeAttribute(string roles) : base(typeof(JwtAuthorizeFilter))
        {
            Arguments = new object[] { roles };
        }

        public JwtAuthorizeAttribute() : base(typeof(JwtAuthorizeFilter))
        {
        }
    }
}

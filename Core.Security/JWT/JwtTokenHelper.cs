using Core.Security.JWT;
using Microsoft.Extensions.Configuration;

namespace Core.Infrastructure.Security.JWT
{
    public class JwtTokenHelper
    {
        public IConfiguration Configuration { get; }
        private readonly TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration;
    }
}
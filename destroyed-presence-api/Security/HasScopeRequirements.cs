using Microsoft.AspNetCore.Authorization;

namespace destroyed_presence_api.Security
{
    public class HasScopeRequirements : IAuthorizationRequirement
    {
        public string Scope { get; }
        public string Issuer { get; }

        public HasScopeRequirements(string scope, string issuer)
        {
            Scope = scope ?? throw new ArgumentNullException(nameof(scope));
            Issuer = issuer ?? throw new ArgumentNullException(nameof(issuer));
        }
    }
}

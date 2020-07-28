using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ErrorCentral.OAuth.Configuration
{
    public class IdentityConfig
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new IdentityResource[]
            {
                new IdentityResources.OpenId()
            };
        }

        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "alice",
                    Password = "password",
                    Claims = new [] {
                        new Claim(ClaimTypes.Role, "admin"),
                        new Claim(ClaimTypes.Email, "alice@mail.com")
                    }
                },
                new TestUser
                {
                    SubjectId = "2",
                    Username = "bob",
                    Password = "password",
                    Claims = new [] {
                        new Claim(ClaimTypes.Role, "user"),
                        new Claim(ClaimTypes.Email, "bob@mail.com")
                    }
                }
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>() {

                new Client
                {
                    ClientId = "error-central",
                    ClientSecrets = { new Secret("aceleradevcsharp".Sha256()) },
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    RedirectUris = new List<string>{ "https://localhost:5000/signin-oidc" },
                    RequirePkce = false,
                    AllowedScopes = { 
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "testeAPI"
                    },
                }

            };
        }

        public static IEnumerable<ApiScope> GetApiScopes() =>
            new List<ApiScope> { new ApiScope("testeAPI","Error Central API") };

        public static IEnumerable<ApiResource> GetApiResources() =>
            new List<ApiResource>
            {
                new ApiResource("testeAPI","Error Central API")
                {
                    Scopes = { "testeAPI" }
                }
            };

    }
}

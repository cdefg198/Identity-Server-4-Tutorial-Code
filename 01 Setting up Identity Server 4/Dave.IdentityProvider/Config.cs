﻿using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Dave.IdentityProvider
{
    public static class Config
    {
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "Nick",
                    Password = "password",

                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "Nick"),
                        new Claim("family_name", "Carter")
                    }
                },
                new TestUser
                {
                    SubjectId = "2",
                    Username = "Dave",
                    Password = "password",

                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "Dave"),
                        new Claim("family_name", "Mustaine")
                    }
                }
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }
    }
}
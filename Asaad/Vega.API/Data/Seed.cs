using System.Collections.Generic;
using Newtonsoft.Json;
using Vega.api.Data;
using Vega.API.Models;

namespace Vega.API.Data
{
    public class Seed
    {
        private readonly VegaDbContext context;
        public Seed (VegaDbContext context)
        {
            this.context = context;

        }
         public void SeedUsers()
        {
            // context.Users.RemoveRange(context.Users);
            // context.SaveChanges();

            // seed users
            // var userData = System.IO.File.ReadAllText("Data/UserSeedData.json");
            // var users = JsonConvert.DeserializeObject<List<User>>(userData);
            // foreach (var user in users)
            // {
            //     // create the password hash
            //     byte[] passwordHash, passwordSalt;
            //     CreatePasswordHash("password", out passwordHash, out passwordSalt);

            //     user.PasswordHash = passwordHash;
            //     user.PasswordSalt = passwordSalt;
            //     user.Username = user.Username.ToLower();

            //     context.Users.Add(user);
            // }

            // context.SaveChanges();
        }

        // private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        // {
        //     using (var hmac = new System.Security.Cryptography.HMACSHA512())
        //     {
        //         passwordSalt = hmac.Key;
        //         passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        //     }
        // }
    }
}
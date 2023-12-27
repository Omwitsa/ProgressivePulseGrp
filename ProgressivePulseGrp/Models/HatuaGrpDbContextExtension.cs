namespace ProgressivePulseGrp.Models
{
    public static class HatuaGrpDbContextExtension
    {
        public static void EnsureDatabaseSeeded(this HatuaGrpDbContext context)
        {
            if (!context.Users.Any())
            {
                //context.Add(new User
                //{
                //    UserName = "dean@abno.com",
                //    DateCreated = DateTime.UtcNow,
                //    EmailConfirmed = true,
                //    PasswordHash = SecurePasswordHasher.Hash("123456"),
                //    PhoneNumber = "0715507260",
                //    Status = true,
                //    Level = Level.Dean,

                //});
            }

            context.SaveChanges();
        }
    }
}

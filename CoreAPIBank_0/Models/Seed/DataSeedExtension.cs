using CoreAPIBank_0.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreAPIBank_0.Models.Seed
{
    public static class DataSeedExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            UserCardInfo uInfo = new UserCardInfo()
            {
                Id = 1,
                Balance = 10000,
                CardLimit = 10000,
                CardNumber = "1111 1111 1111 1111",
                CardUserName = "Test verisidir",
                CVC = "222",
                ExpiryMonth = 12,
                ExpiryYear = 2025
            };

            modelBuilder.Entity<UserCardInfo>().HasData(uInfo);
        }
    }
}

namespace mySmartWallet2022.Models.Data.Entities
{
    public class SeedHelperClass
    {
        public static async Task seed(ApplicationDbContext context)
        {
            if (!context.Customers.Any())
            {

                context.Customers.Add(new Customer

                {
                    FirstName = "John",
                    LastName = "Stones",
                    MiddleName = "Max",
                    gender = GenderEnum.male,
                    MaritalStatus= MaritalStatusEnum.Single,
                    DateOfBirth = DateTime.Now.AddYears(-20),
                    Country = "England",
                    State = "Manchester",
                    City ="LA",
                    Active = true,

                });
                context.Customers.Add(new Customer

                {
                    FirstName = "Delly",
                    LastName = "Jones",
                    MiddleName = "Alice",
                    gender = GenderEnum.Female,
                    MaritalStatus = MaritalStatusEnum.Single,
                    DateOfBirth = DateTime.Now.AddYears(-10),
                    Country = "England",
                    State = "shefffield",
                    City = "Texas",
                    Active = true,

                }
                    );
                // context.SaveChangesAsync();
                await context.SaveChangesAsync();
            }
        
        }
    }
}

namespace Homework
{
    public static class UserFactory
    {
        public static RegistrationUser CreateValidUser()
        {
            return new RegistrationUser
            {
                FirstName = "Test",
                LastName = "User",
                Year = "2000",
                Month = "2",
                Date = "1",
                Password = "gdsjafgujdsw",
                Gender = "male",
                PostCode = "4324422"
            };
        }
    }
}

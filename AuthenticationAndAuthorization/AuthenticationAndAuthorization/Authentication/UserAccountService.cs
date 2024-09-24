namespace AuthenticationAndAuthorization.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> users;

        public UserAccountService()
        {
            users = new List<UserAccount>
            {
                new UserAccount{UserName="admin",Password="admin", Role="Admministrator"},
                new UserAccount{UserName="school",Password="123", Role="school"}
            };
        }

        public UserAccount? GetByUserName (string username)
        {
            return users.FirstOrDefault(x => x.UserName == username);
        }
    }
}

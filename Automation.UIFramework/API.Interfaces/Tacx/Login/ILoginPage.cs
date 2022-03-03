namespace API.Interfaces.Tacx.Login
{
    public interface ILoginPage
    {
        void CreateNewAccount(string userName, string email, string password);
    }
}

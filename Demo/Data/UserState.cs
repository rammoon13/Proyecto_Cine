using Demo.Data.Models;

namespace Demo.Data
{
    public class UserState
    {
        public Usuario? Usuario { get; private set; }

        public void Login(Usuario usuario)
        {
            Usuario = usuario;
        }

        public void Logout()
        {
            Usuario = null;
        }
    }
}

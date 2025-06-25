using Demo.Data.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace Demo.Data
{
    public class UserState
    {
        private const string SessionKey = "current-user-id";
        private readonly ProtectedSessionStorage _sessionStorage;
        private readonly CinemaDbContext _context;

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();

        public UserState(ProtectedSessionStorage sessionStorage, CinemaDbContext context)
        {
            _sessionStorage = sessionStorage;
            _context = context;
        }

        public Usuario? Usuario { get; private set; }

        public async Task InitializeAsync()
        {
            var storedId = await _sessionStorage.GetAsync<int?>(SessionKey);
            if (storedId.Success && storedId.Value.HasValue)
            {
                Usuario = await _context.Usuarios.FindAsync(storedId.Value.Value);
                NotifyStateChanged();
            }
        }

        public async Task Login(Usuario usuario)
        {
            Usuario = usuario;
            await _sessionStorage.SetAsync(SessionKey, usuario.Id);
            NotifyStateChanged();
        }

        public async Task Logout()
        {
            Usuario = null;
            await _sessionStorage.DeleteAsync(SessionKey);
            NotifyStateChanged();
        }
    }
}

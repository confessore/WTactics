using System.Threading.Tasks;
using WTactics.Models;

namespace WTactics.Services.Interfaces
{
    public interface IMenuService
    {
        Task<Menu> GenerateNewMenuAsync();
    }
}

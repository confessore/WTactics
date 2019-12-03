using System.Threading.Tasks;
using WTactics.Models;

namespace WTactics.Services.Interfaces
{
    public interface IMapService
    {
        Task<Map> GenerateNewMapAsync();
    }
}

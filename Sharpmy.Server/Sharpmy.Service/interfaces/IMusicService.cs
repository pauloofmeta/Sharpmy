using System.Threading.Tasks;

namespace Sharpmy.Service.interfaces
{
    public interface IMusicService: IServiceBase
    {
         Task<bool> CatalogAsync();
    }
}
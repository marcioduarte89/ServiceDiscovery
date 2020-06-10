using System.Threading.Tasks;

namespace Discovery.UI.Services 
{
    public interface IGreetingsService
    {
        Task<string> GetGreetingsMessage();
    }
}

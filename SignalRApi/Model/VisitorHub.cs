using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRApi.Model
{
    public class VisitorHub : Hub
    {
        private readonly VisitorService _visitorService;

        public VisitorHub(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }
        public async Task GetVisitorList()
        {
            await Clients.All.SendAsync("CallVisitList", _visitorService.GetVisitorChartList());
        }
    }
}

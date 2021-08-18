using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using SignalRDemo.Services;

namespace SignalRDemo
{
    // [Authorize]
    public class CountHub : Hub
    {
        private readonly CountService _countService;

        public CountHub(CountService countService)
        {
            _countService = countService;
        }

        public async Task GetLatestCount(string random)
        {
            // var user = Context.User.Identity.Name;

            int count;
            do
            {
                count = _countService.GetLatestCount();

                Thread.Sleep(1000);

                await Clients.All.SendAsync("ReceiveUpdate", count);
            } while (count < 10);

            await Clients.All.SendAsync("Finished");
        }

        public override async Task OnConnectedAsync()
        {
            //// 建立連結後運行
            //var connectionId = Context.ConnectionId;

            //var client = Clients.Client(connectionId);

            //await client.SendAsync("someFunc", new { });
            //// 除此 connectionId 其他執行 someFunc
            //await Clients.AllExcept(connectionId).SendAsync("someFunc");

            //await Groups.AddToGroupAsync(connectionId, "MyGroup");
            //await Groups.RemoveFromGroupAsync(connectionId, "MyGroup");

            //await Clients.Groups("MyGroup").SendAsync("someFunc");
        }
    }
}

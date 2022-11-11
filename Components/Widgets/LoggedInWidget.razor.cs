using Microsoft.AspNetCore.Identity;

namespace BlazorServer.Components.Widgets
{
    public partial class LoggedInWidget
    {
        private int LoggedUsers { get; set; } = 0;

        protected override void OnInitialized()
        {
            LoggedUsers = new Random().Next(10);
        }
    }
}

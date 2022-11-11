using Microsoft.AspNetCore.Identity;

namespace BlazorServer.Components.Widgets
{
    public partial class LoggedInWidget
    {
        private int number { get; set; } = 0;

        protected override void OnInitialized()
        {
            number = new Random().Next(10);
        }
    }
}

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;

namespace BlazorServer.Components.Widgets
{
    public partial class LoggedInWidget
    {
        [Inject]
        public ApplicationState ApplicationState { get; set; } = null!;
        private int LoggedUsers { get; set; } 

        protected override void OnInitialized()
        {

            LoggedUsers=ApplicationState.Number;
        }
    }
}

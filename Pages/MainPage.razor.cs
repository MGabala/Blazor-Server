using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorServer.Pages
{
    public partial class MainPage
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        
        private async Task ClickEventHandler()
        {

        }
        private async Task InputString(ChangeEventArgs input)
        {
            Console.WriteLine(input.Value);
        }
        private async Task NavigateToDetails()
        {

        }
    }
}

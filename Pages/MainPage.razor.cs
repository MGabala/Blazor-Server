using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorServer.Pages
{
    public partial class MainPage
    {
        
        private async Task ClickEventHandler()
        {

        }
        private async Task InputString(ChangeEventArgs input)
        {
            Console.WriteLine(input.Value);
        }
    }
}

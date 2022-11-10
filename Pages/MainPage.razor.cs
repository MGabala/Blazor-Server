using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorServer.Pages
{
    public partial class MainPage
    {

        #region SimplyHitTheBreakPoint
        private async Task ClickEventHandler()
        {

        }
        #endregion
        #region InputPassingToMethod
        private async Task InputString(ChangeEventArgs input)
        {
            Console.WriteLine(input.Value);
        }
        #endregion
        #region HowToHitBreakPointViaButton
        //This is how you can hit methods via code from page
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        private async Task NavigateToDetails()
        {

        }
        //This is how you can hit methods via code from page
        #endregion
    }
}

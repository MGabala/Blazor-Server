using BlazorServer.Components;
using BlazorServer.Components.Widgets;
using BlazorServer.MockData;
using BlazorServer.Models;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http.Features;

namespace BlazorServer.Pages
{
    public partial class MainPage
    {
        public List<ItemModel> Items { get; set; }

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

        //This is how you can use widgets dynamically generated 
        #region Widgets
        public List<Type> Widgets { get; set; } = new List<Type>() {
                    typeof(LoggedInWidget)};
        #endregion

        #region ErrorHandling
        //<ErrorBoundary>
        //<ChildContent>

        //</ChildContent>
        //<ErrorContent>
        //<p class="error">Error</p>        
        //</ErrorContent>
        //</ErrorBoundary>
        #endregion

        #region DataBinding
        public ItemModel Item { get; set; }
        protected override Task OnInitializedAsync()
        {
            Item = new ItemModel
            {
                Id = 1,
                Name = "Test name",
                Description = "Test description"
            };
            return base.OnInitializedAsync();
        }
        #endregion
    }
}

using BlazorServer.Components;
using BlazorServer.Components.Widgets;
using BlazorServer.Entities;
using BlazorServer.MockData;
using BlazorServer.Models;
using BlazorServer.Repositories;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;

namespace BlazorServer.Pages
{
    public partial class MainPage
    {
        [Inject]
        private IItemRepository _repository { get; set; }

        public IEnumerable<ItemEntity> Items { get; set; }

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
        public ItemEntity Item { get; set; } = new ItemEntity();
        //protected override Task OnInitializedAsync()
        //{
        //    Item = new ItemEntity
        //    {
        //        Id = 1,
        //        Name = "Test name",
        //        Description = "Test description"
        //    };
        //    return base.OnInitializedAsync();
        //}
        public async Task Button_Click()
        {
            Item.Name = "Change value after hitting ";
        }
        #endregion
        [Parameter]
        public string ItemId { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Items = await _repository.GetAllItems();

            Item = new ItemEntity
            {
                Id = 1,
                Name = "Test name",
                Description = "Test description"
            };
        }

        //Upload file
        private IBrowserFile selectedFile;
        private void OnInputFileChange(InputFileChangeEventArgs input)
        {
            selectedFile = input.File;
            StateHasChanged();

            ////handle image upload
            //string currentUrl = _httpContextAccessor.HttpContext.Request.Host.Value;
            //var path = $"{_webHostEnvironment.WebRootPath}\\uploads\\{employee.ImageName}";
            //var fileStream = System.IO.File.Create(path);
            //fileStream.Write(employee.ImageContent, 0, employee.ImageContent.Length);
            //fileStream.Close();
        }

        #region SubmitingForm
        protected async Task HandleValidSubmit()
        {

        }
        protected async Task HandleInvalidSubmit()
        {

        }
        #endregion
    }
}

using Microsoft.AspNetCore.Components;

namespace BlazorServer.Components
{
    public partial class LoggedUsersCounter
    {
        private int NumberOfUsers;
        [Inject]
        public ApplicationState ApplicationState { get; set; } = null!;
        protected override void OnInitialized()
        {
            NumberOfUsers = new Random().Next(1, 10);
            ApplicationState.Number = NumberOfUsers;
        }
    }
}

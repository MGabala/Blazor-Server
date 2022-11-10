using System.Runtime.CompilerServices;

namespace BlazorServer.Pages
{
    public partial class Counter
    {


        private int currentCount = 0;
        private async Task IncrementCount()
        {
            currentCount++;
        }

    }
}
 
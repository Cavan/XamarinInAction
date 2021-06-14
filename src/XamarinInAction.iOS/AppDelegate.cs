using Foundation;
using MvvmCross.Platforms.Ios.Core;
using XamarinInAction.Core;

namespace XamarinInAction.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}

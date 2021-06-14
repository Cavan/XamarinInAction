using MvvmCross.ViewModels;
using XamarinInAction.Core.ViewModels.Main;

namespace XamarinInAction.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainViewModel>();
        }
    }
}

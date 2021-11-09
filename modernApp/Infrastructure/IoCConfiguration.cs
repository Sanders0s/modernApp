using GalaSoft.MvvmLight.Messaging;
using Microsoft.VisualStudio.OLE.Interop;
using modernApp.ViewModels;
using Ninject.Modules;
namespace modernApp.Infrastructure
{
    class IoCConfiguration : NinjectModule
    {
        public override void Load()
        {
            Bind<MainViewModel>().ToSelf().InTransientScope();

            Bind<IMessenger>().To<Messenger>().InSingletonScope();
        }
    }
}

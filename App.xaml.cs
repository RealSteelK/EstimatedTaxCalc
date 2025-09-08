using System.Configuration;
using System.Data;
using System.Windows;
using Prism.Unity;

namespace EstimatedTaxCalc
{
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    { 
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e); 
        }

        // IoC 컨테이너에 객체를 등록하는 메소드
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // View-ViewModel 관계 등록 (Navigation에 사용)
            containerRegistry.RegisterForNavigation<MainView, MainViewModel>();
        }

        // Shell View를 생성하는 메소드
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

    }

}

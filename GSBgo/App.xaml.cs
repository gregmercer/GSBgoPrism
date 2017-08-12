using Xamarin.Forms;
using Prism.DryIoc;

using GSBgo.Views;

namespace GSBgo
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();
            NavigationService.NavigateAsync("NavigationPage/HomePage");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<HomePage>();
			Container.RegisterTypeForNavigation<RoomsPage>();
		}
	}
}

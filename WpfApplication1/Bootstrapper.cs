using System.Windows;
using Caliburn.Micro;
using WpfApplication1.ViewModels;

namespace WpfApplication1
{
	public class Bootstrapper : BootstrapperBase
	{
		public Bootstrapper()
		{
			Initialize();
		}

		protected override void OnStartup(object sender, StartupEventArgs e)
		{
			DisplayRootViewFor<ShellViewModel>();
		}
	}
}
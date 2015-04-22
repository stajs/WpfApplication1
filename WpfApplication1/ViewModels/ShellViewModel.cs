using Caliburn.Micro;

namespace WpfApplication1.ViewModels
{
		public class ShellViewModel : PropertyChangedBase
		{
			private string _name;
			private NestedViewModel _nestedViewModel;

			public string Name
			{
				get { return _name; }
				set
				{
					_name = value;
					NotifyOfPropertyChange(() => Name);
				}
			}

			public NestedViewModel NestedViewModel
			{
				get { return _nestedViewModel; }
				set
				{
					if (Equals(value, _nestedViewModel)) return;
					_nestedViewModel = value;
					NotifyOfPropertyChange(() => NestedViewModel);
				}
			}

			public ShellViewModel()
			{
				NestedViewModel = new NestedViewModel();
				Name = "Shell";
			}
		}
}

using Caliburn.Micro;

namespace WpfApplication1.ViewModels
{
	public class NestedViewModel : PropertyChangedBase
	{
		private string _name;

		public string Name
		{
			get { return _name; }
			set
			{
				_name = value;
				NotifyOfPropertyChange(() => Name);
			}
		}

		public NestedViewModel()
		{
			Name = "Nested";
		}
	}
}
using Prism;
using Prism.Events;
using Prism.Navigation;
using System;

namespace GSBgo.ViewModels
{
    public class ChildViewModelBase : BaseViewModel, IActiveAware, INavigatingAware, IDestructible
    {
		private bool _isActive;
		public bool IsActive
		{
			get { return _isActive; }
			set { SetProperty(ref _isActive, value, () => System.Diagnostics.Debug.WriteLine($"{Title} IsActive Changed: {value}")); }
		}

        public event EventHandler IsActiveChanged;
    }
}

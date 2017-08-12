using Prism.Mvvm;
using Prism.Navigation;

using GSBgo.Business;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace GSBgo.ViewModels
{
    public class DigestPageViewModel : ChildViewModelBase
    {
        INavigationService _navigationService { get; }

        public DigestPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private ObservableCollection<Digest> _digestList;
        public ObservableCollection<Digest> DigestList
        {
            get { return _digestList; }
            set { SetProperty(ref _digestList, value); }
        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            if (DigestList == null)
            {
                ObservableCollection<Digest> digest = new ObservableCollection<Digest>();

                digest.Add(new Digest { Name = "Digest Item 1" });
                digest.Add(new Digest { Name = "Digest Item 2" });
                digest.Add(new Digest { Name = "Digest Item 3" });

                DigestList = digest;
            }
        }
    }
}

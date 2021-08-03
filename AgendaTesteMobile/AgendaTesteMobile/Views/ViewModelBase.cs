using Prism.Mvvm;
using Prism.Navigation;
using System.Reactive.Disposables;

namespace AgendaTesteMobile.Views
{
    public class ViewModelBase : BindableBase, IInitialize, INavigatedAware, IDestructible    
    {
        protected INavigationService NavigationService { get; private set; }
        
        private string _title;
        public string Title 
        {   
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public CompositeDisposable Disposables { get; }

        public ViewModelBase(INavigationService navigationService)
        {
            Disposables = new CompositeDisposable();
            NavigationService = navigationService;
        }

        public void Initialize(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            
        }

        public void Destroy()
        {
            Disposables.Dispose();
        }
    }
}
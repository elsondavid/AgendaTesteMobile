using AgendaTesteMobile.Api;
using AgendaTesteMobile.Models;
using AgendaTesteMobile.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AgendaTesteMobile.Views
{
    public class PacientePageViewModel : ViewModelBase
    {
        private readonly IApi _api;
        private Paciente _paciente;
        public PacientePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Nome = new ReactiveProperty<string>().AddTo(Disposables);
            Cpf = new ReactiveProperty<string>().AddTo(Disposables);
            SendCommand = new ReactiveCommand();
            SendCommand.Subscribe(x => OnSendCommand()).AddTo(Disposables);
           // _api = api;

        }
        public ReactiveProperty<string> Nome { get; }
        public ReactiveProperty<string> Cpf { get; }
        public ReactiveCommand SendCommand { get; }

        public void OnSendCommand()
        {
            _paciente.Nome = Nome.Value;
            _paciente.Cpf = Cpf.Value;

            _api.SetData(_paciente)
                .ObserveOnUIDispatcher()
                .Subscribe()
                .AddTo(Disposables);
        }

    }
}

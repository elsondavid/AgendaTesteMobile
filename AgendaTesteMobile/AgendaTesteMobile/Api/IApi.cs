using AgendaTesteMobile.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTesteMobile.Api
{
    public interface IApi
    {
        [Post("/paciente/SetData")]
        IObservable<HttpContent> SetData([Body] Paciente paciente);

        //[Post("/Vacina/SetDataVacina")]
        //IObservable<HttpContent> SetDataVacina([Body] Vacina vacina);
    }
}

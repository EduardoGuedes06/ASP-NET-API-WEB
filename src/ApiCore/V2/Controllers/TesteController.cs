using ApiCore.Controllers;
using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiCore.V2.Controllers
{
    [Route("api/v2/teste")]
    public class TesteController : HomeController
    {
        public TesteController(INotificador notificador, IUser appUser) : base(notificador, appUser)
        {
        }

        [HttpGet]
        public string Valor()
        {

            return "Sou a V2";
        }
    }
}

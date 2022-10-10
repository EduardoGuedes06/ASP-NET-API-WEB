using ApiCore.Controllers;
using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiCore.V1.Controllers
{
    [Route("api/v1/teste")]
    public class TesteController : HomeController
    {
        public TesteController(INotificador notificador, IUser appUser) : base(notificador, appUser)
        {
        }
        [HttpGet]
        public string Valor()
        {
            return "Sou a V1";
        }
    }
}

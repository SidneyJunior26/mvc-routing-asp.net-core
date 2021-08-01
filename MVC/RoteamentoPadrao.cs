using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ListaLeitura.App.MVC
{
    public class RoteamentoPadrao
    {
        public static Task TratamentoPadrao(HttpContext context)
        {
            // Rota Padrão /<Classe>Controller/Metodo
            // {classe}/{metodo}

            var classe = context.GetRouteValue("controller").ToString();
            var nomeMetodo = context.GetRouteValue("action").ToString();

            var nomeCompleto = $"ListaLeitura.App.Controller.{classe}controller";

            var tipo = Type.GetType(nomeCompleto);
            var metodo = tipo.GetMethods().Where(x => x.Name == nomeMetodo).First();
            var requestDelegate = (RequestDelegate)Delegate.CreateDelegate(typeof(RequestDelegate), metodo);

            return requestDelegate.Invoke(context);
        }
    }
}

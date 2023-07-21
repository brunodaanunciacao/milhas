using Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controller
{
    public class DepoimentosController : ControllerBase
    {
        
        [HttpPost]
        public Depoimento CreateDepoimento(){
            
        }
        
        [HttpGet]
        public Enumerable<Depoimento> GetDepoimentos(){

        }

        [HttpPut]
        public Depoimento GetDepoimentos(){

        }

        [HttpDelete]
        public bool DeleteDepoimento(){

        }        
    }
}
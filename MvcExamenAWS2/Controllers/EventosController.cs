using Microsoft.AspNetCore.Mvc;
using MvcExamenAWS2.Models;
using MvcExamenAWS2.Services;

namespace MvcExamenAWS2.Controllers
{
    public class EventosController : Controller
    {
        private ServiceApiEventos service;
        private ServiceStorageAWS serviceStorage;

        public EventosController(ServiceApiEventos service, ServiceStorageAWS serviceStorage)
        {
            this.service = service;
            this.serviceStorage = serviceStorage;
        }

        public async Task<IActionResult> Eventos()
        {
            List<Evento> peliculas = await this.service.GetEventosAsync();
            return View(peliculas);
        }

        public async Task<IActionResult> Categorias()
        {
            List<CategoriaEvento> categorias = await this.service.GetCategoriasAsync();
            return View(categorias);
        }


        public IActionResult EventosCategoria()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EventosCategoria(int idcategoria)
        {
            List<Evento> eventos =
                await this.service.GetEventosCategoria(idcategoria);
            return View(eventos);
        }


        public async Task<IActionResult> FindEvento(int idcategoria)
        {
            Evento evento = await this.service.FindEvento(idcategoria);
            return View(evento);
        }



    }
}

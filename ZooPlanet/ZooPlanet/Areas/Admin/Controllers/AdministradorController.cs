using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using ZooPlanet.Models;
using ZooPlanet.Models.ViewModels;
using ZooPlanet.Repositories;

namespace ZooPlanet.Controllers
{
    [Area("Admin")]
    public class AdministradorController : Controller
    {
        public IWebHostEnvironment Environment { get; set; }
        public AdministradorController(IWebHostEnvironment env)
        {
            Environment = env;
        }

       
        
        public IActionResult Index()
        {
            EspeciesIndexViewModel vm = new EspeciesIndexViewModel();
            animalesContext context = new animalesContext();
            ClasesRepository categoriasRepository = new ClasesRepository(context);
            EspeciesRepository productosRepository = new EspeciesRepository(context);

           
            vm.Especies = productosRepository.GetAll();
            
            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(EspeciesIndexViewModel vm)
        {
            animalesContext context = new animalesContext();
           ClasesRepository categoriasRepository = new ClasesRepository(context);
            EspeciesRepository productosRepository = new EspeciesRepository(context);

           
            vm.Especies = productosRepository.GetEspeciesByClase(vm.idClase);

            return View(vm);
        }
        
        public IActionResult Agregar()
        {
           EspeciesViewModel vm = new EspeciesViewModel();
            animalesContext context = new animalesContext();
            ClasesRepository clasesRepository = new ClasesRepository(context);
            vm.Clases = clasesRepository.GetAll();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Agregar(EspeciesViewModel vm)
        {
            animalesContext context = new animalesContext();
            
            try
            {
                EspeciesRepository repos = new EspeciesRepository(context);
                repos.Insert(vm.Especies);
              

                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {

                ModelState.AddModelError("", ex.Message);
                ClasesRepository categoriasRepository = new ClasesRepository(context);
                vm.Clases = categoriasRepository.GetAll();

                return View(vm);
            }

        }
       
        public IActionResult Editar(int id)
        {
            animalesContext context = new animalesContext();
            EspeciesViewModel vm = new EspeciesViewModel();

            EspeciesRepository er = new EspeciesRepository(context);
            vm.Especies = er.GetById(id);
            if (vm.Especies == null)
            {
                return RedirectToAction("Index");
            }
            ClasesRepository cr = new ClasesRepository(context);
            vm.Clases = cr.GetAll();


            return View(vm);
        }


        [HttpPost]
        public IActionResult Editar(EspeciesViewModel vm)
        {
            animalesContext context = new animalesContext();


            try
            {
                EspeciesRepository repos = new EspeciesRepository(context);

                var e = repos.GetById(vm.Especies.Id);
                if (e != null)
                {
                    e.Especie = vm.Especies.Especie;
                    e.IdClase = vm.Especies.IdClase;
                    e.Habitat = vm.Especies.Habitat;
                    e.Peso = vm.Especies.Peso;
                    e.Tamaño = vm.Especies.Tamaño;
                    e.Observaciones = vm.Especies.Observaciones;
                    repos.Update(e);


                }


                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {

                ModelState.AddModelError("", ex.Message);
                ClasesRepository cr = new ClasesRepository(context);
                vm.Clases = cr.GetAll();

                return View(vm);
            }
        }


        
        public IActionResult Eliminar(int id)
        {
            using (animalesContext context = new animalesContext())
            {
                EspeciesRepository repos = new EspeciesRepository(context);
                var e = repos.GetEspeciesById(id);
                if (e != null)
                {
                    return View(e);
                }
                else
                    return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public IActionResult Eliminar(Especies e)
        {
            using (animalesContext context = new animalesContext())
            {
                EspeciesRepository repos = new EspeciesRepository(context);
                var especie = repos.GetById(e.Id);
                if (especie != null)
                {
                    repos.Delete(especie);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "El producto no existe o ya ha sido eliminado.");
                    return View(e);
                }


            }


        }



       
        public IActionResult Imagen(int id)
        {
            animalesContext context = new animalesContext();
            EspeciesViewModel vm = new EspeciesViewModel();

            EspeciesRepository er = new EspeciesRepository(context);
            vm.Especies = er.GetById(id);
            if (vm.Especies == null)
            {
                return RedirectToAction("Index");
            }

            ClasesRepository cr = new ClasesRepository(context);
            vm.Clases = cr.GetAll();

            if (System.IO.File.Exists(Environment.WebRootPath + $"/especies/{vm.Especies.Id}.jpg"))
            {
                vm.Imagen = vm.Especies.Id + ".jpg";
            }
            else
            {
                vm.Imagen = "no-disponible.png";
            }
            return View(vm);
        }
        
        [HttpPost]
        public IActionResult Imagen(EspeciesViewModel vm)
        {
            animalesContext context = new animalesContext();
            if (vm.Archivo != null)
            {
                if (vm.Archivo.ContentType != "image/jpeg" || vm.Archivo.Length > 1024 * 1024 * 2)
                {
                    ModelState.AddModelError("", "Debe selecionar un archivo jpg de menos de 2mb");
                    ClasesRepository clasesRepository = new ClasesRepository(context);
                    vm.Clases = clasesRepository.GetAll();

                    return View(vm);
                }
            }

            try 
            {
               EspeciesRepository repos = new EspeciesRepository(context);

                var e = repos.GetById(vm.Especies.Id);
                if (e != null)
                { 
                    if (vm.Archivo != null)
                {
                    FileStream fs = new FileStream(Environment.WebRootPath + "/especies/" + vm.Especies.Id + ".jpg", FileMode.Create);
                    vm.Archivo.CopyTo(fs);
                    fs.Close();
                }
                }

                return RedirectToAction("Index");
            }
            
            //Guardar archivo de inserción

            catch (Exception ex)
            {

                ModelState.AddModelError("", ex.Message);
                ClasesRepository clasesRepository = new ClasesRepository(context);
                vm.Clases = clasesRepository.GetAll();

                return View(vm);
            }
           
        }



    }
}
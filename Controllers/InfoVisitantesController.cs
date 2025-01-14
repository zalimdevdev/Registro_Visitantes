using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RegistroVisitantes.Models;


namespace RegistroVisitantes.Controllers
{
    public class InfoVisitantesController : Controller
    {
        private readonly AppDbContext _context;

        public InfoVisitantesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: InfoVisitantes
        public async Task<IActionResult> Index()
        {
            return View(await _context.InfoVisitantes.ToListAsync());
        }



[HttpGet]
public IActionResult ConsultaReportes()
{

           ViewBag.ReporteGenerado = false; // Indica si ya se generó el reporte

    return View();
}

[HttpPost]
public IActionResult ConsultaReportes(DateTime fecha)
{
    

 var visitantesDelDia = _context.InfoVisitantes
                .Where(v => v.Fecha.HasValue && v.Fecha.Value.Date == fecha.Date)
                .ToList();
            
            ViewBag.VisitantesDelDia = visitantesDelDia;
            

            // Conteo de nacionales y extranjeros
            var totalNacionales = visitantesDelDia
                .Where(v => v.Nacionalidad == "Nacional")
                .Select(v => v.Identificacion)
                .Distinct()
                .Count();

            var totalExtranjeros = visitantesDelDia
                .Where(v => v.Nacionalidad == "Extranjero")
                .Select(v => v.Identificacion)
                .Distinct()
                .Count();

            // Conteo por país de origen
            var conteoPorPais = visitantesDelDia
                .Where(v => v.Nacionalidad == "Extranjero" && !string.IsNullOrEmpty(v.PaisDeOrigen))
                .GroupBy(v => v.PaisDeOrigen)
                .Select(group => new
                {
                    Pais = group.Key,
                    Total = group.Select(v => v.Identificacion).Distinct().Count()
                })
                .ToDictionary(g => g.Pais, g => g.Total);

            // Pasar los datos a la vista
            ViewBag.TotalNacionales = totalNacionales;
            ViewBag.TotalExtranjeros = totalExtranjeros;
            ViewBag.ConteoPorPais = conteoPorPais;
            ViewBag.ReporteGenerado = true;


    return View();
}


        // GET: InfoVisitantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoVisitante = await _context.InfoVisitantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (infoVisitante == null)
            {
                return NotFound();
            }

            return View(infoVisitante);
        }

        // GET: InfoVisitantes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InfoVisitantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fecha,Nombre,Sexo,EdadVisitantes,Identificacion,Email,NumeroTelefono,Nacionalidad,PaisDeOrigen")] InfoVisitante infoVisitante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(infoVisitante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(infoVisitante);
        }

        // GET: InfoVisitantes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoVisitante = await _context.InfoVisitantes.FindAsync(id);
            if (infoVisitante == null)
            {
                return NotFound();
            }
            return View(infoVisitante);
        }

        // POST: InfoVisitantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Id,Fecha,Nombre,Sexo,EdadVisitantes,Identificacion,Email,NumeroTelefono,Nacionalidad,PaisDeOrigen")] InfoVisitante infoVisitante)
        {
            if (id != infoVisitante.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(infoVisitante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InfoVisitanteExists(infoVisitante.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(infoVisitante);
        }



        // GET: InfoVisitantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoVisitante = await _context.InfoVisitantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (infoVisitante == null)
            {
                return NotFound();
            }

            return View(infoVisitante);
        }

        // POST: InfoVisitantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var infoVisitante = await _context.InfoVisitantes.FindAsync(id);
            if (infoVisitante != null)
            {
                _context.InfoVisitantes.Remove(infoVisitante);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InfoVisitanteExists(int? id)
        {
            return _context.InfoVisitantes.Any(e => e.Id == id);
        }
    }
}


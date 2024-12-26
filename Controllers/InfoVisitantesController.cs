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
    // Inicializar los resultados como nulos
    ViewBag.TotalNacionales = null;
    ViewBag.TotalExtranjeros = null;
// Aqui inician los paises

ViewBag.TotalAfganistán = null;
ViewBag.TotalAlbania = null;
ViewBag.TotalAlemania = null;
ViewBag.TotalAndorra = null;
ViewBag.TotalAngola = null;
ViewBag.TotalAntiguaYBarbuda = null;
ViewBag.TotalArabiaSaudita = null;
ViewBag.TotalArgelia = null;
ViewBag.TotalArgentina = null;
ViewBag.TotalArmenia = null;
ViewBag.TotalAustralia = null;
ViewBag.TotalAustria = null;
ViewBag.TotalAzerbaiyán = null;
ViewBag.TotalBahamas = null;
ViewBag.TotalBangladés = null;
ViewBag.TotalBarbados = null;
ViewBag.TotalBaréin = null;
ViewBag.TotalBelice = null;
ViewBag.TotalBenin = null;
ViewBag.TotalBielorrusia = null;
ViewBag.TotalBirmania = null;
ViewBag.TotalBolivia = null;
ViewBag.TotalBosniaYHerzegovina = null;
ViewBag.TotalBotsuana = null;
ViewBag.TotalBrasil = null;
ViewBag.TotalBrunéi = null;
ViewBag.TotalBulgaria = null;
ViewBag.TotalBurkinaFaso = null;
ViewBag.TotalBurundi = null;
ViewBag.TotalCaboVerde = null;
ViewBag.TotalCamboya = null;
ViewBag.TotalCamerún = null;
ViewBag.TotalCanadá = null;


//ViewBag.TotalCatar = null;


ViewBag.TotalChad = null;
ViewBag.TotalChile = null;
ViewBag.TotalChina = null;
ViewBag.TotalChipre = null;
ViewBag.TotalCiudadDelVaticano = null;
ViewBag.TotalColombia = null;
ViewBag.TotalComoras = null;
ViewBag.TotalCoreaDelNorte = null;
ViewBag.TotalCoreaDelSur = null;
ViewBag.TotalCostaDeMarfil = null;
ViewBag.TotalCostaRica = null;
ViewBag.TotalCroacia = null;
ViewBag.TotalCuba = null;
ViewBag.TotalDinamarca = null;
ViewBag.TotalDominica = null;
ViewBag.TotalRepúblicaDominicana = null;
ViewBag.TotalEcuador = null;
ViewBag.TotalEgipto = null;
ViewBag.TotalElSalvador = null;
ViewBag.TotalEmiratosÁrabesUnidos = null;
ViewBag.TotalEritrea = null;
ViewBag.TotalEslovaquia = null;
ViewBag.TotalEslovenia = null;
ViewBag.TotalEspaña = null;
ViewBag.TotalEstadosUnidos = null;
ViewBag.TotalEstonia = null;
ViewBag.TotalEsuatini = null;
ViewBag.TotalEtiopía = null;
ViewBag.TotalFilipinas = null;
ViewBag.TotalFinlandia = null;
ViewBag.TotalFiyi = null;
ViewBag.TotalFrancia = null;
ViewBag.TotalGabón = null;
ViewBag.TotalGambia = null;
ViewBag.TotalGeorgia = null;
ViewBag.TotalGhana = null;
ViewBag.TotalGranada = null;
ViewBag.TotalGrecia = null;
ViewBag.TotalGuatemala = null;
ViewBag.TotalGuinea = null;
ViewBag.TotalGuineaBisáu = null;
ViewBag.TotalGuineaEcuatorial = null;
ViewBag.TotalGuyana = null;
ViewBag.TotalHaití = null;
ViewBag.TotalHonduras = null;
ViewBag.TotalHungría = null;
ViewBag.TotalIndia = null;
ViewBag.TotalIndonesia = null;
ViewBag.TotalIrak = null;
ViewBag.TotalIrán = null;
ViewBag.TotalIrlanda = null;
ViewBag.TotalIslandia = null;
ViewBag.TotalIsrael = null;
ViewBag.TotalItalia = null;
ViewBag.TotalJamaica = null;
ViewBag.TotalJapón = null;
ViewBag.TotalJordania = null;
ViewBag.TotalKazajistán = null;
ViewBag.TotalKenia = null;
ViewBag.TotalKirguistán = null;
ViewBag.TotalKiribati = null;
ViewBag.TotalKosovo = null;
ViewBag.TotalKuwait = null;
ViewBag.TotalLaos = null;
ViewBag.TotalLesoto = null;
ViewBag.TotalLetonia = null;
ViewBag.TotalLíbano = null;
ViewBag.TotalLiberia = null;
ViewBag.TotalLibia = null;
ViewBag.TotalLiechtenstein = null;
ViewBag.TotalLituania = null;
ViewBag.TotalLuxemburgo = null;
ViewBag.TotalMadagascar = null;
ViewBag.TotalMalasia = null;
ViewBag.TotalMalaui = null;
ViewBag.TotalMaldivas = null;
ViewBag.TotalMalí = null;
ViewBag.TotalMalta = null;
ViewBag.TotalMarruecos = null;
ViewBag.TotalIslasMarshall = null;
ViewBag.TotalMauricio = null;
ViewBag.TotalMauritania = null;
ViewBag.TotalMéxico = null;
ViewBag.TotalMicronesia = null;
ViewBag.TotalMoldavia = null;
ViewBag.TotalMónaco = null;
ViewBag.TotalMongolia = null;
ViewBag.TotalMontenegro = null;
ViewBag.TotalMozambique = null;
ViewBag.TotalNamibia = null;
ViewBag.TotalNauru = null;
ViewBag.TotalNepal = null;
ViewBag.TotalNicaragua = null;
ViewBag.TotalNíger = null;
ViewBag.TotalNigeria = null;
ViewBag.TotalNoruega = null;
ViewBag.TotalNuevaZelanda = null;
ViewBag.TotalOmán = null;
ViewBag.TotalPaísesBajos = null;
ViewBag.TotalPakistán = null;
ViewBag.TotalPalaos = null;
ViewBag.TotalPanamá = null;
ViewBag.TotalPapúaNuevaGuinea = null;
ViewBag.TotalParaguay = null;
ViewBag.TotalPerú = null;
ViewBag.TotalPolonia = null;
ViewBag.TotalPortugal = null;
ViewBag.TotalReinoUnido = null;
ViewBag.TotalRepúblicaCentroafricana = null;
ViewBag.TotalRepúblicaCheca = null;
ViewBag.TotalRepúblicaDelCongo = null;
ViewBag.TotalRepúblicaDemocráticaDelCongo = null;
ViewBag.TotalRuanda = null;
ViewBag.TotalRumanía = null;
ViewBag.TotalRusia = null;
ViewBag.TotalSamoa = null;
ViewBag.TotalSanCristóbalYNieves = null;
ViewBag.TotalSanMarino = null;
ViewBag.TotalSanVicenteYLasGranadinas = null;
ViewBag.TotalSantaLucía = null;
ViewBag.TotalSantoToméYPríncipe = null;
ViewBag.TotalSenegal = null;
ViewBag.TotalSerbia = null;
ViewBag.TotalSeychelles = null;
ViewBag.TotalSierraLeona = null;
ViewBag.TotalSingapur = null;
ViewBag.TotalSiria = null;
ViewBag.TotalSomalia = null;
ViewBag.TotalSriLanka = null;
ViewBag.TotalSudáfrica = null;
ViewBag.TotalSudán = null;
ViewBag.TotalSudánDelSur = null;
ViewBag.TotalSuecia = null;
ViewBag.TotalSuiza = null;
ViewBag.TotalSurinam = null;
ViewBag.TotalTailandia = null;
ViewBag.TotalTaiwán = null;
ViewBag.TotalTanzania = null;
ViewBag.TotalTayikistán = null;
ViewBag.TotalTimorOriental = null;
ViewBag.TotalTogo = null;
ViewBag.TotalTonga = null;
ViewBag.TotalTrinidadYTobago = null;
ViewBag.TotalTúnez = null;
ViewBag.TotalTurquía = null;
ViewBag.TotalTurkmenistán = null;
ViewBag.TotalTuvalu = null;
ViewBag.TotalUcrania = null;
ViewBag.TotalUganda = null;
ViewBag.TotalUruguay = null;
ViewBag.TotalUzbekistán = null;
ViewBag.TotalVanuatu = null;
ViewBag.TotalVenezuela = null;
ViewBag.TotalVietnam = null;
ViewBag.TotalYemen = null;
ViewBag.TotalZambia = null;
ViewBag.TotalZimbabue = null;
ViewBag.TotalPalestina = null;


    return View();
}

[HttpPost]
public IActionResult ConsultaReportes(DateTime fecha)
{
    var visitantesDelDia = _context.InfoVisitantes
        .Where(v => v.Fecha.HasValue && v.Fecha.Value.Date == fecha.Date) // Filtrar por fecha
        .ToList();

    // Calcular totales por nacionalidad
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












 //var visitantesDelDia = _context.InfoVisitantes
   //     .Where(v => v.Fecha.HasValue && v.Fecha.Value.Date == fecha.Date) // Filtrar por fecha
     //   .ToList();

    // Calcular totales por país de origen
    
   var totalAfganistán = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Afganistán")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalAlbania = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Albania")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalAlemania = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Alemania")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalAndorra = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Andorra")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalAngola = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Angola")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalAntiguaYBarbuda = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Antigua y Barbuda")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalArabiaSaudita = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Arabia Saudita")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalArgelia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Argelia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalArgentina = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Argentina")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalArmenia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Armenia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalAustralia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Australia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalAustria = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Austria")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalAzerbaiyán = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Azerbaiyán")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalBahamas = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Bahamas")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalBangladés = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Bangladés")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalBarbados = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Barbados")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalBaréin = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Baréin")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalBelice = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Belice")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalBenin = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Benín")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalBielorrusia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Bielorrusia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

    var totalBirmania = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Birmania (Myanmar)")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalBolivia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Bolivia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalBosniaYHerzegovina = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Bosnia y Herzegovina")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalBotsuana = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Botsuana")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalBrasil = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Brasil")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalBrunéi = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Brunéi")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalBulgaria = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Bulgaria")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalBurkinaFaso = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Burkina Faso")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalBurundi = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Burundi")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalCaboVerde = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Cabo Verde")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalCamboya = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Camboya")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalCamerún = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Camerún")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalCanadá = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Canadá")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();



var totalChad = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Chad")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalChile = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Chile")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalChina = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "China")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalChipre = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Chipre")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalCiudadDelVaticano = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Ciudad del Vaticano")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalColombia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Colombia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalComoras = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Comoras")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalCoreaDelNorte = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Corea del Norte")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalCoreaDelSur = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Corea del Sur")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalCostaDeMarfil = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Costa de Marfil")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalCostaRica = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Costa Rica")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalCroacia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Croacia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalCuba = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Cuba")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalDinamarca = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Dinamarca")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalDominica = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Dominica")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalRepublicaDominicana = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "República Dominicana")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalEcuador = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Ecuador")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalEgipto = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Egipto")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalElSalvador = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "El Salvador")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalEmiratosArabesUnidos = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Emiratos Árabes Unidos")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalEritrea = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Eritrea")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalEslovaquia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Eslovaquia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalEslovenia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Eslovenia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalEspaña = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "España")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalEstadosUnidos = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Estados Unidos")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalEstonia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Estonia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalEsuatini = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Esuatini (Suazilandia)")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalEtiopía = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Etiopía")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalFilipinas = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Filipinas")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalFinlandia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Finlandia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalFiyi = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Fiyi")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalFrancia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Francia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalGabón = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Gabón")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalGambia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Gambia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalGeorgia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Georgia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalGhana = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Ghana")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalGranada = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Granada")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalGrecia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Grecia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalGuatemala = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Guatemala")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalGuinea = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Guinea")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalGuineaBisáu = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Guinea-Bisáu")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalGuineaEcuatorial = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Guinea Ecuatorial")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalGuyana = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Guyana")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalHaití = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Haití")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalHonduras = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Honduras")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalHungría = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Hungría")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalIndia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "India")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalIndonesia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Indonesia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalIrak = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Irak")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalIrán = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Irán")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalIrlanda = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Irlanda")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalIslandia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Islandia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalIsrael = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Israel")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalItalia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Italia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalJamaica = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Jamaica")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalJapón = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Japón")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalJordania = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Jordania")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalKazajistán = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Kazajistán")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalKenia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Kenia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalKirguistán = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Kirguistán")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalKiribati = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Kiribati")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalKosovo = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Kosovo")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalKuwait = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Kuwait")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalLaos = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Laos")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalLesoto = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Lesoto")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalLetonia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Letonia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalLíbano = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Líbano")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalLiberia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Liberia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalLibia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Libia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalLiechtenstein = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Liechtenstein")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalLituania = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Lituania")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalLuxemburgo = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Luxemburgo")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalMadagascar = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Madagascar")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalMalasia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Malasia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalMalaui = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Malaui")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalMaldivas = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Maldivas")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalMalí = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Malí")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalMalta = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Malta")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalMarruecos = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Marruecos")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalIslasMarshall = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Islas Marshall")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalMauricio = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Mauricio")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalMauritania = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Mauritania")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalMéxico = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "México")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalMicronesia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Micronesia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalMoldavia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Moldavia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalMónaco = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Mónaco")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalMongolia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Mongolia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalMontenegro = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Montenegro")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalMozambique = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Mozambique")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalNamibia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Namibia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalNauru = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Nauru")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalNepal = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Nepal")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalNicaragua = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Nicaragua")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalNíger = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Níger")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalNigeria = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Nigeria")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalNoruega = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Noruega")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalNuevaZelanda = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Nueva Zelanda")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalOmán = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Omán")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalPaisesBajos = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Países Bajos")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalPakistán = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Pakistán")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalPalaos = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Palaos")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalPanamá = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Panamá")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalPapúaNuevaGuinea = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Papúa Nueva Guinea")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalParaguay = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Paraguay")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalPerú = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Perú")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalPolonia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Polonia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalPortugal = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Portugal")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalCatar = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Catar")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalReinoUnido = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Reino Unido")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalRepublicaCentroafricana = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "República Centroafricana")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalRepublicaCheca = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "República Checa")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalRepublicaDelCongo = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "República del Congo")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalRepublicaDemocraticaDelCongo = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "República Democrática del Congo")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalRepúblicaDominicana = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "República Dominicana")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalRuanda = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Ruanda")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalRumanía = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Rumanía")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalRusia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Rusia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSamoa = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Samoa")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSanCristobalYNieves = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "San Cristóbal y Nieves")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSanMarino = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "San Marino")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSanVicenteYLasGranadinas = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "San Vicente y las Granadinas")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSantaLucía = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Santa Lucía")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSantoTomeYPrincipe = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Santo Tomé y Príncipe")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSenegal = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Senegal")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSerbia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Serbia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSeychelles = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Seychelles")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSierraLeona = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Sierra Leona")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSingapur = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Singapur")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSiria = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Siria")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSomalia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Somalia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSriLanka = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Sri Lanka")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSudafrica = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Sudáfrica")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSudan = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Sudán")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSudanDelSur = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Sudán del Sur")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSuecia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Suecia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSuiza = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Suiza")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalSurinam = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Surinam")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalTailandia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Tailandia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalTaiwan = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Taiwán")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalTanzania = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Tanzania")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalTayikistan = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Tayikistán")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalTimorOriental = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Timor Oriental")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalTogo = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Togo")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalTonga = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Tonga")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalTrinidadYTobago = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Trinidad y Tobago")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalTunez = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Túnez")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalTurquia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Turquía")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalTurkmenistan = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Turkmenistán")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalTuvalu = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Tuvalu")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalUcrania = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Ucrania")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalUganda = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Uganda")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalUruguay = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Uruguay")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalUzbekistan = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Uzbekistán")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalVanuatu = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Vanuatu")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalVenezuela = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Venezuela")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalVietnam = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Vietnam")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalYemen = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Yemen")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalZambia = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Zambia")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalZimbabue = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Zimbabue")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();

var totalPalestina = visitantesDelDia 
    .Where(v => v.PaisDeOrigen == "Palestina")
    .Select(v => v.Identificacion)
    .Distinct()
    .Count();


var totalesPorPais = new Dictionary<string, int>
{
    { "Estados Unidos", totalEstadosUnidos },
    { "Nicaragua", totalNicaragua },
    { "Benín", totalBenin },
    { "España", totalEspaña }
    // Agrega el resto de los países aquí
};






    // Pasar los datos a la vista
    
ViewBag.TotalAfganistán = totalAfganistán;
ViewBag.TotalAlbania = totalAlbania;
ViewBag.TotalAlemania = totalAlemania;
ViewBag.TotalAndorra = totalAndorra;
ViewBag.TotalAngola = totalAngola;
ViewBag.TotalAntiguaYBarbuda = totalAntiguaYBarbuda;
ViewBag.TotalArabiaSaudita = totalArabiaSaudita;
ViewBag.TotalArgelia = totalArgelia;
ViewBag.TotalArgentina = totalArgentina;
ViewBag.TotalArmenia = totalArmenia;
ViewBag.TotalAustralia = totalAustralia;
ViewBag.TotalAustria = totalAustria;
ViewBag.TotalAzerbaiyán = totalAzerbaiyán;
ViewBag.TotalBahamas = totalBahamas;
ViewBag.TotalBangladés = totalBangladés;
ViewBag.TotalBarbados = totalBarbados;
ViewBag.TotalBaréin = totalBaréin;
ViewBag.TotalBelice = totalBelice;
ViewBag.TotalBenin = totalBenin;
ViewBag.TotalBielorrusia = totalBielorrusia;
ViewBag.TotalBirmania = totalBirmania;
ViewBag.TotalBolivia = totalBolivia;
ViewBag.TotalBosniaYHerzegovina = totalBosniaYHerzegovina;
ViewBag.TotalBotsuana = totalBotsuana;
ViewBag.TotalBrasil = totalBrasil;
ViewBag.TotalBrunéi = totalBrunéi;
ViewBag.TotalBulgaria = totalBulgaria;
ViewBag.TotalBurkinaFaso = totalBurkinaFaso;
ViewBag.TotalBurundi = totalBurundi;
ViewBag.TotalCaboVerde = totalCaboVerde;
ViewBag.TotalCamboya = totalCamboya;
ViewBag.TotalCamerún = totalCamerún;
ViewBag.TotalCanadá = totalCanadá;
ViewBag.TotalCatar = totalCatar;
ViewBag.TotalChad = totalChad;
ViewBag.TotalChile = totalChile;
ViewBag.TotalChina = totalChina;
ViewBag.TotalChipre = totalChipre;
ViewBag.TotalCiudadDelVaticano = totalCiudadDelVaticano;
ViewBag.TotalColombia = totalColombia;
ViewBag.TotalComoras = totalComoras;
ViewBag.TotalCoreaDelNorte = totalCoreaDelNorte;
ViewBag.TotalCoreaDelSur = totalCoreaDelSur;
ViewBag.TotalCostaDeMarfil = totalCostaDeMarfil;
ViewBag.TotalCostaRica = totalCostaRica;
ViewBag.TotalCroacia = totalCroacia;
ViewBag.TotalCuba = totalCuba;
ViewBag.TotalDinamarca = totalDinamarca;
ViewBag.TotalDominica = totalDominica;
ViewBag.TotalRepublicaDominicana = totalRepublicaDominicana;
ViewBag.TotalEcuador = totalEcuador;
ViewBag.TotalEgipto = totalEgipto;
ViewBag.TotalElSalvador = totalElSalvador;
ViewBag.TotalEmiratosArabesUnidos = totalEmiratosArabesUnidos;
ViewBag.TotalEritrea = totalEritrea;
ViewBag.TotalEslovaquia = totalEslovaquia;
ViewBag.TotalEslovenia = totalEslovenia;
ViewBag.TotalEspaña = totalEspaña;
ViewBag.TotalEstadosUnidos = totalEstadosUnidos;
ViewBag.TotalEstonia = totalEstonia;
ViewBag.TotalEsuatini = totalEsuatini;
ViewBag.TotalEtiopía = totalEtiopía;
ViewBag.TotalFilipinas = totalFilipinas;
ViewBag.TotalFinlandia = totalFinlandia;
ViewBag.TotalFiyi = totalFiyi;
ViewBag.TotalFrancia = totalFrancia;
ViewBag.TotalGabón = totalGabón;
ViewBag.TotalGambia = totalGambia;
ViewBag.TotalGeorgia = totalGeorgia;
ViewBag.TotalGhana = totalGhana;
ViewBag.TotalGranada = totalGranada;
ViewBag.TotalGrecia = totalGrecia;
ViewBag.TotalGuatemala = totalGuatemala;
ViewBag.TotalGuinea = totalGuinea;
ViewBag.TotalGuineaBisáu = totalGuineaBisáu;
ViewBag.TotalGuineaEcuatorial = totalGuineaEcuatorial;
ViewBag.TotalGuyana = totalGuyana;
ViewBag.TotalHaití = totalHaití;
ViewBag.TotalHonduras = totalHonduras;
ViewBag.TotalHungría = totalHungría;
ViewBag.TotalIndia = totalIndia;
ViewBag.TotalIndonesia = totalIndonesia;
ViewBag.TotalIrak = totalIrak;
ViewBag.TotalIrán = totalIrán;
ViewBag.TotalIrlanda = totalIrlanda;
ViewBag.TotalIslandia = totalIslandia;
ViewBag.TotalIsrael = totalIsrael;
ViewBag.TotalItalia = totalItalia;
ViewBag.TotalJamaica = totalJamaica;
ViewBag.TotalJapón = totalJapón;
ViewBag.TotalJordania = totalJordania;
ViewBag.TotalKazajistán = totalKazajistán;
ViewBag.TotalKenia = totalKenia;
ViewBag.TotalKirguistán = totalKirguistán;
ViewBag.TotalKiribati = totalKiribati;
ViewBag.TotalKosovo = totalKosovo;
ViewBag.TotalKuwait = totalKuwait;
ViewBag.TotalLaos = totalLaos;
ViewBag.TotalLesoto = totalLesoto;
ViewBag.TotalLetonia = totalLetonia;
ViewBag.TotalLíbano = totalLíbano;
ViewBag.TotalLiberia = totalLiberia;
ViewBag.TotalLibia = totalLibia;
ViewBag.TotalLiechtenstein = totalLiechtenstein;
ViewBag.TotalLituania = totalLituania;
ViewBag.TotalLuxemburgo = totalLuxemburgo;
ViewBag.TotalMadagascar = totalMadagascar;
ViewBag.TotalMalasia = totalMalasia;
ViewBag.TotalMalaui = totalMalaui;
ViewBag.TotalMaldivas = totalMaldivas;
ViewBag.TotalMalí = totalMalí;
ViewBag.TotalMalta = totalMalta;
ViewBag.TotalMarruecos = totalMarruecos;
ViewBag.TotalIslasMarshall = totalIslasMarshall;
ViewBag.TotalMauricio = totalMauricio;
ViewBag.TotalMauritania = totalMauritania;
ViewBag.TotalMéxico = totalMéxico;
ViewBag.TotalMicronesia = totalMicronesia;
ViewBag.TotalMoldavia = totalMoldavia;
ViewBag.TotalMónaco = totalMónaco;
ViewBag.TotalMongolia = totalMongolia;
ViewBag.TotalMontenegro = totalMontenegro;
ViewBag.TotalMozambique = totalMozambique;
ViewBag.TotalNamibia = totalNamibia;
ViewBag.TotalNauru = totalNauru;
ViewBag.TotalNepal = totalNepal;
ViewBag.TotalNicaragua = totalNicaragua;
ViewBag.TotalNíger = totalNíger;
ViewBag.TotalNigeria = totalNigeria;
ViewBag.TotalNoruega = totalNoruega;
ViewBag.TotalNuevaZelanda = totalNuevaZelanda;
ViewBag.TotalOmán = totalOmán;
ViewBag.TotalPaisesBajos = totalPaisesBajos;
ViewBag.TotalPakistán = totalPakistán;
ViewBag.TotalPalaos = totalPalaos;
ViewBag.TotalPanamá = totalPanamá;
ViewBag.TotalPapúaNuevaGuinea = totalPapúaNuevaGuinea;
ViewBag.TotalParaguay = totalParaguay;
ViewBag.TotalPerú = totalPerú;
ViewBag.TotalPolonia = totalPolonia;
ViewBag.TotalPortugal = totalPortugal;
ViewBag.TotalReinoUnido = totalReinoUnido;
ViewBag.TotalRepublicaCentroafricana = totalRepublicaCentroafricana;
ViewBag.TotalRepublicaCheca = totalRepublicaCheca;
ViewBag.TotalRepublicaDelCongo = totalRepublicaDelCongo;
ViewBag.TotalRepublicaDemocraticaDelCongo = totalRepublicaDemocraticaDelCongo;
ViewBag.TotalRuanda = totalRuanda;
ViewBag.TotalRumanía = totalRumanía;
ViewBag.TotalRusia = totalRusia;
ViewBag.TotalSamoa = totalSamoa;
ViewBag.TotalSanCristobalYNieves = totalSanCristobalYNieves;
ViewBag.TotalSanMarino = totalSanMarino;
ViewBag.TotalSanVicenteYLasGranadinas = totalSanVicenteYLasGranadinas;
ViewBag.TotalSantaLucía = totalSantaLucía;
ViewBag.TotalSantoTomeYPrincipe = totalSantoTomeYPrincipe;
ViewBag.TotalSenegal = totalSenegal;
ViewBag.TotalSerbia = totalSerbia;
ViewBag.TotalSeychelles = totalSeychelles;
ViewBag.TotalSierraLeona = totalSierraLeona;
ViewBag.TotalSingapur = totalSingapur;
ViewBag.TotalSiria = totalSiria;
ViewBag.TotalSomalia = totalSomalia;
ViewBag.TotalSriLanka = totalSriLanka;
ViewBag.TotalSudafrica = totalSudafrica;
ViewBag.TotalSudan = totalSudan;
ViewBag.TotalSudanDelSur = totalSudanDelSur;
ViewBag.TotalSuecia = totalSuecia;
ViewBag.TotalSuiza = totalSuiza;
ViewBag.TotalSurinam = totalSurinam;
ViewBag.TotalTailandia = totalTailandia;
ViewBag.TotalTaiwan = totalTaiwan;
ViewBag.TotalTanzania = totalTanzania;
ViewBag.TotalTayikistan = totalTayikistan;
ViewBag.TotalTimorOriental = totalTimorOriental;
ViewBag.TotalTogo = totalTogo;
ViewBag.TotalTonga = totalTonga;
ViewBag.TotalTrinidadYTobago = totalTrinidadYTobago;
ViewBag.TotalTunez = totalTunez;
ViewBag.TotalTurquia = totalTurquia;
ViewBag.TotalTurkmenistan = totalTurkmenistan;
ViewBag.TotalTuvalu = totalTuvalu;
ViewBag.TotalUcrania = totalUcrania;
ViewBag.TotalUganda = totalUganda;
ViewBag.TotalUruguay = totalUruguay;
ViewBag.TotalUzbekistan = totalUzbekistan;
ViewBag.TotalVanuatu = totalVanuatu;
ViewBag.TotalVenezuela = totalVenezuela;
ViewBag.TotalVietnam = totalVietnam;
ViewBag.TotalYemen = totalYemen;
ViewBag.TotalZambia = totalZambia;
ViewBag.TotalZimbabue = totalZimbabue;
ViewBag.TotalPalestina = totalPalestina;

        

    // Pasar los datos a la vista
    ViewBag.TotalNacionales = totalNacionales;
    ViewBag.TotalExtranjeros = totalExtranjeros;











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


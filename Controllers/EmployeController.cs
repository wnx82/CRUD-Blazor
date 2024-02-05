using CRUD.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;

namespace CRUD.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
        private readonly Database dbSession;

        public EmployeController(Database db)
        {
            this.dbSession = db;
        }

        // GetAll
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetAll()
        {
            try
            {
                var employes = this.dbSession.Employes.ToList();
                return StatusCode(StatusCodes.Status200OK, employes);
            }
            catch (SqlNullValueException ex)
            {
                // Créez un objet contenant l'information d'erreur
                var errorResponse = new
                {
                    message = "Une erreur s'est produite lors de la récupération des données.",
                    exception = ex.ToString() // Ceci inclut le message et la trace de la pile
                };

                // Renvoie l'objet comme réponse JSON avec un code d'état 500
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }


        // Ajout d'une employe
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Add([FromBody] Employe employe)
        {
            if (employe != null)
            {
                this.dbSession.Employes.Add(employe);
                this.dbSession.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, null);
            }
            else
            {
                // La employe est null, vous pouvez retourner un code d'erreur approprié
                return StatusCode(StatusCodes.Status400BadRequest, "Employe is null.");
            }
        }


        // Modification d'une employe
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Update(Employe updatedEmploye)
        {
            var employe = dbSession.Employes.Find(updatedEmploye.Id);

            if (employe == null)
            {
                return NotFound("Employe not found.");
            }

            //employe = updatedEmploye;


            employe.Nom = updatedEmploye.Nom;
            employe.Prenom = updatedEmploye.Prenom;

            employe.CreatedAt = updatedEmploye.CreatedAt;
            employe.UpdatedAt = updatedEmploye.UpdatedAt;
            employe.DeletedAt = updatedEmploye.DeletedAt;


            this.dbSession.Employes.Update(employe);
            this.dbSession.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, null);
        }

        // Effacer une employe
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Delete(Employe art)
        {
            try
            {
                var employe = this.dbSession.Employes.Find(art.Id);

                if (employe == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, "Employe not found.");
                }

                this.dbSession.Employes.Remove(employe);
                this.dbSession.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "Impossible d'effacer cette employe, il est lié à une ou plusieurs commandes");
            }
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChartEvol_back.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChartEvol_back.Controllers
{
    [Route("api/[controller]")]
    public class PatientController : Controller
    {
        private readonly IPatientRepository _patientRepository;

        public PatientController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

       
        [HttpGet]
        public IEnumerable<Patient> GetAll()
        {
            return _patientRepository.GetAll();
        }




        [HttpGet("{id}", Name = "GetPatients")]
        public IActionResult GetById(int id)
        {
            var item = _patientRepository.Find(id);
            if(item == null)
            {
                return NotFound(); 
            }
            return new ObjectResult(item);
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartEvol_back.Model
{
    public class PatientRepository : IPatientRepository
    {
        private readonly DataContext _context;

        public Patient Find(int key)
        {
            return _context.Patient.FirstOrDefault(t => t.pacCod == key);
        }

        public IEnumerable<Patient> GetAll()
        {
            return _context.Patient.ToList();
        }


    }
}
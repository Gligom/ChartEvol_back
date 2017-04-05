using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartEvol_back.Model
{
    public class PatientRepository : IPatientRepository
    {
        private readonly PatientContext _context;

        public PatientRepository(PatientContext context)
        {
            _context = context;
        }

        public IEnumerable<Patient> GetAll()
        {
            return _context.Pacienti.ToList();
        }

        public Patient Find(int key)
        {
            return _context.Pacienti.FirstOrDefault(t => t.pacCod == key);
        }

    }
}
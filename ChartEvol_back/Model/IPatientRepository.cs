using System.Collections.Generic;


namespace ChartEvol_back.Model
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetAll();
        Patient Find(int key);
    }
}



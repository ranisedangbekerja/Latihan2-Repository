using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanResponsi
{
    internal class Manager : Karyawan 
    {
        private List<Karyawan> karyawansManaged;

        public Manager(string nama, string departemen, int id_departemen) : base(nama, departemen, id_departemen)
        {
            karyawansManaged = new List<Karyawan>();
        }

        public void AddKaryawan(Karyawan karyawan)
        {
            karyawansManaged.Add(karyawan);
        }

        public void RemoveKaryawan(Karyawan karyawan)
        {
            karyawansManaged.Remove(karyawan);
        }
    }
}

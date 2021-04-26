using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_04_26_MedziagosKartojimas
{
    public class AKlase : BaseClass
    {
        public AKlase(string name) : base(name)
        {
        }
        public override int NameKodas(int WHATTHEFUCK)
        {
            int suma = 0;
            foreach (var raide in Name)
            {
                suma += (int)raide * WHATTHEFUCK;
            }
            return suma;
        }
        public override string NameMetodas()
        {
            var sb = new StringBuilder();
            var balses = "aeėiyou".ToList();
            foreach (var raide in Name)
            {
                var kodas =  balses.Contains(raide) ? ((int)raide).ToString() : raide.ToString();
                sb.Append(kodas);
            }
            return sb.ToString();
        }
    }
}
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
            throw new NotImplementedException();
        }

        public override string NameMetodas()
        {
            var balses = "aeėiyou".ToList();
            foreach (var raide in Name)
            {
                balses.Contains(raide).ToString
            }
        }
    }
}
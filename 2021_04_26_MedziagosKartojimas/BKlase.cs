namespace _2021_04_26_MedziagosKartojimas
{
    public class BKlase : BaseClass
    {
        public BKlase(string name) : base(name)
        {
        }

        public override int NameKodas(int WHATTHEFUCK)
        {
            int suma = 0;
            foreach (var raide in Name)
            {
                suma -= (int)raide * WHATTHEFUCK;
            }
            return suma;
        }

        public override string NameMetodas()
        {
            throw new System.NotImplementedException();
        }
    }
}//namespace _2021_04_26_MedziagosKartojimas
namespace _2021_04_26_MedziagosKartojimas
{
    public class BKlase : BaseClass, IZodisKitaip
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
        public string ZodisBeBalsiu()
        {
            char beBalsiu = 'a';
            foreach (var raide in Name)
            {
                beBalsiu -= raide * 'a';
            }
            return beBalsiu;
        }
        public string ZodisBePriebalsiu()
        {
            throw new System.NotImplementedException();
        }
        public string ZodisSuPakeistomisBalsemis(char a)
        {
            throw new System.NotImplementedException();
        }
        public string ZodisSuPakeistomisPriebalsemis(int xxx)
        {
            throw new System.NotImplementedException();
        }
    }//public class BKlase : BaseClass
}//namespace _2021_04_26_MedziagosKartojimas
namespace vb2018
{
    internal class Stadionok
    {
        public string varos { get; set; }
        public string nev1 { get; set; }
        public string nev2 { get; set; }
        public int f_hely { get; set; }

        public Stadionok(string varos, string nev1, string nev2, int f_hely)
        {
            this.varos = varos;
            this.nev1 = nev1;
            this.nev2 = nev2;
            this.f_hely = f_hely;
        }
        public override string ToString()
        {
            return varos+";"+nev1+";"+nev2+";"+f_hely;
        }
    }
}
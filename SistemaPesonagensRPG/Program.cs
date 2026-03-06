using System.Text;

namespace SistemaPesonagensRPG
{
    internal class Program
    {

        public static void TocarSomAlarme(string msg)
        {
            Console.WriteLine("[🔊 SOM DE CORAÇÃO RÁPIDO] " + msg);
        }

        public static void ExibirEfeitoSangue(string msg)
        {
            Console.WriteLine("[⚠]" + msg);
            
        }

        public static void VerificarEstado(Personagens p)
        {
            if(p.PontosVida <= 0)
            {
                TocarSomAlarme("💀O personagem foi DERROTADO!!💀");
            }
            if (p.PontosVida <= 20 && p.PontosVida > 0)
            {
                ExibirEfeitoSangue("VIDA CRÍTICA!");
            }
        }





        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Personagens Personagem01 = new Personagens("John", 15);

            //Personagem01.GanharExperiencia(120);

           
            //Personagem01.ReceberDano(30);
            //VerificarEstado(Personagem01);

       
            //Personagem01.ReceberDano(60);
            //VerificarEstado(Personagem01);

           
            //Personagem01.ReceberDano(20);
            //VerificarEstado(Personagem01);

            
            //Personagem01.Curar(50);


            Personagens Personagem02 = new Personagens("Gigante", 25);

            Console.WriteLine($"Personagem: {Personagem01.Nome} || Vida: {Personagem01.PontosVida} || Poder de Ataque: {Personagem01.PoderAtaque}");
            Console.WriteLine($"Personagem: {Personagem02.Nome} || vida: {Personagem02.PontosVida} || Poder de Ataque: {Personagem02.PoderAtaque}");

            Personagem01.Atacar(Personagem02);

            Console.WriteLine($"Personagem: {Personagem01.Nome} || Vida: {Personagem01.PontosVida} || Poder de Ataque: {Personagem01.PoderAtaque}");
            Console.WriteLine($"Personagem: {Personagem02.Nome} || vida: {Personagem02.PontosVida} || Poder de Ataque: {Personagem02.PoderAtaque}");



        }
    }
}

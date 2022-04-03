namespace dio_desafio_csharp_poo_abstraindo_um_jogo_rpg.Classes
{
    public class Arqueiro : Heroi
    {
        public Arqueiro(string nome) : base(nome, "Arqueiro")
        {
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nome} usa Flechada.");
        }

        public override void UsarHabilidade()
        {
            if(MP >= 2)
            {
                Console.WriteLine($"{Nome} usa Flechada Tripla.");
                MP--;
            }
            
        }
    }
}
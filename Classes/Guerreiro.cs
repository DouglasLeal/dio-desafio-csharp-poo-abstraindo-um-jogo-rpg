namespace dio_desafio_csharp_poo_abstraindo_um_jogo_rpg.Classes
{
    public class Guerreiro : Heroi
    {
        public Guerreiro(string nome) : base(nome, "Guerreiro")
        {
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nome} usa Corte Leve.");
        }

        public override void UsarHabilidade()
        {
            if(MP >= 3)
            {
                Console.WriteLine($"{Nome} usa Corte Duplo.");
                MP--;
            }            
        }
    }
}
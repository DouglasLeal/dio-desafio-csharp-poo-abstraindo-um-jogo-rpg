namespace dio_desafio_csharp_poo_abstraindo_um_jogo_rpg.Classes
{
    public class Mago : Heroi
    {
        public Mago(string nome) : base(nome, "Mago")
        {
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nome} usa Esfera de Energia.");
        }

        public override void UsarHabilidade()
        {
            if(MP >= 2)
            {
                Console.WriteLine($"{Nome} usa Bola de Fogo.");
                MP--;
            }            
        }
    }
}
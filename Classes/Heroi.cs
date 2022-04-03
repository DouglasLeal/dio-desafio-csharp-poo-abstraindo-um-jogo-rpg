namespace dio_desafio_csharp_poo_abstraindo_um_jogo_rpg.Classes
{
    public abstract class Heroi
    {
        public string Nome { get; private set; }
        public string Classe { get; private set; }
        public int Nivel { get; private set; }
        public int Experiencia { get; private set; }
        public int ExperienciaProximoNivel { get; private set; }
        public int HP { get; private set; }
        public int HPMaximo { get; private set; }
        public int MP { get; protected set; }
        public int MPMaximo { get; private set; }
        public int Forca { get; private set; }
        public int Resistencia { get; private set; }
        public int Inteligencia { get; private set; }
        public int Agilidade { get; private set; }
        public int PontosParaDistribuir { get; private set; }

        public Heroi(string nome, string classe)
        {
            Nome = nome;
            Classe = classe;
            Nivel = 1;
            Experiencia = 0;
            ExperienciaProximoNivel = 100;
            HP = 50;
            HPMaximo = 50;
            MP = 10;
            MPMaximo = 10;
            Forca = 1;
            Resistencia = 1;
            Inteligencia = 1;
            Agilidade = 1;
            PontosParaDistribuir = 5;
        }

        public void AumentarExp(int nivelInimigo)
        {
            var random = new Random();
            Experiencia += nivelInimigo * random.Next(25, 51);
        
            if(Experiencia >= ExperienciaProximoNivel)
            {
                Nivel++;
                PontosParaDistribuir += 2;
                ExperienciaProximoNivel *= 2;
                Console.WriteLine($"Você passou de nível! Nível atual {Nivel}");
            }
        }

        public void AumentarAtributo(string atributo)
        {
            if(PontosParaDistribuir <= 0)
            {
                return;
            }

            switch (atributo)
            {
                case "forca":
                    Forca++;
                    break;
                case "resistencia":
                    Resistencia++;
                    HPMaximo += 25;
                    HP = HPMaximo;
                    break;
                case "inteligencia":
                    Inteligencia++;
                    MPMaximo += 4;
                    MP = MPMaximo;
                    break;
                case "agilidade":
                    Agilidade++;
                    break;
                default:
                    break;
            }
        }

        public void Recuperar()
        {
            HP = HPMaximo;
            MP = MPMaximo;
        }

        public abstract void Atacar();
        public abstract void UsarHabilidade();

    }
}
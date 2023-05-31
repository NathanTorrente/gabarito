
public class Program
{
    static void Main(string[] args)
    {

    }
    
            
    
    class Prova
    {
        private Gabarito gabarito;
        private List<char> respostasAluno;
        private int numQuestaoAtual;

        public Prova(Gabarito gabarito)
        {
            this.gabarito = gabarito;
            this.respostasAluno = new List<char>();
            this.numQuestaoAtual = 1;
        }

        public void RespostaAluno(char resposta)
        {
            respostasAluno.Add(resposta);
            numQuestaoAtual++;
            // ola
        }

        public int Acertos()
        {
            int acertos = 0;
            for (int i = 0; i < respostasAluno.Count; i++)
            {
                if (respostasAluno[i] == gabarito.RespostaQuestao(i + 1))
                {
                    if (i < 10)
                    {
                        acertos += 1;
                    }
                    else
                    {
                        acertos += 2;
                    }
                }
            }
            return acertos;
        }

        public double Nota()
        {
            return Acertos() / 2.0;
        }

        public double Maior(Prova outraProva)
        {
            int acertos1 = this.Acertos();
            int acertos2 = outraProva.Acertos();
            if (acertos1 > acertos2)
            {
                return this.Nota();
            }
            else if (acertos2 > acertos1)
            {
                return outraProva.Nota();
            }
            else
            {
                double nota1 = this.Nota();
                double nota2 = outraProva.Nota();
                if (nota1 > nota2)
                {
                    return nota1;
                }
                else
                {
                    return nota2;
                }
            }
        }
    }
}


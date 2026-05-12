namespace Atividade3
{
    public class Personagem
    {
        string nome;
        int velocidade;


        public static void FilaVelocidade()
        {
            Console.WriteLine("Exercício 2 (Lista e Fila)\n");
            List<Personagem> personLista = new List<Personagem>();
            personLista.Add(new Personagem { nome = "Geralt", velocidade = 15 });
            personLista.Add(new Personagem { nome = "Joel", velocidade = 8 });
            personLista.Add(new Personagem { nome = "Leon", velocidade = 10 });

            SelecionSort(personLista);
            ListaVelocidadeAdd(personLista);

            //foreach (var p in personLista) Console.WriteLine(p);
        }

        public static void SelecionSort(List<Personagem> personLista)
        {
            int n = personLista.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (personLista[j].velocidade < personLista[minIndex].velocidade)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    Personagem temp = personLista[i];
                    personLista[i] = personLista[minIndex];
                    personLista[minIndex] = temp;
                }
            }
        }
        public static void ListaVelocidadeAdd(List<Personagem> personLista)
        {

            Queue<Personagem> filaPersonagem = new Queue<Personagem>();

            for (int i = 0; i < personLista.Count; i++)
            {
                filaPersonagem.Enqueue(personLista[i]);
            }

            ListaVelocidadeRemove(filaPersonagem);
        }

                public override string ToString()
        {
            return $"{nome} - Velocidade: {velocidade}";
        }


        public static void ListaVelocidadeRemove(Queue<Personagem> filaPersonagem)
        {

            int n = filaPersonagem.Count;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(filaPersonagem.Dequeue());
            }
        }
    }
}

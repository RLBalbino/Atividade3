namespace Atividade3
{

    public class Tabuleiro
    {
        public string[] tabuleiro = new string[] { "Vazio", "Vazio", "Vazio" };

        public override string ToString()
        {
            return string.Join(", ", tabuleiro);
        }

        public Tabuleiro Clone()
        {
            return new Tabuleiro { tabuleiro = (string[])this.tabuleiro.Clone() };
        }
        public static void TabuleiroHistorico()
        {
            Stack<Tabuleiro> tabuleiroPosicao = new Stack<Tabuleiro>();
            Tabuleiro t1 = new Tabuleiro();

            t1.tabuleiro[0] = "Jogador";
            tabuleiroPosicao.Push(t1.Clone());
            t1.tabuleiro[0] = "Vazio";
            t1.tabuleiro[1] = "Jogador";
            tabuleiroPosicao.Push(t1.Clone());

            Stack<Tabuleiro> pilhaClonada = new Stack<Tabuleiro>(tabuleiroPosicao.Select(t => t.Clone()).Reverse());
            
            RemovaHistorico(pilhaClonada);
        }
        public static void RemovaHistorico(Stack<Tabuleiro> pilhaClonada)
        {
            pilhaClonada.Pop();
            Console.WriteLine(pilhaClonada.Peek());
        } 
    }
}

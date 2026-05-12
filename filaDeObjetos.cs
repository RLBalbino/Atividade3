namespace Atividade3
{

    public class ItemForja
    {
        public string tipo;
        public string nome;
        public int TempoSegundos;

        public static void Forja()
        {
            Console.WriteLine("Exercício 1 (Fila de Objetos)\n");
            Queue<ItemForja> filaForja = new Queue<ItemForja>();
            filaForja.Enqueue(new ItemForja { tipo = "Arma", nome = "Espada de Ferro", TempoSegundos = 120 });
            filaForja.Enqueue(new ItemForja { tipo = "Armadura", nome = "Escudo", TempoSegundos = 200 });
            filaForja.Enqueue(new ItemForja { tipo = "Cosumivel", nome = "Pacote de Flechas", TempoSegundos = 60 });

            Confeccao(filaForja);
        }
        public static void Confeccao(Queue<ItemForja> filaForja)
        {
            while (filaForja.Count > 0)
            {
                ItemForja itemTerminado = filaForja.Dequeue();
                Console.WriteLine($"Item fabricado com sucesso: {itemTerminado.nome}! \nTempo de forja: {itemTerminado.TempoSegundos}s.");

                if (filaForja.Count > 0)
                {
                    Console.WriteLine($"\nO próximo da fila é: {filaForja.Peek().nome}.\n");
                }


            }
            Console.WriteLine("Fila vazia, nenhum item para forja\n");
        }
    }
}

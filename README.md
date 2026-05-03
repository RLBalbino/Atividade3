# Atividade3
Atividade avaliativa sobre pilhas, filas e listas.

# Exercício 1 (Fila de Objetos) - 2 pontos
1. Crie uma classe chamada ItemForja com as propriedades: Nome (string),
TempoSegundos (int) e Tipo (string).
2. Crie uma fila (Queue) que armazene objetos do tipo ItemForja.
3. O jogador foi na forja e mandou fabricar 3 itens. Instancie e adicione à fila: uma
"Espada de Ferro", um "Escudo" e um "Pacote de Flechas".
4. Simule o sistema do jogo terminando de fabricar o primeiro item. Remova-o da fila e
exiba no console: "Item fabricado com sucesso: [Nome]! Tempo de forja:
[TempoSegundos] O próximo da fila é: [Nome do próximo]".
5. Faça isso para todos os três itens, quando o último item for forjado, exiba no
console: “Fila vazia, nenhum item para forja”

# Exercício 2 (Lista e Pilha) - 4 pontos
1. Crie uma classe Personagem com: Nome (string) e Velocidade (int).
2. Crie uma lista com 3 personagens na seguinte ordem:
○ "Geralt" (Vel: 15);
○ "Joel" (Vel: 8);
○ "Leon" (Vel: 10).
3. Antes de o combate começar, você deve ordenar essa lista do mais rápido para o
mais lento.
4. Após ordenar, insira os personagens em uma fila.
5. Remova cada um da fila e exiba a ordem de ataque: "1 - Ataque: Geralt, 2 - Ataque:
Leon, 3- Ataque: Joel".

# Exercício 3 (Pilha) - 4 Pontos
Em jogos de xadrez ou quebra-cabeça de grade, quando você usa um botão "Desfazer", o
jogo restaura a posição anterior do tabuleiro.
1. Crie um tabuleiro simples representado por um array unidimensional: string[]
tabuleiro = { "Vazio", "Vazio", "Vazio" };.
2. Crie uma pilha de strings para guardar o histórico do tabuleiro.
3. O jogador moveu um personagem para a posição 0. Atualize o tabuleiro:
tabuleiro[0] = "Jogador"; e empilhe o tabuleiro na pilha.
4. O jogador moveu o personagem para a posição 1: Atualize o tabuleiro para
{"Vazio", "Jogador", "Vazio"} e empilhe de novo.
5. Em C#, arrays são tipos de referência. Se você apenas empilhar a variável
tabuleiro, todas as posições da pilha apontarão para o mesmo array e o histórico
será inútil. Você deve empilhar uma cópia exata e independente (Clone) do array a
cada jogada.
6. Desempilhe a última jogada e exiba como o tabuleiro estava no turno anterior.

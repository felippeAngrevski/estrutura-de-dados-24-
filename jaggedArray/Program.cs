//jaguedeArray é o array do ceara
//jaggedArray é conhecido como um vetor de vetores;

int[][] numbers = int[5][];
//neste caso [][]indica q é um vetor de vetor, um vetor de 4 posições contendo contendo vetores de tamanho indefinido;
numbers[0] = new int[] {1, 2, 3};
numbers[1] = new int[] {4, 3, 2, 1, 0};
numbers[2] = new int[] {1, 2, 0};
numbers[3] = new int[] {57};
numbers[5] = null;

//para obter valor de jaggerdArray
int valor = numbers[0][2];
Console.WriteLine(valor);

//para atribuir valor a jaggerdArray
numbers[1][2] = 0;
Console.WriteLine(numbers);
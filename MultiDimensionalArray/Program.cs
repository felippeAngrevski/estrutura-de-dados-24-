// criando um vetor multidimensional 5x2

int[,] numbers = new int[5, 2];

//criando um vetor tridimensional 
int[,,] trinumbers = new int[5, 4, 3];

//podemos inicializar os valores do vetor no momento de sua declaração
int[,] iniNumbers = new int[,]{
    {9, 5, -9}, 
    {3, 8, -7},
    {4, 12, 3}, 
    {6, 5, -22},
    {1, 4, 9},
};

//para acessar os valores contidos neste tipo de variavel 
int valor = iniNumbers[0,1]; //neste caso 5

Console.WriteLine($"iniNumbers[0,1] == {valor}");

int maiorValor = 0, i, j, linha = 0, coluna = 0;

for(i = 0; i < 5; i++){
    for(j = 0; j < 3; j++){
        if(iniNumbers[i, j] > maiorValor){
            maiorValor = iniNumbers[i,j];
            linha = i + 1;
            coluna = j + 1;
        }
    };
};

Console.WriteLine($"maior valor é {maiorValor}");
Console.WriteLine($"posição é {linha}, {coluna}");

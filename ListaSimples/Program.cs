using System.Collections; 

//utilizando a lista simples
ArrayList arrList = new();
arrList.Add(5);
arrList.Add("nome");

//é possivel add vários valores de uma vez
arrList.AddRange(new int[]{1,2,3});
//um metodo add insere o valor ao final do vetor

//já o metodo insert permite incluir o valor na posição especificada no primeiro parametro.
arrList.Insert(1, 15);

//lento valores da lista
object primeiro = arrList[0];
int quarto = (int)arrList[3];

//percorrendo a lista com foreach
foreach(object obj in arrList){
    Console.Write($" | {obj}");
}


//obtendo o tamanho total da lista
int tamanho = arrList.Count;

//obtendo a capacidade
int capacidade = arrList.Capacity;

for(int i = 0; i < arrList.Count; i++){
    Console.Write($" | {arrList[i]}");
}

//recursos importantes da lista
//verificas se um valor é contido na lista
bool contemNome = arrList.Contains("nome");
if(!contemNome) Console.WriteLine("n tem");

//para saber o índica q contem o valor buscado. neste caso se o valor existir na lista, ele retorna o indice como número intieiro.
//caso o valor não exista, retorna -1.
int indiceValor = arrList.IndexOf("nome");
if(indiceValor >= 0) Console.WriteLine($" nome está em [{indiceValor}]");
else Console.WriteLine("n tem");

//é possível também, remover itens da lista
arrList.Remove("nome"); //remove pelo valor
arrList.RemoveAt(4); //remove por indice
arrList.RemoveRange(0, 2); //o primeiro parametro é o indice e o segundo é quantas caas após o indice
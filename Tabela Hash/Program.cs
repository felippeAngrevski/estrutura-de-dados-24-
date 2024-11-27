//exemplo de uma agenda telefonica-
using System.Collections;

Hashtable phoneBook = new Hashtable(){
    {"Thomazzi", "49-99961-0150"},
    {"Mauricio", "49-99975-8575"},
    {"Gabriel", "49-99205-8904"},
};

// É possivel adicionar elementos de diverças formas
// Pelo proprio indice chave inexistente
phoneBook["M"] = "5566";

// Ou pelo metodo Add()
phoneBook.Add("N", "6169");

// Entretanto a tabela hash verifica se há duplicidade de chave e pode lançar uma exeption
try{
    phoneBook.Add("Thomazzi", "49-99961-0150");
}
catch(Exception ex){
    Console.WriteLine($"Erro ao tentar incerir o valor repetido");
    Console.WriteLine(ex.Message);
}

// Percorrendo itens da hash table
Console.WriteLine("Agenda telefonica:");
if (phoneBook.Count == 0) {
    Console.WriteLine("A agenda está vazia");
}
else {
    foreach (DictionaryEntry entry in phoneBook) {
        Console.WriteLine($"{entry.Key}:{entry.Value}");
    }
}
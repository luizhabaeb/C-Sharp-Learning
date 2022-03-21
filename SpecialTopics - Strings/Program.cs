//STRINGS - INTERESTING FUNCTIONS


string original = "abcde FGHIJ ABC abc DEFG   ";
string s1 = original.ToUpper();
string s2 = original.ToLower(); 
string s3 = original.Trim();     //tira os espaços
string s4 = original.Substring(3);
string s5 = original.Substring(3, 5); //Começo na posição três, mas corto apenas 5 caracteres > "de FG"
string s6 = original.Replace('a', 'x'); //Substituir parte da string por outra
bool b1 = String.IsNullOrEmpty(original); //Testa se o conteúdo é NULO ou vazio ""
bool b2 = String.IsNullOrWhiteSpace(original); //Testa se a variável é nula ou tem muito espaço em branco

int n1 = original.IndexOf("bc");
int n2 = original.LastIndexOf("bc");


Console.WriteLine("Original: -" + original + "-");
Console.WriteLine("ToUpper: -" + s1 + "-");
Console.WriteLine("ToLower: -" + s2 + "-");
Console.WriteLine("Trim: -" + s3 + "-");
Console.WriteLine("IndexOf (bc) starts on position: " + n1);
Console.WriteLine("LastIndexOf (bc) starts on position: " + n2);
Console.WriteLine("Substring (3): " + s4);
Console.WriteLine("Substring (3, 5): " + s5);
Console.WriteLine("Replace ('a' to 'x'): " + s6);
Console.WriteLine("Is Null or Empty: " + b1);  //Falso - A String não é nulo ou vazia
Console.WriteLine("Is Null or White Space: " + b2); //Falso


//• Formatar: ToLower(), ToUpper(), Trim()
//• Buscar: IndexOf, LastIndexOf
//• Recortar: Substring(inicio), Substring(inicio, tamanho)
//• Substituir: Replace(char, char), Replace(string, string)
//• String.IsNullOrEmpty(str), String.IsNullOrWhiteSpace(str)
//• str.Split(' ')
//• Conversão para numero: int x = int.Parse(str), int x =Convert.ToInt32(str)
//• Conversão de número: str = x.ToString(), str = x.ToString("C"), str =
//x.ToString("C3"), str = x.ToString("F2"
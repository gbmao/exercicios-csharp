//A solução deve incluir uma iteração do-while ou while.

//Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() 
//para solicitar ao usuário um dos três nomes de função: Administrador, Gerente ou Usuário.

Console.WriteLine("Please insert your role (Administrator, Manager or User)");
string role = "";
bool azul = true;
do
{
    role = Console.ReadLine().Trim().ToLower();
    //role.Trim().ToLower();
    if (role == "administrator") break;
    if (role == "manager") break;
    if (role == "user") break;
    Console.WriteLine($"The role name that you entered  \"{role}\"  is not valid. Enter your role name (Administrator, Manager or User)");

} while (azul);

Console.WriteLine($"Your input value ({role}) has been accepted");
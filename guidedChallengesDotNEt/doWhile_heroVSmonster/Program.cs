//Random random = new Random();
//int current = random.Next(1,11);

/*do
{
    current = random.Next(1, 11);
    string talk = "- ainda não é o 7!";
    if (current == 7) talk = "- Parabéns, tiramos 7!!!!";
    Console.WriteLine(current + talk);
} while (current !=7);



while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}  
Console.WriteLine($"Last number: {current}");


do
{
    current = random.Next(1,11);

    if (current >= 8) continue;

    Console.WriteLine("Ainda estamos no bloco!");
    Console.WriteLine(current);
    
} while (current != 7);

*/

int monsterHealth = 10;
int heroHealth = 10;
Random random = new Random();
int damage = 0;

do 
{
    damage = random.Next(1, 11);
    monsterHealth -= damage;
    Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth}.");

    if (monsterHealth > 0) 
    {
        damage = random.Next(1, 11);
        heroHealth -= damage;
        Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");
        
        if (heroHealth <= 0)
        {
            Console.WriteLine("Monster Wins!");
            break;
        }
    }

} while (monsterHealth > 0);

if (monsterHealth <= 0) Console.WriteLine("Hero Wins!");


/* solução gabarito:



int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!"); 


*/
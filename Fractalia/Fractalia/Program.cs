Console.WriteLine("Enter Character name"); 
string character = Console.ReadLine();
int lvl = 1;
int maxhp = 10;
float currentHp = 10;



if (maxhp < 0)
{
    maxhp = 0;
}
if (currentHp > maxhp)
    currentHp = maxhp;

Console.WriteLine($"Name: {character}, Level: {lvl},HP: {currentHp}");

Console.WriteLine("How many dmg?");
string? damageInput = Console.ReadLine();

float damage = float.Parse(damageInput);


static float TakeDamage(float currentHp, float damage)
{ 
    currentHp -= damage;

    if(currentHp < 0)
    {
        currentHp = 0;
    }
    return currentHp;

}

currentHp = TakeDamage(currentHp, damage);

bool isAlive = currentHp > 0;
if (!isAlive)
    Console.WriteLine("You Dead");
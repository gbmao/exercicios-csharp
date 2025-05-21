using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = { "('-')", "(^-^)", "(X_X)" };
string[] foods = { "@@@@@", "$$$$$", "#####" };

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

InitializeGame();


while (!shouldExit)
{
    // fechando o programa em caso de mudar tamanho do terminal. Melhor local para por IF?
    if (TerminalResized())
    {
        Console.Clear();
        Console.WriteLine("Console was resized. Program exiting.");
        Console.WriteLine();
    }
    // stun se for X_X
    Stun();
    Move();
    PlayerAteFood();
}
Console.Clear();

// stun the player
void Stun()
{
    if (PlayerIsX_X())
    {
        FreezePlayer();
        player = states[0];
    }
}
// Returns true if the Terminal was resized 
bool TerminalResized()
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood()
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Changes the player to match the food consumed
void ChangePlayer()
{   
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer()
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move()
{
    int lastX = playerX;
    int lastY = playerY;

    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.UpArrow:
            playerY--;
            break;
        case ConsoleKey.DownArrow:
            playerY++;
            break;
        case ConsoleKey.LeftArrow:
            if (PlayerIsHappy())
            {
                playerX--;
                playerX--;
                playerX--;
            }
            else
            {
                playerX--;
            }

            break;
        case ConsoleKey.RightArrow:
            if (PlayerIsHappy())
            {
                playerX++;
                playerX++;
                playerX++;
            }
            else
            {
                playerX++;
            }

            break;
        case ConsoleKey.S:
            player = states[0];
            break;
        // Se uma entrada não direcional for detectada, faça com que o jogo seja encerrado
        default:
            shouldExit = true;
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++)
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame()
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}

//Criar um método que usa as variáveis existentes de posicionamento do player e do alimento
//O método deve retornar um valor
//Depois que o usuário mover o personagem, chame seu método para determinar o seguinte:
//Se deve ou não usar o método existente que altera a aparência do jogador
//Se deve ou não usar o método existente para mostrar novamente o alimento

void PlayerAteFood()
{

    //int[,] playerPosition = { { playerX, playerY } , { playerX +1, playerY +1 } };
    if (playerX == foodX && playerY == foodY)
    {
        ChangePlayer();

        ShowFood();
    }
    // player = states[0];
}
// method para retornar se a aparencia é x_x
bool PlayerIsX_X()
{
    return player == states[2];
}

bool PlayerIsHappy()
{
    return player == states[1];
}
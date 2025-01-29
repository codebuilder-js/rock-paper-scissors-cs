using System;
class RockPaperScissors {
  static void Main() {
    int playerScore = 0;
    int enemyScore = 0;
    
    Random random = new Random();
    
    Console.WriteLine("Welcome to Rock, Paper and Scissors game!");
    
    while(playerScore != 3 && enemyScore != 3) {
        Console.WriteLine("Player Score: " + playerScore + " | Enemy Score: " + enemyScore);
        Console.Write("Type 'R'ock, 'P'aper or 'S'cissors: ");
        
        string playerChoice = Console.ReadLine().ToLower();
        
        int enemyChoice = random.Next(0, 3);
        
        if(enemyChoice == 0) {
            Console.WriteLine("Enemy choses Rock");
            
            if(playerChoice == "r") {
                Console.WriteLine("Tie!");
            } else if(playerChoice == "p") {
                Console.WriteLine("Player wins this round!");
                playerScore++;
            } else if(playerChoice == "s") {
                Console.WriteLine("Enemy wins this round!");
                enemyScore++;
            }
        } else if(enemyChoice == 1) {
            Console.WriteLine("Enemy choses Paper");
            
            if(playerChoice == "p") {
                Console.WriteLine("Tie!");
            } else if(playerChoice == "s") {
                Console.WriteLine("Player wins this round!");
                playerScore++;
            } else if(playerChoice == "r") {
                Console.WriteLine("Enemy wins this round!");
                enemyScore++;
            }
        } else if(enemyChoice == 2) {
            Console.WriteLine("Enemy chooses Scissors");
            
            if(playerChoice == "s") {
                Console.WriteLine("Tie!");
            } else if(playerChoice == "r") {
                Console.WriteLine("Player wins this round!");
                playerScore++;
            }else if(playerChoice == "p") {
                Console.WriteLine("Enemy wins this round!");
                enemyScore++;
            }
        }
        
        Console.WriteLine("");
    }
    
    if(playerScore == 3) {
        Console.WriteLine("Player wins!");
    } else if (enemyScore == 3) {
        Console.WriteLine("Enemy wins!");
    }
  }
}

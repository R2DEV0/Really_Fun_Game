// using System;

// namespace Really_Fun_Game
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine(@"

// ************************************************************************************************        
// *                                                                                              *
// *                      ,,))))))));,                                                            *
// *                   __)))))))))))))),                                                          *
// *           \|/       -\(((((''''((((((((.                                                     *
// *           -*-==//////((''  .     `)))))),                                                    *
// *           /|\      ))| o    ;-.    '(((((                                  ,(,               *
// *                   ( `|    /  )    ;))))'                               ,_))^;(~              *
// *                       |   |   |   ,))((((_     _____------~~~-.        %,;(;(>';'~           *
// *                       o_);   ;    )))(((` ~---~  `::           \      %%~~)(v;(`('~          *
// *                           ;    ''''````         `:       `:::|\,__,%%    );`'; ~             *
// *                          /    Really_Fun_Game   )   /      `:|`----'     `-'                 *
// *                   ______/\/~    |                 /        /                                 *
// *                 / /~;;.____/;;'  /          ___--,-(   `;;;/                                 *
// *                /  / //  _;______;'------~~~~~    /;;/\    /                                  *
// *               //  | |                        / ;   \;;,\                                     *
// *               (<_  | ;                      /',/-----'  _>                                   *
// *               \_| ||_                     //~;~~~~~~~~~                                      *
// *                   `\_|                   (,~~                                                *
// *                                           \~\                                                *
// ***********************************************************************************************    
//             ");
//             Console.WriteLine("\nWelcome to our really fun game! What would you like your player's name to be?");
//             string PlayerName = Console.ReadLine();
//             string PlayerClass = "";
//             Console.WriteLine($"\nTime for {PlayerName} to start their journey!");
//             // Character Creation starts here
//             bool ClassSelected = false;
//             while(ClassSelected == false)
//             {
//                 Console.WriteLine("\nWho would you like to be? \n1. Wizard \n2. Ninja \n3. Samurai");
//                 PlayerClass = Console.ReadLine();
//                 if(PlayerClass == "1" || PlayerClass.ToLower() == "wizard")
//                 {
//                     PlayerClass = "Wizard";
//                     ClassSelected = true;
//                     Console.WriteLine(@"

// ************************************************************************************************

//                                     _,._                     
//                         .||,       /_ _\\                 o      
//                         \.`',/     |'L'| |        o          
//                         = ,. =     | -,| L              o    
//                         / || \    ,-'\'/,'`.                  
//                         ||     ,'   `,,. `.            0    
//                         ,|____,' , ,;' \| |                 
//                         (3|\    _/|/'   _| |       0         
//                         ||/,-''  | >-'' _,\\              0 
//                         ||'      ==\ ,-'  ,'         0     
//                         ||       |  V \ ,|             0    
//                         ||       |    |` |        _________ 
//                         ||       |    |   \     <(‘       ‘)>
//                         ||       |    \    \      \,     ,/
//                         ||       |     |    \.   _//^---^\\_
//                         ||       |      \_,-'               
//                         ||       |___,,--')_\               
//                         ||         |_|   ccc/               
//                         ||        ccc/ 
                        
 
// ************************************************************************************************                                                                              
//                     ");
//                 }
//                 else if(PlayerClass == "2" || PlayerClass.ToLower() == "ninja")
//                 {
//                     PlayerClass = "Ninja";
//                     ClassSelected = true;
//                     Console.WriteLine( @"
// *****************************************************************************
// *                                                                           *
// *                ___                                                        *
// *               /___\_/                                                     *
// *               |\_/|<\                                                     *
// *               (`o ) `   __(\_            /\_                              *
// *               \ ~ /_.-`` _|__)  ( ( ( ( /()>                              *
// *              _/`-`  _.-``               `\/                               *
// *            .-`      (    __                                               *
// *          (  \.-     \  /   `-.       |                                    *
// *           \  \_    /\/        `-.__-( )                                   *
// *            `-|__)__//   /``-   /__   /                                    *
// *                \__//   /         (__/                                     *
// *                  //   )                                                   *
// *                 /|   |                                                    *
// *                //| J |                                                    *
// *               // |   |                                                    *
// *                  |   |                                                    *
// *                  L___J                                                    *
// *                   ( |                                                     *
// *                   ..oO()                                                  *
// *                                                                           *
// *****************************************************************************
//                 ");
//                 }
//                 else if(PlayerClass == "3" || PlayerClass.ToLower() == "samurai")
//                 {
//                     PlayerClass = "Samurai";
//                     ClassSelected = true;
//                     Console.WriteLine(@"
//                                     /)
//                                    //
//                  __*_             //
//               /-(____)           //
//              ////- -|\          //
//           ,____o% -,_          //
//          /  \\   |||  ;       //
//         /____\....::./\      //
//        _/__/#\_ _,,_/--\    //
//        /___/######## \/''-(\  < |__\  /    \
//      /___\  __  /___\/     |
//     /____\\'__'//____\   __|
//                     ");
//                 }
//                 else
//                 {
//                     Console.WriteLine("\nThat wasn't one of the options!");
//                 }
//             }
//             Character Player;
//             if(PlayerClass == "Wizard")
//             {
//                 Player = new Wizard(PlayerName);
//             }
//             else if(PlayerClass == "Ninja")
//             {
//                 Player = new Ninja(PlayerName);
//             }
//             else
//             {
//                 Player = new Samurai(PlayerName);
//             }
//             // End Character Creation
//             string[] Location = {"Your Home", "You are starting in your own home. You are the only one here."};
//             // Game Loop
//             while(Player.IsAlive == true)
//             {
//                 Console.WriteLine("\nWhat would you like to do?\n1.Look around\n2.Go somewhere\n3.Pick a fight");
//                 string PlayerResponse = Console.ReadLine();
//                 // Looking around
//                 if(PlayerResponse == "1" || PlayerResponse.ToLower() == "look around")
//                 {
//                     Console.WriteLine($"You are in {Location[0]}. Description: {Location[1]}");
//                 }
//                 // Going somewhere new
//                 else if(PlayerResponse == "2" || PlayerResponse.ToLower() == "go somewhere")
//                 {
//                     bool LocationChosen = false;
//                     while(LocationChosen == false)
//                     {
//                         Console.WriteLine("\nWould you like to go to \n1.The Woods \n2.The Caves \n3. The Supermarket \n4. Your Home \n5. Cancel");
//                         PlayerResponse = Console.ReadLine();
//                         if(PlayerResponse == "1" || PlayerResponse.ToLower() == "the woods")
//                         {
//                             Location[0] = "The Woods";
//                             Location[1] = "You are in the woods. There are owls hooting and wolves howling and you see something dash between the trees!  What was that?";
//                             LocationChosen =  true;
//                             System.Console.WriteLine(@"



// ******************************************************************************
// *                                                                            *
// *                                  ,@@@@@@@,                                 *
// *                         ,&&,.   ,@@@@@@/@@,  .oo8888o.                     *
// *                       ,&%%&%&&%,@@@@@/@@@@@@,8888\88/8o                    * 
// *                     ,%&\%&&%&&%,@@@\@@@/@@@88\88888/88'                    *
// *                    %&&%&%&/%&&%@@\@@/ /@@@88888\88888'                     *
// *                     %&&%/ %&%%&&@@\ V /@@' `88\8 `/88'                     *
// *                      `&%\ ` /%&'    |.|        \ '|8'                      *
// *                          |o|        | |         | |                        *
// *                          |.|        | |         | |                        *
// *                      / ._\//_/__/  ,\_//__\\/.  \_//__/_                   *
// *                                                                            *
// ******************************************************************************


//                         ");
//                         }
//                         else if(PlayerResponse == "2" || PlayerResponse.ToLower() == "the caves")
//                         {
//                             Location[0] = "The Caves";
//                             Location[1] = "You are in the caves. It is cold, dark, and you hear dripping!  You walk in deeper and hear a loud scratching that startles you so much, you bash into a wall. Bats scatter through the air while something you stepped on is screeching and something else is hitting you in the face. Ouch!";
//                             LocationChosen =  true;
//                             System.Console.WriteLine(@"




// ***********************************************************************************
// *                    /   \              /'\       _                               *
// *\_..           /'.,/     \_         .,'   \     / \_                             *
// *    \         /            \      _/       \_  /    \     _                      *
// *     \__,.   /              \    /           \/.,   _|  _/ \                     *
// *          \_/                \  /',.,/M\      \_ \_/  \/    \                    *
// *                           _  \/   /MMMM\../',.\    _/      \                    *
// *             /           _/m\  \  /MMMMMM\      \  /.,/'\   _\                   *
// *           _/           /MMmm\  \_MMMMMMMM\      \/      \_/  \                  *
// *          /      \     |MMMMmm|   \__   \          \_ _     \   \_               *
// *                  \   /MMMMMMm|      \   \           /M\      \    \             *
// *          /M\      \  |MMMMMMmm\      \___          /MMM\_      \_   \           *
// *         /MMM\     \|MMMMMMMMmm|____.'  /\_        /MMMMM\       \   \_          *
// *        /MMMMM\     /'.,___________...,,'   \     /MMMMMMM\   \        \         *
// *       /MMMMMMM\   /       \          |      \   /MMMMMMMMM\   \_       \        *
// *                 _/        |           \      \_      \     \    \       \_      *
// *                /                               \      \     \_   \        \     *
// *                                                 \      \      \   \__      \    *
// *                                                  \      \_     \     \      \   *
// *                                                   |       \     \     \      \  *
// *                                                    \            |            \  *
// ***********************************************************************************
//                             ");
//                         }
//                         else if(PlayerResponse == "3" || PlayerResponse.ToLower() == "the supermarket")
//                         {
//                             Location[0] = "\nThe Supermarket";
//                             Location[1] = "\nYou are in the supermarket. You decide to grab some groceries while you are out. Your shopping list includes chips, milk, eggs, and bread. Make sure to you wear your face mask and remain 6ft from all other people or you will die. You also notice that a dragon is shopping at the same market";
//                             LocationChosen =  true;
//                             System.Console.WriteLine(@"
//                                                     ___
//                                              ___..--'  .`.
//                                     ___...--'     -  .` `.`.
//                            ___...--' _      -  _   .` -   `.`.
//                   ___...--'  -       _   -       .`  `. - _ `.`.
//            __..--'_______________ -         _  ._________ . - `.`.
//         .`    _ /\    -        .`      _     .|SuperDuper | _  -`.`.
//       .` -   _ /  \_     -   .`  _         .` |  Market   |`.   - `.`.
//     .`-    _  /   /\   -   .`        _   .`   |___________|  `. _   `.`.
//   .`________ /__ /_ \____.`____________.`     ___       ___  - `._____`|
//     |   -  __  -|    | - |  ____  |   | | _  |   |  _  |   |  _ |
//     | _   |  |  | -  |   | |.--.| |___| |    |___|     |___|    |
//     |     |--|  |    | _ | |'--'| |---| |   _|---|     |---|_   |
//     |   - |__| _|  - |   | |.--.| |   | |    |   |_  _ |   |    |
//  ---``--._      |    |   |=|'--'|=|___|=|====|___|=====|___|====|
//  -- . ''  ``--._| _  |  -|_|.--.|_______|_______________________|
// `--._           '--- |_  |:|'--'|:::::::|:::::::::::::::::::::::|
// _____`--._ ''      . '---'``--._|:::::::|:::::::::::::::::::::::|
// ----------`--._          ''      ``--.._|:::::::::::::::::::::::|
// `--._ _________`--._'        --     .   ''-----.................'
//      `--._----------`--._.  _           -- . :''           -    ''
//           `--._          `--._ :'              -- . :''      -- . ''
//  -- . ''       `--._          `--._   -- . :''
//           :'        `--._          `--._:'  -- . ''      -- . ''
//   -- . ''     -- . ''    `--._         `--._      -- . ''     -- . ''
//                               `--._          `--._
//  -- . ''           :'              `--._         `--._-- . ''    -- . ''
//           -- . ''       -- . ''         `--._         `--._   -- . ''
// :'                 -- . ''          -- . ''  `--._        -`--._
//                             ");
//                         }
//                         else if(PlayerResponse == "4" || PlayerResponse.ToLower() == "your home")
//                         {
//                             Location[0] = "\nYour Home";
//                             Location[1] = "\nYou are starting in your own home. You are the only one here.";
//                             LocationChosen = true;

//                             System.Console.WriteLine(@"

// ***********************************************************************************
// *                                                                                 *
// *                                    `                                            *
// *                                      `                                          *
// *                                       ` ::     %%                               *
// *                                  _______||_  ,%%&%,                             *
// *                                 /\     _   \%&&%%&%%                            *
// *                                /  \___/^\___\%&%%&&%                            *
// *                                |  | []   [] |%\Y&%'                             *
// *                                |  |   .-.   |  ||                               *
// *                              ~~@._|@@_|||_@@|~ ||~~~~~~~~~~~~~                  *
// *                                  `''') )'''`                                    *
// *                                                                                 *
// *                                                                                 *
// *                                                                                 *
// ***********************************************************************************

//                             ");
//                         }
//                         else if(PlayerResponse == "5" || PlayerResponse.ToLower() == "cancel")
//                         {
//                             LocationChosen = true;
//                         }
//                         else
//                         {
//                             Console.WriteLine("\nThat wasn't one of the options. Are you trying to pull a fast one?");
//                         }
//                     }
//                 }
//                 else if(PlayerResponse == "3" || PlayerResponse.ToLower() == "pick a fight")
//                 {
//                     // Enemies: Goblin, Troll, Dragon, Unhandled
//                     bool InCombat = false;
//                     if(Location[0] == "Your Home")
//                     {
//                         UnhandledException Bry = new UnhandledException("Bry","Your Home");
//                         Console.WriteLine(@"





//           _.----.                          
//        .-'       \-.                       
//       /           ; \                      
//      :           /:  \                     
//      ;         .'  ;  ;                    
//      ;      .-''   :  :
//     :   _.+(   .-- :  :                    
//     ;  ;   *   *   :  :                  
//     ;  :     |     ;  ;                    
//     (  ;           :  :                     
//     )   '  .---.   '  )                     
//     (    '. `'' .'    (
//      '-._.:`---':-'-..)                   
//           ;     ;                         
//    _..__.-. -. (:                          
//  ,'   .:(o);     '-._                      
//  :    _: 0 ;        \`.                    
//  ;  .'/.\-/-.        `:                    
// :  : :  -U--:'-.  \    ;                   
// ;  ; :  ----;   '-. .-'' \                  
// '. '  \ ---(      ; :    ;                 
//   \ '. '-;-'      :-:    :                 
//    `. ''/         ; :    ;                 
//      ''       .-'':  :`. /                  
//        :  --''   :   ;                     
//         ;        ;   : :                   
//         :       :     ; ;                  
//          ;      :   ; : :                  
//          :      ;   :  ; \                 
//           ;    :    ;  :  \_               
//           :    :        \  \'-.            
//           ;    ;         \  `. '-.         
//          :    :     c     \   `./'-._      
//          ;    :            \    \    '-.   
//         :     ;             `.   ;-.  -.`. 
//         :    :       __..--'' \  :  `.\.`.\
//         ;    :_..--'';  ;  _.-'\  ;   '))))\ 
//        :     ;      _L.-'''     \ :    '-='
//        ;    :_..--''            |  ;       
//       /     ;                   |; :       
//     .'     /                    |: |       
//     `.    /                     |        
//       :-./         /\           |
//       ;/          /  \          |          
//       /          /    \         |          
//      /          /     |         |          
//     /          /      |         |          
//    /          /       |         |          
//   |          /        |         |
//                         ");


//                         Console.WriteLine("\nYou see an unhandled exception! Do you REALLY want to fight that? \n1.Yes\n2.No");
//                         PlayerResponse=Console.ReadLine();
//                         if(PlayerResponse == "1" || PlayerResponse.ToLower() == "yes")
//                         {
//                             InCombat = true;
//                         }
//                         else if(PlayerResponse =="2" || PlayerResponse.ToLower() == "no")
//                         {
//                             Console.WriteLine("\nProbably a good choice");
//                         }
//                         // Combat Loop for Unhandled
//                         while(InCombat == true)
//                         {
//                             bool PlayerTurn = true;
//                             while(PlayerTurn == true)
//                             {
//                                 Console.WriteLine($"You are fighting {Bry.Name}, the Unhandled Exception!\nWhat would you like to do?\n1.Do a regular attack! \n2.Do a special attack! \n3.Slap them! \n4.Tickle them! \n5.Run Away");
//                                 PlayerResponse = Console.ReadLine();
//                                 if(PlayerResponse == "1" || PlayerResponse.ToLower() == "do a regular attack!" || PlayerResponse.ToLower() == "attack")
//                                 {
//                                     Player.Attack(Bry);
//                                     PlayerTurn = false;
//                                 }
//                                 else if(PlayerResponse == "2" || PlayerResponse.ToLower() == "do a special attack!" || PlayerResponse.ToLower() == "special attack")
//                                 {
//                                     Player.SpecialMove(Bry);
//                                     PlayerTurn = false;
//                                 }
//                                 else if(PlayerResponse == "3" || PlayerResponse.ToLower() == "slap them!" || PlayerResponse.ToLower() == "slap")
//                                 {
//                                     Player.Slap(Bry);
//                                     PlayerTurn = false;
//                                 }
//                                 else if(PlayerResponse == "4" || PlayerResponse.ToLower() == "tickle them!" || PlayerResponse.ToLower() == "tickle")
//                                 {
//                                     Player.Tickle(Bry);
//                                     PlayerTurn = false;
//                                 }
//                                 else if(PlayerResponse == "5" || PlayerResponse.ToLower() == "run away!" || PlayerResponse.ToLower() == "run")
//                                 {
//                                     if(Bry.Laughing == true)
//                                     {
//                                         Console.WriteLine("\nBry is laughing too hard to keep up with you! You run away!");
//                                         InCombat = false;
//                                         PlayerTurn = false;
//                                     }
//                                     else
//                                     {
//                                         Console.WriteLine("\nBry is too quick! You can't get away!");
//                                         PlayerTurn = false;
//                                     }
//                                 }
//                                 else
//                                 {
//                                     Console.WriteLine("\nThat wasn't an option!");
//                                 }
//                             }
//                             if(Bry.IsAlive == false)
//                             {
//                                 Console.WriteLine("\nYou win!");
//                             }
//                             else if(Bry.Laughing == true)
//                             {
//                                 Console.WriteLine("\nBry is laughing too hard to attack");
//                             }
//                             else
//                             {
//                                 Bry.Annihilate(Player);
//                             }
//                             PlayerTurn = true;
//                         }
//                     }
//                     // End of Home
//                     if(Location[0] == "The Woods")
//                     {
//                         Goblin Webfund = new Goblin("Webfund","The Woods");
//                     //     Console.WriteLine(@"
//                     // // ASCII art for goblin here! ###################################################
                    
//                     //     ");
//                         Console.WriteLine("\nYou see a goblin minding it's own business in the woods. Would you like to attack it? \n1.Yes\n2.No");
//                         PlayerResponse=Console.ReadLine();
//                         if(PlayerResponse == "1" || PlayerResponse.ToLower() == "yes")
//                         {
//                             InCombat = true;
//                         }
//                         else if(PlayerResponse =="2" || PlayerResponse.ToLower() == "no")
//                         {
//                             Console.WriteLine("\nYou leave the goblin be.");
//                         }
//                         // Combat Loop for Unhandled
//                         while(InCombat == true)
//                         {
//                             bool PlayerTurn = true;
//                             while(PlayerTurn == true)
//                             {
//                                 Console.WriteLine($"You are fighting {Webfund.Name}, the Goblin!\nWhat would you like to do?\n1.Do a regular attack! \n2.Do a special attack! \n3.Slap them! \n4.Tickle them! \n5.Run Away");
//                                 PlayerResponse = Console.ReadLine();
//                                 if(PlayerResponse == "1" || PlayerResponse.ToLower() == "do a regular attack!" || PlayerResponse.ToLower() == "attack")
//                                 {
//                                     Player.Attack(Webfund);
//                                     PlayerTurn = false;
//                                 }
//                                 else if(PlayerResponse == "2" || PlayerResponse.ToLower() == "do a special attack!" || PlayerResponse.ToLower() == "special attack")
//                                 {
//                                     Player.SpecialMove(Webfund);
//                                     PlayerTurn = false;
//                                 }
//                                 else if(PlayerResponse == "3" || PlayerResponse.ToLower() == "slap them!" || PlayerResponse.ToLower() == "slap")
//                                 {
//                                     Player.Slap(Webfund);
//                                     PlayerTurn = false;
//                                 }
//                                 else if(PlayerResponse == "4" || PlayerResponse.ToLower() == "tickle them!" || PlayerResponse.ToLower() == "tickle")
//                                 {
//                                     Player.Tickle(Webfund);
//                                     PlayerTurn = false;
//                                 }
//                                 else if(PlayerResponse == "5" || PlayerResponse.ToLower() == "run away!" || PlayerResponse.ToLower() == "run")
//                                 {
//                                     if(Webfund.Laughing == true)
//                                     {
//                                         Console.WriteLine("\nWebfund is laughing too hard to keep up with you! You run away!");
//                                         InCombat = false;
//                                         PlayerTurn = false;
//                                     }
//                                     else
//                                     {
//                                         Console.WriteLine("\nWebfund is too quick! You can't get away!");
//                                         PlayerTurn = false;
//                                     }
//                                 }
//                                 else
//                                 {
//                                     Console.WriteLine("\nThat wasn't an option!");
//                                 }
//                             }
//                             if(Webfund.IsAlive == false)
//                             {
//                                 Console.WriteLine("\nYou win!");
//                             }
//                             else if(Webfund.Laughing == true)
//                             {
//                                 Console.WriteLine("\nWebfund is laughing too hard to attack");
//                             }
//                             else
//                             {
//                                 Webfund.Attack(Player);
//                             }
//                             PlayerTurn = true;
//                         }
//                         // End of Woods
//                     if(Location[0] == "The Supermarket")
//                     {
//                         Dragon George = new Dragon("George","The Supermarket");
//                         Console.WriteLine(@"

//                  ___====-_  _-====___
//            _--^^^#####//      \\#####^^^--_
//         _-^##########// (    ) \\##########^-_
//        -############//  |\^^/|  \\############-\
//      _/############//   (@::@)   \\############\_
//     /#############((     \\//     ))#############\
//    -###############\\    (oo)    //###############-\
//   -#################\\  / VV \  //##################\
//  -###################\\/      \//###################-\
// _#/|##########/\######(   /\   )######/\##########|\#_\
// |/ |#/\#/\#/\/  \#/\##\  |  |  /##/\#/  \/\#/\#/\#| \| \
// `  |/  V  V  `   V  \#\| |  | |/#/  V   '  V  V  \|  '
//    `   `  `      `   / | |  | | \   '      '  '   '
//                     (  | |  | |  )
//                    __\ | |  | | /__
//                   (VVV(VVV)(VVV)VVV)
//                   ");
//                         Console.WriteLine("\nYou see a dragon doing shopping for it's groceries. Would you like to attack it? \n1.Yes\n2.No");
//                         PlayerResponse=Console.ReadLine();
//                         if(PlayerResponse == "1" || PlayerResponse.ToLower() == "yes")
//                         {
//                             InCombat = true;
//                         }
//                         else if(PlayerResponse =="2" || PlayerResponse.ToLower() == "no")
//                         {
//                             Console.WriteLine("\nProbably best not to enrage a shopping dragon.");
//                         }
//                         // Combat Loop for Unhandled
//                         while(InCombat == true)
//                         {
//                             bool PlayerTurn = true;
//                             while(PlayerTurn == true)
//                             {
//                                 Console.WriteLine($"You are fighting {George.Name}, the Goblin!\nWhat would you like to do?\n1.Do a regular attack! \n2.Do a special attack! \n3.Slap them! \n4.Tickle them! \n5.Run Away");
//                                 PlayerResponse = Console.ReadLine();
//                                 if(PlayerResponse == "1" || PlayerResponse.ToLower() == "do a regular attack!" || PlayerResponse.ToLower() == "attack")
//                                 {
//                                     Player.Attack(George);
//                                     PlayerTurn = false;
//                                 }
//                                 else if(PlayerResponse == "2" || PlayerResponse.ToLower() == "do a special attack!" || PlayerResponse.ToLower() == "special attack")
//                                 {
//                                     Player.SpecialMove(George);
//                                     PlayerTurn = false;
//                                 }
//                                 else if(PlayerResponse == "3" || PlayerResponse.ToLower() == "slap them!" || PlayerResponse.ToLower() == "slap")
//                                 {
//                                     Player.Slap(George);
//                                     PlayerTurn = false;
//                                 }
//                                 else if(PlayerResponse == "4" || PlayerResponse.ToLower() == "tickle them!" || PlayerResponse.ToLower() == "tickle")
//                                 {
//                                     Player.Tickle(George);
//                                     PlayerTurn = false;
//                                 }
//                                 else if(PlayerResponse == "5" || PlayerResponse.ToLower() == "run away!" || PlayerResponse.ToLower() == "run")
//                                 {
//                                     if(George.Laughing == true)
//                                     {
//                                         Console.WriteLine("\nGeorge is laughing too hard to keep up with you! You run away!");
//                                         InCombat = false;
//                                         PlayerTurn = false;
//                                     }
//                                     else
//                                     {
//                                         Console.WriteLine("\nGeorge is too quick! You can't get away!");
//                                         PlayerTurn = false;
//                                     }
//                                 }
//                                 else
//                                 {
//                                     Console.WriteLine("\nThat wasn't an option!");
//                                 }
//                             }
//                             if(George.IsAlive == false)
//                             {
//                                 Console.WriteLine("\nYou win!");
//                             }
//                             else if(George.Laughing == true)
//                             {
//                                 Console.WriteLine("\nGeorge is laughing too hard to attack");
//                             }
//                             else
//                             {
//                                 George.FireAttack(Player);
//                             }
//                             PlayerTurn = true;
//                         }
//                     }
//                     // End of Supermarket
//                     if(Location[0] == "The Caves")
//                     {
//                         Troll Cody = new Troll("Cody","The Supermarket");
//                         // Insert ASCII art for troll
//                         Console.WriteLine("\nYou see a troll hanging out in a cave, counting it's coins and posting on web forums. Do you want to attack it? \n1.Yes\n2.No");
//                         PlayerResponse=Console.ReadLine();
//                         if(PlayerResponse == "1" || PlayerResponse.ToLower() == "yes")
//                         {
//                             InCombat = true;
//                         }
//                         else if(PlayerResponse =="2" || PlayerResponse.ToLower() == "no")
//                         {
//                             Console.WriteLine("\nYou leave the troll to his counting.");
//                         }
//                         // Combat Loop for Unhandled
//                         while(InCombat == true)
//                         {
//                             bool PlayerTurn = true;
//                             while(PlayerTurn == true)
//                             {
//                                 Console.WriteLine($"You are fighting {Cody.Name}, the Troll!\nWhat would you like to do?\n1.Do a regular attack! \n2.Do a special attack! \n3.Slap them! \n4.Tickle them! \n5.Run Away");
//                                 PlayerResponse = Console.ReadLine();
//                                 if(PlayerResponse == "1" || PlayerResponse.ToLower() == "do a regular attack!" || PlayerResponse.ToLower() == "attack")
//                                 {
//                                     Player.Attack(Cody);
//                                     PlayerTurn = false;
//                                 }
//                                 else if(PlayerResponse == "2" || PlayerResponse.ToLower() == "do a special attack!" || PlayerResponse.ToLower() == "special attack")
//                                 {
//                                     Player.SpecialMove(Cody);
//                                     PlayerTurn = false;
//                                 }
//                                 else if(PlayerResponse == "3" || PlayerResponse.ToLower() == "slap them!" || PlayerResponse.ToLower() == "slap")
//                                 {
//                                     Player.Slap(Cody);
//                                     PlayerTurn = false;
//                                 }
//                                 else if(PlayerResponse == "4" || PlayerResponse.ToLower() == "tickle them!" || PlayerResponse.ToLower() == "tickle")
//                                 {
//                                     Player.Tickle(Cody);
//                                     PlayerTurn = false;
//                                 }
//                                 else if(PlayerResponse == "5" || PlayerResponse.ToLower() == "run away!" || PlayerResponse.ToLower() == "run")
//                                 {
//                                     if(Cody.Laughing == true)
//                                     {
//                                         Console.WriteLine("\nCody is laughing too hard to keep up with you! You run away!");
//                                         InCombat = false;
//                                         PlayerTurn = false;
//                                     }
//                                     else
//                                     {
//                                         Console.WriteLine("\nCody is too quick! You can't get away!");
//                                         PlayerTurn = false;
//                                     }
//                                 }
//                                 else
//                                 {
//                                     Console.WriteLine("\nThat wasn't an option!");
//                                 }
//                             }
//                             if(Cody.IsAlive == false)
//                             {
//                                 Console.WriteLine("\nYou win!");
//                             }
//                             else if(Cody.Laughing == true)
//                             {
//                                 Console.WriteLine("\nCody is laughing too hard to attack");
//                             }
//                             else
//                             {
//                                 if (Cody.Health < 150)
//                                 {
//                                     Cody.Regenerate();
//                                 }
//                                 else
//                                 {
//                                     Cody.AsSalt(Player);
//                                 }
//                             }
//                             PlayerTurn = true;
//                         }
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine("\nThat wasn't an option!");
//                 }
//                 // End of Caves Loop
//             }
//             // End Game Loop
//         }
//         }
//     }
// }

//         // Console.WriteLine(@"
//                 //  .
// // //         ('
// // //         '|
// // //         |'
// // //        [::]
// // //        [::]   _......_
// // //        [::].-'      _.-`.
// // //        [:.'    .-. '-._.-`.
// // //        [/ /\   |  \        `-..
// // //        / / |   `-.'      .-.   `-.
// // //       /  `-'            (   `.    `.
// // //      |           /\      `-._/      \
// // //      '    .'\   /  `.           _.-'|
// // //     /    /  /   \_.-'        _.':;:/
// // //   .'     \_/             _.-':;_.-'
// // //  /   .-.             _.-' \;.-'
// // // /   (   \       _..-'     |
// // // \    `._/  _..-'    .--.  |
// // //  `-.....-'/  _ _  .'    '.|
// // //           | |_|_| |      | \  (o)
// // //      (o)  | |_|_| |      | | (\'/)
// // //     (\'/)/  ''''' |     o|  \;:;
// // //      :;  |        |      |  |/)
// // //       ;: `-.._    /__..--'\.' ;:
// // //           :;  `--' :;   :;
// // //         @")
// //                   _ _ __            
// //                 (  o  o \            
// //                  |      /        
// //                   \    (          
// //                  /======\ /\      
// //                 ( *  * */ *_\
// //                 |*  * * * /                
// //                 | *  \*_ /
// //                 /*  *  * |
// //                 ==========
// //                  \     /                      "
// //        \\|/       )   /                  "        "  "
// //     ""     "    / |  (       \\||//  \|/    "     "
// //          "      \ |___ )         
// // "
        
// //         ")
// //     }
// // }

// // (@"
// // QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ
// // QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ
// // QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ
// // QQQQQQQQQQQQQQQQQQQWQQQQQWWWBBBHHHHHHHHHBWWWQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ
// // QQQQQQQQQQQQQQQD!`__ssaaaaaaaaaass_ass_s____.  -~""??9VWQQQQQQQQQQQQQQQQQQQ
// // QQQQQQQQQQQQQP'_wmQQQWWBWV?GwwwmmWQmwwwwwgmZUVVHAqwaaaac,"?9$QQQQQQQQQQQQQQ
// // QQQQQQQQQQQW! aQWQQQQW?qw#TTSgwawwggywawwpY?T?TYTYTXmwwgZ$ma/-?4QQQQQQQQQQQ
// // QQQQQQQQQQW' jQQQQWTqwDYauT9mmwwawww?WWWWQQQQQ@TT?TVTT9HQQQQQQw,-4QQQQQQQQQ
// // QQQQQQQQQQ[ jQQQQQyWVw2$wWWQQQWWQWWWW7WQQQQQQQQPWWQQQWQQw7WQQQWWc)WWQQQQQQQ
// // QQQQQQQQQf jQQQQQWWmWmmQWU???????9WWQmWQQQQQQQWjWQQQQQQQWQmQQQQWL 4QQQQQQQQ
// // QQQQQQQP'.yQQQQQQQQQQQP"       <wa,.!4WQQQQQQQWdWP??!"??4WWQQQWQQc ?QWQQQQQ
// // QQQQQP'_a.<aamQQQW!<yF "!` ..  "??$Qa "WQQQWTVP'    "??' =QQmWWV?46/ ?QQQQQ
// // QQQP'sdyWQP?!`.-"?46mQQQQQQT!mQQgaa. <wWQQWQaa _aawmWWQQQQQQQQQWP4a7g -WWQQ
// // QQ[ j@mQP'adQQP4ga, -????" <jQQQQQWQQQQQQQQQWW;)WQWWWW9QQP?"`  -?QzQ7L ]QQQ
// // QW jQkQ@ jWQQD'-?$QQQQQQQQQQQQQQQQQWWQWQQQWQQQc "4QQQQa   .QP4QQQQfWkl jQQQ
// // QE ]QkQk $D?`  waa "?9WWQQQP??T?47`_aamQQQQQQWWQw,-?QWWQQQQQ`"QQQD\Qf(.QWQQ
// // QQ,-Qm4Q/-QmQ6 "WWQma/  "??QQQQQQL 4W"- -?$QQQQWP`s,awT$QQQ@  "QW@?$:.yQQQQ
// // QQm/-4wTQgQWQQ,  ?4WWk 4waac -???$waQQQQQQQQF??'<mWWWWWQW?^  ` ]6QQ' yQQQQQ
// // QQQQw,-?QmWQQQQw  a,    ?QWWQQQw _.  "????9VWaamQWV???"  a j/  ]QQf jQQQQQQ
// // QQQQQQw,"4QQQQQQm,-$Qa     ???4F jQQQQQwc <aaas _aaaaa 4QW ]E  )WQ`=QQQQQQQ
// // QQQQQQWQ/ $QQQQQQQa ?H ]Wwa,     ???9WWWh dQWWW,=QWWU?  ?!     )WQ ]QQQQQQQ
// // QQQQQQQQQc-QWQQQQQW6,  QWQWQQQk <c                             jWQ ]QQQQQQQ
// // QQQQQQQQQQ,"$WQQWQQQQg,."?QQQQ'.mQQQmaa,.,                . .; QWQ.]QQQQQQQ
// // QQQQQQQQQWQa ?$WQQWQQQQQa,."?( mQQQQQQW[:QQQQm[ ammF jy! j( } jQQQ(:QQQQQQQ
// // QQQQQQQQQQWWma "9gw?9gdB?QQwa, -??T$WQQ;:QQQWQ ]WWD _Qf +?! _jQQQWf QQQQQQQ
// // QQQQQQQQQQQQQQQws "Tqau?9maZ?WQmaas,,    --~-- ---  . _ssawmQQQQQQk 3QQQQWQ
// // QQQQQQQQQQQQQQQQWQga,-?9mwad?1wdT9WQQQQQWVVTTYY?YTVWQQQQWWD5mQQPQQQ ]QQQQQQ
// // QQQQQQQWQQQQQQQQQQQWQQwa,-??$QwadV}<wBHHVHWWBHHUWWBVTTTV5awBQQD6QQQ ]QQQQQQ
// // QQQQQQQQQQQQQQQQQQQQQQWWQQga,-"9$WQQmmwwmBUUHTTVWBWQQQQWVT?96aQWQQQ ]QQQQQQ
// // QQQQQQQQQQWQQQQWQQQQQQQQQQQWQQma,-?9$QQWWQQQQQQQWmQmmmmmQWQQQQWQQW(.yQQQQQW
// // QQQQQQQQQQQQQWQQQQQQWQQQQQQQQQQQQQga%,.  -??9$QQQQQQQQQQQWQQWQQV? sWQQQQQQQ
// // QQQQQQQQQWQQQQQQQQQQQQQQWQQQQQQQQQQQWQQQQmywaa,;~^"!???????!^`_saQWWQQQQQQQ
// // QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQWWWWQQQQQmwywwwwwwmQQWQQQQQQQQQQQ
// // QQQQQQQWQQQWQQQQQQWQQQWQQQQQWQQQQQQQQQQQQQQQQWQQQQQWQQQWWWQQQQQQQQQQQQQQQWQ

// // ")
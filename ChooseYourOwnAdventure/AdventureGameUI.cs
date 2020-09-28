using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class AdventureGameUI
    { 
        public void Run()
        {
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Before you stand three doors of mysterious origin. You are compelled to enter. \n\n Choose: Left, Middle, or Right.\n");
                string userInput = Console.ReadLine().ToLower();
                var room1 = ""; var room2 = ""; var room3 = ""; var room4 = ""; var room5 = ""; var room6 = ""; var room7 = ""; var room8 = ""; var room9 = "";
                int wall;
                // room 1 (Room of Three Doors)
                switch (userInput)
                {
                    case "left":
                        Console.Clear();
                        Console.WriteLine("snake pit placeholder");
                        room1 = "Left";
                        break;

                    case "middle":
                        Console.Clear();
                        Console.WriteLine("You enter a room filled with swirling mists that flood around you. They cling to your skin as you walk past, dying you all the colors of the rainbow. As you walk through the room it becomes harder to make out anything through the technicolor haze. \n\n " +
                            "Choose: Explore, Dance, or Vape");
                        room1 = "Middle";

                        break;


                    case "right":
                        Console.Clear();
                        Console.WriteLine("You catch a glimpse of a person walking away from you who looks just like your grandmother, Betty Crocker. She enters a rustic cottage surrounded by parsnips and rutabagas. There is a winnebago parked amongst the rutabagas. You catch a fading scent of oatmeal cookies from her direction. \n\n" +
                            "Choose: Follow, Explore, or Eat");
                        room1 = "Right";
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }
                string userInput2 = Console.ReadLine().ToLower();
                // room 2 (Room of Swirling Mists AND Room of Grandma's House)
                switch (userInput2)
                {
                    case "explore":
                        Console.Clear();
                        if (room1 is "Middle")
                        {
                            Console.WriteLine("explore swirling mists placeholder\n\n");
                        }
                        else if (room1 is "Right")
                        {
                            Console.WriteLine("Explore windebago placeholder\n\n");
                        }
                        break;

                    case "dance":
                        Console.Clear();
                        Console.WriteLine(" dancing to death in swirling mist placeholder\n\n");
                        break;


                    case "vape":
                        Console.Clear();
                        Console.WriteLine("vaping swirling mists to death placeholder\n\n");
                        break;
                    case "follow":
                        Console.Clear();
                        Console.WriteLine("follow grandma placeholder\n\n");
                        break;

                    case "eat":
                        Console.Clear();
                        Console.WriteLine("eat cottage placeholder \n\n");
                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }

                // room 3 (Room of Desert)

                Console.WriteLine("Before you stands a desert with arrows pointing in three directions.The arrow pointing to the right says “Oasis.” The arrow pointing left says, “Death.” The third arrow points directly up into the sky and says nothing.\n\n" +
                    "Choose: Right, Left, or Jump");
                string userInput3 = Console.ReadLine().ToLower();
                switch (userInput3)
                {
                    case "right":
                        Console.Clear();
                        Console.WriteLine("It’s a wall. A wonderful wall. Impenetrable and unscalable. You could try to run full speed into it and break through to the other side. Though tempted, you decided against it as you like your body in an unbroken state.\n\n" +
                            "Choose: Wait, Wait, or Wait");

                        break;

                    case "left":
                        Console.Clear();
                        Console.WriteLine("As you step left your foot lands upon a field of red flowers, spanning farther than you can see. You look in all around you and around surrounded by a lovely meadow of beautiful flowers. A pleasant scent fills the air. The sun shines brightly. The wind rustles your hair. Whoever you voted for won that last election. All is right in the world.\n\n" +
                            "Choose: Run, Nap, or Burn");
                        room3 = "fieldOfFlowers";
                        break;

                    case "jump":
                        Console.Clear();
                        Console.WriteLine("You leap with all your might into the air, the power of your legs suddenly expanding beyond your wildest dreams. As you reach the sky you notice it shrinking and turning dark. You hit your head on something dark and pass out. You awake in a world filled with short green grass and pipes. Your clothes have been replaced with overalls. A swarm of snapping turtles charges at you. \n\n" +
                            "Choose: Run, Jump, or Pet");
                        room3 = "mario";

                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }

                // room 4 (Rooms of Wonderwall, Poppies, Turtles)

                string userInput4 = Console.ReadLine().ToLower();
                switch (userInput4)
                {
                    case "run":
                        Console.Clear();
                        if (room3 is "fieldOfFlowers")
                        {
                            Console.WriteLine("flowers placeholder\n\n");
                        }
                        else if (room3 is "mario")
                        {
                            Console.WriteLine("Mario land placeholder\n\n");
                        }
                        break;

                    case "wait":
                        for (wall = 1; wall < 16; wall++)
                        {
                            if (wall < 10)
                            {
                                Console.WriteLine("you're waiting at the wall placeholder\n\n");
                                Console.Write("Press any key to continue waiting..");
                                Console.ReadKey();
                            }
                            else if (wall >= 10 && wall < 15)
                            {
                                Console.WriteLine("Man, you must really like walls...");
                                Console.Write("Press any key to continue waiting..");
                                Console.ReadKey();
                            }
                            else
                            {
                                continueToRun = false;
                            }
                        }
                        break;

                    case "nap":
                        Console.Clear();
                        Console.WriteLine("nap in flower field forever placeholder\n\n");
                        break;
                    case "burn":
                        Console.Clear();
                        Console.WriteLine("burn the field placeholder\n\n");
                        break;

                    case "jump":
                        Console.Clear();
                        Console.WriteLine("jump on turtle and die placeholder \n\n");
                        break;

                    case "pet":
                        Console.Clear();
                        Console.WriteLine("pet turtle and die placeholder \n\n");
                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }

                // room 5 (Room of Bus Stop)
                Console.WriteLine("You arrive at a bus stop in the middle of nowhere there is a bench. The land around you is bleak and grey. \n\n Choose: Sit on bench, SiT oN BeNcH, or Sit on BENCH.\n");
                string userInput5 = Console.ReadLine().ToLower();
                switch (userInput5)
                {
                    case "sit on bench":
                        Console.Clear();
                        Console.WriteLine("on the catbus placeholder");
                        break;

                    case "sit":
                        Console.Clear();
                        Console.WriteLine("on the catbus placeholder");
                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }
                //room 6 (Room of Cat Bus)
                Console.WriteLine("The cat stops at a railroad floating in a violet sea. A figure draped in a black cloak enters. Their head ducks to avoid scraping the roof of the bus. They take a seat across from you.\n\n" +
                    "Choose: Hello, Silence, Leave");
                string userInput6 = Console.ReadLine().ToLower();
                switch (userInput6)
                {
                    case "hello":
                        Console.Clear();
                        Console.WriteLine("Blackhole to spaceship placeholder");
                        break;

                    case "silence":
                        Console.Clear();
                        Console.WriteLine("YOU WON THE GAME placeholder");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;

                    case "leave":
                        Console.Clear();
                        Console.WriteLine("stuck in ocean bustop placeholder");
                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }

                //room 7 (Room of Space)
                Console.WriteLine("You fall and fall and fall. The darkness breaks away and you are assaulted by the blaring claxons and glaring artificial light. You slam into a cold pristine floor. All around you is white branching halls, screens, and flashing lights. It might be calm if it weren’t for the alarms screaming in your ears.\n\n" +
                    "Choose: Explore, Wait, or Sleep");
                string userInput7 = Console.ReadLine().ToLower();
                switch (userInput7)
                {
                    case "explore":
                        Console.Clear();
                        Console.WriteLine("exploring the spaceship placeholder");
                        room7 = "explore";
                        break;
                    case "wait":
                        Console.Clear();
                        Console.WriteLine("your wait lasts an eternity, because you die placeholder");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;

                    case "sleep":
                        Console.Clear();
                        Console.WriteLine("sleep also lasts an eternity, because you also die placeholder");
                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }

                //room 8 (Room of Space Cafeteria)
                Console.WriteLine("You walk into a room filled with tables and benches, all pristine and empty. Seemingly never used. In the center of this room is a table with a large red button. Around this table are 5 figures each clad in a different colored suit: Red, Blue, Black, Yellow, Pink. They are screaming and pointing at each other. Their faces are hidden behind the visors of their round helmets - expression unknown. They all turn to face you as you arrive!\n\n" +
                    "Choose: Hello, Run, or Vent");
                string userInput8 = Console.ReadLine().ToLower();
                switch (userInput8)
                {
                    case "hello":
                        Console.Clear();
                        Console.WriteLine("voted off the spaceship placeholder");
                        Console.ReadKey();
                        Console.ReadKey();
                        //continueToRun = false;
                        break;
                    case "run":
                        Console.Clear();
                        Console.WriteLine("shot in the head by an alien placeholder");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;

                    case "vent":
                        Console.Clear();
                        Console.WriteLine("to screen 8 placeholder");
                        room8 = "escapedRoom8";
                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }

                //room 9 (Room of Space Cafeteria)
                Console.WriteLine("You crawl through the vents until you find a glowing portal. Seeing your chance, you dive through. You find your head submerged in water, and your body free from the oppressive claustrophobia of the ventilation shafts. You look down, water dripping from your hair, to see a solid gold toilet. While debating whether you can steal a toilet, you notice the entire room is covered in gold as well. The sink is also made of gold. The walls seem to be plastered in a thin gold filament. The floor is covered in a gold-colored tile.  Clearly whoever owns this place is compensating for something. Outside the bathroom is a man sitting in a chair with his back to you. From what you can see,  his flesh seems to be an oddly tinted shade of orange.\n\n" +
                    "Choose: Steal, Murder, or Explore");
                string userInput9 = Console.ReadLine().ToLower();
                switch (userInput9)
                {
                    case "steal":
                        Console.Clear();
                        Console.WriteLine("You pry a golden faucet handle from the sink. Outside the bathroom is a man sitting in a chair with his back to you. From what you can see,  his flesh seems to be an oddly tinted shade of orange.\n\n" +
                            "Inventory: 1 Gold Handle " +
                    "Choose: Murder or Explore");
                        string stealInput = Console.ReadLine().ToLower();
                        switch (stealInput)
                        {
                            case "murder":
                                Console.Clear();
                                Console.WriteLine("murder the orange man placeholder");
                                room9 = "murder";
                                break;

                            case "explore":
                                Console.Clear();
                                Console.WriteLine("lost in gaudy maze placeholder");
                                Console.ReadKey();
                                Console.ReadKey();
                                continueToRun = false;
                                break;
                        }
                        break;

                    case "murder":
                        Console.Clear();
                        Console.WriteLine("murder the orange man placeholder");
                        room9 = "murder";
                        break;

                    case "explore":
                        Console.Clear();
                        Console.WriteLine("lost in gaudy maze placeholder");
                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }

                //Room 10 (Room of Golden Nonsense)
                Console.WriteLine("You see a piece of crumpled loose leaf paper tacked to the door in front of you. Unlike the previous doors, this one does not shimmer with the mysteries of the universe. It flickers like the dying embers of a campfire.\n\n" +
                    "Choose: Inspect or Run");
                string userInput10 = Console.ReadLine().ToLower();
                switch (userInput8)
                {
                    case "inspect":
                        Console.Clear();
                        Console.WriteLine("door under construction placeholder");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;
                    case "run":
                        Console.Clear();
                        Console.WriteLine("shot in the head by secret service placeholder");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;
                }
            }

        }
    }
}
    




















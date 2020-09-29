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
                        Console.WriteLine("You can hear the black figure's breathing from across the isle. The death rattle sound makes you want to clear your own throat. You decide to extend a cheerfull greeting. \"Well, hello good sir! Pleasant weather we're having! Am I right?\" The hooded head turns toward you, as it's neck popps and cracks. You can see a mouth under the hood. Suddenly the mouth opens wide and you are sucked into the dark gaping chasm as if it were a black hole!");
                        break;

                    case "silence":
                        Console.Clear();
                        Console.WriteLine("You decide to mind your own business. That cloaked guy is creapy anyway, and he smells like cheese. You put in your AirPods and resume the Ear Biscuits podcast you'd been listening to before this whole three door situation began in the first place. There's a loud screach and you're jolted awake. \"How in the world was I able to fall asleep on this crazy cat bus thing\" you ask yourself. As you look around you notice there is no longer a cloaked figure to your left. A man sits in it's place wearing work coveralls with a name patch that reads \"Squiggy\". He smells like cheese. Looking out of your window, you realize the now normal looking bus is parked outside of your apartment. You waste no time and hustle off of that bus and into your warm home-sweet-home. CONGRATULATIONS! YOU'VE WON THE GAME!");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;

                    case "leave":
                        Console.Clear();
                        Console.WriteLine("Who ever this guys is, he smells like cheese! There's also a whole lot of creaking, popping, and snapping sounds coming from under that blacker-than-black cloak. You decide to take your chances in the floating railroad station. You enter the station and realize you're the only living around. Looking out of a window at the seemingly endless violet sea, you realize you may be the only living thing for thousands of miles. Maybe millions of miles. Maybe a billion-thousand miles!! You spot a phone on the wall and dial your buddy Dave. Hoping to hear a ring, you're deflated when only sound you hear from the other end is the Frank Sinatra song \"Beyond The Sea\". After waiting 9 days at the station without seeing another living being, you decide to swim for it. You drowned. GAME OVER");
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
                        Console.WriteLine("Where to go? There are SO many halls to choose from. Even halls in the ceiling and floor. You decide to go down the hallway on your immediate left. This hall is illuminated with a pinkish light. It's the only hall not lit by purely white light, so it's a no-brainer, right? RIGHT?");
                        room7 = "explore";
                        break;
                    case "wait":
                        Console.Clear();
                        Console.WriteLine("You decide to wait around for some reason. Just hangin' out guys. Days and nights are indistinguishable. This is weird. You swear it's been weeks but you've never developed hunger pains or a thirst. Years later (you guess it's been years) you're still hanging out. Not hungry, not thirsty, not aging. GAME OVER");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;

                    case "sleep":
                        Console.Clear();
                        Console.WriteLine("This cold hard floor seems like the perfect place to take a nap. The blaring horns are just soothing enough to usher you into sweet sleepy-time. You end up dying from a brain aneurysm, due to the BLARING HORNS! GAME OVER");
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
                        Console.WriteLine("You decide to cheerfully greet the roundtable. \"Hey guys! I'm Andy. My favorite color is muave and love David Hasselhoff.\" Every suited-up being around the table suddenly shoots up their hands and a hatch below you opens up and you're sucked out into the vacuum of space. You've been air-locked! GAME OVER");
                        Console.ReadKey();
                        Console.ReadKey();
                        //continueToRun = false;
                        break;
                    case "run":
                        Console.Clear();
                        Console.WriteLine("You start to consider running for it. Before you even make up your mind, the blue suited being pull out a gun and shoots you in the head. Your mind was read! GAME OVER");
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
                        Console.WriteLine("You pry a golden faucet handle from the sink. Outside the bathroom, a man sits in a chair with his back to you. The top of his head protudes above the back of the chair. His scalp appears orange with hair golden, yet straw-like - almost as if Rumpelstiltskin himself turned straw into gold, but then realized he preferred straw. \n\n" +
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
                        Console.WriteLine("You reach out and flatten the piece of paper. It simply reads \"Door Under Construction\". What does that even mean? You place your hand on the door's facade and your palm is immediately burnt. No only is the room on the other side in flames, but the door's locked and won't budge. You turn away in defeat. GAME OVER");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;
                    case "run":
                        Console.Clear();
                        Console.WriteLine("You make a run for it and immediately slip on the fringe of a golden rug. As you right yourself, you are shot in the back of the head by a Secret Service Agent.");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;
                }
            }

        }
    }
}
    




















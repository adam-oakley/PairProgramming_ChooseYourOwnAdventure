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
        static void RunMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t____ _         ___                  ___  __   ____ _                __");
            Console.WriteLine(" \t\t))  ))_  __   ))_) __  __  _  _    )) ) )L`   ))  ))_  __  __ __   ))\\ __  __  __  __");
            Console.WriteLine("\t\t((  ((`( (('  ((`\\ ((_)((_)((`1(   ((_( ((    ((  ((`( (|  (('(('  ((_/((_)((_)(|  _)) \n\n\n\n\n\n\n\n\n\n\n\n");
            Console.Write("\t\t\t\t\t\tPress Enter to Start:");
            string start = Console.ReadLine();

            bool continueToRun = true;


            while (continueToRun)
            {


                Console.Clear();
                Console.WriteLine("Before you stand three doors of mysterious origin. You are compelled to enter. \n\n Choose: Left, Middle, or Right.\n");
                string userInput = Console.ReadLine().ToLower();
                var room1 = ""; var room1key = ""; var room2 = ""; var room3 = ""; var room3key = ""; var room4 = ""; var room5 = ""; var room6 = ""; var room7 = ""; var room8 = ""; var room9 = "";
                int wall;
                // room 1 (Room of Three Doors)
                switch (userInput)
                {
                    case "left":
                        Console.Clear();
                        Console.WriteLine("You leap recklessly through the magical doorway and fall headfirst into a pit of snakes. Luckily the snakes are terrified of your arrival and flee before you hit the ground. \n\n");

                        Console.WriteLine("Unfortunately, these snakes evolved to live atop sharpened stalagmites. The short remained of your life is one as a swissed cheese.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("You should stay away from casinos. You have terrible luck if you died this quickly.");
                        Console.ReadKey();

                        continue;

                    case "middle":
                        Console.Clear();
                        Console.WriteLine("You enter a room filled with swirling mists that flood around you. They cling to your skin as you walk past, dying you all the colors of the rainbow. As you walk through the room it becomes harder to make out anything through the technicolor haze. \n\n " +
                            "Choose: Explore, Dance, or Vape");
                        room1 = "success";
                        room1key = "Middle";

                        break;


                    case "right":
                        Console.Clear();
                        Console.WriteLine("You catch a glimpse of a person walking away from you who looks just like your grandmother, Betty Crocker. She enters a rustic cottage surrounded by parsnips and rutabagas. There is a winnebago parked amongst the rutabagas. You catch a fading scent of oatmeal cookies from her direction. \n\n" +
                            "Choose: Follow, Explore, or Eat");
                        room1 = "success";
                        room1key = "Right";
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        continue;
                }

                // room 2 (Room of Swirling Mists AND Room of Grandma's House)
                if (room1 is "success")
                {
                    string userInput2 = Console.ReadLine().ToLower();
                    switch (userInput2)
                    {
                        case "explore":
                            Console.Clear();
                            if (room1key is "Middle")
                            {
                                Console.WriteLine("You  enter deeper in the Joseph's Technicolor Dream Mist. The wisps begin climbing higher up your body and sparking in more radiant hues. They seem to gesture and call to you. Inviting you deeper and deeper into their world. They promise shelter and respite tinged with mystery and wonder. You succumb to their lure, never realizing you have lost sight of the door you entered from.\n\n");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("By the time you notice, if you ever notice, it will be too late.\n\n");
                                Console.ReadKey();

                                Console.WriteLine(" \"Not all explorers go down in history. Most die and are simply forgotten.\"\n -Buddha, probably. ");
                                Console.ReadKey();
                                continue;
                            }
                            else if (room1key is "Right")
                            {
                                Console.WriteLine("Your grandmother does not have a Winebago. Suspicious you climb inside and discover rows upon rows of neatly stack human skulls. They are dinged and chipped - as though knawed upon by some wild animal. You feel a sharp pain in your ankle and fall to the floor of the Winebago. You do not get up again.\n\n");
                                Console.ReadKey();

                                Console.Clear();
                                Console.WriteLine("As the last embers of consciousness slip away you remember - your grandmother wasn't twelve feet tall either");
                                Console.ReadKey();
                                continue;
                            }
                            break;

                        case "dance":
                            Console.Clear();
                            Console.WriteLine(" As you watch the mists swirl and spin around you, you feel a chill run up your spine. You are overcome with a desire to become one with the mists. To swirl as they do, to flow and be free as they are. A part of this knows that this is unnatural that you could fight this feeling. \n\n" +
                                "You choose not to. Why would you want to fight against your home. You abandon yourself to the mists - you spring through the air leaving sparks of stardust in your wake. Each spark fueled by the the life you once had and the person you never were. \n\n");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("You are home. You are free. You are unbound. You are mist.");
                            Console.ReadKey();
                            continue;


                        case "vape":
                            Console.Clear();
                            Console.WriteLine("You look at the mist and for some ungodly reason you decide to smoke it. You pull out your vape pen, empty the cartridge and wander through the mists until you find a veridian stream that seems to seep wisps of fog into the air. You fill up your vape and take a hit. \n\n");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("You hear a cold, distant laughter as you asphyxiate to death.");
                            Console.ReadKey();
                            continue;

                        case "follow":
                            Console.Clear();
                            Console.WriteLine("You follow your grandmother into the her cottage as any good grandchild would. It is quaint and lovely, filled with nicknacks, and you politely ignore the fact that it is filled with photos of you that you have never seen before. Some you can prove could not have been taken. Your grandmother offers you a cookie. Recalling the oatmeal in the air you accept. \n\n" +
                                "It’s gingerbread. It’s delicious. For some reason you need to use the restroom urgently. After asking your grandmother to put on a lovely pot of tea, you run to the bathroom (not question why you know where it is). In the bathroom you see that the window is outline with a mystical shimmering light.\n\n" +
                                "You squeeze through the window to prevent your grandmother from turning you into baked goods. You enter a land with bright sun and blazing heat. \n\n");
                            room2 = "success";
                            Console.ReadKey();
                            break;

                        case "eat":
                            Console.Clear();
                            Console.WriteLine("Using your fairy tale knowledge you know what to do! This cottage has to be made of candy and your safest course of action is to eat all of it and pray you don’t get diabetes or have a heart attack halfway through.\n\n" +
                                "You take a huge bite out of the gingerbread corner of the cottage and break all of your teeth. You lie there screaming, hoping the witch inside will put you out of your misery. Eventually you hear sirens and pass out.\n\n");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Who would make a house out of candy? That would melt in like a day. Stop trying to eat houses. And be nicer to your grandmother!");
                            Console.ReadKey();
                            continue;

                        default:
                            Console.WriteLine("Invalid Entry");
                            Console.ReadKey();
                            continue;
                    }
                }

                // room 3 (Room of Desert)
                if (room2 is "success")
                {
                    Console.Clear();
                    Console.WriteLine("Before you stands a desert with arrows pointing in three directions.The arrow pointing to the right says “Oasis.” The arrow pointing left says, “Death.” The third arrow points directly up into the sky and says nothing.\n\n" +
                        "Choose: Right, Left, or Jump");
                    string userInput3 = Console.ReadLine().ToLower();
                    switch (userInput3)
                    {
                        case "right":
                            Console.Clear();
                            Console.WriteLine("It’s a wall. A wonderful wall. Impenetrable and unscalable. You could try to run full speed into it and break through to the other side. Though tempted, you decided against it as you like your body in an unbroken state.\n\n" +
                                "Choose: Wait, Wait, or Wait");
                            room3 = "success";

                            break;

                        case "left":
                            Console.Clear();
                            Console.WriteLine("As you step left your foot lands upon a field of red flowers, spanning farther than you can see. You look all around you and are surrounded by a lovely meadow of beautiful flowers. A pleasant scent fills the air. The sun shines brightly. The wind rustles your hair. Whoever you voted for won that last election. All is right in the world.\n\n" +
                                "Choose: Run, Nap, or Burn");
                            room3 = "success";
                            room3key = "fieldOfFlowers";
                            break;

                        case "jump":
                            Console.Clear();
                            Console.WriteLine("You leap with all your might into the air, the power of your legs suddenly expanding beyond your wildest dreams. As you reach the sky you notice it shrinking and turning dark. You hit your head on something dark and pass out. You awake in a world filled with short green grass and pipes. Your clothes have been replaced with overalls. A swarm of snapping turtles charges at you. \n\n" +
                                "Choose: Run, Jump, or Pet");
                            room3 = "success";
                            room3key = "mario";

                            break;

                        default:
                            Console.WriteLine("Invalid Entry");
                            Console.ReadKey();
                            continue;
                    }
                }

                // room 4 (Rooms of Wonderwall, Poppies, Turtles)
                if (room3 is "success")
                {

                    string userInput4 = Console.ReadLine().ToLower();
                    switch (userInput4)
                    {
                        case "run":
                            Console.Clear();
                            if (room3key is "fieldOfFlowers")
                            {
                                Console.WriteLine("Enjoying the scene you decide to take a break and run through the meadow. You’ve had a rough day after all. You prance and frolic to your heart’s content. Birds join you singing happily. Kittens seem to appear out of nowhere and leap into your arms purring. \n\n" +
                                    "Eventually you grow tired. Your breathing starts to slow. Your throat is sore. Too sore. You try to move but you can’t. There’s a cat sleeping on you. You can’t wake a sleeping cat even if it means you have to die. \n\n" +
                                    "And die you do. \n\n");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("The cat eats your face.");
                                Console.ReadKey();
                                continue;

                            }
                            else if (room3key is "mario")
                            {
                                Console.WriteLine("You’re no plumber. You immediately run away. As they say, discretion is the better part of valor. You find a large green pipe and decide to hide from the turtles inside. You sprint through the circular entrance and immediately are teleported away. \n\n" +
                                    "The turtles continue on their way to revolt against their liege for unjust taxation, theft, and the wanton massacre of turtle-kind at the hands of mushroom powered plumbers.");
                            }
                            break;

                        case "wait":
                            for (wall = 1; wall < 16; wall++)
                            {
                                if (wall < 10)
                                {
                                    Console.WriteLine("You stare at this majestic piece of architecture, inspired by its beauty and the sheer amount of labor and money required to construct such a thing. As you do, you begin to wonder what kind of idiot builds a 50 foot high wall in the middle of nowhere?\n\n");
                                    Console.Write("Press any key to continue waiting..");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else if (wall >= 10 && wall < 15)
                                {
                                    Console.WriteLine("Man, you must really like walls...");
                                    Console.Write("Press any key to continue waiting..");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            break;

                        case "nap":
                            Console.Clear();
                            Console.WriteLine("You decide to take a nap in the flower field and you never wake up. They’re demon flowers. Get it? \n\n");
                            Console.ReadKey();
                            Console.WriteLine("Look they can’t all be elaborately weird or funny. Get over it and make better choices in life. ");
                            Console.ReadKey();
                            continue;
                        case "burn":
                            Console.Clear();
                            Console.WriteLine("You’ve been around the block or time or two. You know suspicious fields of blood red flowers when you see them. Using your magical powers of Amazon Prime Now you conjure gasoline and a lighter. \n\n" +
                                "You hear demonic screeches and yowls as you torch the fields. You sit back in a camp chair you conjured and knock back a couple of beers as you watch the world burn. You feel a satisfactory sense of smug as a glowing neon doorway appears before you once the meadow is reduced to ashes. \n\n" +
                                "You chuck your empty beer at full force through the doorway in case anything is waiting for you on the other side and then calmly walk through.");
                            Console.ReadKey();
                            room4 = "success";
                            break;

                        case "jump":
                            Console.Clear();
                            Console.WriteLine("You scream your name in a fake italian accent at the rampaging reptiles and leap for all your worth. The power in your legs surprises you as you get more air than a Boeing 707. You slam onto the head of a turtle with all the force of a deranged soccer mom at a black friday sale with an adderall addiction.\n\n" +
                                "The turtle collapses into its shell and slides away, knocking over its comrades-in-shells. You get a strike. The turtle hits the gutter then rebounds and comes soaring right back at you - striking you in the gut. \n\n");
                            Console.ReadKey();
                            Console.WriteLine("You topple to the ground and are devoured by the horde of snapping turtles, who have decided to remind you they are omnivorous.");
                            Console.ReadKey();

                            continue;

                        case "pet":
                            Console.Clear();
                            Console.WriteLine("Either you didn’t try to jump on the turtles yet or you just didn’t learn your lesson. They devour you all the same but this time you are more aware of it because your spine has not been dislocated via shell ricochet. \n\n");
                            Console.ReadKey();
                            Console.WriteLine("Either way you have the survival instincts of a dead fish and a similar lifespan");
                            Console.ReadKey();
                            continue;

                        default:
                            Console.WriteLine("Invalid Entry");
                            Console.ReadKey();
                            continue;
                    }
                }

                // room 5 (Room of Bus Stop)
                if (room4 is "success")
                {

                    Console.Clear();
                    Console.WriteLine("You arrive at a bus stop in the middle of nowhere there is a bench. The land around you is bleak and grey. \n\n Choose: Sit on bench, SiT oN BeNcH, or Sit on BENCH.\n");
                    string userInput5 = Console.ReadLine().ToLower();
                    switch (userInput5)
                    {
                        case "sit on bench":
                            Console.Clear();
                            Console.WriteLine("I don’t know what you expected here. You just sit down and wait for the bus to arrive… it’s a bus stop, fam.\n\n" +
                                "Press the same key you’ve been spamming to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("You feel an odd rhythm pounding through the ground and reverberating up the bench.Like a staccato being played by the shifting of the earth.It gets louder and deeper and you begin to shake and hop in the air.\n\n" +
                                "A gigantic orange tabby shaped like a bus stops in front of you and lets out a melodious yowl. A shaggy furred door opens up in its center and reveals stairs and rows of seats. You consider waiting for the next bus, but catbus growls at you while the door closes and opens again.\n\n" +
                                "Taking the hint, you enter and seat yourself in the back.");
                            Console.ReadKey();
                            room5 = "success";
                            break;

                        case "sit":
                            Console.Clear();
                            Console.WriteLine("I don’t know what you expected here. You just sit down and wait for the bus to arrive… it’s a bus stop, fam.\n\n");
                            Console.WriteLine("Press the same key you’ve been spamming to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("You feel an odd rhythm pounding through the ground and reverberating up the bench.Like a staccato being played by the shifting of the earth.It gets louder and deeper and you begin to shake and hop in the air.\n\n" +
                               "A gigantic orange tabby shaped like a bus stops in front of you and lets out a melodious yowl. A shaggy furred door opens up in its center and reveals stairs and rows of seats. You consider waiting for the next bus, but catbus growls at you while the door closes and opens again.\n\n" +
                               "Taking the hint, you enter and seat yourself in the back.");
                            Console.ReadKey();
                            room5 = "success";
                            break;

                        default:
                            Console.WriteLine("Invalid Entry");
                            Console.ReadKey();
                            continue;
                    }
                }
                //room 6 (Room of Cat Bus)
                if (room5 is "success")
                {
                    Console.Clear();
                    Console.WriteLine("The catbus stops at a railroad floating in a violet sea. A figure draped in a black cloak enters. Their head ducks to avoid scraping the roof of the bus. They take a seat across from you.\n\n" +
                        "Choose: Hello, Silence, Leave");
                    string userInput6 = Console.ReadLine().ToLower();
                    switch (userInput6)
                    {
                        case "hello":
                            Console.Clear();
                            Console.WriteLine("You can hear the black figure's breathing from across the aisle. The death rattle sound makes you want to clear your own throat. You decide to extend a cheerful greeting. \"Well, hello good sir! Pleasant weather we're having! Am I right?\" The hooded head turns toward you, as its neck pops and cracks. You can see a mouth under the hood. Suddenly the mouth opens wide and you are sucked into the dark gaping chasm as if it were a black hole!");
                            room6 = "success";
                            Console.ReadKey();
                            break;

                        case "silence":
                            Console.Clear();
                            Console.WriteLine("You decide to mind your own business. That cloaked guy is creepy anyway, and he smells like cheese. You put in your AirPods and resume the Ear Biscuits podcast you'd been listening to before this whole three door situation began in the first place. There's a loud screech and you're jolted awake. \"How in the world was I able to fall asleep on this crazy cat bus thing\" you ask yourself. As you look around you notice there is no longer a cloaked figure to your left. A man sits in its place wearing work coveralls with a name patch that reads \"Squiggy\". He smells like cheese. Looking out of your window, you realize the now normal looking bus is parked outside of your apartment. You waste no time and hustle off of that bus and into your warm home-sweet-home. \n\n");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("\t\t\t\t_ _  ___  _ _    _ _ _  ___  _ _   ____ _ _  ___    ___  __  _  _  ___ _ ");
                            Console.WriteLine("\t\t\t\t`\\`) )) ) ))`)   ))`)`) )) ) )\\`)   ))  )L`) )L     ))_ /_`) )\\/,) )L  ))");
                            Console.WriteLine("\t\t\t\t (( ((_( ((_(   ((,(,' ((_( ((`(   ((  (( ( ((_    ((_((( ( ((`(( ((_ (( ");
                            Console.WriteLine("\t\t\t\t                                                                       o ");
                            Console.ReadKey();
                            continue;

                        case "leave":
                            Console.Clear();
                            Console.WriteLine("Whoever this guy is, he smells like cheese! There's also a whole lot of creaking, popping, and snapping sounds coming from under that blacker-than-black cloak. You decide to take your chances in the floating railroad station. You enter the station and realize you're the only living being around. Looking out of a window at the seemingly endless violet sea, you realize you may be the only living thing for thousands of miles. Maybe millions of miles. Maybe a billion-thousand miles!!\n\n");
                            Console.Clear();

                            Console.WriteLine("You spot a phone on the wall and dial your buddy Dave. Hoping to hear a ring, you deflate when all you hear from the other end is the Frank Sinatra song \"Beyond The Sea\". After waiting 3 days at the station without seeing another living being, you decide to swim for it.\n\n");
                            Console.ReadKey();
                            Console.WriteLine("You drown");
                            continue;

                        default:
                            Console.WriteLine("Invalid Entry");
                            Console.ReadKey();
                            continue;
                    }
                }

                //room 7 (Room of Space)
                if (room6 is "success")
                {
                    Console.Clear();
                    Console.WriteLine("You fall and fall and fall. The darkness breaks away and you are assaulted by the blaring claxons and glaring artificial light. You slam into a cold pristine floor. All around you is white branching halls, screens, and flashing lights. It might be calm if it weren’t for the alarms screaming in your ears.\n\n" +
                        "Choose: Explore, Wait, or Sleep");
                    string userInput7 = Console.ReadLine().ToLower();
                    switch (userInput7)
                    {
                        case "explore":
                            Console.Clear();
                            Console.WriteLine("Where to go? There are SO many halls to choose from. Even halls in the ceiling and floor. You decide to go down the hallway on your immediate left. This hall is illuminated with a pinkish light. It's the only hall not lit by purely white light, so it's a no-brainer, right? RIGHT?\n\n");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("No you're going left. Learn to read.");
                            Console.ReadKey();
                            room7 = "success";
                            break;
                        case "wait":
                            Console.Clear();
                            Console.WriteLine("You decide to wait around for some reason. Just hangin' out guys. Days and nights are indistinguishable. This is weird. You swear it's been weeks but you've never developed hunger pains or a thirst. Years later (you guess it's been years) you're still hanging out. Not hungry, not thirsty, not aging. \n\n");
                            Console.ReadKey();
                            Console.WriteLine("One day, millenia from now. You will realize you have been haunting these halls for quite some time. Your bones already crumbled to dust");
                            Console.ReadKey();
                            continue;

                        case "sleep":
                            Console.Clear();
                            Console.WriteLine("This cold hard floor seems like the perfect place to take a nap. The blaring horns are just soothing enough to usher you into sweet sleepy-time. You end up dying from a brain aneurysm, due to the BLARING HORNS! \n\n");
                            Console.ReadKey();
                            Console.WriteLine("Honestly, I don't know what you were expecting.");
                            Console.ReadKey();
                            continue;

                        default:
                            Console.WriteLine("Invalid Entry");
                            Console.ReadKey();
                            continue;
                    }
                }

                //room 8 (Room of Space Cafeteria)
                if (room7 is "success")
                {

                    Console.Clear();
                    Console.WriteLine("You walk into a room filled with tables and benches, all pristine and empty. Seemingly never used. In the center of this room is a table with a large red button. Around this table are 5 figures each clad in a different colored suit: Red, Blue, Black, Yellow, Pink. They are screaming and pointing at each other. Their faces are hidden behind the visors of their round helmets - expression unknown. They all turn to face you as you arrive!\n\n" +
                        "Choose: Hello, Run, or Vent");
                    string userInput8 = Console.ReadLine().ToLower();
                    switch (userInput8)
                    {
                        case "hello":
                            Console.Clear();
                            Console.WriteLine("You decide to cheerfully greet the roundtable. \"Hey guys! I'm Andy. My favorite color is mauve and I love David Hasselhoff.\" Every suited-up being around the table suddenly shoots up their hands and a hatch below you opens up and you're sucked out into the vacuum of space. \n\n");
                            Console.ReadKey();
                            Console.WriteLine("You've been AIR-LOCKED!");
                            Console.ReadKey();
                            continue;
                        case "run":
                            Console.Clear();
                            Console.WriteLine("You consider running for it. You look left and right, trying to find the best way out. Before you even make up your mind, Blue draws a gun and shoots you in the head. You were being awfully suspicious!\n\n" +
                                "The rest of the colors gang up and throw Blue out the airlock. Then Red and Pink take off their helmets revealing the hideous monsters beneath. Black and Yellow don’t even have time to scream before spikes pierce their skulls and they fall limply to the floor.\n\n");
                            Console.ReadKey();
                            Console.WriteLine("GG");
                            Console.ReadKey();
                            continue;

                        case "vent":
                            Console.Clear();
                            Console.WriteLine("These guys are giving you the creeps and making you nervous. They're all staring at you and not moving a muscle. You spot an air vent on the floor next to you and dive into it. Surprisingly, none of the beings follow you");
                            Console.ReadKey();
                            room8 = "success";
                            break;

                        default:
                            Console.WriteLine("Invalid Entry");
                            Console.ReadKey();
                            continue;
                    }
                }

                //room 9 (Room of Space Cafeteria)
                if (room8 is "success")
                {
                    Console.Clear();
                    Console.WriteLine("You crawl through the vents until you find a glowing portal. Seeing your chance, you dive through. You find your head submerged in water, and your body free from the oppressive claustrophobia of the ventilation shafts. You look down, water dripping from your hair, to see a solid gold toilet. While debating whether you can steal a toilet, you notice the entire room is covered in gold as well. The sink is also made of gold. The walls seem to be plastered in a thin gold filament. The floor is covered in a gold-colored tile.  Clearly whoever owns this place is compensating for something. Outside the bathroom is a man sitting in a chair with his back to you. From what you can see,  his flesh seems to be an oddly tinted shade of orange.\n\n" +
                        "Choose: Steal, Murder, or Explore");
                    string userInput9 = Console.ReadLine().ToLower();
                    switch (userInput9)
                    {
                        case "steal":
                            Console.Clear();
                            Console.WriteLine("You pry a golden faucet handle from the sink. Outside the bathroom is a man sitting in a chair with his back to you. From what you can see,  his flesh seems to be an oddly tinted shade of orange.\n\n" +
                                "Inventory: 1 Gold Handle \n\n" +
                        "Choose: Murder or Explore");
                            string stealInput = Console.ReadLine().ToLower();
                            switch (stealInput)
                            {
                                case "murder":
                                    Console.Clear();
                                    Console.WriteLine("The chair swivels around revealing a man that resembles a pile of mashed potatoes. He begins to speak in a loud raspy voice. Something about his tremendous wealth? Annoyed, you decide to murder may be your only way of escaping with your sanity. You grab a golden candelabra from the adjacent table and bonk him over the head.\n\n" +
                                        "The orange creature turns to look at you bemused. Then it spots the gold in your hand, bewitched. You chuck the candelabra out a window and the creature leaps through grasping at his precious gold. \n\n" +
                                        "You have slain the demon!");
                                    room9 = "murder1";
                                    break;

                                case "explore":
                                    Console.Clear();
                                    Console.WriteLine("You need to get away from the orange creature, but you also don’t want to leave yet. There’s obviously something here that can set you up for life. If the walls are gold, what else is there to find?\n\n" +
                                        "You weave your way through halls of reflective gold as the sun begins to rise. You can tell as the light turns what was once a gaudy monstrosity of a labyrinth into a radiant hellscape. The light reflects off every surface. It is impossible to see. \n\n" +
                                        "It’s getting hotter and hotter. Your flesh is tanning at rates you once thought impossible. You know now how the orange monster got his coloring. It doesn’t take long for you to pass out as your skin begins to burn away. \n\n");
                                    Console.ReadKey();
                                    Console.WriteLine("You have died in a gaudy tanning bed.");
                                    Console.ReadKey();
                                    if (room9 is "murder1")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Inventory: 1 Gold Handle\n\n");
                                        Console.ReadKey();
                                    }
                                    continue;
                            }
                            break;

                        case "murder":
                            Console.Clear();
                            Console.WriteLine("The chair swivels around revealing a man that resembles a pile of mashed potatoes. He begins to speak in a loud raspy voice. Something about his tremendous wealth? Annoyed, you decide to murder may be your only way of escaping with your sanity. You grab a golden candelabra from the adjacent table and bonk him over the head.\n\n" +
                                "The orange creature turns to look at you bemused. Then it spots the gold in your hand, bewitched. You chuck the candelabra out a window and the creature leaps through grasping at his precious gold. \n\n");
                            Console.ReadKey();
                            Console.WriteLine("You have slain the demon!");
                            Console.ReadKey();
                            room9 = "murder";
                            break;

                        case "explore":
                            Console.Clear();

                            Console.WriteLine("You need to get away from the orange creature, but you also don’t want to leave yet. There’s obviously something here that can set you up for life. If the walls are gold, what else is there to find?\n\n" +
                                "You weave your way through halls of reflective gold as the sun begins to rise. You can tell as the light turns what was once a gaudy monstrosity of a labyrinth into a radiant hellscape. The light reflects off every surface. It is impossible to see. \n\n" +
                                "It’s getting hotter and hotter. Your flesh is tanning at rates you once thought impossible. You know now how the orange monster got his coloring. It doesn’t take long for you to pass out as your skin begins to burn away. \n\n");
                            Console.ReadKey();
                            Console.WriteLine("You have died in a tanning bed.");
                            Console.ReadKey();
                            continue;

                        default:
                            Console.WriteLine("Invalid Entry");
                            Console.ReadKey();
                            continue;
                    }
                }

                //Room 10 (Room of Golden Nonsense)
                if (room9 is "murder" || room9 is "murder1")
                {
                    Console.Clear();
                    Console.WriteLine("You see a piece of crumpled loose leaf paper tacked to the door in front of you. Unlike the previous doors, this one does not shimmer with the mysteries of the universe. It flickers like the dying embers of a campfire.\n\n");
                    if (room9 is "murder1") { Console.WriteLine("Inventory: 1 Gold Handle\n\n"); }
                    Console.WriteLine("Choose: Inspect or Run");
                    string userInput10 = Console.ReadLine().ToLower();
                    switch (userInput10)
                    {
                        case "inspect":
                            Console.Clear();
                            Console.WriteLine("You reach out and flatten the piece of paper. It reads \"Door Under Construction\". \n\n");
                            if (room9 is "murder1") { Console.WriteLine("Inventory: 1 Gold Handle\n\n"); }
                            Console.WriteLine("...\n\n");
                            Console.ReadKey();
                            Console.WriteLine("...\n\n");
                            Console.ReadKey();

                            Console.Clear();
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("\t\t\t\t ___  __  _  _  ___    ___  _ _  ___ ___ ");
                            Console.WriteLine("\t\t\t\t ))_ /_`) )\\/,) )L     )) ) ))`) )L  ))_)");
                            Console.WriteLine("\t\t\t\t((_((( ( ((`(( ((_    ((_( ((,' ((_ ((`\\ ");
                            Console.ReadKey();
                            if (room9 is "murder1")
                            {
                                Console.Clear();
                                Console.WriteLine("Inventory: 1 Gold Handle\n\n");
                                Console.ReadKey();
                            }
                            continue;
                        case "run":
                            Console.Clear();
                            Console.WriteLine("You make a run for it and immediately slip on the fringe of a golden rug. As you right yourself, you are shot in the back of the head by a man in black suit with a plastic earpiece.\n\n" +
                                "As you die, you hear him say, \"Target eliminated. Eagle 1 down. Finally.\" \n\n");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("\t\t\t\t ___  __  _  _  ___    ___  _ _  ___ ___ ");
                            Console.WriteLine("\t\t\t\t ))_ /_`) )\\/,) )L     )) ) ))`) )L  ))_)");
                            Console.WriteLine("\t\t\t\t((_((( ( ((`(( ((_    ((_( ((,' ((_ ((`\\ ");
                            Console.ReadKey();
                            if (room9 is "murder1")
                            {
                                Console.Clear();
                                Console.WriteLine("Inventory: 1 Gold Handle\n\n");
                                Console.ReadKey();
                            }
                            continue;

                        default:
                            Console.WriteLine("Invalid Entry");
                            Console.ReadKey();
                            continue;
                    }
                }




            }
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t____ _         ___                  ___  __   ____ _                __");
            Console.WriteLine(" \t\t))  ))_  __   ))_) __  __  _  _    )) ) )L`   ))  ))_  __  __ __   ))\\ __  __  __  __");
            Console.WriteLine("\t\t((  ((`( (('  ((`\\ ((_)((_)((`1(   ((_( ((    ((  ((`( (|  (('(('  ((_/((_)((_)(|  _)) \n\n\n\n\n\n\n\n\n\n\n\n");
        }
    }
}


    




















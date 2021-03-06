using System.Collections.Generic;

namespace FakerDotNet.Data
{
    internal static class StarWarsData
    {
        public static readonly IEnumerable<string> Characters = new[]
        {
            "Padme Amidala",
            "Jar Jar Binks",
            "Borvo the Hutt",
            "Darth Caedus",
            "Boba Fett",
            "Jabba the Hutt",
            "Obi-Wan Kenobi",
            "Darth Maul",
            "Leia Organa",
            "Sheev Palpatine",
            "Kylo Ren",
            "Darth Sidious",
            "Anakin Skywalker",
            "Luke Skywalker",
            "Ben Solo",
            "Han Solo",
            "Darth Vader",
            "Watto",
            "Mace Windu",
            "Yoda",
            "Count Dooku",
            "Sebulba",
            "Qui-Gon Jinn",
            "Chewbacca",
            "Jango Fett",
            "Lando Calrissian",
            "Bail Organa",
            "Wedge Antilles",
            "Poe Dameron",
            "Ki-Adi-Mundi",
            "Nute Gunray",
            "Panaka",
            "Rune Haako",
            "Rey",
            "Finn",
            "Supreme Leader Snoke",
            "General Hux",
            "Admiral Ackbar",
            "Ahsoka Tano",
            "Asajj Ventress",
            "Bendu",
            "Captain Phasma",
            "Chirrut Imwe",
            "Ezra Bridger",
            "Galen Erso",
            "Grand Moff Tarkin",
            "Grand Admiral Thrawn",
            "Greedo",
            "Jyn Erso",
            "Lyra Erso",
            "Maz Kanata",
            "Mon Mothma",
            "Sabine Wren",
            "Saw Gerrera",
            "Savage Opress",
            "Shmi Skywalker",
            "Kanan Jarrus",
            "Hera Syndulla",
            "Rose Tico",
            "Vice Admiral Holdo"
        };

        public static readonly IEnumerable<string> CallSquadrons = new[]
        {
            "Rogue",
            "Red",
            "Gray",
            "Green",
            "Blue",
            "Gold",
            "Black",
            "Yellow",
            "Phoenix"
        };

        public static readonly IEnumerable<string> CallNumbers = new[]
        {
            "Leader",
            "#"
        };

        public static readonly IEnumerable<string> Droids = new[]
        {
            "2-1B",
            "4-LOM",
            "ASP",
            "B2-RP",
            "B1",
            "BD-3000",
            "C1-10P",
            "FA-4",
            "GH-7",
            "GNK",
            "LM-432",
            "ID9",
            "11-4D",
            "2-1B",
            "327-T",
            "4-LOM",
            "B4-D4",
            "NR-N99",
            "C-3PO",
            "R2-D2",
            "BB-8",
            "R2-Q5",
            "Super Battle Droid",
            "Mouse Droid",
            "Droideka",
            "Buzz Droid",
            "Magnaguard",
            "Interrogation Droid",
            "Vulture Droid",
            "BB-9E",
            "K-2SO"
        };

        public static readonly IEnumerable<string> Planets = new[]
        {
            "Alderaan",
            "Ahch-To",
            "Bespin",
            "Cantonica",
            "Coruscant",
            "Cloud City",
            "Crait",
            "DQar",
            "Dathomir",
            "Dagobah",
            "Death Star",
            "Eadu",
            "Endor",
            "Felucia",
            "Geonosis",
            "Hoth",
            "Hosnian Prime",
            "Jakku",
            "Jedha",
            "Kamino",
            "Kashyyyk",
            "Lothal",
            "Mandalore",
            "Mustafar",
            "Mygeeto",
            "Naboo",
            "Onderon",
            "Ryloth",
            "Scarif",
            "Starkiller Base",
            "Sullust",
            "Takodana",
            "Tatooine",
            "Utapau",
            "Yavin 4"
        };

        public static readonly IEnumerable<string> Species = new[]
        {
            "Ewok",
            "Hutt",
            "Gungan",
            "Ithorian",
            "Jawa",
            "Neimoidian",
            "Sullustan",
            "Wookiee",
            "Mon Calamari",
            "Bith",
            "Dathomirian",
            "Gamorreans",
            "Kaminoan",
            "Twi'lek",
            "Porg"
        };

        public static readonly IEnumerable<string> Vehicles = new[]
        {
            "V-Wing Fighter",
            "ATT Battle Tank",
            "Naboo N-1 Starfighter",
            "Republic Cruiser",
            "Naboo Royal Starship",
            "Gungan Bongo Submarine",
            "Flash Speeder",
            "Trade Federation Battleship",
            "Millennium Falcon",
            "Sith Infiltrator",
            "AT-ST Walker",
            "TIE Bomber",
            "Imperial Shuttle",
            "Sandcrawler",
            "TIE Interceptor",
            "Speeder Bike",
            "Death Star",
            "AT-AT Walker",
            "Imperial Star Destroyer",
            "X-Wing Fighter",
            "A-Wing Fighter",
            "GR-75 Transport",
            "Imperial Interdictor",
            "MTT",
            "Phantom II",
            "Republic Attack Gunship",
            "Rey's Speeder",
            "Ghost",
            "U-Wing",
            "Y-Wing Starfighter",
            "First Order TIE Fighter",
            "AT-M6 Walker",
            "First Order Dreadnought",
            "TIE Silencer",
            "Resistance Bomber",
            "Resistance Ski Speeder"
        };

        public static readonly IEnumerable<string> WookieWords = new[]
        {
            "wyaaaaaa",
            "ruh",
            "huewaa",
            "muaa",
            "mumwa",
            "wua",
            "ga",
            "ma",
            "ahuma",
            "ooma",
            "youw",
            "kabukk",
            "wyogg",
            "gwyaaaag",
            "roooarrgh",
            "ur",
            "ru",
            "roo",
            "hnn-rowr",
            "yrroonn",
            "nng",
            "rarr"
        };

        public static readonly IEnumerable<string> SentenceEndings = new[]
        {
            ".",
            "?",
            "!"
        };

        public static readonly IDictionary<string, string[]> QuotesForCharacters = new Dictionary<string, string[]>
        {
            {
                "admiral_ackbar",
                new[]
                {
                    "It's a trap!",
                    "The Shield is down! Commence attack on the Death star's main reactor.",
                    "We have no choice, General Calrissian! Our cruisers can't repel firepower of that magnitude!"
                }
            },
            {
                "ahsoka_tano",
                new[]
                {
                    "Suicide is not the Jedi way, master.",
                    "Let's just say my master will always do what needs to be done. I'm not even sure how peacetime will agree with him.",
                    "Sorry to interrupt your playtime, Grumpy, but wouldn't you prefer a challenge?"
                }
            },
            {
                "anakin_skywalker",
                new[]
                {
                    "I've got a bad feeling about this.",
                    "Just for once, let me look on you with my own eyes.",
                    "Jedi business, go back to your drinks!"
                }
            },
            {
                "asajj_ventress",
                new[]
                {
                    "You're tenacious, Jedi.",
                    "Not even the dark side can give you that power."
                }
            },
            {
                "bendu",
                new[]
                {
                    "Your presence is like a violent storm in this quiet world",
                    "An object can not make you good, or evil. The temptation of power, forbidden knowledge, even the desire to do good can lead some down that path. But only you can change yourself.",
                    "Once something is known, it cannot be unknown."
                }
            },
            {
                "boba_fett",
                new[]
                {
                    "He's no good to me dead.",
                    "You can run, but you'll only die tired."
                }
            },
            {
                "c_3po",
                new[]
                {
                    "I have a bad feeling about this.",
                    "R2-D2, you know better than to trust a strange computer!",
                    "You’ll be malfunctioning within a day, you nearsighted scrap pile.",
                    "I'm terribly sorry about all this. After all, he's only a Wookiee!",
                    "Don’t you call me a mindless philosopher, you overweight glob of grease!",
                    "We're doomed.",
                    "I suggest a new strategy, R2. Let the Wookiee win.",
                    "We seem to be made to suffer. It's our lot in life.",
                    "I'm backwards you filthy furball!",
                    "If I told you half the things I've heard about this Jabba the Hutt, you'd probably short circuit.",
                    "Don’t worry about Master Luke. I’m sure he’ll be all right. He’s quite clever, you know… for a human being.",
                    "I can’t abide these Jawas. Disgusting creatures.",
                    "It's against my programming to impersonate a deity.",
                    "Just you reconsider playing that message for him! No, I don't think he likes you at all. No, I don't like you either.",
                    "Now don't you forget this! Why I should stick my neck out for you is far beyond my capacity!"
                }
            },
            {
                "count_dooku",
                new[]
                {
                    "Twice the pride, double the fall."
                }
            },
            {
                "darth_caedus",
                new[]
                {
                    "You're smarter than a tree, aren't you?"
                }
            },
            {
                "darth_vader",
                new[]
                {
                    "I find your lack of faith disturbing.",
                    "You are a member of the rebel alliance, and a traitor.",
                    "You are unwise to lower your defenses!",
                    "I am altering the deal. Pray I don't alter it any further.",
                    "Perhaps you think you're being treated unfairly?",
                    "The circle is now complete. When I left you, I was but the learner. Now I am the master.",
                    "Obi-Wan was wise to hide her from me. Now, his failure is complete. If you will not turn to the Dark Side… then perhaps she will.",
                    "Search your feelings, you know it to be true!",
                    "Impressive. Most impressive. Obi-Wan has taught you well. You have controlled your fear. Now, release your anger. Only your hatred can destroy me.",
                    "I hope so for your sake, the Emperor is not as forgiving as I am",
                    "Be careful not to choke on your aspirations, Director.",
                    "He is as clumsy as he is stupid.",
                    "You may use any methods necessary, but I want them alive. No disintegrations!",
                    "You have failed me for the last time, Admiral."
                }
            },
            {
                "emperor_palpatine",
                new[]
                {
                    "Only at the end do you realize the power of the Dark Side.",
                    "Oh, I'm afraid the deflector shield will be quite operational when your friends arrive.",
                    "There is a great disturbance in the Force.",
                    "Give in to your anger. With each passing moment you make yourself more my servant.",
                    "Let the hate flow through you!",
                    "Your feeble skills are no match for the power of the Dark Side.",
                    "Your hate has made you powerful. Now fulfill your destiny, take you're father's place by my side.",
                    "So be it, Jedi.",
                    "The Force is strong with him. The son of Skywalker must not become a Jedi."
                }
            },
            {
                "finn",
                new[]
                {
                    "Droid, please!",
                    "Sanitation",
                    "Solo, we'll figure it out. We'll use the Force.",
                    "I'm a big deal in the Resistance. Which puts a real target on my back."
                }
            },
            {
                "general_hux",
                new[]
                {
                    "I won't have you question my methods.",
                    "Careful, Ren, that your personal interests not interfere with orders from Leader Snoke."
                }
            },
            {
                "grand_admiral_thrawn",
                new[]
                {
                    "I will start my operations here, and pull the rebels apart piece by piece. They'll be the architects of their own destruction.",
                    "War is in your blood. I studied the art of war, worked to perfect it, but you? You were forged by it."
                }
            },
            {
                "grand_moff_tarkin",
                new[]
                {
                    "Now, witness the power of this fully operational battle station.",
                    "The Jedi are extinct. Their fire has gone out of the universe. You, my friend, are all that's left of their religion."
                }
            },
            {
                "greedo",
                new[]
                {
                    "Koona t'chuta Solo? (Going somewhere Solo?)",
                    "Soong peetch alay. (It's too late.)",
                    "Ee mara tom tee tok maky cheesa. (You should have paid him when you had the chance.)",
                    "Jabba won neechee kochba mu shanee wy tonny wya uska. (Jabba put a price on your head so large, every bounty hunter in the galaxy will be looking for you.)",
                    "Chosky nowy u chusu. (I'm lucky I found you first.)",
                    "El jaya kulpa intick kuny ku suwa. (If you give it to me, I might forget I found you.)",
                    "Semal hi teek teek. (Jabba's through with you.)",
                    "Sone guru ye buya nyah oo won spasteega koo shu coon bon duwa weeptee. (He has no time for smugglers who drop their shipments at the first sign of an Imperial cruiser.)",
                    "Talk Jabba. (Tell that to Jabba.)",
                    "Boompa kom bok nee aht am bompah. (He may only take your ship.)",
                    "Nuklee numaa (that's the idea.)",
                    "Ches ko ba tuta creesta crenko ya kolska! (This is something I've been looking forward to for a long time.)"
                }
            },
            {
                "han_solo",
                new[]
                {
                    "It's the ship that made the Kessel Run in less than 12 parsecs.",
                    "She may not look like much, but she's got it where it counts, kid.",
                    "Never tell me the odds",
                    "Well, you said you wanted to be around when I made a mistake.",
                    "No reward is worth this.",
                    "Shut him up or shut him down.",
                    "I got a bad feeling about this.",
                    "I have a really bad feeling about this.",
                    "Ungh. And I thought they smelled bad on the outside.",
                    "I have a bad feeling about this.",
                    "Bounty hunters! We don't need this scum.",
                    "If they follow standard Imperial procedure, they'll dump their garbage before they go to light-speed.",
                    "Hokey religions and ancient weapons are no match for a good blaster at your side, kid."
                }
            },
            {
                "jabba_the_hutt",
                new[]
                {
                    "Solo, la pa loiya Solo! (Solo, come out of there! Solo!)",
                    "Bone duwa pweepway? (Have you now?)",
                    "Han, ma bookie, keel-ee calleya ku kah. (Han, my boy, you disappoint me.)",
                    "Wanta dah moolee-rah... (Why haven't you paid me...)",
                    "Mon kee chees kreespa Greedo? (And why did you fry poor Greedo?)",
                    "Han, ma kee chee zay. (Han, I can't make exceptions.)",
                    "Hassa ba una kulkee malia... (What if everyone who smuggled for me...)",
                    "Lude eveela deesa... (drooped their cargo at the sight...)",
                    "sloan dwa spasteega el was nwo yana da gooloo? (of an Imperial starship?)",
                    "Han, ma bookie, baldo nee anna dodo da eena. (You're the best.)",
                    "See fa doi dee yaba... (So for an extra twenty percent...)",
                    "Dee do ee deen. (Okay, fifteen percent.)",
                    "Ee ya ba ma dookie massa... (But if you fail me again...)",
                    "Eek bon chee ko pa na green. (I'll put a price on your head so big...)",
                    "na meeto do buny dunko la cho ya. (you won't be able to get near a civilized system.)",
                    "Boska! (Come on!)"
                }
            },
            {
                "jar_jar_binks",
                new[]
                {
                    "Ooh mooey mooey I love you!",
                    "Yoosa should follow me now, okeeday?",
                    "Yipe! How wude!",
                    "Ohh, maxi big da Force. Well dat smells stinkowiff.",
                    "Oh Gooberfish",
                    "Exsqueeze me",
                    "Mesa cause one, two-y little bitty axadentes, huh? Yud say boom de gasser, den crashin der bosses heyblibber, den banished.",
                    "Mesa called Jar-Jar Binks. Mesa your humble servant.",
                    "My forgotten, da Bosses will do terrible tings to me TERRRRRIBLE is me going back der!",
                    "Mesa day startin pretty okee-day with a brisky morning munchy, then BOOM! Gettin very scared and grabbin that Jedi and POW! Mesa here! Mesa gettin' very very scared!"
                }
            },
            {
                "k_2so",
                new[]
                {
                    "I have a bad feeling about..."
                }
            },
            {
                "kylo_ren",
                new[]
                {
                    "You need a teacher. I can show you the ways of the Force.",
                    "Show me again, grandfather, and I will finish what you started."
                }
            },
            {
                "lando_calrissian",
                new[]
                {
                    "Why you slimy, double-crossing, no-good swindler. You've got a lot of guts coming here, after what you pulled.",
                    "How you doin' Chewbacca? Still hanging around with this loser?",
                    "But how could they be jamming us if they don't know that we're coming?",
                    "This deal is getting worse all the time."
                }
            },
            {
                "leia_organa",
                new[]
                {
                    "You do have your moments. Not many, but you have them.",
                    "I have a bad feeling about this.",
                    "Would somebody get this big walking carpet out of my way?",
                    "Aren't you a little short for a Stormtrooper?",
                    "Help me Obi-Wan. You're my only hope",
                    "Why, you stuck-up, half-witted, scruffy-looking nerf herder!",
                    "Governor Tarkin, I should've expected to find you holding Vader's leash. I recognized your foul stench when I was brought on board.",
                    "Somebody has to save our skins. Into the garbage chute, flyboy!"
                }
            },
            {
                "luke_skywalker",
                new[]
                {
                    "But I was going into Tosche Station to pick up some power converters!",
                    "I have a very bad feeling about this.",
                    "It's not impossible. I used to bullseye womp rats in my T-16 back home, they're not much bigger than two meters.",
                    "You know, that little droid is going to cause me a lot of trouble.",
                    "If you're saying that coming here was a bad idea, I'm starting to agree with you.",
                    "You'll find I'm full of surprises!",
                    "Your overconfidence is your weakness.",
                    "You serve your master well. And you will be rewarded.",
                    "Threepio, tell them if they don't do as you wish, you'll become angry and use your magic",
                    "I am a Jedi, like my father before me."
                }
            },
            {
                "mace_windu",
                new[]
                {
                    "The senate will decide your fate.",
                    "Then our worst fears have been realized. We must move quickly if the Jedi Order is to survive."
                }
            },
            {
                "maz_kanata",
                new[]
                {
                    "I assume you need something. Desperately."
                }
            },
            {
                "obi_wan_kenobi",
                new[]
                {
                    "An elegant weapon for a more civilized age.",
                    "You don’t need to see his identification. These aren’t the droids you’re looking for.",
                    "You will never find a more wretched hive of scum and villainy. We must be cautious.",
                    "Who's the more foolish; the fool, or the fool who follows him?",
                    "I have a bad feeling about this.",
                    "Strike me down, and I will become more powerful than you could possibly imagine.",
                    "In my experience there is no such thing as luck.",
                    "The Force will be with you. Always.",
                    "That's no moon. It's a space station.",
                    "I felt a great disturbance in the Force. As if millions of voices suddenly cried out in terror and were suddenly silenced.",
                    "Use the Force, Luke."
                }
            },
            {
                "padme_amidala",
                new[]
                {
                    "So this is how liberty dies. With thunderous applause.",
                    "Ani? My goodness, you've grown.",
                    "Anakin you're breaking my heart, you're going down a path I can't follow.",
                    "Hold me, like you did by the lake on Naboo; so long ago when there was nothing but our love. No politics, no plotting, no war.",
                    "I was not elected to watch my people suffer and die while you discuss this invasion in a committee!"
                }
            },
            {
                "qui_gon_jinn",
                new[]
                {
                    "Remember your focus determines your reality."
                }
            },
            {
                "rey",
                new[]
                {
                    "You will remove these restraints and leave this cell with the door open.",
                    "The garbage'll do"
                }
            },
            {
                "shmi_skywalker",
                new[]
                {
                    "You can't stop change any more than you can stop the suns from setting.",
                    "The Republic doesn't exist out here. We must survive on our own."
                }
            },
            {
                "yoda",
                new[]
                {
                    "Wars not make one great.",
                    "Truly wonderful, the mind of a child is.",
                    "That is why you fail.",
                    "A Jedi uses the Force for knowledge and defense, never for attack.",
                    "Adventure. Excitement. A Jedi craves not these things.",
                    "Fear is the path to the dark side... fear leads to anger... anger leads to hate... hate leads to suffering.",
                    "Judge me by my size, do you?",
                    "Do. Or do not. There is no try.",
                    "Luminous beings are we... not this crude matter.",
                    "Train yourself to let go of everything you fear to lose.",
                    "Size matters not. Look at me. Judge me by my size, do you?",
                    "Ohhh. Great warrior. Wars not make one great."
                }
            }
        };
    }
}

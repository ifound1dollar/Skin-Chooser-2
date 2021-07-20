using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skin_Chooser_2
{
    class Skin_Chooser_2
    {
        //test5
        #region publics
        public static Random randomObject = new Random(); //random to be used for every champ
        public static Array marksman = new[] { 0, 1, 2 };

        public static int skin; //int that gets assigned random value
        public static int lastResult; //used to prevent repeats
        public static int dsLR; //used to prevent repeats only in dragonslayer function
        public static int oldchampNum; //used to switch champion modes

        public static int champNum = 76; //champion value, initially set to Vayne's
        public static string champion = "VAYNE"; //string that's displayed up top

        public static bool dragonslayer; //used for dragonslayer function
        //public static bool invalid; //used for invalid response message
        #endregion
        public static int total = 155; //gwen
        public static string appVer = "v4.1a"; //version listed in Intro and up top
        static void Main(string[] args)
        {
            /*while (true)
            {
                int adc = randomObject.Next(marksman.Length);
                Console.WriteLine(adc);
                Console.ReadLine();
            }*/
            Intro();
        }
        static void Intro()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("                              ifound1dollar's League of Legends " +
                "Skin Randomizer ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(appVer);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.Write("                                             Press any key to begin...");
            Console.ReadKey();
            Loop();
        }
        static void Loop()
        {
            lastResult = 20; //assigns filler value
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("SKIN RANDOMIZER {0} " +
                "[Type 'h' for help and commands]", appVer);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("  {0} MODE ({1})", champion, champNum);
            while (true)
            {
                oldchampNum = champNum; //for changing modes
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Press enter to run...");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Reply();
                if (dragonslayer == true) { dragonslayer = false; continue; }
                //if (invalid == true) { invalid = false; continue; }
                Console.ForegroundColor = ConsoleColor.Green;
                Choose();
            }
        }
        static void Reply()
        {
            string r = Console.ReadLine().ToLower();
            #region misc
            if (r == "clear"
                || r == "cle"
                || r == "clea") { Loop(); }
            if (r == "c"
                || r == "cl"
                || r == "changelog") { Changelog(); }
            if (r == "h"
                || r == "hel"
                || r == "help") { Help(); }
            if (r == "intro" || r == "reset")
            {
                Console.Clear();
                champion = "VAYNE";
                champNum = 76;
                Intro();
            }
            if (r == "r" || r == "rand" || r == "random")
            {
                champNum = randomObject.Next(1, total + 1); //max always has to be 1 more
                while (champNum == oldchampNum) { champNum = randomObject.Next(1, total + 1); }
                ChampName(champNum);
            }
            #endregion misc
            #region champions
            #region A
            if (r == "aa"
                || r == "aat"
                || r == "aatr"
                || r == "aatro"
                || r == "aatrox") { champNum = 114; }
            if (r == "ah"
                || r == "ahr"
                || r == "ninetails"
                || r == "rule34"
                || r == "ahri") { champNum = 89; }
            if (r == "ak"
                || r == "aka"
                || r == "akal"
                || r == "akali") { champNum = 51; }
            if (r == "al"
                || r == "ali"
                || r == "cow"
                || r == "alis"
                || r == "alist"
                || r == "alistar") { champNum = 1; }
            if (r == "am"
                || r == "mu"
                || r == "amu"
                || r == "amum"
                || r == "mummy"
                || r == "mum"
                || r == "mumy"
                || r == "amumu") { champNum = 24; }
            if (r == "ani"
                || r == "egg"
                || r == "anivegg"
                || r == "eggnivia"
                || r == "aniv"
                || r == "anivia") { champNum = 26; }
            if (r == "ann"
                || r == "anni"
                || r == "teddy"
                || r == "teddybear"
                || r == "teddy bear"
                || r == "tibbers"
                || r == "annie") { champNum = 2; }
            if (r == "aph"
                || r == "aphe"
                || r == "aphel"
                || r == "aphelios") { champNum = 147; }
            if (r == "as"
                || r == "ash"
                || r == "slow"
                || r == "ashe") { champNum = 3; }
            if (r == "au"
                || r == "aur"
                || r == "sol"
                || r == "asol"
                || r == "star"
                || r == "star guy"
                || r == "aurelion sol"
                || r == "aurelionsol") { champNum = 130; }
            if (r == "az"
                || r == "azi"
                || r == "soldier"
                || r == "soldiers"
                || r == "azir") { champNum = 121; }
            #endregion
            #region B
            if (r == "ba"
                || r == "bar"
                || r == "bard") { champNum = 124; }
            if (r == "bl"
                || r == "bli"
                || r == "blit"
                || r == "blitz"
                || r == "robot"
                || r == "blitzcrank") { champNum = 34; }
            if (r == "bran"
                || r == "fire"
                || r == "fire guy"
                || r == "brand") { champNum = 74; }
            if (r == "brau"
                || r == "daddy"
                || r == "braum") { champNum = 119; }
            #endregion
            #region C
            if (r == "cai"
                || r == "cait"
                || r == "caitlyn") { champNum = 67; }
            if (r == "cam"
                || r == "cami"
                || r == "camil"
                || r == "camille") { champNum = 134; }
            if (r == "cas"
                || r == "cass"
                || r == "snake"
                || r == "snake lady"
                || r == "cassiopeia") { champNum = 66; }
            if (r == "cho"
                || r == "munch"
                || r == "chogath"
                || r == "cho gath"
                || r == "cho'gath") { champNum = 25; }
            if (r == "co"
                || r == "cor"
                || r == "cork"
                || r == "corki") { champNum = 37; }
            #endregion
            #region D
            if (r == "da"
                || r == "dar"
                || r == "dari"
                || r == "darius") { champNum = 98; }
            if (r == "di"
                || r == "dia"
                || r == "dian"
                || r == "moon"
                || r == "moon lady"
                || r == "diana") { champNum = 102; }
            if (r == "dra"
                || r == "drav"
                || r == "drave"
                || r == "draven") { champNum = 99; }
            if (r == "dr"
                || r == "dr."
                || r == "mu"
                || r == "mundo"
                || r == "drmundo"
                || r == "dr mundo"
                || r == "dr. mundo"
                || r == "dr.mundo") { champNum = 35; }
            #endregion
            #region E
            if (r == "ek"
                || r == "ekk"
                || r == "ekko") { champNum = 125; }
            if (r == "el"
                || r == "spider"
                || r == "spider lady"
                || r == "elise") { champNum = 106; }
            if (r == "ev"
                || r == "eve"
                || r == "evelyn"
                || r == "demon bitch"
                || r == "evelynn") { champNum = 20; }
            if (r == "ez"
                || r == "twink"
                || r == "ezr"
                || r == "ezreal") { champNum = 47; }
            #endregion
            #region F
            if (r == "fid"
                || r == "fidd"
                || r == "fiddle"
                || r == "spooky"
                || r == "fiddlesticks") { champNum = 4; }
            if (r == "fio"
                || r == "fior"
                || r == "fiora") { champNum = 94; }
            if (r == "fiz"
                || r == "fish"
                || r == "fizz") { champNum = 87; }
            #endregion
            #region G
            if (r == "gal"
                || r == "gali"
                || r == "galio") { champNum = 57; }
            if (r == "gp"
                || r == "gang"
                || r == "plank"
                || r == "gangplank") { champNum = 30; }
            if (r == "gar"
                || r == "demacia"
                || r == "gare"
                || r == "garen") { champNum = 50; }
            if (r == "gn"
                || r == "gna"
                || r == "gnar") { champNum = 120; }
            if (r == "grag"
                || r == "fat"
                || r == "fatty"
                || r == "large"
                || r == "graga"
                || r == "gragas") { champNum = 44; }
            if (r == "grav"
                || r == "grave"
                || r == "graves") { champNum = 85; }
            if (r == "gw"
                || r == "gwe"
                || r == "gwen"
                || r == "scissor"
                || r == "scissors") { champNum = 155; }
            #endregion
            #region H
            if (r == "hec"
                || r == "heca"
                || r == "horse guy"
                || r == "hecarim") { champNum = 96; }
            if (r == "donger"
                || r == "dong"
                || r == "dinger"
                || r == "heim"
                || r == "heime"
                || r == "heimer"
                || r == "heimerdinger") { champNum = 39; }
            #endregion
            #region I
            if (r == "il"
                || r == "ill"
                || r == "illa"
                || r == "illao"
                || r == "illaoi") { champNum = 128; }
            if (r == "ir"
                || r == "ire"
                || r == "irel"
                || r == "irelia") { champNum = 64; }
            if (r == "iv"
                || r == "ive"
                || r == "iver"
                || r == "green"
                || r == "tree dude"
                || r == "ivern") { champNum = 133; }
            #endregion
            #region J
            if (r == "ja"
                || r == "jan"
                || r == "jana"
                || r == "janna") { champNum = 33; }
            if (r == "j4"
                || r == "jar"
                || r == "jarv"
                || r == "jarvan"
                || r == "jarvan4"
                || r == "jarvaniv") { champNum = 71; }
            if (r == "jax"
                || r == "realweapon"
                || r == "real weapon") { champNum = 5; }
            if (r == "jay"
                || r == "jayc"
                || r == "jayce") { champNum = 100; }
            if (r == "jh"
                || r == "jhi"
                || r == "4"
                || r == "four"
                || r == "jhin") { champNum = 129; }
            if (r == "ji"
                || r == "jin"
                || r == "jinx") { champNum = 116; }
            #endregion
            #region K
            if (r == "kai"
                || r == "kaisa"
                || r == "kai sa"
                || r == "kai'sa") { champNum = 140; }
            if (r == "kal"
                || r == "kali"
                || r == "kalis"
                || r == "kalist"
                || r == "kalista") { champNum = 122; }
            if (r == "karm"
                || r == "karma") { champNum = 69; }
            if (r == "kart"
                || r == "karth"
                || r == "karthu"
                || r == "karthus") { champNum = 23; }
            if (r == "kas"
                || r == "kass"
                || r == "16"
                || r == "sixteen"
                || r == "level16"
                || r == "level 16"
                || r == "kassadin") { champNum = 29; }
            if (r == "kat"
                || r == "kata"
                || r == "reset"
                || r == "resets"
                || r == "katarina") { champNum = 36; }
            if (r == "kayl"
                || r == "kayle") { champNum = 6; }
            if (r == "kany"
                || r == "kane"
                || r == "rhaast"
                || r == "rhast"
                || r == "darkin"
                || r == "kayn") { champNum = 137; }
            if (r == "ke"
                || r == "ken"
                || r == "kenn"
                || r == "kenne"
                || r == "kennen") { champNum = 49; }
            if (r == "kha"
                || r == "khazix"
                || r == "k6"
                || r == "bug"
                || r == "kha zix"
                || r == "kha'zix") { champNum = 105; }
            if (r == "ki"
                || r == "kin"
                || r == "kind"
                || r == "kindr"
                || r == "kindre"
                || r == "kindred") { champNum = 127; }
            if (r == "kl"
                || r == "kle"
                || r == "kled") { champNum = 132; }
            if (r == "kog"
                || r == "kogm"
                || r == "kogmaw"
                || r == "kog maw"
                || r == "kog'maw") { champNum = 54; }
            #endregion
            #region L
            if (r == "lb"
                || r == "leb"
                || r == "lebl"
                || r == "leblanc") { champNum = 63; }
            if (r == "lee"
                || r == "sin"
                || r == "leesin"
                || r == "lee sin") { champNum = 73; }
            if (r == "leo"
                || r == "leon"
                || r == "leona") { champNum = 79; }
            if (r == "lil"
                || r == "lili"
                || r == "deer"
                || r == "lilia"
                || r == "lillia") { champNum = 149; }
            if (r == "lis"
                || r == "liss"
                || r == "ice queen"
                || r == "lissandra") { champNum = 113; }
            if (r == "luc"
                || r == "luci"
                || r == "lucia"
                || r == "lucian") { champNum = 115; }
            if (r == "lul"
                || r == "poly"
                || r == "squirrel"
                || r == "polymorph"
                || r == "lulu") { champNum = 95; }
            if (r == "lux"
                || r == "light lady") { champNum = 62; }
            #endregion
            #region M
            if (r == "yi"
                || r == "mas"
                || r == "master"
                || r == "masteryi"
                || r == "master yi") { champNum = 7; }
            if (r == "malp"
                || r == "malph"
                || r == "rock"
                || r == "mountain"
                || r == "malphite") { champNum = 20; }
            if (r == "malz"
                || r == "malza"
                || r == "press r"
                || r == "malzahar") { champNum = 52; }
            if (r == "mao"
                || r == "maok"
                || r == "tree"
                || r == "maokai") { champNum = 70; }
            if (r == "mf"
                || r == "mis"
                || r == "for"
                || r == "fort"
                || r == "fortune"
                || r == "miss"
                || r == "missfortune"
                || r == "miss fortune") { champNum = 59; }
            if (r == "mord"
                || r == "morde"
                || r == "kaiser"
                || r == "death realm"
                || r == "mordekaiser") { champNum = 46; }
            if (r == "morg"
                || r == "morga"
                || r == "morgan"
                || r == "black shield"
                || r == "morgana") { champNum = 8; }
            #endregion
            #region N
            if (r == "nam"
                || r == "nami") { champNum = 108; }
            if (r == "nas"
                || r == "nasu"
                || r == "susan"
                || r == "nasus") { champNum = 38; }
            if (r == "naut"
                || r == "nauti"
                || r == "nautil"
                || r == "nautilu"
                || r == "anchor"
                || r == "nautilus") { champNum = 93; }
            if (r == "ne"
                || r == "nee"
                || r == "neek"
                || r == "lesbian"
                || r == "neeko") { champNum = 142; }
            if (r == "ni"
                || r == "nid"
                || r == "nida"
                || r == "cat lady"
                || r == "nidalee") { champNum = 42; }
            if (r == "no"
                || r == "noc"
                || r == "noct"
                || r == "noctu"
                || r == "nightmare"
                || r == "nocturne") { champNum = 72; }
            if (r == "nu"
                || r == "willump"
                || r == "nunuandwillump"
                || r == "nunu and willump"
                || r == "nunu&willump"
                || r == "nunu & willump"
                || r == "nunu") { champNum = 9; }
            #endregion
            #region O
            if (r == "ol"
                || r == "ola"
                || r == "olaf") { champNum = 53; }
            if (r == "ori"
                || r == "oria"
                || r == "orian"
                || r == "oriana"
                || r == "orianna") { champNum = 77; }
            if (r == "orn"
                || r == "horn"
                || r == "ornn") { champNum = 138; }
            #endregion
            #region P
            if (r == "pa"
                || r == "pan"
                || r == "pant"
                || r == "panth"
                || r == "pantheon") { champNum = 45; }
            if (r == "pop"
                || r == "popp"
                || r == "popy"
                || r == "poppy") { champNum = 43; }
            if (r == "py"
                || r == "pyk"
                || r == "pyke") { champNum = 141; }
            #endregion
            #region Q
            if (r == "qi"
                || r == "qiy"
                || r == "qiya"
                || r == "qiyan"
                || r == "qiyana") { champNum = 145; }
            if (r == "qu"
                || r == "qui"
                || r == "valor"
                || r == "bird lady"
                || r == "quin"
                || r == "quinn") { champNum = 111; }
            #endregion
            #region R
            if (r == "rak"
                || r == "rakan") { champNum = 135; }
            if (r == "ram"
                || r == "ramm"
                || r == "ok"
                || r == "rammus") { champNum = 29; }
            if (r == "rek"
                || r == "reks"
                || r == "reksai"
                || r == "rek sai"
                || r == "rek'sai") { champNum = 123; }
            if (r == "rel"
                || r == "rell") { champNum = 153; }
            if (r == "rene"
                || r == "croc"
                || r == "crocodile"
                || r == "renek"
                || r == "renekton") { champNum = 68; }
            if (r == "reng"
                || r == "renga"
                || r == "knifecat"
                || r == "knife cat"
                || r == "rengar") { champNum = 103; }
            if (r == "riv"
                || r == "rive"
                || r == "riven") { champNum = 83; }
            if (r == "rum"
                || r == "rumb"
                || r == "rumbl"
                || r == "rumble") { champNum = 75; }
            if (r == "ry"
                || r == "ryz"
                || r == "rework"
                || r == "reworks"
                || r == "ryze") { champNum = 10; }
            #endregion
            #region S
            if (r == "sa"
                || r == "sam"
                || r == "sami"
                || r == "samir"
                || r == "samira") { champNum = 151; }
            if (r == "sej"
                || r == "seju"
                || r == "sejuani") { champNum = 91; }
            if (r == "sen"
                || r == "senn"
                || r == "senna") { champNum = 146; }
            if (r == "ser"
                || r == "sera"
                || r == "phine"
                || r == "sona2.0"
                || r == "sona 2"
                || r == "sona 2.0"
                || r == "serap"
                || r == "seraph"
                || r == "seraphi"
                || r == "seraphin"
                || r == "seraphine") { champNum = 152; }
            if (r == "set"
                || r == "hot"
                || r == "sett") { champNum = 148; }
            if (r == "sha"
                || r == "shac"
                || r == "shaco") { champNum = 40; }
            if (r == "she"
                || r == "shen") { champNum = 48; }
            if (r == "shy"
                || r == "shyv"
                || r == "dragon lady"
                || r == "shyvana") { champNum = 86; }
            if (r == "sin"
                || r == "sing"
                || r == "singe"
                || r == "singed") { champNum = 18; }
            if (r == "sio"
                || r == "sion") { champNum = 11; }
            if (r == "siv"
                || r == "sivi"
                || r == "sivir") { champNum = 12; }
            if (r == "sk"
                || r == "ska"
                || r == "skar"
                || r == "skarn"
                || r == "skarner") { champNum = 81; }
            if (r == "son"
                || r == "sona") { champNum = 60; }
            if (r == "sor"
                || r == "sora"
                || r == "raka"
                || r == "soraka") { champNum = 13; }
            if (r == "sw"
                || r == "swa"
                || r == "swai"
                || r == "bird guy"
                || r == "swain") { champNum = 61; }
            if (r == "syl"
                || r == "syla"
                || r == "chains"
                || r == "sylas") { champNum = 143; }
            if (r == "syn"
                || r == "synd"
                || r == "syndr"
                || r == "syndra") { champNum = 104; }
            #endregion
            #region T
            if (r == "tah"
                || r == "tahm"
                || r == "ken"
                || r == "kenc"
                || r == "kench"
                || r == "frog"
                || r == "tahmkench"
                || r == "tahm kench") { champNum = 126; }
            if (r == "tali"
                || r == "taliy"
                || r == "taliya"
                || r == "rock lady"
                || r == "taliyah") { champNum = 131; }
            if (r == "talo"
                || r == "firstblood"
                || r == "first blood"
                || r == "25%"
                || r == "talon") { champNum = 82; }
            if (r == "tar"
                || r == "tari"
                || r == "taric") { champNum = 31; }
            if (r == "tee"
                || r == "teem"
                || r == "aids"
                || r == "teemo") { champNum = 14; }
            if (r == "th"
                || r == "thr"
                || r == "thre"
                || r == "thres"
                || r == "thresh") { champNum = 110; }
            if (r == "tri"
                || r == "tris"
                || r == "trist"
                || r == "trista"
                || r == "tristan"
                || r == "tristana") { champNum = 15; }
            if (r == "tru"
                || r == "trun"
                || r == "trund"
                || r == "trundl"
                || r == "trundle") { champNum = 65; }
            if (r == "try"
                || r == "tryn"
                || r == "trynd"
                || r == "trynda"
                || r == "tryndamere") { champNum = 22; }
            if (r == "tf"
                || r == "fate"
                || r == "twistedfate"
                || r == "twisted fate") { champNum = 16; }
            if (r == "tw"
                || r == "rat"
                || r == "sewer rat"
                || r == "twi"
                || r == "twit"
                || r == "twitc"
                || r == "twitch") { champNum = 21; }
            #endregion
            #region U
            if (r == "ud"
                || r == "udy"
                || r == "udyr") { champNum = 41; }
            if (r == "ur"
                || r == "urg"
                || r == "urgo"
                || r == "urgot") { champNum = 58; }
            #endregion
            #region V
            if (r == "var"
                || r == "varu"
                || r == "varus") { champNum = 97; }
            if (r == "vn"
                || r == "vay"
                || r == "vayn"
                || r == "vayne") { champNum = 76; }
            if (r == "sb"
                || r == "sp"
                || r == "spi"
                || r == "spir"
                || r == "spiri"
                || r == "flor"
                || r == "spirit"
                || r == "blossom"
                || r == "spirit blossom") { champNum = 1076; }
            if (r == "vei"
                || r == "veig"
                || r == "veiga"
                || r == "veigar") { champNum = 28; }
            if (r == "vel"
                || r == "eye"
                || r == "eye of sauron"
                || r == "velk"
                || r == "velko"
                || r == "velkoz"
                || r == "vel koz"
                || r == "vel'koz") { champNum = 118; }
            if (r == "6"
                || r == "six"
                || r == "vi") { champNum = 109; }
            if (r == "vie"
                || r == "vieg"
                || r == "viego"
                || r == "bork") { champNum = 154; }
            if (r == "vik"
                || r == "vikt"
                || r == "vikto"
                || r == "viktor") { champNum = 90; }
            if (r == "blood"
                || r == "vla"
                || r == "vlad"
                || r == "vladi"
                || r == "vladim"
                || r == "vladimi"
                || r == "vladimir") { champNum = 56; }
            if (r == "vo"
                || r == "vb"
                || r == "vol"
                || r == "voli"
                || r == "volib"
                || r == "bear"
                || r == "volibear") { champNum = 88; }
            #endregion
            #region W
            if (r == "ww"
                || r == "war"
                || r == "wick"
                || r == "warwick") { champNum = 17; }
            if (r == "wu"
                || r == "wuk"
                || r == "wuko"
                || r == "wukon"
                || r == "wukong") { champNum = 80; }
            #endregion
            #region X
            if (r == "xa"
                || r == "xay"
                || r == "xaya"
                || r == "xayah") { champNum = 136; }
            if (r == "xe"
                || r == "xer"
                || r == "xerath"
                || r == "xerat") { champNum = 84; }
            if (r == "xi"
                || r == "xin"
                || r == "xinz"
                || r == "zhao"
                || r == "xinzhao"
                || r == "xin zhao") { champNum = 55; }
            #endregion
            #region Y
            if (r == "ya"
                || r == "yas"
                || r == "yasu"
                || r == "yasuo") { champNum = 117; }
            if (r == "yon"
                || r == "better yasuo"
                || r == "yone") { champNum = 150; }
            if (r == "yor"
                || r == "yori"
                || r == "yoric"
                || r == "yorick") { champNum = 78; }
            if (r == "yu"
                || r == "damn cat"
                || r == "yum"
                || r == "yumi"
                || r == "yummi"
                || r == "yuumi") { champNum = 144; }
            #endregion
            #region Z
            if (r == "za"
                || r == "zac") { champNum = 112; }
            if (r == "ze"
                || r == "zed") { champNum = 107; }
            if (r == "zig"
                || r == "bomb"
                || r == "bombs"
                || r == "zigs"
                || r == "zigg"
                || r == "ziggs") { champNum = 92; }
            if (r == "zil"
                || r == "zile"
                || r == "zilea"
                || r == "groovy"
                || r == "zilean") { champNum = 19; }
            if (r == "zo"
                || r == "cancer"
                || r == "aids"
                || r == "zoe") { champNum = 139; }
            if (r == "zy"
                || r == "zyr"
                || r == "plant"
                || r == "plants"
                || r == "plant lady"
                || r == "zyra") { champNum = 101; }
            #endregion
            #endregion
            #region dragonslayer
            if (r == "ds" && champNum == 76
                || r == "ds" && champNum == 1076) { Dragonslayer(); }
            if (r == "dra" && champNum == 76
                || r == "dra" && champNum == 1076) { Dragonslayer(); }
            if (r == "drag" && champNum == 76
                || r == "drag" && champNum == 1076) { Dragonslayer(); }
            if (r == "dragon" && champNum == 76
                || r == "dragon" && champNum == 1076) { Dragonslayer(); }
            if (r == "slayer" && champNum == 76
                || r == "slayer" && champNum == 1076) { Dragonslayer(); }
            if (r == "dragonslayer" && champNum == 76
                || r == "dragonslayer" && champNum == 1076) { Dragonslayer(); }
            #endregion
            if (champNum != oldchampNum) { ChampName(champNum); }
            /*
            else if (r.Length > 0 && dragonslayer == false)
            {
                invalid = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please try again.");
                Console.WriteLine("");
            }
            */
        }
        static void ChampName(int num)
        {
            if (num == 0) { champion = "null"; } //never used, num is never 0
            if (num == 1) { champion = "ALISTAR"; }
            if (num == 2) { champion = "ANNIE"; }
            if (num == 3) { champion = "ASHE"; }
            if (num == 4) { champion = "FIDDLESTICKS"; }
            if (num == 5) { champion = "JAX"; }
            if (num == 6) { champion = "KAYLE"; }
            if (num == 7) { champion = "MASTER YI"; }
            if (num == 8) { champion = "MORGANA"; }
            if (num == 9) { champion = "NUNU & WILLUMP"; }
            if (num == 10) { champion = "RYZE"; }
            if (num == 11) { champion = "SION"; }
            if (num == 12) { champion = "SIVIR"; }
            if (num == 13) { champion = "SORAKA"; }
            if (num == 14) { champion = "TEEMO"; }
            if (num == 15) { champion = "TRISTANA"; }
            if (num == 16) { champion = "TWISTED FATE"; }
            if (num == 17) { champion = "WARWICK"; }
            if (num == 18) { champion = "SINGED"; }
            if (num == 19) { champion = "ZILEAN"; }
            if (num == 20) { champion = "EVELYNN"; }
            if (num == 21) { champion = "TWITCH"; }
            if (num == 22) { champion = "TRYNDAMERE"; }
            if (num == 23) { champion = "KARTHUS"; }
            if (num == 24) { champion = "AMUMU"; }
            if (num == 25) { champion = "CHO'GATH"; }
            if (num == 26) { champion = "ANIVIA"; }
            if (num == 27) { champion = "RAMMUS"; }
            if (num == 28) { champion = "VEIGAR"; }
            if (num == 29) { champion = "KASSADIN"; }
            if (num == 30) { champion = "GANGPLANK"; }
            if (num == 31) { champion = "TARIC"; }
            if (num == 32) { champion = "BLITZCRANK"; }
            if (num == 33) { champion = "DR. MUNDO"; }
            if (num == 34) { champion = "JANNA"; }
            if (num == 35) { champion = "MALPHITE"; }
            if (num == 36) { champion = "CORKI"; }
            if (num == 37) { champion = "KATARINA"; }
            if (num == 38) { champion = "NASUS"; }
            if (num == 39) { champion = "HEIMERDINGER"; }
            if (num == 40) { champion = "SHACO"; }
            if (num == 41) { champion = "UDYR"; }
            if (num == 42) { champion = "NIDALEE"; }
            if (num == 43) { champion = "POPPY"; }
            if (num == 44) { champion = "GRAGAS"; }
            if (num == 45) { champion = "PANTHEON"; }
            if (num == 46) { champion = "MORDEKAISER"; }
            if (num == 47) { champion = "EZREAL"; }
            if (num == 48) { champion = "SHEN"; }
            if (num == 49) { champion = "KENNEN"; }
            if (num == 50) { champion = "GAREN"; }
            if (num == 51) { champion = "AKALI"; }
            if (num == 52) { champion = "MALZAHAR"; }
            if (num == 53) { champion = "OLAF"; }
            if (num == 54) { champion = "KOG'MAW"; }
            if (num == 55) { champion = "XIN ZHAO"; }
            if (num == 56) { champion = "VLADIMIR"; }
            if (num == 57) { champion = "GALIO"; }
            if (num == 58) { champion = "URGOT"; }
            if (num == 59) { champion = "MISS FORTUNE"; }
            if (num == 60) { champion = "SONA"; }
            if (num == 61) { champion = "SWAIN"; }
            if (num == 62) { champion = "LUX"; }
            if (num == 63) { champion = "LEBLANC"; }
            if (num == 64) { champion = "IRELIA"; }
            if (num == 65) { champion = "TRUNDLE"; }
            if (num == 66) { champion = "CASSIOPEIA"; }
            if (num == 67) { champion = "CAITLYN"; }
            if (num == 68) { champion = "RENEKTON"; }
            if (num == 69) { champion = "KARMA"; }
            if (num == 70) { champion = "MAOKAI"; }
            if (num == 71) { champion = "JARVAN IV"; }
            if (num == 72) { champion = "NOCTURNE"; }
            if (num == 73) { champion = "LEE SIN"; }
            if (num == 74) { champion = "BRAND"; }
            if (num == 75) { champion = "RUMBLE"; }
            if (num == 76) { champion = "VAYNE"; }
            if (num == 1076) { champion = "SPIRIT BLOSSOM VAYNE"; }
            if (num == 77) { champion = "ORIANNA"; }
            if (num == 78) { champion = "YORICK"; }
            if (num == 79) { champion = "LEONA"; }
            if (num == 80) { champion = "WUKONG"; }
            if (num == 81) { champion = "SKARNER"; }
            if (num == 82) { champion = "TALON"; }
            if (num == 83) { champion = "RIVEN"; }
            if (num == 84) { champion = "XERATH"; }
            if (num == 85) { champion = "GRAVES"; }
            if (num == 86) { champion = "SHYVANA"; }
            if (num == 87) { champion = "FIZZ"; }
            if (num == 88) { champion = "VOLIBEAR"; }
            if (num == 89) { champion = "AHRI"; }
            if (num == 90) { champion = "VIKTOR"; }
            if (num == 91) { champion = "SEJUANI"; }
            if (num == 92) { champion = "ZIGGS"; }
            if (num == 93) { champion = "NAUTILUS"; }
            if (num == 94) { champion = "FIORA"; }
            if (num == 95) { champion = "LULU"; }
            if (num == 96) { champion = "HECARIM"; }
            if (num == 97) { champion = "VARUS"; }
            if (num == 98) { champion = "DARIUS"; }
            if (num == 99) { champion = "DRAVEN"; }
            if (num == 100) { champion = "JAYCE"; }
            if (num == 101) { champion = "ZYRA"; }
            if (num == 102) { champion = "DIANA"; }
            if (num == 103) { champion = "RENGAR"; }
            if (num == 104) { champion = "SYNDRA"; }
            if (num == 105) { champion = "KHA'ZIX"; }
            if (num == 106) { champion = "ELISE"; }
            if (num == 107) { champion = "ZED"; }
            if (num == 108) { champion = "NAMI"; }
            if (num == 109) { champion = "VI"; }
            if (num == 110) { champion = "THRESH"; }
            if (num == 111) { champion = "QUINN"; }
            if (num == 112) { champion = "ZAC"; }
            if (num == 113) { champion = "LISSANDRA"; }
            if (num == 114) { champion = "AATROX"; }
            if (num == 115) { champion = "LUCIAN"; }
            if (num == 116) { champion = "JINX"; }
            if (num == 117) { champion = "YASUO"; }
            if (num == 118) { champion = "VEL'KOZ"; }
            if (num == 119) { champion = "BRAUM"; }
            if (num == 120) { champion = "GNAR"; }
            if (num == 121) { champion = "AZIR"; }
            if (num == 122) { champion = "KALISTA"; }
            if (num == 123) { champion = "REK'SAI"; }
            if (num == 124) { champion = "BARD"; }
            if (num == 125) { champion = "EKKO"; }
            if (num == 126) { champion = "TAHM KENCH"; }
            if (num == 127) { champion = "KINDRED"; }
            if (num == 128) { champion = "ILLAOI"; }
            if (num == 129) { champion = "JHIN"; }
            if (num == 130) { champion = "AURELION SOL"; }
            if (num == 131) { champion = "TALIYAH"; }
            if (num == 132) { champion = "KLED"; }
            if (num == 133) { champion = "IVERN"; }
            if (num == 134) { champion = "CAMILLE"; }
            if (num == 135) { champion = "RAKAN"; }
            if (num == 136) { champion = "XAYAH"; }
            if (num == 137) { champion = "KAYN"; }
            if (num == 138) { champion = "ORNN"; }
            if (num == 139) { champion = "ZOE"; }
            if (num == 140) { champion = "KAI'SA"; }
            if (num == 141) { champion = "PYKE"; }
            if (num == 142) { champion = "NEEKO"; }
            if (num == 143) { champion = "SYLAS"; }
            if (num == 144) { champion = "YUUMI"; }
            if (num == 145) { champion = "QIYANA"; }
            if (num == 146) { champion = "SENNA"; }
            if (num == 147) { champion = "APHELIOS"; }
            if (num == 148) { champion = "SETT"; }
            if (num == 149) { champion = "LILLIA"; }
            if (num == 150) { champion = "YONE"; }
            if (num == 151) { champion = "SAMIRA"; }
            if (num == 152) { champion = "SERAPHINE"; }
            if (num == 153) { champion = "RELL"; }
            if (num == 154) { champion = "VEIGO"; }
            if (num == 155) { champion = "GWEN"; }
            Loop();
        }
        static void Choose()
        {
            if (champNum == 0) { Intro(); } //never used, champNum is never 0
            if (champNum == 1) { Alistar(); }
            if (champNum == 2) { Annie(); }
            if (champNum == 3) { Ashe(); }
            if (champNum == 4) { Fiddlesticks(); }
            if (champNum == 5) { Jax(); }
            if (champNum == 6) { Kayle(); }
            if (champNum == 7) { MasterYi(); }
            if (champNum == 8) { Morgana(); }
            if (champNum == 9) { Nunu(); }
            if (champNum == 10) { Ryze(); }
            if (champNum == 11) { Sion(); }
            if (champNum == 12) { Sivir(); }
            if (champNum == 13) { Soraka(); }
            if (champNum == 14) { Teemo(); }
            if (champNum == 15) { Tristana(); }
            if (champNum == 16) { TwistedFate(); }
            if (champNum == 17) { Warwick(); }
            if (champNum == 18) { Singed(); }
            if (champNum == 19) { Zilean(); }
            if (champNum == 20) { Evelynn(); }
            if (champNum == 21) { Twitch(); }
            if (champNum == 22) { Tryndamere(); }
            if (champNum == 23) { Karthus(); }
            if (champNum == 24) { Amumu(); }
            if (champNum == 25) { Chogath(); }
            if (champNum == 26) { Anivia(); }
            if (champNum == 27) { Rammus(); }
            if (champNum == 28) { Veigar(); }
            if (champNum == 29) { Kassadin(); }
            if (champNum == 30) { Gangplank(); }
            if (champNum == 31) { Taric(); }
            if (champNum == 32) { Blitzcrank(); }
            if (champNum == 33) { DrMundo(); }
            if (champNum == 34) { Janna(); }
            if (champNum == 35) { Malphite(); }
            if (champNum == 36) { Corki(); }
            if (champNum == 37) { Katarina(); }
            if (champNum == 38) { Nasus(); }
            if (champNum == 39) { Heimerdinger(); }
            if (champNum == 40) { Shaco(); }
            if (champNum == 41) { Udyr(); }
            if (champNum == 42) { Nidalee(); }
            if (champNum == 43) { Poppy(); }
            if (champNum == 44) { Gragas(); }
            if (champNum == 45) { Pantheon(); }
            if (champNum == 46) { Mordekaiser(); }
            if (champNum == 47) { Ezreal(); }
            if (champNum == 48) { Shen(); }
            if (champNum == 49) { Kennen(); }
            if (champNum == 50) { Garen(); }
            if (champNum == 51) { Akali(); }
            if (champNum == 52) { Malzahar(); }
            if (champNum == 53) { Olaf(); }
            if (champNum == 54) { KogMaw(); }
            if (champNum == 55) { XinZhao(); }
            if (champNum == 56) { Vladimir(); }
            if (champNum == 57) { Galio(); }
            if (champNum == 58) { Urgot(); }
            if (champNum == 59) { MissFortune(); }
            if (champNum == 60) { Sona(); }
            if (champNum == 61) { Swain(); }
            if (champNum == 62) { Lux(); }
            if (champNum == 63) { LeBlanc(); }
            if (champNum == 64) { Irelia(); }
            if (champNum == 65) { Trundle(); }
            if (champNum == 66) { Cassiopeia(); }
            if (champNum == 67) { Caitlyn(); }
            if (champNum == 68) { Renekton(); }
            if (champNum == 69) { Karma(); }
            if (champNum == 70) { Maokai(); }
            if (champNum == 71) { JarvanIV(); }
            if (champNum == 72) { Nocturne(); }
            if (champNum == 73) { LeeSin(); }
            if (champNum == 74) { Brand(); }
            if (champNum == 75) { Rumble(); }
            if (champNum == 76) { Vayne(); }
            if (champNum == 1076) { SpiritBlossom(); }
            if (champNum == 77) { Orianna(); }
            if (champNum == 78) { Yorick(); }
            if (champNum == 79) { Leona(); }
            if (champNum == 80) { Wukong(); }
            if (champNum == 81) { Skarner(); }
            if (champNum == 82) { Talon(); }
            if (champNum == 83) { Riven(); }
            if (champNum == 84) { Xerath(); }
            if (champNum == 85) { Graves(); }
            if (champNum == 86) { Shyvana(); }
            if (champNum == 87) { Fizz(); }
            if (champNum == 88) { Volibear(); }
            if (champNum == 89) { Ahri(); }
            if (champNum == 90) { Viktor(); }
            if (champNum == 91) { Sejuani(); }
            if (champNum == 92) { Ziggs(); }
            if (champNum == 93) { Nautilus(); }
            if (champNum == 94) { Fiora(); }
            if (champNum == 95) { Lulu(); }
            if (champNum == 96) { Hecarim(); }
            if (champNum == 97) { Varus(); }
            if (champNum == 98) { Darius(); }
            if (champNum == 99) { Draven(); }
            if (champNum == 100) { Jayce(); }
            if (champNum == 101) { Zyra(); }
            if (champNum == 102) { Diana(); }
            if (champNum == 103) { Rengar(); }
            if (champNum == 104) { Syndra(); }
            if (champNum == 105) { KhaZix(); }
            if (champNum == 106) { Elise(); }
            if (champNum == 107) { Zed(); }
            if (champNum == 108) { Nami(); }
            if (champNum == 109) { Vi(); }
            if (champNum == 110) { Thresh(); }
            if (champNum == 111) { Quinn(); }
            if (champNum == 112) { Zac(); }
            if (champNum == 113) { Lissandra(); }
            if (champNum == 114) { Aatrox(); }
            if (champNum == 115) { Lucian(); }
            if (champNum == 116) { Jinx(); }
            if (champNum == 117) { Yasuo(); }
            if (champNum == 118) { VelKoz(); }
            if (champNum == 119) { Braum(); }
            if (champNum == 120) { Gnar(); }
            if (champNum == 121) { Azir(); }
            if (champNum == 122) { Kalista(); }
            if (champNum == 123) { RekSai(); }
            if (champNum == 124) { Bard(); }
            if (champNum == 125) { Ekko(); }
            if (champNum == 126) { TahmKench(); }
            if (champNum == 127) { Kindred(); }
            if (champNum == 128) { Illaoi(); }
            if (champNum == 129) { Jhin(); }
            if (champNum == 130) { AurelionSol(); }
            if (champNum == 131) { Taliyah(); }
            if (champNum == 132) { Kled(); }
            if (champNum == 133) { Ivern(); }
            if (champNum == 134) { Camille(); }
            if (champNum == 135) { Rakan(); }
            if (champNum == 136) { Xayah(); }
            if (champNum == 137) { Kayn(); }
            if (champNum == 138) { Ornn(); }
            if (champNum == 139) { Zoe(); }
            if (champNum == 140) { KaiSa(); }
            if (champNum == 141) { Pyke(); }
            if (champNum == 142) { Neeko(); }
            if (champNum == 143) { Sylas(); }
            if (champNum == 144) { Yuumi(); }
            if (champNum == 145) { Qiyana(); }
            if (champNum == 146) { Senna(); }
            if (champNum == 147) { Aphelios(); }
            if (champNum == 148) { Sett(); }
            if (champNum == 149) { Lillia(); }
            if (champNum == 150) { Yone(); }
            if (champNum == 151) { Samira(); }
            if (champNum == 152) { Seraphine(); }
            if (champNum == 153) { Rell(); }
            if (champNum == 154) { Viego(); }
            if (champNum == 155) { Gwen(); }
        }
        static void Changelog()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    Changelog:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("v1.0 - v1.4: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Type 1 to see details...");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("v2.0 - v2.7: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Type 2 to see details...");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("v3.0 - v3.7: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Type 3 to see details...");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("v4.0 beta1 (02/17/21): "); Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Completely re-organized code. Loop is now one single " +
                "function, champion functions are only used");
            Console.WriteLine("   for responses. Reply function is now only for input. " +
                "Only 'A' champions are working currently.");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("v4.0 (03/28/21): "); Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("All champions now working.");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("v4.1 (03/29/21): "); Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Added random champion function.");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("v4.1a (07/17/21): "); Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Added Gwen.");

            //end list
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Press any key to return...");
            var input = Console.ReadKey();
            if (input.Key == ConsoleKey.NumPad1
                || input.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("    Version 1 Changelog:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v1.0: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("First version, basic with no end function.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v1.1: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("End function and filler changelog added.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v1.2: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Proper changelog added and function called.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v1.2a: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Cleaned up code.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v1.3: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Early-stage anti-repeat " +
                    "(added message when repeat occurs).");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v1.4: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Completed anti-repeat, includes message when repeat " +
                    "occurs. Automatically rolls new number.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v1.4a: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Moved 'end' to seperate function like changelog," +
                    " removed some unnecessary code. Fixed changelog inconsistency.");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Press any key to return...");
                Console.ReadKey();
                Changelog();
            }
            if (input.Key == ConsoleKey.NumPad2
                || input.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("    Version 2 Changelog:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v2.0: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Added support for multiple champions. Overhauled " +
                "code, each champ has it's own function to easily be called.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v2.1: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Changelog and end now have their own screens. Clear " +
                    "function added, visual clarification improved.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v2.2: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Added Tristana and Malphite, removed repeat message. " +
                    "Updated Jinx strings.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v2.3: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Adjusted code, removed repeated code so more champs can " +
                    "be implemented. Changelog no longer has separate screen.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v2.4: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Added Nunu, Orianna. Moved a little more code to " +
                    "eliminate repeats.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v2.5: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Added Annie, Chogath, Kayle, Lux, Morgana, Singed, " +
                    "Twitch, Veigar, and Wukong.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v2.5a: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Adjusted some formatting so code is consistent.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v2.6: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Added Spirit Blossom Vayne, fixed lastResult value " +
                    "discrepancies.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v2.6a: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Added a Spirit Blossom Vayne only mode.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v2.6b: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Fixed spacing issue in Nunu mode.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v2.7: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Added introduction screen, changed program name in StartInfo.");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Press any key to return...");
                Console.ReadKey();
                Changelog();
            }
            if (input.Key == ConsoleKey.NumPad3
                || input.Key == ConsoleKey.D3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("    Version 3 Changelog:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v3.0 beta1: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Added all champions, with filler strings. Cannot be " +
                    "called yet. De-capitalized Changelog.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v3.0 beta2: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Added 'if' statemets to Reply(); all champions can " +
                    "now be called. New champions still have filler strings.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v3.0: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Filler strings replaced with proper strings, using either " +
                    "\"Default\" twice or once with the one owned skin.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v3.1: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Added Samira.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v3.1a: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Changed Twitch function so that it runs Reply() at the" +
                    " beginning of the while loop instead of the end. Test.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v3.2: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Added public int before main args, not yet equal to " +
                    "champ num. This allows changelog to have its own screen. Also");
                Console.WriteLine("   added dragonslayer command that can only be called " +
                    "within vayne function. This is thanks to the public int.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v3.2a: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Added anti-repeat to dragonslayer function by defining " +
                    "the int before main args. Removed \"private\" from funcs.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v3.3: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Collapsed changelog v1 and v2. Help now has its own " +
                    "screen. Adjusted colors in changelog for clarity.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v3.4: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Added numbers to all champions chronologically. " +
                    "Changelog/help don't use them yet.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v3.4a: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Assigned champion number to Spirit Blossom Vayne " +
                    "and renamed from SB. Can be called in more ways now.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v3.4b: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Changed dragonslayer func to run anti-repeat " +
                    "on any dragonslayer roll in the normal vayne func after use.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v3.5: "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Added Return function for after using help, changelog, or " +
                    "new clear function. Help notes that champion numbers ");
                Console.WriteLine("   can now be used to switch modes. Not implemented yet.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v3.5a (10/14/20): "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Commented out 2 unnecessary lines in Vayne and Twitch " +
                    "anti-repeat functions.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v3.6 (11/04/20): "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Added Seraphine. Finished Return function, now works for " +
                    "all champions. Fixed Nunu anti-repeat.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v3.6a (11/11/20): "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Rolling any Dragonslayer variant in Vayne mode assigns a " +
                    "value to dragonslayerLR to prevent ");
                Console.WriteLine("   repeats when running Dragonslayer function immediately after.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("v3.7 (02/06/21): "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Added Rell and Seraphine.");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Press any key to return...");
                Console.ReadKey();
                Changelog();
            }
            Loop();
        }
        static void Help()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    Command list:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Change mode: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("input Champion name or number");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("(champion numbers are chronological)");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Choose random champion: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\"r\" or \"rand\" or \"random\"");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("View Changelog: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\"c\" or \"cl\" or \"changelog\"");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("This screen: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\"h\" or \"help\"");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Clear screen: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\"clear\"");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Reset program: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\"reset\" or \"intro\"");
            //Console.WriteLine("Close program: \"end\" or \"close\" or \"stop\"");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.Write("Press any key to return...");
            Console.ReadKey();
            Loop();
        }


        #region more than 1 skin
        static void Annie()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Annie-versary"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Prom Queen"); break; }
            }
            Console.WriteLine("");
        }
        static void Chogath()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Jurassic"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Loch Ness"); break; }
            }
            Console.WriteLine("");
        }
        static void Jinx()
        {
            skin = randomObject.Next(7);
            while (skin == lastResult) { skin = randomObject.Next(7); }
            switch (skin)
            {
                case 0:
                    {
                        lastResult = 0; Console.Write("Firecracker ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("White"); break;
                    }
                case 1:
                    {
                        lastResult = 1; Console.Write("Firecracker ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Black"); break;
                    }
                case 2:
                    {
                        lastResult = 2; Console.Write("Firecracker ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Light Blue"); break;
                    }
                case 3:
                    {
                        lastResult = 3; Console.Write("Firecracker ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Pink"); break;
                    }
                case 4:
                    {
                        lastResult = 4; Console.Write("Firecracker ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Orange"); break;
                    }
                case 5:
                    {
                        lastResult = 5; Console.Write("Firecracker ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Purple"); break;
                    }
                case 6:
                    {
                        lastResult = 6; Console.Write("Firecracker ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Green"); break;
                    }
            }
            Console.WriteLine("");
        }
        static void Kayle()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Riot"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Transcendent"); break; }
            }
            Console.WriteLine("");
        }
        static void Lux()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Lunar Empress"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Steel Legion"); break; }
            }
            Console.WriteLine("");
        }
        static void Malphite()
        {
            skin = randomObject.Next(8);
            while (skin == lastResult) { skin = randomObject.Next(8); }
            switch (skin)
            {
                case 0:
                    {
                        lastResult = 0; Console.Write("Mecha ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Yellow"); break;
                    }
                case 1:
                    {
                        lastResult = 1; Console.Write("Mecha ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Green"); break;
                    }
                case 2:
                    {
                        lastResult = 2; Console.Write("Mecha ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Black"); break;
                    }
                case 3:
                    {
                        lastResult = 3; Console.Write("Mecha ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tan"); break;
                    }
                case 4:
                    {
                        lastResult = 4; Console.Write("Mecha ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("White"); break;
                    }
                case 5:
                    {
                        lastResult = 5; Console.Write("Mecha ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Blue"); break;
                    }
                case 6:
                    {
                        lastResult = 6; Console.Write("Mecha ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Gray"); break;
                    }
                case 7:
                    {
                        lastResult = 7; Console.Write("Mecha ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Orange"); break;
                    }
            }
            Console.WriteLine("");
        }
        static void Morgana()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Ghost Bride"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Blade Mistress"); break; }
            }
            Console.WriteLine("");
        }
        static void Nunu()
        {
            skin = randomObject.Next(7);
            while (skin == lastResult) { skin = randomObject.Next(7); }
            switch (skin)
            {
                case 0:
                    {
                        lastResult = 0; Console.Write("Papercraft ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("White"); break;
                    }
                case 1:
                    {
                        lastResult = 1; Console.Write("Papercraft ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Light Blue"); break;
                    }
                case 2:
                    {
                        lastResult = 2; Console.Write("Papercraft ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Black"); break;
                    }
                case 3:
                    {
                        lastResult = 3; Console.Write("Papercraft ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Purple"); break;
                    }
                case 4:
                    {
                        lastResult = 4; Console.Write("Papercraft ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Pink"); break;
                    }
                case 5:
                    {
                        lastResult = 5; Console.Write("Papercraft ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Yellow"); break;
                    }
                case 6: { lastResult = 6; Console.WriteLine("Workshop"); break; }
            }
            Console.WriteLine("");
        }
        static void Orianna()
        {
            skin = randomObject.Next(3);
            while (skin == lastResult) { skin = randomObject.Next(3); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("TPA"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Winter Wonder"); break; }
                case 2: { lastResult = 2; Console.WriteLine("Victorious"); break; }
            }
            Console.WriteLine("");
        }
        static void Singed()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Hextech"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Mad Scientist"); break; }
            }
            Console.WriteLine("");
        }
        static void Tristana()
        {
            skin = randomObject.Next(5);
            while (skin == lastResult) { skin = randomObject.Next(5); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Bewitching"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Riot Girl"); break; }
                case 2:
                    {
                        lastResult = 2; Console.Write("Rocket Girl ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Blue"); break;
                    }
                case 3:
                    {
                        lastResult = 3; Console.Write("Rocket Girl ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Purple"); break;
                    }
                case 4:
                    {
                        lastResult = 4; Console.Write("Rocket Girl ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Red"); break;
                    }
            }
            Console.WriteLine("");
        }
        static void Twitch()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Medieval"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Whistler Village"); break; }
            }
            Console.WriteLine("");
        }
        static void Vayne()
        {
            skin = randomObject.Next(19);
            while (skin == lastResult) { skin = randomObject.Next(19); }
            if (lastResult >= 100)
            {
                while (skin == 2 || skin == 8 || skin == 9 || skin == 10)
                {
                    skin = randomObject.Next(19);
                }
            }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Vindicator"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Aristocrat"); break; }
                case 2:
                    {
                        lastResult = 2; dsLR = 0;
                        Console.WriteLine("Dragonslayer");
                        break;
                    }
                case 3: { lastResult = 3; Console.WriteLine("Heartseeker"); break; }
                case 4: { lastResult = 4; Console.WriteLine("SKT T1"); break; }
                case 5: { lastResult = 5; Console.WriteLine("Arclight"); break; }
                case 6: { lastResult = 6; Console.WriteLine("Soulstealer"); break; }
                case 7:
                    {
                        lastResult = 7;
                        Console.WriteLine("Firecracker Prestige Edition"); break;
                    }
                case 8:
                    {
                        lastResult = 8; dsLR = 1;
                        Console.Write("Dragonslayer ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Green"); break;
                    }
                case 9:
                    {
                        lastResult = 9; dsLR = 2;
                        Console.Write("Dragonslayer ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Red"); break;
                    }
                case 10:
                    {
                        lastResult = 10; dsLR = 3;
                        Console.Write("Dragonslayer ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Silver"); break;
                    }
                case 11: { lastResult = 11; Console.WriteLine("Spirit Blossom "); break; }
                case 12:
                    {
                        lastResult = 12; Console.Write("Spirit Blossom ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Red"); break;
                    }
                case 13:
                    {
                        lastResult = 13; Console.Write("Spirit Blossom ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Yellow"); break;
                    }
                case 14:
                    {
                        lastResult = 14; Console.Write("Spirit Blossom ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Green"); break;
                    }
                case 15:
                    {
                        lastResult = 15; Console.Write("Spirit Blossom ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Purple"); break;
                    }
                case 16:
                    {
                        lastResult = 16; Console.Write("Spirit Blossom ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Pink"); break;
                    }
                case 17:
                    {
                        lastResult = 17; Console.Write("Spirit Blossom ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Black"); break;
                    }
                case 18:
                    {
                        lastResult = 18; Console.Write("Spirit Blossom ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("White"); break;
                    }
            }
            Console.WriteLine("");
        }
        static void Dragonslayer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            skin = randomObject.Next(4);
            while (skin == dsLR) { skin = randomObject.Next(4); }
            switch (skin)
            {
                case 0:
                    {
                        dsLR = 0; lastResult = 100;
                        Console.WriteLine("Dragonslayer"); break;
                    }
                case 1:
                    {
                        dsLR = 1; lastResult = 101;
                        Console.Write("Dragonslayer ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Green"); break;
                    }
                case 2:
                    {
                        dsLR = 2; lastResult = 102;
                        Console.Write("Dragonslayer ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Red"); break;
                    }
                case 3:
                    {
                        dsLR = 3; lastResult = 103;
                        Console.Write("Dragonslayer ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Silver"); break;
                    }
            }
            dragonslayer = true;
            Console.WriteLine("");
        }
        static void SpiritBlossom()
        {
            skin = randomObject.Next(8);
            while (skin == lastResult) { skin = randomObject.Next(8); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Spirit Blossom"); break; }
                case 1:
                    {
                        lastResult = 1; Console.Write("Spirit Blossom ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Red"); break;
                    }
                case 2:
                    {
                        lastResult = 2; Console.Write("Spirit Blossom ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Yellow"); break;
                    }
                case 3:
                    {
                        lastResult = 3; Console.Write("Spirit Blossom ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Green"); break;
                    }
                case 4:
                    {
                        lastResult = 4; Console.Write("Spirit Blossom ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Purple"); break;
                    }
                case 5:
                    {
                        lastResult = 5; Console.Write("Spirit Blossom ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Pink"); break;
                    }
                case 6:
                    {
                        lastResult = 6; Console.Write("Spirit Blossom ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Black"); break;
                    }
                case 7:
                    {
                        lastResult = 7; Console.Write("Spirit Blossom ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("White"); break;
                    }
            }
            Console.WriteLine("");
        }
        static void Veigar()
        {
            skin = randomObject.Next(4);
            while (skin == lastResult) { skin = randomObject.Next(4); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("White Mage"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Curling"); break; }
                case 2: { lastResult = 2; Console.WriteLine("Superb Villain"); break; }
                case 3: { lastResult = 3; Console.WriteLine("Final Boss"); break; }
            }
            Console.WriteLine("");
        }
        static void Wukong()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Lancer Stratus"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Underworld"); break; }
            }
            Console.WriteLine("");
        }
        #endregion more than 1 skin

        #region 1 or fewer skins
        #region A
        static void Aatrox()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Victorious"); break; }
            }
            Console.WriteLine("");
        }
        static void Ahri()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Akali()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Blood Moon"); break; }
            }
            Console.WriteLine("");
        }
        static void Alistar()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Amumu()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Emumu"); break; }
            }
            Console.WriteLine("");
        }
        static void Anivia()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Blackfrost"); break; }
            }
            Console.WriteLine("");
        }
        //Annie
        static void Aphelios()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Ashe()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Sherwood Forest"); break; }
            }
            Console.WriteLine("");
        }
        static void AurelionSol()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Mecha"); break; }
            }
            Console.WriteLine("");
        }
        static void Azir()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region B
        static void Bard()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Blitzcrank()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Boom Boom"); break; }
            }
            Console.WriteLine("");
        }
        static void Brand()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Vandal"); break; }
            }
            Console.WriteLine("");
        }
        static void Braum()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Santa"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region C
        static void Caitlyn()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Safari"); break; }
            }
            Console.WriteLine("");
        }
        static void Camille()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Cassiopeia()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        //Cho'Gath
        static void Corki()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Urfrider"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region D
        static void Darius()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Diana()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Draven()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void DrMundo()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region E
        static void Ekko()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Elise()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Evelynn()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Safecracker"); break; }
            }
            Console.WriteLine("");
        }
        static void Ezreal()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Pulsefire"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region F
        static void Fiddlesticks()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Fiddle Me Timbers"); break; }
            }
            Console.WriteLine("");
        }
        static void Fiora()
        {
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Fizz()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Atlantean"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region G
        static void Galio()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Gangplank()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Garen()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Gnar()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Gragas()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Graves()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Victorious"); break; }
            }
            Console.WriteLine("");
        }
        static void Gwen()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region H
        static void Hecarim()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Heimerdinger()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }

        #endregion
        #region I
        static void Illaoi()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Irelia()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Ivern()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region J
        static void Janna()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void JarvanIV()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Jax()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Warden"); break; }
            }
            Console.WriteLine("");
        }
        static void Jayce()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Forsaken"); break; }
            }
            Console.WriteLine("");
        }
        static void Jhin()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        //Jinx
        #endregion
        #region K
        static void KaiSa()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Kalista()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Blood Moon"); break; }
            }
            Console.WriteLine("");
        }
        static void Karma()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Karthus()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Fnatic"); break; }
            }
        }
        static void Kassadin()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Katarina()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Kitty Kat"); break; }
            }
            Console.WriteLine("");
        }
        //Kayle
        static void Kayn()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Kennen()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void KhaZix()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Kindred()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Kled()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void KogMaw()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Reindeer"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region L
        static void LeBlanc()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void LeeSin()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Leona()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Lillia()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Lissandra()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Lucian()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Hired Gun"); break; }
            }
            Console.WriteLine("");
        }
        static void Lulu()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Pool Party"); break; }
            }
            Console.WriteLine("");
        }
        //Lux
        #endregion
        #region M
        static void MasterYi()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        //Malphite
        static void Malzahar()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Overlord"); break; }
            }
            Console.WriteLine("");
        }
        static void Maokai()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Victorious"); break; }
            }
            Console.WriteLine("");
        }
        static void MissFortune()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Pool Party"); break; }
            }
            Console.WriteLine("");
        }
        static void Mordekaiser()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        //Morgana
        #endregion
        #region N
        static void Nami()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Nasus()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Nautilus()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Neeko()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Nidalee()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Nocturne()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Void"); break; }
            }
            Console.WriteLine("");
        }
        //Nunu
        #endregion
        #region O
        static void Olaf()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        //Orianna
        static void Ornn()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region P
        static void Pantheon()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Poppy()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Pyke()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region Q
        static void Qiyana()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Quinn()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Phoenix"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region R
        static void Rakan()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Rammus()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
    }
        static void RekSai()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Rell()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Renekton()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("SKT T1"); break; }
            }
            Console.WriteLine("");
        }
        static void Rengar()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Riven()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Arcade"); break; }
            }
            Console.WriteLine("");
        }
        static void Rumble()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Ryze()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Dark Crystal"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region S
        static void Samira()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Sejuani()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Firecracker"); break; }
            }
            Console.WriteLine("");
        }
        static void Senna()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Seraphine()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Sett()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Shaco()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Shen()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Shyvana()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        //Singed
        static void Sion()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Sivir()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Snowstorm"); break; }
            }
            Console.WriteLine("");
        }
        static void Skarner()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Sona()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Soraka()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Swain()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Sylas()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Lunar Wrath"); break; }
            }
            Console.WriteLine("");
        }
        static void Syndra()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Snow Day"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region T
        static void TahmKench()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Taliyah()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Talon()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Taric()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Teemo()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Panda"); break; }
            }
            Console.WriteLine("");
        }
        static void Thresh()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("SSW"); break; }
            }
            Console.WriteLine("");
        }
        //Trisana
        static void Trundle()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Tryndamere()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void TwistedFate()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        //Twitch
        #endregion
        #region U
        static void Udyr()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Urgot()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region V
        static void Varus()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Arclight"); break; }
            }
            Console.WriteLine("");
        }
        //Vayne
        //Veigar
        static void VelKoz()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Vi()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Viego()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Viktor()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Vladimir()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Blood Lord"); break; }
            }
            Console.WriteLine("");
        }
        static void Volibear()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Thousand-Pierced"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region W
        static void Warwick()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Gray"); break; }
            }
            Console.WriteLine("");
        }
        //Wukong
        #endregion
        #region X
        static void Xayah()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Star Guardian"); break; }
            }
            Console.WriteLine("");
        }
        static void Xerath()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void XinZhao()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region Y
        static void Yasuo()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Battle Boss"); break; }
            }
            Console.WriteLine("");
        }
        static void Yone()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Yorick()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Yuumi()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #region Z
        static void Zac()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Zed()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Ziggs()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Master Arcanist"); break; }
            }
            Console.WriteLine("");
        }
        static void Zilean()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Zoe()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        static void Zyra()
        {
            skin = randomObject.Next(2);
            while (skin == lastResult) { skin = randomObject.Next(2); }
            switch (skin)
            {
                case 0: { lastResult = 0; Console.WriteLine("Default"); break; }
                case 1: { lastResult = 1; Console.WriteLine("Default"); break; }
            }
            Console.WriteLine("");
        }
        #endregion
        #endregion 1 or fewer skins


    }
}

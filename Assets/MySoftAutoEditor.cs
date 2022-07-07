using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor;
using System ;
using System.IO;
public class MySoftAutoEditor: MonoBehaviour
{


   
    [MenuItem("MySoft Editor/InitProject")]
    static void InitProject()
    {
       PlayerSettings.companyName = "mycoloringbook";
        PlayerSettings.productName = "oddbodscoloring";
PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android,"com."+"mycoloringbook"+"."+"oddbodscoloring");
	DirectoryInfo d = new DirectoryInfo(@"Assets/_Game/_Sprites/_Textures");
FileInfo[] infos = d.GetFiles(); // get all files in directory
var idxf =1;
foreach(FileInfo f in infos)
{
            if(f.Name.Contains(".meta"))
            {
                continue; 
            }
 AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/"+f.Name , idxf.ToString() +".png");
            idxf += 1;
}

    }
 
    [MenuItem("MySoft Editor/renameclasses")]
    static void renameclasses()
    {
     
        AssetDatabase.RenameAsset("Assets/AudienceNetwork/Scenes/Banner/marionrangel.cs", "alejandroyang.cs");
AssetDatabase.RenameAsset("Assets/AudienceNetwork/Scenes/Interstitial/raymundohutchison.cs", "trumanreeder.cs");
AssetDatabase.RenameAsset("Assets/AudienceNetwork/Scenes/RewardedVideo/franklinroper.cs", "jesushernandez.cs");
AssetDatabase.RenameAsset("Assets/AudienceNetwork/Scenes/Settings/jasperaquino.cs", "colegriffin.cs");
AssetDatabase.RenameAsset("Assets/AudienceNetwork/Scenes/louiefitzpatrick.cs", "alexwolfe.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/_Main/mauricecortez.cs", "rufusesposito.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/_Main/rodgalvan.cs", "elmerwilliamson.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/_Main/rodrigoherrera.cs", "vincentdelatorre.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/brockmiles.cs", "rodolfobrand.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/careyvalencia.cs", "santoscarlson.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/diegostuart.cs", "arnoldhood.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/erniegrimm.cs", "homermccall.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/mikemackey.cs", "cleobush.cs");
AssetDatabase.RenameAsset("Assets/_Game/_Scripts/shannonbrowning.cs", "elbertdickerson.cs");
AssetDatabase.RenameAsset("Assets/ralphmontalvo.cs", "darylhuff.cs");


    }

[MenuItem("MySoft Editor/renamepngs")]
   static void renamepngs()
    {
      
        AssetDatabase.RenameAsset("Assets/MaxSdk/Resources/Images/Invictor elijahstone.png", "Oddbods randolphkimble.png");
AssetDatabase.RenameAsset("Assets/MaxSdk/Resources/Images/Invictor gusroach.png", "Oddbods blainekaplan.png");
AssetDatabase.RenameAsset("Assets/MaxSdk/Resources/Images/Invictor keithpowers.png", "Oddbods stephanali.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Invictor armandsaenz.png", "Oddbods roscoenash.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Invictor franklinmadrigal.png", "Oddbods antoinekraus.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Invictor guadalupezepeda.png", "Oddbods rustyelkins.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Invictor harrisonwilkes.jpg", "Oddbods eltonernst.jpg");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Invictor jeffryduffy.png", "Oddbods bryantabel.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Invictor lamontbarrett.png", "Oddbods carrollcurran.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Invictor mackboyce.png", "Oddbods genarofarmer.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Invictor merrillledford.png", "Oddbods jamesfry.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Invictor mitchellkennedy.png", "Oddbods rolanddevine.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Invictor phillipglover.png", "Oddbods norberthester.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Invictor rodneyfarr.png", "Oddbods marioblue.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Invictor tyroneedwards.png", "Oddbods tysoncamp.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Invictor vernonwu.png", "Oddbods evanbaca.png");
AssetDatabase.RenameAsset("Assets/_Game/New Folder/Invictor weldonshea.png", "Oddbods kendallwilder.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/1x/Invictor armandorobbins.png", "Oddbods bradleyrizzo.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/1x/Invictor staceyodell.png", "Oddbods alexandersears.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/1x/Invictor wilfordokeefe.png", "Oddbods genebutler.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/Invictor morrisjewell.png", "Oddbods issacmack.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/Invictor ottoeubanks.png", "Oddbods norbertwiley.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/Invictor quintonbraun.png", "Oddbods isaiahlink.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/Invictor ralphmcbride.png", "Oddbods ashleyswanson.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/Invictor robbietrotter.png", "Oddbods isaacsummers.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/Invictor rufuswebber.png", "Oddbods allendunbar.png");
AssetDatabase.RenameAsset("Assets/_Game/Newpi/Invictor russellhardin.png", "Oddbods thaddeusadams.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/3x/Invictor darenosborn.png", "Oddbods rickynolan.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor allenschmidt.png", "Oddbods carsonleblanc.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor chadbattle.png", "Oddbods romanmullen.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor christopherbrandt.png", "Oddbods richardcarroll.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor clementmontes.png", "Oddbods fabianbonner.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor cruzchase.png", "Oddbods karlbowen.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor curtreilly.png", "Oddbods brentsadler.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor darengranger.png", "Oddbods renechan.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor dominicweller.png", "Oddbods sonnytang.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor fidellang.png", "Oddbods dominickbeasley.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor humbertoatwood.png", "Oddbods pasqualeweiss.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor israelritchie.png", "Oddbods montyferrell.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor josuehays.png", "Oddbods delmarpelletier.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor lawrencepalmer.png", "Oddbods gerrydaugherty.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor lesliereyes.png", "Oddbods dirkportillo.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor philipdye.png", "Oddbods jerrykay.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor reggietuttle.png", "Oddbods patricktracy.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor ricardopiper.png", "Oddbods otisgeiger.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor shermangreco.png", "Oddbods pedrosaldana.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor thaddeuswilkins.png", "Oddbods millardvernon.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor timmyeason.png", "Oddbods deweymelendez.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor wilfredyost.png", "Oddbods sethmack.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Buttons/Invictor woodrowdouglas.png", "Oddbods ramirohuff.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Main/Invictor adantolbert.png", "Oddbods martingallegos.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Main/Invictor donalddukes.png", "Oddbods glennfrench.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Main/Invictor errolchaney.png", "Oddbods garryvelazquez.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Main/Invictor greggchappell.png", "Oddbods galenbritton.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Main/Invictor lancemaddox.png", "Oddbods donnycortes.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Main/Invictor leviwestbrook.png", "Oddbods martinmayes.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Main/Invictor merlechacon.png", "Oddbods carmenyost.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Invictor aubreydickens.png", "Oddbods alvingilmore.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Invictor averymiddleton.png", "Oddbods roycelund.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Invictor bobbiebranch.png", "Oddbods willishannah.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Invictor eddiekey.png", "Oddbods herbertrosa.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Invictor irvingvalenzuela.png", "Oddbods antoniocooper.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Invictor jaredhuynh.png", "Oddbods jaimesolis.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Invictor leslielevine.png", "Oddbods ulysseshancock.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Invictor monteedwards.png", "Oddbods benniemcintyre.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/1x/Invictor randalpowers.png", "Oddbods gerryduke.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/2x/Invictor carlomilligan.png", "Oddbods numbersshultz.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/2x/Invictor richardjamison.png", "Oddbods edmundmontgomery.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Invictor damianblackburn.png", "Oddbods arronnguyen.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Invictor darryljuarez.png", "Oddbods earlsalazar.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Invictor felipeburgess.png", "Oddbods elvinwarner.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Invictor frankbutts.png", "Oddbods dominiquepotter.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Invictor garretttravis.png", "Oddbods bobbiecastro.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Invictor montesolano.png", "Oddbods jasperroot.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Invictor nickpollard.png", "Oddbods timmywilkes.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Invictor robertsweeney.png", "Oddbods johnniechandler.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Invictor terrancejacob.png", "Oddbods darryltobin.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Invictor timothywilkins.png", "Oddbods russellweaver.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/3x/Invictor victormcrae.png", "Oddbods darrelsloan.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Invictor ashleyochoa.png", "Oddbods philiplucas.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Invictor brucedooley.png", "Oddbods horacewebb.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Invictor carrollhanley.png", "Oddbods jarvissmallwood.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Invictor ellisadair.png", "Oddbods calvinespinoza.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Invictor ellishannah.png", "Oddbods toddhiggins.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Invictor geraldblair.png", "Oddbods kendallstaley.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Invictor jeffrydyer.png", "Oddbods donnellraines.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Invictor marcocuellar.png", "Oddbods garystarks.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Invictor williamfriedman.png", "Oddbods joncarson.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Stickers/Invictor zacharyokeefe.png", "Oddbods eddiequiroz.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Invictor alexcrosby.png", "Oddbods trentonbradshaw.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Invictor bookerokeefe.png", "Oddbods philsims.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Invictor codybarrera.png", "Oddbods geoffreynunez.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Invictor henrydwyer.png", "Oddbods royfischer.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Invictor humbertosingleton.png", "Oddbods denisbassett.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Invictor jesseotto.png", "Oddbods brocktodd.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Invictor juanshea.png", "Oddbods sterlingtovar.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Invictor keithhanks.png", "Oddbods donnellcraig.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Invictor shelbynix.png", "Oddbods melvintrujillo.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Invictor stewartspencer.png", "Oddbods michaelkerr.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_StickersIcons/Invictor terrencebecker.png", "Oddbods beaufrancisco.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/1.png", "Oddbods claytonlin.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/2.png", "Oddbods devinjackson.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/3.png", "Oddbods marshalldubois.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/4.png", "Oddbods robertodonnell.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/5.png", "Oddbods franklinrankin.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/6.png", "Oddbods rickeybradshaw.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/7.png", "Oddbods heathgentry.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_Textures/8.png", "Oddbods garrettbrennan.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Invictor basilvega.png", "Oddbods micahoneal.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Invictor billyware.png", "Oddbods bartroche.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Invictor darenhenderson.png", "Oddbods trentsilva.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Invictor dirksands.png", "Oddbods aureliolester.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Invictor edmondhill.png", "Oddbods alejandroshirley.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Invictor ernieengel.png", "Oddbods johnathanbowers.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Invictor franciscomerrill.png", "Oddbods cornellrandall.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Invictor heathbarnes.png", "Oddbods landonkyle.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Invictor homerwitt.png", "Oddbods ramonadams.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Invictor juliusmcconnell.png", "Oddbods danmaynard.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Invictor marianosykes.png", "Oddbods shawnlivingston.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Invictor troydutton.png", "Oddbods jaylane.png");
AssetDatabase.RenameAsset("Assets/_Game/_Sprites/_UI/Invictor trumancrow.png", "Oddbods gordonchristiansen.png");
AssetDatabase.RenameAsset("Assets/_Game/Invictor clydemanley.png", "Oddbods houstoncamp.png");
AssetDatabase.RenameAsset("Assets/Invictor eddyrodriguez.png", "Oddbods guadalupebyers.png");


    }
[MenuItem("MySoft Editor/newguids")]
  static void newguids()
    {
        RegenerateGuids();


    }

[MenuItem("MySoft Editor/newguidForprojectOnly")]
  static void newguidForprojectOnly()
    {
        RegenerateGuids2();


    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public static void RegenerateGuids() {
            if (EditorUtility.DisplayDialog("GUIDs regeneration",
                "You are going to start the process of GUID regeneration. This may have unexpected results. \n\n MAKE A PROJECT BACKUP BEFORE PROCEEDING!",
                "Regenerate GUIDs", "Cancel")) {
                try {
                    AssetDatabase.StartAssetEditing();

                    string path = Path.GetFullPath(".") + Path.DirectorySeparatorChar + "ProjectSettings";
                    UnityGuidRegenerator regenerator = new UnityGuidRegenerator(path);
                    regenerator.RegenerateGuids();
                      path = Path.GetFullPath(".") + Path.DirectorySeparatorChar + "Assets";
                    UnityGuidRegenerator regenerator2 = new UnityGuidRegenerator(path);
                    regenerator2.RegenerateGuids();
                }
                finally {
                    AssetDatabase.StopAssetEditing();
                    EditorUtility.ClearProgressBar();
                    AssetDatabase.Refresh();
                }
            }
        }



 public static void RegenerateGuids2() {
            if (EditorUtility.DisplayDialog("GUIDs regeneration",
                "You are going to start the process of GUID regeneration. This may have unexpected results. \n\n MAKE A PROJECT BACKUP BEFORE PROCEEDING!",
                "Regenerate GUIDs", "Cancel")) {
                try {
                    AssetDatabase.StartAssetEditing();

                    string path = Path.GetFullPath(".") + Path.DirectorySeparatorChar + "ProjectSettings";
                    UnityGuidRegenerator regenerator = new UnityGuidRegenerator(path);
                    regenerator.RegenerateGuids();
 
                }
                finally {
                    AssetDatabase.StopAssetEditing();
                    EditorUtility.ClearProgressBar();
                    AssetDatabase.Refresh();
                }
            }
        }
    }
 
    internal class UnityGuidRegenerator {
        private static readonly string[] kDefaultFileExtensions = {
            "*.meta",
            "*.mat",
            "*.anim",
            "*.prefab",
            "*.unity",
            "*.asset"
        };

        private readonly string _assetsPath;

        public UnityGuidRegenerator(string assetsPath) {
            _assetsPath = assetsPath;
        }

        public void RegenerateGuids(string[] regeneratedExtensions = null) {
            if (regeneratedExtensions == null) {
                regeneratedExtensions = kDefaultFileExtensions;
            }

            // Get list of working files
            List<string> filesPaths = new List<string>();
            foreach (string extension in regeneratedExtensions) {
                filesPaths.AddRange(
                    Directory.GetFiles(_assetsPath, extension, SearchOption.AllDirectories)
                    );
            }

            // Create dictionary to hold old-to-new GUID map
            Dictionary<string, string> guidOldToNewMap = new Dictionary<string, string>();
            Dictionary<string, List<string>> guidsInFileMap = new Dictionary<string, List<string>>();

            // We must only replace GUIDs for Resources present in Assets. 
            // Otherwise built-in resources (shader, meshes etc) get overwritten.
            HashSet<string> ownGuids = new HashSet<string>();

            // Traverse all files, remember which GUIDs are in which files and generate new GUIDs
            int counter = 0;
            foreach (string filePath in filesPaths) {
                EditorUtility.DisplayProgressBar("Scanning Assets folder", MakeRelativePath(_assetsPath, filePath), counter / (float) filesPaths.Count);
                string contents = File.ReadAllText(filePath);
                
                IEnumerable<string> guids = GetGuids(contents);
                IEnumerable<string> guids2 = GetGuids2(contents);
                IEnumerable<string> guids3 = guids.Concat(guids2);

                bool isFirstGuid = true;
                foreach (string oldGuid in guids3) {
                    // First GUID in .meta file is always the GUID of the asset itself
                    if (isFirstGuid && Path.GetExtension(filePath) == ".meta") {
                        ownGuids.Add(oldGuid);
                        isFirstGuid = false;
                    }
                    // Generate and save new GUID if we haven't added it before
                    if (!guidOldToNewMap.ContainsKey(oldGuid)) {
                        string newGuid = Guid.NewGuid().ToString("N");
                        guidOldToNewMap.Add(oldGuid, newGuid);
                    }

                    if (!guidsInFileMap.ContainsKey(filePath))
                        guidsInFileMap[filePath] = new List<string>();

                    if (!guidsInFileMap[filePath].Contains(oldGuid)) {
                        guidsInFileMap[filePath].Add(oldGuid);
                    }
                }

                counter++;
            }

            // Traverse the files again and replace the old GUIDs
            counter = -1;
            int guidsInFileMapKeysCount = guidsInFileMap.Keys.Count;
            foreach (string filePath in guidsInFileMap.Keys) {
                EditorUtility.DisplayProgressBar("Regenerating GUIDs", MakeRelativePath(_assetsPath, filePath), counter / (float) guidsInFileMapKeysCount);
                counter++;

                string contents = File.ReadAllText(filePath);
                foreach (string oldGuid in guidsInFileMap[filePath]) {
                    if (filePath.Contains("ProjectSettings"))
                    {
   if (filePath.Contains("ProjectSettings.asset"))
                    {
                        string newGuid = guidOldToNewMap[oldGuid];
                        if (string.IsNullOrEmpty(newGuid))
                            throw new NullReferenceException("newGuid == null");

                        contents = contents.Replace("guid: " + oldGuid, "guid: " + newGuid);
                        contents = contents.Replace("productGUID: " + oldGuid, "productGUID: " + newGuid);
}
                    }
                    else
                    {
                        if (!ownGuids.Contains(oldGuid))
                            continue;

                        string newGuid = guidOldToNewMap[oldGuid];
                        if (string.IsNullOrEmpty(newGuid))
                            throw new NullReferenceException("newGuid == null");

                        contents = contents.Replace("guid: " + oldGuid, "guid: " + newGuid);
                    }
                    File.WriteAllText(filePath, contents);
                }
                   
            }

            EditorUtility.ClearProgressBar();
        }

        private static IEnumerable<string> GetGuids(string text) {
            const string guidStart = "guid: ";
            const int guidLength = 32;
            int textLength = text.Length;
            int guidStartLength = guidStart.Length;
            List<string> guids = new List<string>();

            int index = 0;
            while (index + guidStartLength + guidLength < textLength) {
                index = text.IndexOf(guidStart, index, StringComparison.Ordinal);
                if (index == -1)
                    break;

                index += guidStartLength;
                string guid = text.Substring(index, guidLength);
                index += guidLength;

                if (IsGuid(guid)) {
                    guids.Add(guid);
                }
            }

            return guids;
        }

        private static IEnumerable<string> GetGuids2(string text)
        {
            const string guidStart = "productGUID: ";
            const int guidLength = 32;
            int textLength = text.Length;
            int guidStartLength = guidStart.Length;
            List<string> guids = new List<string>();

            int index = 0;
            while (index + guidStartLength + guidLength < textLength)
            {
                index = text.IndexOf(guidStart, index, StringComparison.Ordinal);
                if (index == -1)
                    break;

                index += guidStartLength;
                string guid = text.Substring(index, guidLength);
                index += guidLength;

                if (IsGuid(guid))
                {
                    guids.Add(guid);
                }
            }

            return guids;
        }
        private static bool IsGuid(string text) {
            for (int i = 0; i < text.Length; i++) {
                char c = text[i];
                if (
                    !((c >= '0' && c <= '9') ||
                      (c >= 'a' && c <= 'z'))
                    )
                    return false;
            }

            return true;
        }

        private static string MakeRelativePath(string fromPath, string toPath) {
            Uri fromUri = new Uri(fromPath);
            Uri toUri = new Uri(toPath);

            Uri relativeUri = fromUri.MakeRelativeUri(toUri);
            string relativePath = Uri.UnescapeDataString(relativeUri.ToString());

            return relativePath;
        }	


}
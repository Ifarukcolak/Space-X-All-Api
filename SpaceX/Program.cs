using SpaceX.Interfaces;
using SpaceX.Services;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SpaceX.Models;
using Newtonsoft.Json;

namespace SpaceX
{
    public class Program
    {
        #region Private Fields

        private static ServiceProvider serviceProvider;
        private static ICapsule _capsule;
        private static ICore _core;
        private static IDragon _dragon;
        private static IHistory _history;
        private static IInfo _info;
        private static ILandingPad _landingPad;
        private static ILaunch _launch;
        private static ILaunchPad _launchPad;
        private static IMission _mission;
        private static IPayload _payload;
        private static IRocket _rocket;
        private static IRoadster _roadster;
        private static IShip _ship;

        #endregion

        public static void Main(string[] args)
        {
            #region Service Provider

            serviceProvider = new ServiceCollection().AddSingleton<ICapsule, CapsuleService>()
                                                      .AddSingleton<ICore, CoreService>()
                                                      .AddSingleton<IDragon, DragonService>()
                                                      .AddSingleton<IHistory, HistoryService>()
                                                      .AddSingleton<IInfo, InfoService>()
                                                      .AddSingleton<ILandingPad, LandingPadService>()
                                                      .AddSingleton<ILaunch, LaunchService>()
                                                      .AddSingleton<ILaunchPad, LaunchPadService>()
                                                      .AddSingleton<IMission, MissionService>()
                                                      .AddSingleton<IPayload, PayloadService>()
                                                      .AddSingleton<IRocket, RocketService>()
                                                      .AddSingleton<IRoadster, RoadsterService>()
                                                      .AddSingleton<IShip, ShipService>()
                                                      .BuildServiceProvider();

            _capsule = serviceProvider.GetService<ICapsule>();
            _core = serviceProvider.GetService<ICore>();
            _dragon = serviceProvider.GetService<IDragon>();
            _history = serviceProvider.GetService<IHistory>();
            _info = serviceProvider.GetService<IInfo>();
            _landingPad = serviceProvider.GetService<ILandingPad>();
            _launch = serviceProvider.GetService<ILaunch>();
            _launchPad = serviceProvider.GetService<ILaunchPad>();
            _mission = serviceProvider.GetService<IMission>();
            _payload = serviceProvider.GetService<IPayload>();
            _rocket = serviceProvider.GetService<IRocket>();
            _roadster = serviceProvider.GetService<IRoadster>();
            _ship = serviceProvider.GetService<IShip>();

            #endregion
            InitializeApiService();
            Console.ReadLine();
        }

        public static void InitializeApiService()
        {
            while (true)
            {
                Console.WriteLine("Choose an Api");
                Console.WriteLine();
                //capsules
                Console.WriteLine("--------------------");
                Console.WriteLine("Capsules");
                Console.WriteLine("--------------------");
                Console.WriteLine("{0} All capsules", 1);
                Console.WriteLine("{0} One capsule", 2);
                Console.WriteLine("{0} Upcoming capsules", 3);
                Console.WriteLine("{0} Past capsules", 4);
                //cores
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("Cores");
                Console.WriteLine("--------------------");
                Console.WriteLine("{0} All cores", 5);
                Console.WriteLine("{0} One core", 6);
                Console.WriteLine("{0} Upcoming cores", 7);
                Console.WriteLine("{0} Past cores", 8);
                //dragons
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("Dragons");
                Console.WriteLine("--------------------");
                Console.WriteLine("{0} All Dragons", 9);
                Console.WriteLine("{0} One Dragon", 10);
                //history
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("History");
                Console.WriteLine("--------------------");
                Console.WriteLine("{0} All Historical Events", 11);
                Console.WriteLine("{0} One Historical Event", 12);
                //info
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("Info");
                Console.WriteLine("--------------------");
                Console.WriteLine("{0} Company Info", 13);
                Console.WriteLine("{0} API Info", 14);
                //landing pads
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("Landing Pads");
                Console.WriteLine("--------------------");
                Console.WriteLine("{0} All Landing Pads", 15);
                Console.WriteLine("{0} One Landing Pad", 16);
                //launches
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("Launches");
                Console.WriteLine("--------------------");
                Console.WriteLine("{0} All Launches", 17);
                Console.WriteLine("{0} One Launch", 18);
                Console.WriteLine("{0} Past Launches", 19);
                Console.WriteLine("{0} Upcoming Launches", 20);
                Console.WriteLine("{0} Latest Launch", 21);
                Console.WriteLine("{0} Next Launch", 22);
                //launch pads
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("Launch Pads");
                Console.WriteLine("--------------------");
                Console.WriteLine("{0} All Launchpads", 23);
                Console.WriteLine("{0} One Launchpad", 24);
                //missions
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("Missions");
                Console.WriteLine("--------------------");
                Console.WriteLine("{0} All Missions", 25);
                Console.WriteLine("{0} One Mission", 26);
                //payloads
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("Payloads");
                Console.WriteLine("--------------------");
                Console.WriteLine("{0} All Payloads", 27);
                Console.WriteLine("{0} One Payload", 28);
                //rockets
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("Rockets");
                Console.WriteLine("--------------------");
                Console.WriteLine("{0} All Rockets", 29);
                Console.WriteLine("{0} One Rocket", 30);
                //roadster
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("Roadster");
                Console.WriteLine("--------------------");
                Console.WriteLine("{0} Roadster", 31);
                //ships
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("Ships");
                Console.WriteLine("--------------------");
                Console.WriteLine("{0} All Ships", 32);
                Console.WriteLine("{0} One Ship", 33);
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Please wait...");
                        GetAllCapsulesAsync();
                        break;
                    case "2":
                        Console.WriteLine("What is the capsule_serial ?");
                        var capsule_serial = Console.ReadLine();
                        Console.WriteLine("Please wait...");
                        GetOneCapsuleAsync(capsule_serial);
                        break;
                    case "3":
                        Console.WriteLine("Please wait...");
                        GetUpcomingCapsulesAsync();
                        break;
                    case "4":
                        Console.WriteLine("Please wait...");
                        GetPastCapsulesAsync();
                        break;
                    case "5":
                        Console.WriteLine("Please wait...");
                        GetAllCoresAsync();
                        break;
                    case "6":
                        Console.WriteLine("What is the core_serial ?");
                        var core_serial = Console.ReadLine();
                        Console.WriteLine("Please wait...");
                        GetOneCoreAsync(core_serial);
                        break;
                    case "7":
                        Console.WriteLine("Please wait...");
                        GetUpcomingCoresAsync();
                        break;
                    case "8":
                        Console.WriteLine("Please wait...");
                        GetPastCoresAsync();
                        break;
                    case "9":
                        Console.WriteLine("Please wait...");
                        GetAllDragonsAsync();
                        break;
                    case "10":
                        Console.WriteLine("What is the dragon id ?");
                        var id = Console.ReadLine();
                        Console.WriteLine("Please wait...");
                        GetOneDragonAsync(id);
                        break;
                    case "11":
                        Console.WriteLine("Please wait...");
                        GetAllHistoricalEventsAsync();
                        break;
                    case "12":
                        Console.WriteLine("What is the historical event id ?");
                        var event_id = Console.ReadLine();
                        Console.WriteLine("Please wait...");
                        GetOneHistoricalEventAsync(Convert.ToInt32(event_id));
                        break;
                    case "13":
                        Console.WriteLine("Please wait...");
                        GetApiInfoAsync();
                        break;
                    case "14":
                        Console.WriteLine("Please wait...");
                        GetCompanyInfoAsync();
                        break;
                    case "15":
                        Console.WriteLine("Please wait...");
                        GetAllLandingPadsAsync();
                        break;
                    case "16":
                        Console.WriteLine("What is the landing pad id ?");
                        var landing_pad_id = Console.ReadLine();
                        Console.WriteLine("Please wait...");
                        GetOneLandingPadAsync(Convert.ToInt32(landing_pad_id));
                        break;
                    case "17":
                        Console.WriteLine("Please wait...");
                        GetAllLaunchesAsync();
                        break;
                    case "18":
                        Console.WriteLine("What is the launch_id ?");
                        var launch_id = Console.ReadLine();
                        Console.WriteLine("Please wait...");
                        GetOneLaunchAsync(launch_id);
                        break;
                    case "19":
                        Console.WriteLine("Please wait...");
                        GetPastLaunchesAsync();
                        break;
                    case "20":
                        Console.WriteLine("Please wait...");
                        GetUpcominLaunchesAsync();
                        break;
                    case "21":
                        Console.WriteLine("Please wait...");
                        GetLatestLaunchAsync();
                        break;
                    case "22":
                        Console.WriteLine("Please wait...");
                        GetNextLaunchAsync();
                        break;
                    case "23":
                        Console.WriteLine("Please wait...");
                        GetAllLaunchPadsAsync();
                        break;
                    case "24":
                        Console.WriteLine("What is the site_id ?");
                        var site_id = Console.ReadLine();
                        Console.WriteLine("Please wait...");
                        GetOneLaunchPadAsync(site_id);
                        break;
                    case "25":
                        Console.WriteLine("Please wait...");
                        GetAllMissionsAsync();
                        break;
                    case "26":
                        Console.WriteLine("What is the mission_id ?");
                        var mission_id = Console.ReadLine();
                        Console.WriteLine("Please wait...");
                        GetOneMissionAsync(mission_id);
                        break;
                    case "27":
                        Console.WriteLine("Please wait...");
                        GetAllPayloadsAsync();
                        break;
                    case "28":
                        Console.WriteLine("What is the payload_id ?");
                        var payload_id = Console.ReadLine();
                        Console.WriteLine("Please wait...");
                        GetOnePayloadAsync(payload_id);
                        break;
                    case "29":
                        Console.WriteLine("Please wait...");
                        GetAllRocketsAsync();
                        break;
                    case "30":
                        Console.WriteLine("What is the rocket_id ?");
                        var rocket_id = Console.ReadLine();
                        Console.WriteLine("Please wait...");
                        GetOneRocketAsync(rocket_id);
                        break;
                    case "31":
                        Console.WriteLine("Please wait...");
                        GetRoadsterOrbitDataAsync();
                        break;
                    case "32":
                        Console.WriteLine("Please wait...");
                        GetAllShipsAsync();
                        break;
                    case "33":
                        Console.WriteLine("What is the ship_id ?");
                        var ship_id = Console.ReadLine();
                        Console.WriteLine("Please wait...");
                        GetOneShipAsync(ship_id);
                        break;
                }
                Console.WriteLine("Please, enter any key to contiune ");
                Console.ReadLine();
            }
        }

        #region Capsules

        public static async Task GetAllCapsulesAsync()
        {
            var result = await _capsule.GetAllCapsulesAsync();
            WriteModel(result);
        }

        public static async Task GetOneCapsuleAsync(string capsule_serial)
        {
            var result = await _capsule.GetOneCapsuleAsync(capsule_serial);
            WriteModel(result);
        }
        public static async Task GetUpcomingCapsulesAsync()
        {
            var result = await _capsule.GetUpcomingCapsulesAsync();
            WriteModel(result);
        }
        public static async Task GetPastCapsulesAsync()
        {
            var result = await _capsule.GetPastCapsulesAsync();
            WriteModel(result);
        }

        #endregion

        #region Cores

        public static async Task GetAllCoresAsync()
        {
            var result = await _core.GetAllCoresAsync();
            WriteModel(result);
        }

        public static async Task GetOneCoreAsync(string core_serial)
        {
            var result = await _core.GetOneCoreAsync(core_serial);
            WriteModel(result);
        }
        public static async Task GetUpcomingCoresAsync()
        {
            var result = await _core.GetUpcomingCoresAsync();
            WriteModel(result);
        }
        public static async Task GetPastCoresAsync()
        {
            var result = await _core.GetPastCoresAsync();
            WriteModel(result);
        }

        #endregion

        #region Dragons

        public static async Task GetAllDragonsAsync()
        {
            var result = await _dragon.GetAllDragonsAsync();
            WriteModel(result);
        }

        public static async Task GetOneDragonAsync(string id)
        {
            var result = await _dragon.GetOneDragonAsync(id);
            WriteModel(result);
        }

        #endregion

        #region History

        public static async Task GetAllHistoricalEventsAsync()
        {
            var result = await _history.GetAllHistoricalEventsAsync();
            WriteModel(result);
        }

        public static async Task GetOneHistoricalEventAsync(int id)
        {
            var result = await _history.GetOneHistoricalEventAsync(id);
            WriteModel(result);
        }

        #endregion

        #region Info

        public static async Task GetApiInfoAsync()
        {
            var result = await _info.GetApiInfoAsync();
            WriteModel(result);
        }

        public static async Task GetCompanyInfoAsync()
        {
            var result = await _info.GetCompanyInfoAsync();
            WriteModel(result);
        }

        #endregion

        #region Landing Pads

        public static async Task GetAllLandingPadsAsync()
        {
            var result = await _landingPad.GetAllLandingPadsAsync();
            WriteModel(result);
        }

        public static async Task GetOneLandingPadAsync(int id)
        {
            var result = await _landingPad.GetOneLandingPadAsync(id);
            WriteModel(result);
        }


        #endregion

        #region Launces

        public static async Task GetAllLaunchesAsync()
        {
            var result = await _launch.GetAllLaunchesAsync();
            WriteModel(result);
        }

        public static async Task GetLatestLaunchAsync()
        {
            var result = await _launch.GetLatestLaunchAsync();
            WriteModel(result);
        }

        public static async Task GetNextLaunchAsync()
        {
            var result = await _launch.GetNextLaunchAsync();
            WriteModel(result);
        }

        public static async Task GetOneLaunchAsync(string flight_number)
        {
            var result = await _launch.GetOneLaunchAsync(flight_number);
            WriteModel(result);
        }
        public static async Task GetPastLaunchesAsync()
        {
            var result = await _launch.GetPastLaunchesAsync();
            WriteModel(result);
        }
        public static async Task GetUpcominLaunchesAsync()
        {
            var result = await _launch.GetUpcominLaunchesAsync();
            WriteModel(result);
        }

        #endregion

        #region Launch Pads

        public static async Task GetOneLaunchPadAsync(string site_id)
        {
            var result = await _launchPad.GetOneLaunchPadAsync(site_id);
            WriteModel(result);
        }

        public static async Task GetAllLaunchPadsAsync()
        {
            var result = await _launchPad.GetAllLaunchPadsAsync();
            WriteModel(result);
        }

        #endregion

        #region Missions

        public static async Task GetAllMissionsAsync()
        {
            var result = await _mission.GetAllMissionsAsync();
            WriteModel(result);
        }

        public static async Task GetOneMissionAsync(string mission_id)
        {
            var result = await _mission.GetOneMissionAsync(mission_id);
            WriteModel(result);
        }

        #endregion

        #region All Payloads

        public static async Task GetAllPayloadsAsync()
        {
            var result = await _payload.GetAllPayloadsAsync();
            WriteModel(result);
        }

        public static async Task GetOnePayloadAsync(string payload_id)
        {
            var result = await _payload.GetOnePayloadAsync(payload_id);
            WriteModel(result);
        }

        #endregion

        #region Rockets

        public static async Task GetAllRocketsAsync()
        {
            var result = await _rocket.GetAllRocketsAsync();
            WriteModel(result);
        }

        public static async Task GetOneRocketAsync(string rocket_id)
        {
            var result = await _rocket.GetOneRocketAsync(rocket_id);
            WriteModel(result);
        }

        #endregion

        #region Roadster

        public static async Task GetRoadsterOrbitDataAsync()
        {
            var result = await _roadster.GetRoadsterOrbitDataAsync();
            WriteModel(result);
        }
        #endregion

        #region Ships
        public static async Task GetAllShipsAsync()
        {
            var result = await _ship.GetAllShipsAsync();
            WriteModel(result);
        }

        public static async Task GetOneShipAsync(string ship_id)
        {
            var result = await _ship.GetOneShipAsync(ship_id);
            WriteModel(result);
        }

        #endregion

        #region Writing Model

        public static void WriteModel(object model)
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine(JsonConvert.SerializeObject(model, Formatting.Indented));
            Console.WriteLine("-------------------------------------------------------------------------");
        }

        #endregion
    }
}

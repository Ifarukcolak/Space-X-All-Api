using SpaceX.Interfaces;
using SpaceX.Services;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SpaceX.Models;

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
                                                      .AddSingleton<ILaunchPad,LaunchPadService>()
                                                      .AddSingleton<IMission,MissionService>()
                                                      .AddSingleton<IRocket,RocketService>()
                                                      .AddSingleton<IRoadster,RoadsterService>()
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
            _rocket = serviceProvider.GetService<IRocket>();
            _roadster = serviceProvider.GetService<IRoadster>();
            _ship = serviceProvider.GetService<IShip>();

            #endregion

            Console.WriteLine("Write order number  listed of SpaceX Api's");
            var choice=Console.ReadLine();
            switch (choice)
            {
                case "1":
                    GetAllCapsulesAsync();
                    break;
                case "2":
                    Console.WriteLine("What is the capsule_serial ?");
                    var capsule_serial=Console.ReadLine();
                    GetOneCapsuleAsync(capsule_serial);
                    break;
            }
            Console.ReadLine();
        }

        public static async Task GetAllCapsulesAsync()
        {
            var result = await _capsule.GetAllCapsulesAsync();
            Console.WriteLine(result[0].capsule_serial);
        }

        public static async Task GetOneCapsuleAsync(string capsule_serial)
        {
            var result = await _capsule.GetOneCapsuleAsync(capsule_serial);
            Console.WriteLine(result.capsule_serial);
        }
    }
}

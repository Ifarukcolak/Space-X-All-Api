using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Data
{
    public class SpaceXApiPaths
    {
        #region SpaceX Base Api Url

        public static string SpaceXApiBaseUrl = "https://api.spacexdata.com/v3";

        #endregion

        #region Capsule Api Paths

        public static string AllCapsulesPath = "/capsules";
        public static string UpcomingCapsulesPath = "/capsules/upcoming";
        public static string PastCapsulesPath = "/capsules/past";

        #endregion

        #region Core Api Paths

        public static string AllCoresPath = "/cores";
        public static string UpcomingCoresPath = "/cores/upcoming";
        public static string PastCoresPath = "/cores/past";

        #endregion

        #region Dragon Api Path

        public static string AllDragonsPath = "/dragons";

        #endregion

        #region History Api Path

        public static string AllHistoricalEventsPath = "/history";

        #endregion

        #region Info Api Path

        public static string CompanyInfoPath = "/info";

        #endregion

        #region Landing Pad Api Path

        public static string AllLandingPadsPath = "/landpads";

        #endregion

        #region Launch Api Paths

        public static string AllLaunchesPath = "/launches";
        public static string PastLaunchesPath = "/past";
        public static string UpcomingLaunchesPath = "/upcoming";
        public static string LatestLaunchPath = "/latest";
        public static string NextLaunchPath = "/next";

        #endregion

        #region Launch Pad Api Path

        public static string AllLaunchPadsPath = "/launchpads";

        #endregion

        #region Mission Api Path

        public static string AllMissionsPath = "/missions";

        #endregion

        #region Payload Api Path

        public static string AllPayloadsPath = "/payloads";

        #endregion

        #region Rocket Api Path

        public static string AllRocketsPath = "/rockets";

        #endregion

        #region Roadster Api Path

        public static string RoadsterPath = "/roadster";

        #endregion

        #region Ship Api Path

        public static string AllShipsPath = "/ships";

        #endregion

    }
}

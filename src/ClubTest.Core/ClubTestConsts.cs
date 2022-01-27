using ClubTest.Debugging;

namespace ClubTest
{
    public class ClubTestConsts
    {
        public const string LocalizationSourceName = "ClubTest";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "f034e42c0cf4459cb03f85fb8c956094";
    }
}

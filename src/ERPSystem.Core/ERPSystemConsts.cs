using ERPSystem.Debugging;

namespace ERPSystem
{
    public class ERPSystemConsts
    {
        public const string LocalizationSourceName = "ERPSystem";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "a03f548a548f4f4692d4252de9e97611";
    }
}

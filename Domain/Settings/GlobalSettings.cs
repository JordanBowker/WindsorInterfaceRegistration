using WindsorInterfaceRegistration.Domain.Settings.DataContracts;

namespace WindsorInterfaceRegistration.Domain.Settings
{
	public class GlobalSettings : IGlobalSettings
	{
		public string SettingA { get; set; }
		public string SettingB { get; set; }
		public string GlobalSetting { get; set; }
	}
}

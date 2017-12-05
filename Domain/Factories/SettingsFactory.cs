using WindsorInterfaceRegistration.Domain.Factories.DataContracts;
using WindsorInterfaceRegistration.Domain.Settings;
using WindsorInterfaceRegistration.Domain.Settings.DataContracts;

namespace WindsorInterfaceRegistration.Domain.Factories
{
	public class SettingsFactory : ISettingsFactory
	{
		public IGlobalSettings GetSettings()
		{
			return new GlobalSettings { GlobalSetting = "GS", SettingA = "SA", SettingB = "SB" };
		}
	}
}

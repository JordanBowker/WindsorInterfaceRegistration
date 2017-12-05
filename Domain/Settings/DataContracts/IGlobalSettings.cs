namespace WindsorInterfaceRegistration.Domain.Settings.DataContracts
{
	public interface IGlobalSettings : ILocalSettingsA, ILocalSettingsB
	{
		string GlobalSetting { get; set; }
	}
}

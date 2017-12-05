using WindsorInterfaceRegistration.Domain.Settings.DataContracts;

namespace WindsorInterfaceRegistration.Domain.Factories.DataContracts
{
	public interface ISettingsFactory
	{
		IGlobalSettings GetSettings();
	}
}

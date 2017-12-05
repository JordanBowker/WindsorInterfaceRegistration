using WindsorInterfaceRegistration.Domain.Settings.DataContracts;
using WindsorInterfaceRegistration.Domain.Workers.DataContracts;

namespace WindsorInterfaceRegistration.Domain.Workers
{
	public class GlobalWorker : IGlobalWorker
	{
		private readonly IGlobalSettings _globalSettings;

		public GlobalWorker(IGlobalSettings globalSettings)
		{
			_globalSettings = globalSettings;
		}

		public string GetGlobalSetting()
		{
			return _globalSettings.GlobalSetting;
		}
	}
}

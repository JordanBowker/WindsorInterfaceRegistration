using WindsorInterfaceRegistration.Domain.Settings.DataContracts;
using WindsorInterfaceRegistration.Domain.Workers.DataContracts;

namespace WindsorInterfaceRegistration.Domain.Workers
{
	public class WorkerB : IWorkerB
	{
		private readonly ILocalSettingsB _localSettingsB;

		public WorkerB(ILocalSettingsB localSettingsB)
		{
			_localSettingsB = localSettingsB;
		}

		public string GetSettingB()
		{
			return _localSettingsB.SettingB;
		}
	}
}

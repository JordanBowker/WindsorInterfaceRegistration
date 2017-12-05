using WindsorInterfaceRegistration.Domain.Settings.DataContracts;
using WindsorInterfaceRegistration.Domain.Workers.DataContracts;

namespace WindsorInterfaceRegistration.Domain.Workers
{
	public class WorkerA : IWorkerA
	{
		private readonly ILocalSettingsA _localSettingsA;

		public WorkerA(ILocalSettingsA localSettingsA)
		{
			_localSettingsA = localSettingsA;
		}

		public string GetSettingA()
		{
			return _localSettingsA.SettingA;
		}
	}
}

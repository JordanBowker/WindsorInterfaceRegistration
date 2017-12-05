using Castle.MicroKernel.Registration;
using Castle.Windsor;
using NUnit.Framework;
using WindsorInterfaceRegistration.Domain.Factories;
using WindsorInterfaceRegistration.Domain.Factories.DataContracts;
using WindsorInterfaceRegistration.Domain.Settings.DataContracts;
using WindsorInterfaceRegistration.Domain.Workers;
using WindsorInterfaceRegistration.Domain.Workers.DataContracts;

namespace WindsorInterfaceRegistration.IntegrationTests
{
	[TestFixture]
	public class Tests
	{
		private WindsorContainer _windsorContainer;

		[SetUp]
		public void Setup()
		{
			_windsorContainer = new WindsorContainer();

			_windsorContainer.Register(Component.For<ISettingsFactory>().ImplementedBy<SettingsFactory>());
			_windsorContainer.Register(Component.For<IGlobalSettings, ILocalSettingsA, ILocalSettingsB>().UsingFactory((ISettingsFactory factory) => factory.GetSettings()));

			_windsorContainer.Register(Component.For<IGlobalWorker>().ImplementedBy<GlobalWorker>());
			_windsorContainer.Register(Component.For<IWorkerA>().ImplementedBy<WorkerA>());
			_windsorContainer.Register(Component.For<IWorkerB>().ImplementedBy<WorkerB>());
		}

		[Test]
		public void GlobalSettingsTest()
		{
			var globalWorker = _windsorContainer.Resolve<IGlobalWorker>();
			Assert.That(globalWorker.GetGlobalSetting(), Is.EqualTo("GS"));
		}

		[Test]
		public void LocalSettingsATest()
		{
			var workerA = _windsorContainer.Resolve<IWorkerA>();
			Assert.That(workerA.GetSettingA(), Is.EqualTo("SA"));
		}

		[Test]
		public void LocalSettingsBTest()
		{
			var workerB = _windsorContainer.Resolve<IWorkerB>();
			Assert.That(workerB.GetSettingB(), Is.EqualTo("SB"));
		}
	}
}

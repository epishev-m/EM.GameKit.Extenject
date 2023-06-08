namespace EM.GameKit.Extenject
{

using BuildSystem;
using Profile;
using Zenject;

public static class ProfileDiContainerExtensions
{
	public static DiContainer BindProfile(this DiContainer container,
		IVersionConfig versionConfig,
		ISaveConfig saveConfig)
	{
		container.BindInterfacesTo<StorageSegmentReceiverFactory>().AsSingle();
		container.Bind<JsonSerializeConfig>().ToSelf().AsSingle();
		container.BindInterfacesTo<JsonStorageSerializer>().AsSingle();
		container.BindInterfacesTo<FileStorageLocation>().AsSingle();
		container.Bind<IVersionConfig>().FromInstance(versionConfig).AsSingle();
		container.Bind<ISaveConfig>().FromInstance(saveConfig).AsSingle();
		container.BindInterfacesTo<Profile>().AsSingle();

		return container;
	}
}

}
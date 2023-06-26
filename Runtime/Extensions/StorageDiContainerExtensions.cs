namespace EM.GameKit.Extenject
{

using Zenject;

public static class StorageDiContainerExtensions
{
	public static DiContainer BindStorage(this DiContainer container)
	{
		container.BindInterfacesTo<Storage>().AsSingle();
		container.Bind<StorageSaver>().ToSelf().AsSingle();

		return container;
	}
}

}
namespace EM.GameKit.Extenject
{

using Zenject;

public static class StorageDiContainerExtensions
{
	public static DiContainer BindStorage(this DiContainer container)
	{
		container.Bind<Storage>().ToSelf().AsSingle();

		return container;
	}
}

}
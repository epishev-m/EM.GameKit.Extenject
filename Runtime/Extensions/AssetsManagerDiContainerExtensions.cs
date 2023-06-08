namespace EM.GameKit.Extenject
{

using Foundation;
using Zenject;

public static class AssetsManagerDiContainerExtensions
{
	public static DiContainer BindAssetsManager(this DiContainer container)
	{
		container.BindInterfacesTo<AssetsManager>().AsSingle();

		return container;
	}
}

}
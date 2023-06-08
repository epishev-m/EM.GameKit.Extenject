namespace EM.GameKit.Extenject
{

using Foundation;
using Zenject;

public static class ReflectorDiContainerExtensions
{
	public static DiContainer BindReflector(this DiContainer container)
	{
		container.BindInterfacesTo<Reflector>().AsSingle();

		return container;
	}
}

}
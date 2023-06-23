namespace EM.GameKit.Extenject
{

using Zenject;

public static class RegistersDiContainerExtensions
{
	public static DiContainer BindRegisters(this DiContainer container)
	{
		container.BindInterfacesTo<Registers>().AsSingle();
		container.Bind<RegistersSaver>().ToSelf().AsSingle();

		return container;
	}
}

}
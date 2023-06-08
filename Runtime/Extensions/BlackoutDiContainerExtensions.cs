namespace EM.GameKit.Extenject
{

using Zenject;

public static class BlackoutDiContainerExtensions
{
	public static DiContainer BindBlackout(this DiContainer container)
	{
		container.Bind<BlackoutRouter>().ToSelf().AsSingle();
		container.Bind<BlackoutViewModel>().ToSelf().AsSingle();
		
		return container;
	}
}

}
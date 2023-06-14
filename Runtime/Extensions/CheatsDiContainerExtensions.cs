namespace EM.GameKit.Extenject
{

using Zenject;

public static class CheatsDiContainerExtensions
{
	public static DiContainer BindCheats(this DiContainer container)
	{
		container.BindInterfacesTo<CheatBinder>().AsSingle();
		container.Bind<CheatsModel>().ToSelf().AsSingle();
		container.Bind<Cheats>().ToSelf().AsSingle();
		container.Bind<CheatTest>().ToSelf().AsSingle();
		container.Bind<CheatsRouter>().ToSelf().AsSingle();
		container.Bind<CheatsViewModel>().ToSelf().AsSingle();

		return container;
	}
}

}
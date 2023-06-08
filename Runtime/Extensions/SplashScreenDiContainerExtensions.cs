namespace EM.GameKit.Extenject
{

using Zenject;

public static class SplashScreenDiContainerExtensions
{
	public static DiContainer BindSplashScreen<TConfigProvider>(this DiContainer container)
		where TConfigProvider : class, ISplashScreenConfigProvider
	{
		container.Bind<SplashScreenModel>().ToSelf().AsSingle();
		container.Bind<SplashScreenRouter>().ToSelf().AsSingle();
		container.Bind<SplashScreenViewModel>().ToSelf().AsSingle();
		container.Bind<SplashScreen>().ToSelf().AsSingle();
		container.BindInterfacesTo<TConfigProvider>().AsSingle();

		return container;
	}
}

}
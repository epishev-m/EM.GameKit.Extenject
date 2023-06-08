namespace EM.GameKit.Extenject
{

using Zenject;

public static class InternetConnectionDiContainerExtensions
{
	public static DiContainer BindInternetConnection<TConfigProvider>(this DiContainer container)
		where TConfigProvider : class, IInternetConnectionConfigProvider
	{
		container.Bind<InternetConnection>().ToSelf().AsSingle();
		container.Bind<InternetConnectionRouter>().ToSelf().AsSingle();
		container.Bind<InternetConnectionViewModel>().ToSelf().AsSingle();
		container.BindInterfacesTo<TConfigProvider>().AsSingle();

		return container;
	}
}

}
namespace EM.GameKit.Extenject
{

using Zenject;

public static class GdpRegulationDiContainerExtensions
{
	public static DiContainer BindGdpRegulation<TConfigProvider>(this DiContainer container)
		where TConfigProvider : class, IGdpRegulationConfigProvider
	{
		container.Bind<GdpRegulationModel>().ToSelf().AsSingle();
		container.Bind<GdpRegulationSaver>().ToSelf().AsSingle();
		container.Bind<GdpRegulationRouter>().ToSelf().AsSingle();
		container.Bind<GdpRegulationViewModel>().ToSelf().AsSingle();
		container.Bind<GdpRegulation>().ToSelf().AsSingle();
		container.BindInterfacesTo<TConfigProvider>().AsSingle();

		return container;
	}
}

}
namespace EM.GameKit.Extenject
{

using Zenject;

public static class IconTooltipDiContainerExtensions
{
	public static DiContainer BindIconTooltip(this DiContainer container)
	{
		container.Bind<IconTooltipRouter>().ToSelf().AsSingle();
		container.Bind<IconTooltipViewModel>().ToSelf().AsSingle();

		return container;
	}
}

}
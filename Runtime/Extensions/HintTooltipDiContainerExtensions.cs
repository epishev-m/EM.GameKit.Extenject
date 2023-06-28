namespace EM.GameKit.Extenject
{

using Zenject;

public static class HintTooltipDiContainerExtensions
{
	public static DiContainer BindHintTooltip(this DiContainer container)
	{
		container.Bind<HintTooltipRouter>().ToSelf().AsSingle();
		container.Bind<HintTooltipViewModel>().ToSelf().AsSingle();

		return container;
	}
}

}
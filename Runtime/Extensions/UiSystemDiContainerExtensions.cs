namespace EM.GameKit.Extenject
{

using UI;
using Zenject;

public static class UiSystemDiContainerExtensions
{
	public static DiContainer BindUiSystem(this DiContainer container)
	{
		container.BindInterfacesTo<UiRoot>().AsSingle();
		container.BindInterfacesTo<ScreenSystem>().AsSingle();
		container.BindInterfacesTo<PanelSystem>().AsSingle();

		return container;
	}
}

}
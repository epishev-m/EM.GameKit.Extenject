﻿namespace EM.GameKit.Extenject
{

using Zenject;

public static class StateMachineDiContainerExtensions
{
	public static DiContainer BindStateMachine(this DiContainer container)
	{
		container.BindInterfacesTo<GameStateMachine>().AsSingle();

		return container;
	}
}

}
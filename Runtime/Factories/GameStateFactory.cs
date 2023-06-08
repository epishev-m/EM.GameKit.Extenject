namespace EM.GameKit.Extenject
{

using System;
using Foundation;
using GameKit;
using Zenject;

public sealed class GameStateFactory : IGameStateFactory
{
	private readonly DiContainer _diContainer;

	#region IStateFactory

	public Result<IGameState> Create(Type stateType)
	{
		var result = (IGameState) _diContainer.Resolve(stateType);

		if (result == null)
		{
			return new ErrorResult<IGameState>(GameStatesStringResources.FailedToGetInstance(this));
		}

		return new SuccessResult<IGameState>(result);
	}

	#endregion

	#region StateFactory

	public GameStateFactory(DiContainer diContainer)
	{
		Requires.NotNullParam(diContainer, nameof(diContainer));

		_diContainer = diContainer;
	}

	#endregion
}

}
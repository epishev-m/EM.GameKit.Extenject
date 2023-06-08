namespace EM.GameKit.Extenject
{

using EM.GameKit;
using Zenject;

public sealed class CheatFactory : ICheatFactory
{
	private readonly DiContainer _diContainer;

	#region IGameLoopObjectFactory

	public ICheat Get<TCheat>()
		where TCheat : class, ICheat
	{
		return _diContainer.Resolve<TCheat>();
	}

	#endregion

	#region CheatFactory

	public CheatFactory(DiContainer diContainer)
	{
		_diContainer = diContainer;
	}

	#endregion
}

}
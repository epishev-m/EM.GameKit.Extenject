namespace EM.GameKit.Extenject
{

using System;
using UI;
using Zenject;

public class ViewModelFactory : IViewModelFactory
{
	private readonly DiContainer _diContainer;

	#region IViewModelFactory

	public TViewModel Get<TViewModel>()
		where TViewModel : class
	{
		return _diContainer.Resolve<TViewModel>();
	}

	public IViewModel Get(Type type)
	{
		return _diContainer.Resolve(type) as IViewModel;
	}

	#endregion

	#region ViewModelFactory

	public ViewModelFactory(DiContainer diContainer)
	{
		_diContainer = diContainer;
	}

	#endregion
}

}

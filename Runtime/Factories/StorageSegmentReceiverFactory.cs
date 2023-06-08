namespace EM.GameKit.Extenject
{

using System;
using EM.Profile;
using Zenject;

public sealed class StorageSegmentReceiverFactory : IStorageSegmentReceiverFactory
{
	private readonly DiContainer _diContainer;

	#region IStorageSegmentReceiverFactory

	public IStorageSegmentSaver Get(Type type)
	{
		return _diContainer.Resolve(type) as IStorageSegmentSaver;
	}

	#endregion

	#region ReceiverFactory

	public StorageSegmentReceiverFactory(DiContainer diContainer)
	{
		_diContainer = diContainer;
	}

	#endregion
}

}
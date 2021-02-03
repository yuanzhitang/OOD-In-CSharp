using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
	public class Singleton<T> where T : class
	{
		static object SyncRoot = new object();
		static T instance;

		public static T Instance
		{
			get
			{
				if (instance == null)
				{
					lock (SyncRoot)
					{
						if (instance == null)
						{
							ConstructorInfo constructorInfo = typeof(T).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, Type.EmptyTypes, null);
							if (constructorInfo == null)
							{
								throw new InvalidOperationException("SingletonClassMustHavePrivateConstructor");
							}
							instance = constructorInfo.Invoke(null) as T;
						}
					}
				}
				return instance;
			}
		}

		/// <summary>
		/// This method is for the class which has constructors with parameters.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public static T CreateInstance(params object[] parameters)
		{
			if (instance == null)
			{
				lock (SyncRoot)
				{
					if (instance == null)
					{
						Type[] types = new Type[parameters.Length];
						for (int i = 0; i < parameters.Length; ++i)
						{
							types[i] = parameters[i].GetType();
						}

						ConstructorInfo constructorInfo = typeof(T).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, types, null);
						if (constructorInfo == null)
						{
							throw new InvalidOperationException("SingletonClassHasInvalidConstructorParameter");
						}
						instance = constructorInfo.Invoke(parameters) as T;
					}
				}
			}
			return instance;
		}
	}
}

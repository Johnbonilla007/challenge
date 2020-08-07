using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

namespace Challenge.Net.Services.App_Start
{
    public class Container
    {
        private static readonly IUnityContainer _currentContainer = new UnityContainer();
        public static IUnityContainer Current
        {
            get
            {
                return _currentContainer;
            }
        }

        static Container()
        {
            RegisterDependencies();
        }

        private static void RegisterDependencies()
        {
            ChallengeContainer.Configure(_currentContainer);
        }
    }
}
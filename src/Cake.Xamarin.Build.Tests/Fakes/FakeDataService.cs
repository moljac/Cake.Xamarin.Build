using System;
namespace Cake.Xamarin.Build.Tests.Fakes
{
    public class FakeDataService : Core.ICakeDataService
    {
        public TData Get<TData>() where TData : class
        {
            throw new NotImplementedException();
        }

        public void Add<TData>(TData value) where TData : class
        {
            throw new NotImplementedException();
        }
    }
}

using EventDrivenWebApp.Events;
using StructureMap;

namespace IDontEatAnimals.Web
{
    public class StructureMapConfiguration
    {
        public static void Configure()
        {
            ObjectFactory.Initialize(InitializeStructureMap);
        }

        private static void InitializeStructureMap(IInitializationExpression x)
        {
            x.Scan(y =>
                {
                    y.TheCallingAssembly();
                    y.WithDefaultConventions();
                    y.AddAllTypesOf(typeof (IConsumer<>));
                }
            );
        } 
    }
}
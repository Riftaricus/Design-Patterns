using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class LawOfDementer
    {
        public LawOfDementer()
        {
            Console.WriteLine("LawOfDementer constructor called");
        }

        public void doSomething()
        {
            Console.WriteLine("LawOfDementer.doSomething() called");
        }

        public void MethodCallOfObject()
        {
            Console.WriteLine("LawOfDementer.MethodCallOfObject() called");
            doSomething();
        }

        public void MethodCallOfParameter(LawOfDementer parameterClass)
        {
            Console.WriteLine("LawOfDementer.MethodCallOfParameter() called");
            parameterClass.doSomething();
        }

        public void MethodCallOfCreation()
        {
            Console.WriteLine("LawOfDementer.MethodCallOfCreation() called");
            LawOfDementer creationClass = new LawOfDementer();
            creationClass.doSomething();
        }

        private LawOfDementer uninstantiatedComponent;

        public void MethodCallOfInstantiation()
        {
            Console.WriteLine("LawOfDementer.MethodCallOfInstantiation() called");
            uninstantiatedComponent = new LawOfDementer();
            uninstantiatedComponent.doSomething();
        }

        private LawOfDementer ComposedComponent;

        public LawOfDementer(LawOfDementer lawOfDementer)
        {
            Console.WriteLine("LawOfDementer constructor with parameter called");
            ComposedComponent = lawOfDementer;
        }

        public void MethodCallOfComponent()
        {
            Console.WriteLine("LawOfDementer.MethodCallOfComponent() called");
            ComposedComponent.doSomething();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;

namespace ConcreteFactory
{
    public class GlassPosudaFactory : IPosudaFactory
    {
        public IKnife CreateKnife()
        {
            return new GlassKnife();
        }

        public ISpoon CreateSpoon()
        {
            return new GlassSpoon();
        }
    }
    public class MetalPosudaFactory : IPosudaFactory
    {
        public IKnife CreateKnife()
        {
            return new MetalKnife();
        }

        public ISpoon CreateSpoon()
        {
            return new MetalSpoon();
        }
    }
    class GlassKnife : IKnife
    {
    }
    class GlassSpoon : ISpoon
    {
    }
    class MetalKnife : IKnife
    {
    }
    class MetalSpoon : ISpoon
    {
    }

}

using System;

namespace gyak08_jlv3dc
{
    public class factory_ball : interface_factory
    {
        public toy create()
        {
            return new ball();
        }
    }
}
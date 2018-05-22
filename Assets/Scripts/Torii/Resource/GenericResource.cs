﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torii.Resource
{
    public abstract class GenericResource
    {
        public int Lifespan;

        protected GenericResource(int lifespan)
        {
            Lifespan = lifespan;
        }
    }
}

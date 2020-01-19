using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Business.Model
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
    }
}

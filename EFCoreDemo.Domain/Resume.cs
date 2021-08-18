using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.Domain
{
    public class Resume
    {
        public int Id { get; set; }

        public string Description { get; set; }


        // (1:1)
        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }
}

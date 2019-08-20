using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Model
{
   public class Product
    {
        public  virtual int Id { get; set; }
        public  virtual String  Name { get; set; }
        public virtual Price Price { get; set; }

    }
}

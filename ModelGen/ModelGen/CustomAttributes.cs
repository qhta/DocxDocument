using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGen;
public class CustomAttributes : OwnedCollection<CustomAttrib>
{
  public CustomAttributes(Object owner) : base(owner)
  {
  }
}

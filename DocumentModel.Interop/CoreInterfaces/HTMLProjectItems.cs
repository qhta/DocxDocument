using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface HTMLProjectItems: InteropCollection<HTMLProjectItem>
{
  public HTMLProjectItem Item(ref object Index);
}

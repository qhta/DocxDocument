using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface HTMLProjectItems: InteropCollection<HTMLProjectItem>
{
  HTMLProjectItem Item(ref object Index);
}
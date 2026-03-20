using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DiagramNodes: InteropDictionary<string, DiagramNode>
{
  DiagramNode Item(object Index);
  void SelectAll();
}
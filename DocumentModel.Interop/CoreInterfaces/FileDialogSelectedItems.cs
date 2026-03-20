using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface FileDialogSelectedItems: InteropObject, IEnumerable
{
  new IEnumerator GetEnumerator();
  int Count { get; }
  string Item(int Index);
}
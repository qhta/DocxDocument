using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface FileDialogSelectedItems: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  new IEnumerator GetEnumerator();
  int Count { get; }
  string Item(int Index);
}
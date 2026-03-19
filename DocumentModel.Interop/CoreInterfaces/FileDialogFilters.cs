using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface FileDialogFilters: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  new IEnumerator GetEnumerator();
  int Count { get; }
  FileDialogFilter Item(int Index);
  void Delete(object filter);
  void Clear();
  FileDialogFilter Add(string Description, string Extensions, object Position);
}
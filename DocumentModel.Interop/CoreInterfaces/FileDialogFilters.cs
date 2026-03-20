using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface FileDialogFilters: InteropObject, IEnumerable
{
  new IEnumerator GetEnumerator();
  int Count { get; }
  FileDialogFilter Item(int Index);
  void Delete(object filter);
  void Clear();
  FileDialogFilter Add(string Description, string Extensions, object Position);
}
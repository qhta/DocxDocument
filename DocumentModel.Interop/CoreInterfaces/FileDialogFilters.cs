using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface FileDialogFilters: InteropCollection<FileDialogFilter>
{
  FileDialogFilter Item(int Index);
  void Delete(object filter);
  void Clear();
  FileDialogFilter Add(string Description, string Extensions, object Position);
}
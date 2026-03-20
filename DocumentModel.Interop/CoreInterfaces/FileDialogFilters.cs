using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface FileDialogFilters: InteropCollection<FileDialogFilter>
{
  public FileDialogFilter Item(int Index);
  public void Delete(object filter);
  public void Clear();
  public FileDialogFilter Add(string Description, string Extensions, object Position);
}

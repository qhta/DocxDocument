using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface FileDialogSelectedItems: InteropCollection<string>
{
  string Item(int Index);
}
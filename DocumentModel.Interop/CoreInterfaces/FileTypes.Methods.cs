using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface FileTypes
{
  public void Add(MsoFileType FileType);
  public void Remove(int Index);
}

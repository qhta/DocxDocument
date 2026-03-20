using System.Collections;

namespace DocumentModel.Interop.Core;

public interface FileTypes: InteropCollection<MsoFileType>
{
  public void Add(MsoFileType FileType);
  public void Remove(int Index);
}

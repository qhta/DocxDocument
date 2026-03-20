using System.Collections;

namespace DocumentModel.Interop.Core;

public interface FileTypes: InteropCollection<MsoFileType>
{
  void Add(MsoFileType FileType);
  void Remove(int Index);
}
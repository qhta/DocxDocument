using System.Collections;

namespace DocumentModel.Interop.Core;

public interface FileTypes: InteropObject, IEnumerable
{
  MsoFileType this[int Index] { get; }
  int Count { get; }
  void Add(MsoFileType FileType);
  void Remove(int Index);
  new IEnumerator GetEnumerator();
}
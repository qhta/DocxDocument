using System.Collections;

namespace DocumentModel.Interop.Core;

public interface FileTypes: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  MsoFileType this[int Index] { get; }
  int Count { get; }
  void Add(MsoFileType FileType);
  void Remove(int Index);
  new IEnumerator GetEnumerator();
}
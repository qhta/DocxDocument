using System.Collections;

namespace DocumentModel.Interop.Core;

public interface IFoundFiles: IEnumerable
{
  public string this[int Index] { get; }
  public int Count { get; }
  public new IEnumerator GetEnumerator();
}

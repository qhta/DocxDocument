using System.Collections;

namespace DocumentModel.Interop.Core;

public interface DocumentProperties: IEnumerable
{
  public DocumentProperty this[object Index] { get; }
  public int Count { get; }
  public DocumentProperty Add(string Name, bool LinkToContent, object Type, object Value, object LinkSource);
  public new IEnumerator GetEnumerator();
}

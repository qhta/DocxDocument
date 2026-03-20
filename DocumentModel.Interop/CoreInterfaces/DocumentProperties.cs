using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface DocumentProperties: IEnumerable
{
  public DocumentProperty this[object Index] { get; }
  public int Count { get; }
}

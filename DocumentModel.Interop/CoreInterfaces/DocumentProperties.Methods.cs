using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface DocumentProperties
{
  public DocumentProperty Add(string Name, bool LinkToContent, object Type, object Value, object LinkSource);
  public new IEnumerator GetEnumerator();
}

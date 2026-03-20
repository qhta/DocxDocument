using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface CustomXMLValidationErrors
{
  public void Add(CustomXMLNode Node, string ErrorName, string ErrorText, bool ClearedOnUpdate);
}

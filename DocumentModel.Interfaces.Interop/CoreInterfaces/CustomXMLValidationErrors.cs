using System.Collections;

namespace DocumentModel.Interop.Core;

public interface CustomXMLValidationErrors: InteropCollection<CustomXMLValidationError>
{
  public void Add(CustomXMLNode Node, string ErrorName, string ErrorText, bool ClearedOnUpdate);
}

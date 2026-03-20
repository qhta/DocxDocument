using System.Collections;

namespace DocumentModel.Interop.Core;

public interface CustomXMLValidationErrors: InteropCollection<CustomXMLValidationError>
{
  void Add(CustomXMLNode Node, string ErrorName, string ErrorText, bool ClearedOnUpdate);
}
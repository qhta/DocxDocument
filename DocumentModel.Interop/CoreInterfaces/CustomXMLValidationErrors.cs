using System.Collections;

namespace DocumentModel.Interop.Core;

public interface CustomXMLValidationErrors: InteropObject, IEnumerable
{
  int Count { get; }
  CustomXMLValidationError this[int Index] { get; }
  void Add(CustomXMLNode Node, string ErrorName, string ErrorText, bool ClearedOnUpdate);
  new IEnumerator GetEnumerator();
}
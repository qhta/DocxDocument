using System.Collections;

namespace DocumentModel.Interop.Core;

public interface CustomXMLValidationErrors: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  int Count { get; }
  CustomXMLValidationError this[int Index] { get; }
  void Add(CustomXMLNode Node, string ErrorName, string ErrorText, bool ClearedOnUpdate);
  new IEnumerator GetEnumerator();
}
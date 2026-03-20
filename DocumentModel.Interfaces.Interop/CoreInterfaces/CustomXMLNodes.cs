using System.Collections;

namespace DocumentModel.Interop.Core;

public interface CustomXMLNodes: InteropObject, IEnumerable
{
  int Count { get; }
  CustomXMLNode this[int Index] { get; }
  new IEnumerator GetEnumerator();
}
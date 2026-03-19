using System.Collections;

namespace DocumentModel.Interop.Core;

public interface CustomXMLNodes: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  int Count { get; }
  CustomXMLNode this[int Index] { get; }
  new IEnumerator GetEnumerator();
}
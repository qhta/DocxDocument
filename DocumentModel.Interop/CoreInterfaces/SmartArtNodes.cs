using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SmartArtNodes: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  new IEnumerator GetEnumerator();
  SmartArtNode this[object Index] { get; }
  object Parent { get; }
  int Count { get; }
  SmartArtNode Add();
}
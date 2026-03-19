using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SmartArtQuickStyles: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  new IEnumerator GetEnumerator();
  SmartArtQuickStyle this[object Index] { get; }
  object Parent { get; }
  int Count { get; }
}
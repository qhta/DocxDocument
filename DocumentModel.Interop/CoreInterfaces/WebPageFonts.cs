using System.Collections;

namespace DocumentModel.Interop.Core;

public interface WebPageFonts: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  int Count { get; }
  WebPageFont this[MsoCharacterSet Index] { get; }
  new IEnumerator GetEnumerator();
}
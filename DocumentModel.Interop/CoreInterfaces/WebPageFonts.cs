using System.Collections;

namespace DocumentModel.Interop.Core;

public interface WebPageFonts: InteropObject, IEnumerable
{
  int Count { get; }
  WebPageFont this[MsoCharacterSet Index] { get; }
  new IEnumerator GetEnumerator();
}
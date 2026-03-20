using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ThemeFonts: InteropObject, IEnumerable
{
  int Count { get; }
  ThemeFont Item(MsoFontLanguageIndex Index);
  new IEnumerator GetEnumerator();
}
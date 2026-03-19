using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ThemeFonts: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  int Count { get; }
  ThemeFont Item(MsoFontLanguageIndex Index);
  new IEnumerator GetEnumerator();
}
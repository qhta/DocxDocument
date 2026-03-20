using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ThemeFonts: InteropCollection<ThemeFont>
{
  ThemeFont Item(MsoFontLanguageIndex Index);
}
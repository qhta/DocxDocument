using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ThemeFonts: InteropCollection<ThemeFont>
{
  public ThemeFont Item(MsoFontLanguageIndex Index);
}

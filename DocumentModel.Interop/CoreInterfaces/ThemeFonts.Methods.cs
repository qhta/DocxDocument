using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface ThemeFonts
{
  public ThemeFont Item(MsoFontLanguageIndex Index);
}

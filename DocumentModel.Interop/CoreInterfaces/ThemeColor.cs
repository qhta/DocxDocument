using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface ThemeColor: InteropObject
{
  public int RGB { get; set; }
  public MsoThemeColorSchemeIndex ThemeColorSchemeIndex { get; }
}

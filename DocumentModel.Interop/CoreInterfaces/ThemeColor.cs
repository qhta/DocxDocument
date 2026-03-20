using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ThemeColor: InteropObject
{
  public int RGB { get; set; }
  public MsoThemeColorSchemeIndex ThemeColorSchemeIndex { get; }
}

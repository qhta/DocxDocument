using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ThemeColor: InteropObject
{
  int RGB { get; set; }
  MsoThemeColorSchemeIndex ThemeColorSchemeIndex { get; }
}
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ThemeColor: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  int RGB { get; set; }
  object Parent { get; }
  MsoThemeColorSchemeIndex ThemeColorSchemeIndex { get; }
}
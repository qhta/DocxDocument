
namespace DocumentModel.Interop.Core;

public interface OfficeTheme: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  ThemeColorScheme ThemeColorScheme { get; }
  ThemeFontScheme ThemeFontScheme { get; }
  ThemeEffectScheme ThemeEffectScheme { get; }
}
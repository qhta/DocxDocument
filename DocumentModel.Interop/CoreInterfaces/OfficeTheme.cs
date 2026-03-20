
namespace DocumentModel.Interop.Core;

public interface OfficeTheme: InteropObject
{
  ThemeColorScheme ThemeColorScheme { get; }
  ThemeFontScheme ThemeFontScheme { get; }
  ThemeEffectScheme ThemeEffectScheme { get; }
}
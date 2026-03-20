
namespace DocumentModel.Interop.Core;

public partial interface OfficeTheme: InteropObject
{
  public ThemeColorScheme ThemeColorScheme { get; }
  public ThemeFontScheme ThemeFontScheme { get; }
  public ThemeEffectScheme ThemeEffectScheme { get; }
}

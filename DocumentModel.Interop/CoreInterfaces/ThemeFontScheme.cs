
namespace DocumentModel.Interop.Core;

public partial interface ThemeFontScheme: InteropObject
{
  public ThemeFonts MinorFont { get; }
  public ThemeFonts MajorFont { get; }
}

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class Color
{
  public bool ShouldSerializeVal() => Val.HasValue;
  public bool ShouldSerializeThemeColor() => ThemeColor.HasValue;
  public bool ShouldSerializeThemeTint() => ThemeTint.HasValue;
  public bool ShouldSerializeThemeShade() => ThemeShade.HasValue;
}

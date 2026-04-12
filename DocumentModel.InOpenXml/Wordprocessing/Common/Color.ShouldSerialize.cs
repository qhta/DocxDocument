namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Color
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeThemeColor() => ThemeColor is not null;
  public bool ShouldSerializeThemeTint() => ThemeTint is not null;
  public bool ShouldSerializeThemeShade() => ThemeShade is not null;
}

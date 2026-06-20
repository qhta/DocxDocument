namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Color
{
  public bool ShouldSerializeVal() => Val is not null && ShouldSerialize(Val);
  public bool ShouldSerializeThemeColor() => ThemeColor is not null && ShouldSerialize(ThemeColor);
  public bool ShouldSerializeThemeTint() => ThemeTint is not null && ShouldSerialize(ThemeTint);
  public bool ShouldSerializeThemeShade() => ThemeShade is not null && ShouldSerialize(ThemeShade);
}

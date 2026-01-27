namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Underline
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeColor() => Color is not null;
  public bool ShouldSerializeThemeColor() => ThemeColor is not null;
  public bool ShouldSerializeThemeTint() => ThemeTint is not null;
  public bool ShouldSerializeThemeShade() => ThemeShade is not null;
}

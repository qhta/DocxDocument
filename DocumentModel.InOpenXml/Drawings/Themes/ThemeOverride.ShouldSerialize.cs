namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class ThemeOverride
{
  public bool ShouldSerializeColorScheme() => ColorScheme is not null;
  public bool ShouldSerializeFontScheme() => FontScheme is not null;
  public bool ShouldSerializeFormatScheme() => FormatScheme is not null;
}

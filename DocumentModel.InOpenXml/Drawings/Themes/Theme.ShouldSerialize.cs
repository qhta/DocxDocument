namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Theme
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeThemeId() => !String.IsNullOrEmpty(ThemeId);
  public bool ShouldSerializeThemeElements() => ThemeElements is not null;
  public bool ShouldSerializeObjectDefaults() => ObjectDefaults is not null;
  public bool ShouldSerializeExtraColorSchemeList() => ExtraColorSchemeList is not null;
  public bool ShouldSerializeCustomColorList() => CustomColorList is not null;
  public bool ShouldSerializeOfficeStyleSheetExtensionList() => OfficeStyleSheetExtensionList is not null;
}

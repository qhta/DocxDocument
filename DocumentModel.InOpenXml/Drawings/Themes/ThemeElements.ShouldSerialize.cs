namespace DocumentModel.Drawings;

public partial class ThemeElements
{
  public bool ShouldSerializeColorScheme() => ColorScheme is not null;
  public bool ShouldSerializeFontScheme() => FontScheme is not null;
  public bool ShouldSerializeFormatScheme() => FormatScheme is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}

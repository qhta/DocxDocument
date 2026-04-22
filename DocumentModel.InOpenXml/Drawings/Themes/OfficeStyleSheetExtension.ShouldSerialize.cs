namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class OfficeStyleSheetExtension
{
  public bool ShouldSerializeThemeFamily() => ThemeFamily is not null;
  public bool ShouldSerializeUri() => !String.IsNullOrEmpty(Uri);
  public bool ShouldSerializeUriString() => !String.IsNullOrEmpty(UriString);
}

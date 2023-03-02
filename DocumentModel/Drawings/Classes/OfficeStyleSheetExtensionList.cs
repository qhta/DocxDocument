namespace DocumentModel.Drawings;

/// <summary>
///   Defines the OfficeStyleSheetExtensionList Class.
/// </summary>
public record OfficeStyleSheetExtensionList
{
  public Collection<OfficeStyleSheetExtension>? OfficeStyleSheetExtensions { get; set; }
}
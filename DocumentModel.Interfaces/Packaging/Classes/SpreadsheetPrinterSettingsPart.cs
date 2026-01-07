namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SpreadsheetPrinterSettingsPart
/// </summary>
public interface SpreadsheetPrinterSettingsPart: OpenXmlPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}
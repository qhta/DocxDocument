namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SpreadsheetPrinterSettingsPart
/// </summary>
public record SpreadsheetPrinterSettingsPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}
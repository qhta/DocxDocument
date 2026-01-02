namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SpreadsheetPrinterSettingsPart
/// </summary>
public class SpreadsheetPrinterSettingsPart: ModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}
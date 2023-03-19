namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SpreadsheetPrinterSettingsPart
/// </summary>
public class SpreadsheetPrinterSettingsPart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}
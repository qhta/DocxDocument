namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SpreadsheetPrinterSettingsPart
/// </summary>
public interface SpreadsheetPrinterSettingsPart: IModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}
namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SpreadsheetPrinterSettingsPart
/// </summary>
public partial interface SpreadsheetPrinterSettingsPart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}

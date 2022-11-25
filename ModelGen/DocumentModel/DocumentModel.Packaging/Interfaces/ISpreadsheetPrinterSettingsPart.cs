namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SpreadsheetPrinterSettingsPart
/// </summary>
public interface ISpreadsheetPrinterSettingsPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
}

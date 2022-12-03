namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SpreadsheetPrinterSettingsPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.spreadsheetml.printerSettings")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings")]
public interface SpreadsheetPrinterSettingsPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}

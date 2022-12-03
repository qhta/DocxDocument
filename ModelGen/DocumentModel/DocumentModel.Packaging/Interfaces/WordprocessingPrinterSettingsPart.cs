namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordprocessingPrinterSettingsPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.wordprocessingml.printerSettings")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings")]
public interface WordprocessingPrinterSettingsPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}

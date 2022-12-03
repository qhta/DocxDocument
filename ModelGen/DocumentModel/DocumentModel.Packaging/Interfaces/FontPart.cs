namespace DocumentModel.Packaging;

/// <summary>
/// Defines the FontPart
/// </summary>
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/font")]
public interface FontPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? RelationshipType { get ; set; }
  
}

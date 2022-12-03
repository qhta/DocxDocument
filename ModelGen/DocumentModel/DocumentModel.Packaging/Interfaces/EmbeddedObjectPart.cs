namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedObjectPart
/// </summary>
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject")]
public interface EmbeddedObjectPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? RelationshipType { get ; set; }
  
}

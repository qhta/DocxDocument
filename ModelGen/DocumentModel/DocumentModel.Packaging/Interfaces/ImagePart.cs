namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ImagePart
/// </summary>
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image")]
public interface ImagePart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? RelationshipType { get ; set; }
  
}

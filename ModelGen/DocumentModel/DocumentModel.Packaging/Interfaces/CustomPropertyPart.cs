namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomPropertyPart
/// </summary>
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty")]
public interface CustomPropertyPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? RelationshipType { get ; set; }
  
}

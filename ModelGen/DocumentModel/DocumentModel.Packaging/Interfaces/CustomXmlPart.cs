namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomXmlPart
/// </summary>
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml")]
[PartConstraint(typeof(DocumentModel.Packaging.CustomXmlPropertiesPart), false, false)]
public interface CustomXmlPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? RelationshipType { get ; set; }
  
}

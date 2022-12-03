namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VbaProjectPart
/// </summary>
[ContentMime("application/vnd.ms-office.vbaProject")]
[RelationshipUri("http://schemas.microsoft.com/office/2006/relationships/vbaProject")]
[PartConstraint(typeof(DocumentModel.Packaging.VbaDataPart), false, false)]
public interface VbaProjectPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}

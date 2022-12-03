namespace DocumentModel.Packaging;

/// <summary>
/// Defines the Model3DReferenceRelationshipPart
/// </summary>
[ContentMime("model/gltf-binary")]
[RelationshipUri("http://schemas.microsoft.com/office/2017/06/relationships/model3d")]
public interface Model3DReferenceRelationshipPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}

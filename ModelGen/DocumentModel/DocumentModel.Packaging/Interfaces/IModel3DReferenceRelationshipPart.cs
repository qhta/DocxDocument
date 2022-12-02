namespace DocumentModel.Packaging;

/// <summary>
/// Defines the Model3DReferenceRelationshipPart
/// </summary>
public interface IModel3DReferenceRelationshipPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}

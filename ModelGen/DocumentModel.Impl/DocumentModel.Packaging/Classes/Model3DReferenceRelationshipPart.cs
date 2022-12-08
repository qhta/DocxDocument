namespace DocumentModel.Packaging;

/// <summary>
/// Defines the Model3DReferenceRelationshipPart
/// </summary>
public class Model3DReferenceRelationshipPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, Model3DReferenceRelationshipPart
{
  public new DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}

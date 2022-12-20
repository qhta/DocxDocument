namespace DocumentModel.Packaging;

/// <summary>
/// Defines the Model3DReferenceRelationshipPart
/// </summary>
public partial class Model3DReferenceRelationshipPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, Model3DReferenceRelationshipPart
{
  public new DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Model3DReferenceRelationshipPartImpl(): base() {}
  
  public Model3DReferenceRelationshipPartImpl(DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}

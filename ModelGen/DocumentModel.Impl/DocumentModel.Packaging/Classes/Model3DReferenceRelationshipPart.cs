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
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}

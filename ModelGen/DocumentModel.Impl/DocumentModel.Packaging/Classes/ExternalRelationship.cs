namespace DocumentModel.Packaging;

/// <summary>
/// Represents an external relationship.
/// </summary>
public partial class ExternalRelationshipImpl: DocumentModel.Packaging.ReferenceRelationshipImpl, ExternalRelationship
{
  public new DocumentFormat.OpenXml.Packaging.ExternalRelationship? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ExternalRelationship?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ExternalRelationshipImpl(): base() {}
  
  public ExternalRelationshipImpl(DocumentFormat.OpenXml.Packaging.ExternalRelationship openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
}

namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedObjectPart
/// </summary>
public partial class EmbeddedObjectPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, EmbeddedObjectPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public EmbeddedObjectPartImpl(): base() {}
  
  public EmbeddedObjectPartImpl(DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}

namespace DocumentModel.Packaging;

/// <summary>
/// Defines the LegacyDiagramTextPart
/// </summary>
public partial class LegacyDiagramTextPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, LegacyDiagramTextPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public LegacyDiagramTextPartImpl(): base() {}
  
  public LegacyDiagramTextPartImpl(DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart openXmlElement): base(openXmlElement)
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

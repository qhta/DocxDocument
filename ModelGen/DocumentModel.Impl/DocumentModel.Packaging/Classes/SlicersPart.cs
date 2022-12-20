namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlicersPart
/// </summary>
public partial class SlicersPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, SlicersPart
{
  public new DocumentFormat.OpenXml.Packaging.SlicersPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.SlicersPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SlicersPartImpl(): base() {}
  
  public SlicersPartImpl(DocumentFormat.OpenXml.Packaging.SlicersPart openXmlElement): base(openXmlElement)
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

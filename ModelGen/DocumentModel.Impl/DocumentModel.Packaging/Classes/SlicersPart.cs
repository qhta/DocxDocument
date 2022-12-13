namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlicersPart
/// </summary>
public class SlicersPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, SlicersPart
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
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.SlicersPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.SlicersPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}

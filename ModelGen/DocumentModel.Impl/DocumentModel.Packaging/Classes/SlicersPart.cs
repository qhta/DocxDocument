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
  
  public override String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.SlicersPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.SlicersPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}

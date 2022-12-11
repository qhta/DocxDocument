namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideSyncDataPart
/// </summary>
public class SlideSyncDataPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, SlideSyncDataPart
{
  public new DocumentFormat.OpenXml.Packaging.SlideSyncDataPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.SlideSyncDataPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SlideSyncDataPartImpl(): base() {}
  
  public SlideSyncDataPartImpl(DocumentFormat.OpenXml.Packaging.SlideSyncDataPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.SlideSyncDataPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.SlideSyncDataPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Structured Document Tag End Character Properties.
/// </summary>
public class SdtEndCharPropertiesImpl: ModelElementImpl, SdtEndCharProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SdtEndCharPropertiesImpl(): base() {}
  
  public SdtEndCharPropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public RunProperties? RunProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

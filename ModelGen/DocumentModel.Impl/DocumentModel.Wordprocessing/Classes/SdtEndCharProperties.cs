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
  
  public Collection<RunProperties>? RunPropertieses
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

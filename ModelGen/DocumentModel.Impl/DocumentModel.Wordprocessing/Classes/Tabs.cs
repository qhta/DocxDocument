namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Tabs Class.
/// </summary>
public class TabsImpl: ModelElementImpl, Tabs
{
  public DocumentFormat.OpenXml.Wordprocessing.Tabs? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Tabs?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<TabStop>? TabStops
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

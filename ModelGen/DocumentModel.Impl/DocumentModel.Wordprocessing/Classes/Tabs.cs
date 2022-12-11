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
  
  public TabsImpl(): base() {}
  
  public TabsImpl(DocumentFormat.OpenXml.Wordprocessing.Tabs openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public TabStop? TabStop
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

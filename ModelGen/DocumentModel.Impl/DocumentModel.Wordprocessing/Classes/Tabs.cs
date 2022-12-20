namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Tabs Class.
/// </summary>
public partial class TabsImpl: ModelElementImpl, Tabs
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
  
  public DocumentModel.Wordprocessing.TabStop? TabStop
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TabStop>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TabStopImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TabStop>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TabStopImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

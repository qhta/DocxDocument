namespace DocumentModel.Wordprocessing;

/// <summary>
/// Caption Settings.
/// </summary>
public class CaptionsImpl: ModelElementImpl, Captions
{
  public DocumentFormat.OpenXml.Wordprocessing.Captions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Captions?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CaptionsImpl(): base() {}
  
  public CaptionsImpl(DocumentFormat.OpenXml.Wordprocessing.Captions openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Wordprocessing.Caption? Caption
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Caption>();
        if (item != null)
          return new DocumentModel.Wordprocessing.CaptionImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Caption>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.CaptionImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.AutoCaptions? AutoCaptions
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoCaptions>();
        if (item != null)
          return new DocumentModel.Wordprocessing.AutoCaptionsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoCaptions>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.AutoCaptionsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

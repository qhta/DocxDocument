namespace DocumentModel.Wordprocessing;

/// <summary>
/// Automatic Captioning Settings.
/// </summary>
public partial class AutoCaptionsImpl: ModelElementImpl, AutoCaptions
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.AutoCaptions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.AutoCaptions?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public AutoCaptionsImpl(): base() {}
  
  public AutoCaptionsImpl(DocumentFormat.OpenXml.Wordprocessing.AutoCaptions openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Wordprocessing.AutoCaption? AutoCaption
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoCaption>();
        if (item != null)
          return new DocumentModel.Wordprocessing.AutoCaptionImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoCaption>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.AutoCaptionImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

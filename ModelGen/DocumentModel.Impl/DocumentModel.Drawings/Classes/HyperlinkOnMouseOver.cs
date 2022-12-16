namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkOnMouseOver Class.
/// </summary>
public class HyperlinkOnMouseOverImpl: DocumentModel.Drawings.HyperlinkTypeImpl, HyperlinkOnMouseOver
{
  public new DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HyperlinkOnMouseOverImpl(): base() {}
  
  public HyperlinkOnMouseOverImpl(DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.EmbeddedWavAudioFileType? HyperlinkSound
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType>();
        if (item != null)
          return new DocumentModel.Drawings.EmbeddedWavAudioFileTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.EmbeddedWavAudioFileTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public new DocumentModel.Drawings.HyperlinkExtensionList? HyperlinkExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.HyperlinkExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.HyperlinkExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

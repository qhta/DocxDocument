namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkOnHover Class.
/// </summary>
public partial class HyperlinkOnHoverImpl: DocumentModel.Drawings.HyperlinkTypeImpl, HyperlinkOnHover
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Drawing.HyperlinkOnHover? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.HyperlinkOnHover?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public HyperlinkOnHoverImpl(): base() {}
  
  public HyperlinkOnHoverImpl(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover openXmlElement): base(openXmlElement)
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

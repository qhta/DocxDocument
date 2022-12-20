namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkType Class.
/// </summary>
public partial class HyperlinkTypeImpl: ModelElementImpl, HyperlinkType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.HyperlinkType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.HyperlinkType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public HyperlinkTypeImpl(): base() {}
  
  public HyperlinkTypeImpl(DocumentFormat.OpenXml.Drawing.HyperlinkType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// relationship identifier to find target URI
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// In case the url is invalid so we can't create a relationship, we'll save it here, r:id will point to a NULL one
  /// </summary>
  public String? InvalidUrl
  {
    get => (System.String?)OpenXmlElement?.InvalidUrl?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InvalidUrl = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Action to take, it may still need r:id to specify an action target
  /// </summary>
  public String? Action
  {
    get => (System.String?)OpenXmlElement?.Action?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Action = (System.String?)value;
    }
  }
  
  /// <summary>
  /// target frame for navigating to the URI
  /// </summary>
  public String? TargetFrame
  {
    get => (System.String?)OpenXmlElement?.TargetFrame?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TargetFrame = (System.String?)value;
    }
  }
  
  /// <summary>
  /// tooltip for display
  /// </summary>
  public String? Tooltip
  {
    get => (System.String?)OpenXmlElement?.Tooltip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Tooltip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// whether to add this URI to the history when navigating to it
  /// </summary>
  public Boolean? History
  {
    get => (System.Boolean?)OpenXmlElement?.History?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.History = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Whether to highlight it when click on a shape
  /// </summary>
  public Boolean? HighlightClick
  {
    get => (System.Boolean?)OpenXmlElement?.HighlightClick?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HighlightClick = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Whether to stop previous sound when click on it
  /// </summary>
  public Boolean? EndSound
  {
    get => (System.Boolean?)OpenXmlElement?.EndSound?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EndSound = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Sound to play..
  /// </summary>
  public virtual DocumentModel.Drawings.EmbeddedWavAudioFileType? HyperlinkSound
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
  
  /// <summary>
  /// Future extensions..
  /// </summary>
  public virtual DocumentModel.Drawings.HyperlinkExtensionList? HyperlinkExtensionList
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

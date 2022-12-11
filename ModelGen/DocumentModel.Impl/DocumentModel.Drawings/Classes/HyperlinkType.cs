namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkType Class.
/// </summary>
public class HyperlinkTypeImpl: ModelElementImpl, HyperlinkType
{
  public DocumentFormat.OpenXml.Drawing.HyperlinkType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.HyperlinkType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get => (String?)OpenXmlElement?.Id?.Value;
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
    get => (String?)OpenXmlElement?.InvalidUrl?.Value;
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
    get => (String?)OpenXmlElement?.Action?.Value;
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
    get => (String?)OpenXmlElement?.TargetFrame?.Value;
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
    get => (String?)OpenXmlElement?.Tooltip?.Value;
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
    get => (Boolean?)OpenXmlElement?.History?.Value;
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
    get => (Boolean?)OpenXmlElement?.HighlightClick?.Value;
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
    get => (Boolean?)OpenXmlElement?.EndSound?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EndSound = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Sound to play..
  /// </summary>
  public virtual EmbeddedWavAudioFileType? HyperlinkSound
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Future extensions..
  /// </summary>
  public virtual HyperlinkExtensionList? HyperlinkExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

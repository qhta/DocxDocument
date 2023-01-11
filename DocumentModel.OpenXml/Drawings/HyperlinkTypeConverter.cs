namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HyperlinkType Class.
/// </summary>
public static class HyperlinkTypeConverter
{
  /// <summary>
  /// relationship identifier to find target URI
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// In case the url is invalid so we can't create a relationship, we'll save it here, r:id will point to a NULL one
  /// </summary>
  public static String? GetInvalidUrl(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement)
  {
    return openXmlElement?.InvalidUrl?.Value;
  }
  
  public static void SetInvalidUrl(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InvalidUrl = new StringValue { Value = value };
      else
        openXmlElement.InvalidUrl = null;
  }
  
  /// <summary>
  /// Action to take, it may still need r:id to specify an action target
  /// </summary>
  public static String? GetAction(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement)
  {
    return openXmlElement?.Action?.Value;
  }
  
  public static void SetAction(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Action = new StringValue { Value = value };
      else
        openXmlElement.Action = null;
  }
  
  /// <summary>
  /// target frame for navigating to the URI
  /// </summary>
  public static String? GetTargetFrame(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement)
  {
    return openXmlElement?.TargetFrame?.Value;
  }
  
  public static void SetTargetFrame(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TargetFrame = new StringValue { Value = value };
      else
        openXmlElement.TargetFrame = null;
  }
  
  /// <summary>
  /// tooltip for display
  /// </summary>
  public static String? GetTooltip(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement)
  {
    return openXmlElement?.Tooltip?.Value;
  }
  
  public static void SetTooltip(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tooltip = new StringValue { Value = value };
      else
        openXmlElement.Tooltip = null;
  }
  
  /// <summary>
  /// whether to add this URI to the history when navigating to it
  /// </summary>
  public static Boolean? GetHistory(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement)
  {
    return openXmlElement?.History?.Value;
  }
  
  public static void SetHistory(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.History = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.History = null;
  }
  
  /// <summary>
  /// Whether to highlight it when click on a shape
  /// </summary>
  public static Boolean? GetHighlightClick(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement)
  {
    return openXmlElement?.HighlightClick?.Value;
  }
  
  public static void SetHighlightClick(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HighlightClick = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.HighlightClick = null;
  }
  
  /// <summary>
  /// Whether to stop previous sound when click on it
  /// </summary>
  public static Boolean? GetEndSound(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement)
  {
    return openXmlElement?.EndSound?.Value;
  }
  
  public static void SetEndSound(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EndSound = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.EndSound = null;
  }
  
  /// <summary>
  /// Sound to play..
  /// </summary>
  public static DocumentModel.Drawings.EmbeddedWavAudioFileType? GetHyperlinkSound(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkSound>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EmbeddedWavAudioFileTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHyperlinkSound(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement, DocumentModel.Drawings.EmbeddedWavAudioFileType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkSound>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.EmbeddedWavAudioFileTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HyperlinkSound>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Future extensions..
  /// </summary>
  public static DocumentModel.Drawings.HyperlinkExtensionList? GetHyperlinkExtensionList(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HyperlinkExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHyperlinkExtensionList(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement, DocumentModel.Drawings.HyperlinkExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.HyperlinkExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.HyperlinkType? CreateModelElement(DocumentFormat.OpenXml.Drawing.HyperlinkType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HyperlinkType();
      value.Id = GetId(openXmlElement);
      value.InvalidUrl = GetInvalidUrl(openXmlElement);
      value.Action = GetAction(openXmlElement);
      value.TargetFrame = GetTargetFrame(openXmlElement);
      value.Tooltip = GetTooltip(openXmlElement);
      value.History = GetHistory(openXmlElement);
      value.HighlightClick = GetHighlightClick(openXmlElement);
      value.EndSound = GetEndSound(openXmlElement);
      value.HyperlinkSound = GetHyperlinkSound(openXmlElement);
      value.HyperlinkExtensionList = GetHyperlinkExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.HyperlinkType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.HyperlinkType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

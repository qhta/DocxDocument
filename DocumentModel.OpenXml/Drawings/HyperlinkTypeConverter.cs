namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HyperlinkType Class.
/// </summary>
public static class HyperlinkTypeConverter
{
  /// <summary>
  /// relationship identifier to find target URI
  /// </summary>
  private static String? GetId(DXDraw.HyperlinkType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXDraw.HyperlinkType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// In case the url is invalid so we can't create a relationship, we'll save it here, r:id will point to a NULL one
  /// </summary>
  private static String? GetInvalidUrl(DXDraw.HyperlinkType openXmlElement)
  {
    return openXmlElement?.InvalidUrl?.Value;
  }
  
  private static void SetInvalidUrl(DXDraw.HyperlinkType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InvalidUrl = new StringValue { Value = value };
    else
      openXmlElement.InvalidUrl = null;
  }
  
  /// <summary>
  /// Action to take, it may still need r:id to specify an action target
  /// </summary>
  private static String? GetAction(DXDraw.HyperlinkType openXmlElement)
  {
    return openXmlElement?.Action?.Value;
  }
  
  private static void SetAction(DXDraw.HyperlinkType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Action = new StringValue { Value = value };
    else
      openXmlElement.Action = null;
  }
  
  /// <summary>
  /// target frame for navigating to the URI
  /// </summary>
  private static String? GetTargetFrame(DXDraw.HyperlinkType openXmlElement)
  {
    return openXmlElement?.TargetFrame?.Value;
  }
  
  private static void SetTargetFrame(DXDraw.HyperlinkType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.TargetFrame = new StringValue { Value = value };
    else
      openXmlElement.TargetFrame = null;
  }
  
  /// <summary>
  /// tooltip for display
  /// </summary>
  private static String? GetTooltip(DXDraw.HyperlinkType openXmlElement)
  {
    return openXmlElement?.Tooltip?.Value;
  }
  
  private static void SetTooltip(DXDraw.HyperlinkType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tooltip = new StringValue { Value = value };
    else
      openXmlElement.Tooltip = null;
  }
  
  /// <summary>
  /// whether to add this URI to the history when navigating to it
  /// </summary>
  private static Boolean? GetHistory(DXDraw.HyperlinkType openXmlElement)
  {
    return openXmlElement?.History?.Value;
  }
  
  private static void SetHistory(DXDraw.HyperlinkType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.History = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.History = null;
  }
  
  /// <summary>
  /// Whether to highlight it when click on a shape
  /// </summary>
  private static Boolean? GetHighlightClick(DXDraw.HyperlinkType openXmlElement)
  {
    return openXmlElement?.HighlightClick?.Value;
  }
  
  private static void SetHighlightClick(DXDraw.HyperlinkType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HighlightClick = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.HighlightClick = null;
  }
  
  /// <summary>
  /// Whether to stop previous sound when click on it
  /// </summary>
  private static Boolean? GetEndSound(DXDraw.HyperlinkType openXmlElement)
  {
    return openXmlElement?.EndSound?.Value;
  }
  
  private static void SetEndSound(DXDraw.HyperlinkType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.EndSound = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.EndSound = null;
  }
  
  /// <summary>
  /// Sound to play..
  /// </summary>
  private static DMDraws.EmbeddedWavAudioFileType? GetHyperlinkSound(DXDraw.HyperlinkType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HyperlinkSound>();
    if (itemElement != null)
      return DMXDraws.EmbeddedWavAudioFileTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlinkSound(DXDraw.HyperlinkType openXmlElement, DMDraws.EmbeddedWavAudioFileType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HyperlinkSound>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EmbeddedWavAudioFileTypeConverter.CreateOpenXmlElement<DXDraw.HyperlinkSound>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Future extensions..
  /// </summary>
  private static DMDraws.HyperlinkExtensionList? GetHyperlinkExtensionList(DXDraw.HyperlinkType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HyperlinkExtensionList>();
    if (itemElement != null)
      return DMXDraws.HyperlinkExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlinkExtensionList(DXDraw.HyperlinkType openXmlElement, DMDraws.HyperlinkExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HyperlinkExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HyperlinkExtensionListConverter.CreateOpenXmlElement<DXDraw.HyperlinkExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.HyperlinkType? CreateModelElement(DXDraw.HyperlinkType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.HyperlinkType();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.HyperlinkType? value)
    where OpenXmlElementType: DXDraw.HyperlinkType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetInvalidUrl(openXmlElement, value?.InvalidUrl);
      SetAction(openXmlElement, value?.Action);
      SetTargetFrame(openXmlElement, value?.TargetFrame);
      SetTooltip(openXmlElement, value?.Tooltip);
      SetHistory(openXmlElement, value?.History);
      SetHighlightClick(openXmlElement, value?.HighlightClick);
      SetEndSound(openXmlElement, value?.EndSound);
      SetHyperlinkSound(openXmlElement, value?.HyperlinkSound);
      SetHyperlinkExtensionList(openXmlElement, value?.HyperlinkExtensionList);
      return openXmlElement;
    }
    return default;
  }
}

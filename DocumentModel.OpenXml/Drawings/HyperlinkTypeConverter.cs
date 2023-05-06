namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HyperlinkType Class.
/// </summary>
public static class HyperlinkTypeConverter
{
  /// <summary>
  /// relationship identifier to find target URI
  /// </summary>
  private static String? GetId(DXD.HyperlinkType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXD.HyperlinkType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXD.HyperlinkType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// In case the url is invalid so we can't create a relationship, we'll save it here, r:id will point to a NULL one
  /// </summary>
  private static String? GetInvalidUrl(DXD.HyperlinkType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InvalidUrl);
  }
  
  private static bool CmpInvalidUrl(DXD.HyperlinkType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InvalidUrl, value, diffs, objName, "InvalidUrl");
  }
  
  private static void SetInvalidUrl(DXD.HyperlinkType openXmlElement, String? value)
  {
    openXmlElement.InvalidUrl = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Action to take, it may still need r:id to specify an action target
  /// </summary>
  private static String? GetAction(DXD.HyperlinkType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Action);
  }
  
  private static bool CmpAction(DXD.HyperlinkType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Action, value, diffs, objName, "Action");
  }
  
  private static void SetAction(DXD.HyperlinkType openXmlElement, String? value)
  {
    openXmlElement.Action = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// target frame for navigating to the URI
  /// </summary>
  private static String? GetTargetFrame(DXD.HyperlinkType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.TargetFrame);
  }
  
  private static bool CmpTargetFrame(DXD.HyperlinkType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.TargetFrame, value, diffs, objName, "TargetFrame");
  }
  
  private static void SetTargetFrame(DXD.HyperlinkType openXmlElement, String? value)
  {
    openXmlElement.TargetFrame = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tooltip for display
  /// </summary>
  private static String? GetTooltip(DXD.HyperlinkType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tooltip);
  }
  
  private static bool CmpTooltip(DXD.HyperlinkType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tooltip, value, diffs, objName, "Tooltip");
  }
  
  private static void SetTooltip(DXD.HyperlinkType openXmlElement, String? value)
  {
    openXmlElement.Tooltip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// whether to add this URI to the history when navigating to it
  /// </summary>
  private static Boolean? GetHistory(DXD.HyperlinkType openXmlElement)
  {
    return openXmlElement?.History?.Value;
  }
  
  private static bool CmpHistory(DXD.HyperlinkType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.History?.Value == value) return true;
    diffs?.Add(objName, "History", openXmlElement?.History?.Value, value);
    return false;
  }
  
  private static void SetHistory(DXD.HyperlinkType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.History = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.History = null;
  }
  
  /// <summary>
  /// Whether to highlight it when click on a shape
  /// </summary>
  private static Boolean? GetHighlightClick(DXD.HyperlinkType openXmlElement)
  {
    return openXmlElement?.HighlightClick?.Value;
  }
  
  private static bool CmpHighlightClick(DXD.HyperlinkType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HighlightClick?.Value == value) return true;
    diffs?.Add(objName, "HighlightClick", openXmlElement?.HighlightClick?.Value, value);
    return false;
  }
  
  private static void SetHighlightClick(DXD.HyperlinkType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HighlightClick = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.HighlightClick = null;
  }
  
  /// <summary>
  /// Whether to stop previous sound when click on it
  /// </summary>
  private static Boolean? GetEndSound(DXD.HyperlinkType openXmlElement)
  {
    return openXmlElement?.EndSound?.Value;
  }
  
  private static bool CmpEndSound(DXD.HyperlinkType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.EndSound?.Value == value) return true;
    diffs?.Add(objName, "EndSound", openXmlElement?.EndSound?.Value, value);
    return false;
  }
  
  private static void SetEndSound(DXD.HyperlinkType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.EndSound = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.EndSound = null;
  }
  
  /// <summary>
  /// Sound to play..
  /// </summary>
  private static DMD.EmbeddedWavAudioFileType? GetHyperlinkSound(DXD.HyperlinkType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HyperlinkSound>();
    if (element != null)
      return DMXD.EmbeddedWavAudioFileTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkSound(DXD.HyperlinkType openXmlElement, DMD.EmbeddedWavAudioFileType? value, DiffList? diffs, string? objName)
  {
    return DMXD.EmbeddedWavAudioFileTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkSound>(), value, diffs, objName);
  }
  
  private static void SetHyperlinkSound(DXD.HyperlinkType openXmlElement, DMD.EmbeddedWavAudioFileType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HyperlinkSound>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EmbeddedWavAudioFileTypeConverter.CreateOpenXmlElement<DXD.HyperlinkSound>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Future extensions..
  /// </summary>
  private static DMD.HyperlinkExtensionList? GetHyperlinkExtensionList(DXD.HyperlinkType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HyperlinkExtensionList>();
    if (element != null)
      return DMXD.HyperlinkExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkExtensionList(DXD.HyperlinkType openXmlElement, DMD.HyperlinkExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.HyperlinkExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkExtensionList>(), value, diffs, objName);
  }
  
  private static void SetHyperlinkExtensionList(DXD.HyperlinkType openXmlElement, DMD.HyperlinkExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HyperlinkExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HyperlinkExtensionListConverter.CreateOpenXmlElement<DXD.HyperlinkExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.HyperlinkType? CreateModelElement(DXD.HyperlinkType? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.HyperlinkType? openXmlElement, DMD.HyperlinkType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpInvalidUrl(openXmlElement, value.InvalidUrl, diffs, objName))
        ok = false;
      if (!CmpAction(openXmlElement, value.Action, diffs, objName))
        ok = false;
      if (!CmpTargetFrame(openXmlElement, value.TargetFrame, diffs, objName))
        ok = false;
      if (!CmpTooltip(openXmlElement, value.Tooltip, diffs, objName))
        ok = false;
      if (!CmpHistory(openXmlElement, value.History, diffs, objName))
        ok = false;
      if (!CmpHighlightClick(openXmlElement, value.HighlightClick, diffs, objName))
        ok = false;
      if (!CmpEndSound(openXmlElement, value.EndSound, diffs, objName))
        ok = false;
      if (!CmpHyperlinkSound(openXmlElement, value.HyperlinkSound, diffs, objName))
        ok = false;
      if (!CmpHyperlinkExtensionList(openXmlElement, value.HyperlinkExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.HyperlinkType value)
    where OpenXmlElementType: DXD.HyperlinkType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.HyperlinkType openXmlElement, DMD.HyperlinkType value)
  {
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
  }
}

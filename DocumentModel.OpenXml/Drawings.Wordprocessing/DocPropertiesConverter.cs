namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Drawing Object Non-Visual Properties.
/// </summary>
public static class DocPropertiesConverter
{
  /// <summary>
  /// Application defined unique identifier.
  /// </summary>
  private static UInt32? GetId(DXDrawW.DocProperties openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static bool CmpId(DXDrawW.DocProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Id?.Value == value;
  }
  
  private static void SetId(DXDrawW.DocProperties openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Name compatible with Object Model (non-unique).
  /// </summary>
  private static String? GetName(DXDrawW.DocProperties openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXDrawW.DocProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Name?.Value == value;
  }
  
  private static void SetName(DXDrawW.DocProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Description of the drawing element.
  /// </summary>
  private static String? GetDescription(DXDrawW.DocProperties openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }
  
  private static bool CmpDescription(DXDrawW.DocProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Description?.Value == value;
  }
  
  private static void SetDescription(DXDrawW.DocProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Description = new StringValue { Value = value };
    else
      openXmlElement.Description = null;
  }
  
  /// <summary>
  /// Flag determining to show or hide this element.
  /// </summary>
  private static Boolean? GetHidden(DXDrawW.DocProperties openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  private static bool CmpHidden(DXDrawW.DocProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Hidden?.Value == value;
  }
  
  private static void SetHidden(DXDrawW.DocProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Hidden = null;
  }
  
  /// <summary>
  /// Title
  /// </summary>
  private static String? GetTitle(DXDrawW.DocProperties openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static bool CmpTitle(DXDrawW.DocProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Title?.Value == value;
  }
  
  private static void SetTitle(DXDrawW.DocProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Hyperlink associated with clicking or selecting the element..
  /// </summary>
  private static DMDraws.HyperlinkOnClick? GetHyperlinkOnClick(DXDrawW.DocProperties openXmlElement)
  {
    return DMXDraws.HyperlinkOnClickConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.HyperlinkOnClick>());
  }
  
  private static bool CmpHyperlinkOnClick(DXDrawW.DocProperties openXmlElement, DMDraws.HyperlinkOnClick? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HyperlinkOnClickConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.HyperlinkOnClick>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHyperlinkOnClick(DXDrawW.DocProperties openXmlElement, DMDraws.HyperlinkOnClick? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HyperlinkOnClick>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HyperlinkOnClickConverter.CreateOpenXmlElement<DXDraw.HyperlinkOnClick>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hyperlink associated with hovering over the element..
  /// </summary>
  private static DMDraws.HyperlinkOnHover? GetHyperlinkOnHover(DXDrawW.DocProperties openXmlElement)
  {
    return DMXDraws.HyperlinkOnHoverConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.HyperlinkOnHover>());
  }
  
  private static bool CmpHyperlinkOnHover(DXDrawW.DocProperties openXmlElement, DMDraws.HyperlinkOnHover? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HyperlinkOnHoverConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.HyperlinkOnHover>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHyperlinkOnHover(DXDrawW.DocProperties openXmlElement, DMDraws.HyperlinkOnHover? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HyperlinkOnHover>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HyperlinkOnHoverConverter.CreateOpenXmlElement<DXDraw.HyperlinkOnHover>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Future extension.
  /// </summary>
  private static DMDraws.NonVisualDrawingPropertiesExtensionList? GetNonVisualDrawingPropertiesExtensionList(DXDrawW.DocProperties openXmlElement)
  {
    return DMXDraws.NonVisualDrawingPropertiesExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.NonVisualDrawingPropertiesExtensionList>());
  }
  
  private static bool CmpNonVisualDrawingPropertiesExtensionList(DXDrawW.DocProperties openXmlElement, DMDraws.NonVisualDrawingPropertiesExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.NonVisualDrawingPropertiesExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.NonVisualDrawingPropertiesExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualDrawingPropertiesExtensionList(DXDrawW.DocProperties openXmlElement, DMDraws.NonVisualDrawingPropertiesExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.NonVisualDrawingPropertiesExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.NonVisualDrawingPropertiesExtensionListConverter.CreateOpenXmlElement<DXDraw.NonVisualDrawingPropertiesExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsW.DocProperties? CreateModelElement(DXDrawW.DocProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsW.DocProperties();
      value.Id = GetId(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.Description = GetDescription(openXmlElement);
      value.Hidden = GetHidden(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.HyperlinkOnClick = GetHyperlinkOnClick(openXmlElement);
      value.HyperlinkOnHover = GetHyperlinkOnHover(openXmlElement);
      value.NonVisualDrawingPropertiesExtensionList = GetNonVisualDrawingPropertiesExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawW.DocProperties? openXmlElement, DMDrawsW.DocProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpDescription(openXmlElement, value.Description, diffs, objName))
        ok = false;
      if (!CmpHidden(openXmlElement, value.Hidden, diffs, objName))
        ok = false;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName))
        ok = false;
      if (!CmpHyperlinkOnClick(openXmlElement, value.HyperlinkOnClick, diffs, objName))
        ok = false;
      if (!CmpHyperlinkOnHover(openXmlElement, value.HyperlinkOnHover, diffs, objName))
        ok = false;
      if (!CmpNonVisualDrawingPropertiesExtensionList(openXmlElement, value.NonVisualDrawingPropertiesExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.DocProperties? value)
    where OpenXmlElementType: DXDrawW.DocProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetName(openXmlElement, value?.Name);
      SetDescription(openXmlElement, value?.Description);
      SetHidden(openXmlElement, value?.Hidden);
      SetTitle(openXmlElement, value?.Title);
      SetHyperlinkOnClick(openXmlElement, value?.HyperlinkOnClick);
      SetHyperlinkOnHover(openXmlElement, value?.HyperlinkOnHover);
      SetNonVisualDrawingPropertiesExtensionList(openXmlElement, value?.NonVisualDrawingPropertiesExtensionList);
      return openXmlElement;
    }
    return default;
  }
}

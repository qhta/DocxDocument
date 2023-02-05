namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the NonVisualDrawingProperties Class.
/// </summary>
public static class NonVisualDrawingPropertiesConverter
{
  /// <summary>
  /// Application defined unique identifier.
  /// </summary>
  private static UInt32? GetId(DXODraw.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXODraw.NonVisualDrawingProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXODraw.NonVisualDrawingProperties openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Name compatible with Object Model (non-unique).
  /// </summary>
  private static String? GetName(DXODraw.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXODraw.NonVisualDrawingProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Name?.Value == value) return true;
    diffs?.Add(objName, "Name", openXmlElement?.Name?.Value, value);
    return false;
  }
  
  private static void SetName(DXODraw.NonVisualDrawingProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Description of the drawing element.
  /// </summary>
  private static String? GetDescription(DXODraw.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }
  
  private static bool CmpDescription(DXODraw.NonVisualDrawingProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Description?.Value == value) return true;
    diffs?.Add(objName, "Description", openXmlElement?.Description?.Value, value);
    return false;
  }
  
  private static void SetDescription(DXODraw.NonVisualDrawingProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Description = new StringValue { Value = value };
    else
      openXmlElement.Description = null;
  }
  
  /// <summary>
  /// Flag determining to show or hide this element.
  /// </summary>
  private static Boolean? GetHidden(DXODraw.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  private static bool CmpHidden(DXODraw.NonVisualDrawingProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Hidden?.Value == value) return true;
    diffs?.Add(objName, "Hidden", openXmlElement?.Hidden?.Value, value);
    return false;
  }
  
  private static void SetHidden(DXODraw.NonVisualDrawingProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Hidden = null;
  }
  
  /// <summary>
  /// Title
  /// </summary>
  private static String? GetTitle(DXODraw.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static bool CmpTitle(DXODraw.NonVisualDrawingProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Title?.Value == value) return true;
    diffs?.Add(objName, "Title", openXmlElement?.Title?.Value, value);
    return false;
  }
  
  private static void SetTitle(DXODraw.NonVisualDrawingProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Hyperlink associated with clicking or selecting the element..
  /// </summary>
  private static DMDraws.HyperlinkOnClick? GetHyperlinkOnClick(DXODraw.NonVisualDrawingProperties openXmlElement)
  {
    return DMXDraws.HyperlinkOnClickConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.HyperlinkOnClick>());
  }
  
  private static bool CmpHyperlinkOnClick(DXODraw.NonVisualDrawingProperties openXmlElement, DMDraws.HyperlinkOnClick? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HyperlinkOnClickConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.HyperlinkOnClick>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHyperlinkOnClick(DXODraw.NonVisualDrawingProperties openXmlElement, DMDraws.HyperlinkOnClick? value)
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
  private static DMDraws.HyperlinkOnHover? GetHyperlinkOnHover(DXODraw.NonVisualDrawingProperties openXmlElement)
  {
    return DMXDraws.HyperlinkOnHoverConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.HyperlinkOnHover>());
  }
  
  private static bool CmpHyperlinkOnHover(DXODraw.NonVisualDrawingProperties openXmlElement, DMDraws.HyperlinkOnHover? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HyperlinkOnHoverConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.HyperlinkOnHover>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHyperlinkOnHover(DXODraw.NonVisualDrawingProperties openXmlElement, DMDraws.HyperlinkOnHover? value)
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
  private static DMDraws.NonVisualDrawingPropertiesExtensionList? GetNonVisualDrawingPropertiesExtensionList(DXODraw.NonVisualDrawingProperties openXmlElement)
  {
    return DMXDraws.NonVisualDrawingPropertiesExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.NonVisualDrawingPropertiesExtensionList>());
  }
  
  private static bool CmpNonVisualDrawingPropertiesExtensionList(DXODraw.NonVisualDrawingProperties openXmlElement, DMDraws.NonVisualDrawingPropertiesExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.NonVisualDrawingPropertiesExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.NonVisualDrawingPropertiesExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualDrawingPropertiesExtensionList(DXODraw.NonVisualDrawingProperties openXmlElement, DMDraws.NonVisualDrawingPropertiesExtensionList? value)
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
  
  public static DMDrawsO.NonVisualDrawingProperties? CreateModelElement(DXODraw.NonVisualDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsO.NonVisualDrawingProperties();
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
  
  public static bool CompareModelElement(DXODraw.NonVisualDrawingProperties? openXmlElement, DMDrawsO.NonVisualDrawingProperties? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.NonVisualDrawingProperties? value)
    where OpenXmlElementType: DXODraw.NonVisualDrawingProperties, new()
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

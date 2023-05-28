namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the NonVisualDrawingProperties Class.
/// </summary>
public static class NonVisualDrawingPropertiesConverter
{
  /// <summary>
  /// Application defined unique identifier.
  /// </summary>
  private static UInt32? GetId(DXOD.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXOD.NonVisualDrawingProperties openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "AnnotationId", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXOD.NonVisualDrawingProperties openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Name compatible with Object Model (non-unique).
  /// </summary>
  private static String? GetName(DXOD.NonVisualDrawingProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXOD.NonVisualDrawingProperties openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXOD.NonVisualDrawingProperties openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Description of the drawing element.
  /// </summary>
  private static String? GetDescription(DXOD.NonVisualDrawingProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Description);
  }
  
  private static bool CmpDescription(DXOD.NonVisualDrawingProperties openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Description, value, diffs, objName, "Description");
  }
  
  private static void SetDescription(DXOD.NonVisualDrawingProperties openXmlElement, String? value)
  {
    openXmlElement.Description = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Flag determining to show or hide this element.
  /// </summary>
  private static Boolean? GetHidden(DXOD.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  private static bool CmpHidden(DXOD.NonVisualDrawingProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Hidden?.Value == value) return true;
    diffs?.Add(objName, "GlyphHidden", openXmlElement?.Hidden?.Value, value);
    return false;
  }
  
  private static void SetHidden(DXOD.NonVisualDrawingProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Hidden = null;
  }
  
  /// <summary>
  /// Title
  /// </summary>
  private static String? GetTitle(DXOD.NonVisualDrawingProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Title);
  }
  
  private static bool CmpTitle(DXOD.NonVisualDrawingProperties openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Title, value, diffs, objName, "Title");
  }
  
  private static void SetTitle(DXOD.NonVisualDrawingProperties openXmlElement, String? value)
  {
    openXmlElement.Title = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Hyperlink associated with clicking or selecting the element..
  /// </summary>
  private static DMD.HyperlinkOnClick? GetHyperlinkOnClick(DXOD.NonVisualDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HyperlinkOnClick>();
    if (element != null)
      return DMXD.HyperlinkOnClickConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkOnClick(DXOD.NonVisualDrawingProperties openXmlElement, DMD.HyperlinkOnClick? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HyperlinkOnClickConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkOnClick>(), value, diffs, objName, propName);
  }
  
  private static void SetHyperlinkOnClick(DXOD.NonVisualDrawingProperties openXmlElement, DMD.HyperlinkOnClick? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HyperlinkOnClick>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HyperlinkOnClickConverter.CreateOpenXmlElement<DXD.HyperlinkOnClick>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hyperlink associated with hovering over the element..
  /// </summary>
  private static DMD.HyperlinkOnHover? GetHyperlinkOnHover(DXOD.NonVisualDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HyperlinkOnHover>();
    if (element != null)
      return DMXD.HyperlinkOnHoverConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkOnHover(DXOD.NonVisualDrawingProperties openXmlElement, DMD.HyperlinkOnHover? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HyperlinkOnHoverConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkOnHover>(), value, diffs, objName, propName);
  }
  
  private static void SetHyperlinkOnHover(DXOD.NonVisualDrawingProperties openXmlElement, DMD.HyperlinkOnHover? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HyperlinkOnHover>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HyperlinkOnHoverConverter.CreateOpenXmlElement<DXD.HyperlinkOnHover>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Future extension.
  /// </summary>
  private static DMD.NonVisualDrawingPropertiesExtensionList? GetNonVisualDrawingPropertiesExtensionList(DXOD.NonVisualDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.NonVisualDrawingPropertiesExtensionList>();
    if (element != null)
      return DMXD.NonVisualDrawingPropertiesExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingPropertiesExtensionList(DXOD.NonVisualDrawingProperties openXmlElement, DMD.NonVisualDrawingPropertiesExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.NonVisualDrawingPropertiesExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.NonVisualDrawingPropertiesExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetNonVisualDrawingPropertiesExtensionList(DXOD.NonVisualDrawingProperties openXmlElement, DMD.NonVisualDrawingPropertiesExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.NonVisualDrawingPropertiesExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.NonVisualDrawingPropertiesExtensionListConverter.CreateOpenXmlElement<DXD.NonVisualDrawingPropertiesExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDO.NonVisualDrawingProperties? CreateModelElement(DXOD.NonVisualDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDO.NonVisualDrawingProperties();
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
  
  public static bool CompareModelElement(DXOD.NonVisualDrawingProperties? openXmlElement, DMDO.NonVisualDrawingProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpName(openXmlElement, value.Name, diffs, objName, propName))
        ok = false;
      if (!CmpDescription(openXmlElement, value.Description, diffs, objName, propName))
        ok = false;
      if (!CmpHidden(openXmlElement, value.Hidden, diffs, objName, propName))
        ok = false;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName, propName))
        ok = false;
      if (!CmpHyperlinkOnClick(openXmlElement, value.HyperlinkOnClick, diffs, objName, propName))
        ok = false;
      if (!CmpHyperlinkOnHover(openXmlElement, value.HyperlinkOnHover, diffs, objName, propName))
        ok = false;
      if (!CmpNonVisualDrawingPropertiesExtensionList(openXmlElement, value.NonVisualDrawingPropertiesExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDO.NonVisualDrawingProperties value)
    where OpenXmlElementType: DXOD.NonVisualDrawingProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOD.NonVisualDrawingProperties openXmlElement, DMDO.NonVisualDrawingProperties value)
  {
    SetId(openXmlElement, value?.Id);
    SetName(openXmlElement, value?.Name);
    SetDescription(openXmlElement, value?.Description);
    SetHidden(openXmlElement, value?.Hidden);
    SetTitle(openXmlElement, value?.Title);
    SetHyperlinkOnClick(openXmlElement, value?.HyperlinkOnClick);
    SetHyperlinkOnHover(openXmlElement, value?.HyperlinkOnHover);
    SetNonVisualDrawingPropertiesExtensionList(openXmlElement, value?.NonVisualDrawingPropertiesExtensionList);
  }
}

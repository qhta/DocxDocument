namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the NonVisualDrawingProperties Class.
/// </summary>
public static class NonVisualDrawingPropertiesConverter
{
  /// <summary>
  /// Application defined unique identifier.
  /// </summary>
  private static UInt32? GetId(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Name compatible with Object Model (non-unique).
  /// </summary>
  private static String? GetName(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Name?.Value == value) return true;
    diffs?.Add(objName, "Name", openXmlElement?.Name?.Value, value);
    return false;
  }
  
  private static void SetName(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Description of the drawing element.
  /// </summary>
  private static String? GetDescription(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }
  
  private static bool CmpDescription(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Description?.Value == value) return true;
    diffs?.Add(objName, "Description", openXmlElement?.Description?.Value, value);
    return false;
  }
  
  private static void SetDescription(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Description = new StringValue { Value = value };
    else
      openXmlElement.Description = null;
  }
  
  /// <summary>
  /// Flag determining to show or hide this element.
  /// </summary>
  private static Boolean? GetHidden(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  private static bool CmpHidden(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Hidden?.Value == value) return true;
    diffs?.Add(objName, "Hidden", openXmlElement?.Hidden?.Value, value);
    return false;
  }
  
  private static void SetHidden(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Hidden = null;
  }
  
  /// <summary>
  /// Title
  /// </summary>
  private static String? GetTitle(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static bool CmpTitle(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Title?.Value == value) return true;
    diffs?.Add(objName, "Title", openXmlElement?.Title?.Value, value);
    return false;
  }
  
  private static void SetTitle(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Hyperlink associated with clicking or selecting the element..
  /// </summary>
  private static DMDraws.HyperlinkOnClick? GetHyperlinkOnClick(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.HyperlinkOnClick>();
    if (element != null)
      return DMXDraws.HyperlinkOnClickConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkOnClick(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement, DMDraws.HyperlinkOnClick? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HyperlinkOnClickConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.HyperlinkOnClick>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHyperlinkOnClick(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement, DMDraws.HyperlinkOnClick? value)
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
  private static DMDraws.HyperlinkOnHover? GetHyperlinkOnHover(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.HyperlinkOnHover>();
    if (element != null)
      return DMXDraws.HyperlinkOnHoverConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkOnHover(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement, DMDraws.HyperlinkOnHover? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HyperlinkOnHoverConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.HyperlinkOnHover>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHyperlinkOnHover(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement, DMDraws.HyperlinkOnHover? value)
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
  private static DMDraws.NonVisualDrawingPropertiesExtensionList? GetNonVisualDrawingPropertiesExtensionList(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.NonVisualDrawingPropertiesExtensionList>();
    if (element != null)
      return DMXDraws.NonVisualDrawingPropertiesExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingPropertiesExtensionList(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement, DMDraws.NonVisualDrawingPropertiesExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.NonVisualDrawingPropertiesExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.NonVisualDrawingPropertiesExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualDrawingPropertiesExtensionList(DXO2010DrawDgm.NonVisualDrawingProperties openXmlElement, DMDraws.NonVisualDrawingPropertiesExtensionList? value)
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
  
  public static DocumentModel.Drawings.Diagrams.NonVisualDrawingProperties? CreateModelElement(DXO2010DrawDgm.NonVisualDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.NonVisualDrawingProperties();
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
  
  public static bool CompareModelElement(DXO2010DrawDgm.NonVisualDrawingProperties? openXmlElement, DMDrawsDgms.NonVisualDrawingProperties? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.NonVisualDrawingProperties? value)
    where OpenXmlElementType: DXO2010DrawDgm.NonVisualDrawingProperties, new()
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

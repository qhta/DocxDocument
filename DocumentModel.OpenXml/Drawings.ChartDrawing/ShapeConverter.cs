namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Shape Definition.
/// </summary>
public static class ShapeConverter
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  private static String? GetMacro(DXDCD.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Macro);
  }
  
  private static bool CmpMacro(DXDCD.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Macro, value, diffs, objName, "Macro");
  }
  
  private static void SetMacro(DXDCD.Shape openXmlElement, String? value)
  {
    openXmlElement.Macro = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Text Link
  /// </summary>
  private static String? GetTextLink(DXDCD.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.TextLink);
  }
  
  private static bool CmpTextLink(DXDCD.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.TextLink, value, diffs, objName, "TextLink");
  }
  
  private static void SetTextLink(DXDCD.Shape openXmlElement, String? value)
  {
    openXmlElement.TextLink = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Lock Text
  /// </summary>
  private static Boolean? GetLockText(DXDCD.Shape openXmlElement)
  {
    return openXmlElement?.LockText?.Value;
  }
  
  private static bool CmpLockText(DXDCD.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.LockText?.Value == value) return true;
    diffs?.Add(objName, "LockText", openXmlElement?.LockText?.Value, value);
    return false;
  }
  
  private static void SetLockText(DXDCD.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LockText = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.LockText = null;
  }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  private static Boolean? GetPublished(DXDCD.Shape openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }
  
  private static bool CmpPublished(DXDCD.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Published?.Value == value) return true;
    diffs?.Add(objName, "Published", openXmlElement?.Published?.Value, value);
    return false;
  }
  
  private static void SetPublished(DXDCD.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Published = null;
  }
  
  /// <summary>
  /// Non-Visual Shape Properties.
  /// </summary>
  private static DMDCD.NonVisualShapeProperties? GetNonVisualShapeProperties(DXDCD.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.NonVisualShapeProperties>();
    if (element != null)
      return DMXDCD.NonVisualShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualShapeProperties(DXDCD.Shape openXmlElement, DMDCD.NonVisualShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.NonVisualShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.NonVisualShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetNonVisualShapeProperties(DXDCD.Shape openXmlElement, DMDCD.NonVisualShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.NonVisualShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.NonVisualShapePropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  private static DMDCD.ShapeProperties? GetShapeProperties(DXDCD.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.ShapeProperties>();
    if (element != null)
      return DMXDCD.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDCD.Shape openXmlElement, DMDCD.ShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXDCD.Shape openXmlElement, DMDCD.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.ShapePropertiesConverter.CreateOpenXmlElement<DXDCD.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  private static DMDCD.Style? GetStyle(DXDCD.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.Style>();
    if (element != null)
      return DMXDCD.StyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyle(DXDCD.Shape openXmlElement, DMDCD.Style? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.StyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.Style>(), value, diffs, objName, propName);
  }
  
  private static void SetStyle(DXDCD.Shape openXmlElement, DMDCD.Style? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.Style>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.StyleConverter.CreateOpenXmlElement<DXDCD.Style>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  private static DMDCD.TextBody? GetTextBody(DXDCD.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.TextBody>();
    if (element != null)
      return DMXDCD.TextBodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextBody(DXDCD.Shape openXmlElement, DMDCD.TextBody? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.TextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.TextBody>(), value, diffs, objName, propName);
  }
  
  private static void SetTextBody(DXDCD.Shape openXmlElement, DMDCD.TextBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.TextBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.TextBodyConverter.CreateOpenXmlElement<DXDCD.TextBody>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.ChartDrawing.Shape? CreateModelElement(DXDCD.Shape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ChartDrawing.Shape();
      value.Macro = GetMacro(openXmlElement);
      value.TextLink = GetTextLink(openXmlElement);
      value.LockText = GetLockText(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      value.NonVisualShapeProperties = GetNonVisualShapeProperties(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.TextBody = GetTextBody(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDCD.Shape? openXmlElement, DMDCD.Shape? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMacro(openXmlElement, value.Macro, diffs, objName, propName))
        ok = false;
      if (!CmpTextLink(openXmlElement, value.TextLink, diffs, objName, propName))
        ok = false;
      if (!CmpLockText(openXmlElement, value.LockText, diffs, objName, propName))
        ok = false;
      if (!CmpPublished(openXmlElement, value.Published, diffs, objName, propName))
        ok = false;
      if (!CmpNonVisualShapeProperties(openXmlElement, value.NonVisualShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName, propName))
        ok = false;
      if (!CmpTextBody(openXmlElement, value.TextBody, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.Shape value)
    where OpenXmlElementType: DXDCD.Shape, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.Shape openXmlElement, DMDCD.Shape value)
  {
    SetMacro(openXmlElement, value?.Macro);
    SetTextLink(openXmlElement, value?.TextLink);
    SetLockText(openXmlElement, value?.LockText);
    SetPublished(openXmlElement, value?.Published);
    SetNonVisualShapeProperties(openXmlElement, value?.NonVisualShapeProperties);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetStyle(openXmlElement, value?.Style);
    SetTextBody(openXmlElement, value?.TextBody);
  }
}

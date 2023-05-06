namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Connection Shape.
/// </summary>
public static class ConnectionShapeConverter
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  private static String? GetMacro(DXDCD.ConnectionShape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Macro);
  }
  
  private static bool CmpMacro(DXDCD.ConnectionShape openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Macro, value, diffs, objName, "Macro");
  }
  
  private static void SetMacro(DXDCD.ConnectionShape openXmlElement, String? value)
  {
    openXmlElement.Macro = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  private static Boolean? GetPublished(DXDCD.ConnectionShape openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }
  
  private static bool CmpPublished(DXDCD.ConnectionShape openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Published?.Value == value) return true;
    diffs?.Add(objName, "Published", openXmlElement?.Published?.Value, value);
    return false;
  }
  
  private static void SetPublished(DXDCD.ConnectionShape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Published = null;
  }
  
  /// <summary>
  /// Connector Non Visual Properties.
  /// </summary>
  private static DMDCD.NonVisualConnectorShapeDrawingProperties? GetNonVisualConnectorShapeDrawingProperties(DXDCD.ConnectionShape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.NonVisualConnectorShapeDrawingProperties>();
    if (element != null)
      return DMXDCD.NonVisualConnectorShapeDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualConnectorShapeDrawingProperties(DXDCD.ConnectionShape openXmlElement, DMDCD.NonVisualConnectorShapeDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.NonVisualConnectorShapeDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.NonVisualConnectorShapeDrawingProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualConnectorShapeDrawingProperties(DXDCD.ConnectionShape openXmlElement, DMDCD.NonVisualConnectorShapeDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.NonVisualConnectorShapeDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.NonVisualConnectorShapeDrawingPropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualConnectorShapeDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  private static DMDCD.ShapeProperties? GetShapeProperties(DXDCD.ConnectionShape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.ShapeProperties>();
    if (element != null)
      return DMXDCD.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDCD.ConnectionShape openXmlElement, DMDCD.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.ShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetShapeProperties(DXDCD.ConnectionShape openXmlElement, DMDCD.ShapeProperties? value)
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
  /// Connection Shape Style.
  /// </summary>
  private static DMDCD.Style? GetStyle(DXDCD.ConnectionShape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.Style>();
    if (element != null)
      return DMXDCD.StyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyle(DXDCD.ConnectionShape openXmlElement, DMDCD.Style? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.StyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.Style>(), value, diffs, objName);
  }
  
  private static void SetStyle(DXDCD.ConnectionShape openXmlElement, DMDCD.Style? value)
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
  
  public static DocumentModel.Drawings.ChartDrawing.ConnectionShape? CreateModelElement(DXDCD.ConnectionShape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.ConnectionShape();
      value.Macro = GetMacro(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      value.NonVisualConnectorShapeDrawingProperties = GetNonVisualConnectorShapeDrawingProperties(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDCD.ConnectionShape? openXmlElement, DMDCD.ConnectionShape? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMacro(openXmlElement, value.Macro, diffs, objName))
        ok = false;
      if (!CmpPublished(openXmlElement, value.Published, diffs, objName))
        ok = false;
      if (!CmpNonVisualConnectorShapeDrawingProperties(openXmlElement, value.NonVisualConnectorShapeDrawingProperties, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.ConnectionShape value)
    where OpenXmlElementType: DXDCD.ConnectionShape, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.ConnectionShape openXmlElement, DMDCD.ConnectionShape value)
  {
    SetMacro(openXmlElement, value?.Macro);
    SetPublished(openXmlElement, value?.Published);
    SetNonVisualConnectorShapeDrawingProperties(openXmlElement, value?.NonVisualConnectorShapeDrawingProperties);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetStyle(openXmlElement, value?.Style);
  }
}

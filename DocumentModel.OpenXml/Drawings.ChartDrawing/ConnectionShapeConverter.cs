namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Connection Shape.
/// </summary>
public static class ConnectionShapeConverter
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  private static String? GetMacro(DXDrawChartDraw.ConnectionShape openXmlElement)
  {
    return openXmlElement?.Macro?.Value;
  }
  
  private static bool CmpMacro(DXDrawChartDraw.ConnectionShape openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Macro?.Value == value;
  }
  
  private static void SetMacro(DXDrawChartDraw.ConnectionShape openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Macro = new StringValue { Value = value };
    else
      openXmlElement.Macro = null;
  }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  private static Boolean? GetPublished(DXDrawChartDraw.ConnectionShape openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }
  
  private static bool CmpPublished(DXDrawChartDraw.ConnectionShape openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Published?.Value == value;
  }
  
  private static void SetPublished(DXDrawChartDraw.ConnectionShape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Published = null;
  }
  
  /// <summary>
  /// Connector Non Visual Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualConnectorShapeDrawingProperties? GetNonVisualConnectorShapeDrawingProperties(DXDrawChartDraw.ConnectionShape openXmlElement)
  {
    return DMXDrawsChartDraw.NonVisualConnectorShapeDrawingPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties>());
  }
  
  private static bool CmpNonVisualConnectorShapeDrawingProperties(DXDrawChartDraw.ConnectionShape openXmlElement, DMDrawsChartDraw.NonVisualConnectorShapeDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualConnectorShapeDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualConnectorShapeDrawingProperties(DXDrawChartDraw.ConnectionShape openXmlElement, DMDrawsChartDraw.NonVisualConnectorShapeDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.NonVisualConnectorShapeDrawingPropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  private static DMDrawsChartDraw.ShapeProperties? GetShapeProperties(DXDrawChartDraw.ConnectionShape openXmlElement)
  {
    return DMXDrawsChartDraw.ShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.ShapeProperties>());
  }
  
  private static bool CmpShapeProperties(DXDrawChartDraw.ConnectionShape openXmlElement, DMDrawsChartDraw.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeProperties(DXDrawChartDraw.ConnectionShape openXmlElement, DMDrawsChartDraw.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.ShapePropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Connection Shape Style.
  /// </summary>
  private static DMDrawsChartDraw.Style? GetStyle(DXDrawChartDraw.ConnectionShape openXmlElement)
  {
    return DMXDrawsChartDraw.StyleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.Style>());
  }
  
  private static bool CmpStyle(DXDrawChartDraw.ConnectionShape openXmlElement, DMDrawsChartDraw.Style? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.StyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.Style>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStyle(DXDrawChartDraw.ConnectionShape openXmlElement, DMDrawsChartDraw.Style? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.Style>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.StyleConverter.CreateOpenXmlElement<DXDrawChartDraw.Style>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraw.ConnectionShape? CreateModelElement(DXDrawChartDraw.ConnectionShape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.ConnectionShape();
      value.Macro = GetMacro(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      value.NonVisualConnectorShapeDrawingProperties = GetNonVisualConnectorShapeDrawingProperties(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawChartDraw.ConnectionShape? openXmlElement, DMDrawsChartDraw.ConnectionShape? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.ConnectionShape? value)
    where OpenXmlElementType: DXDrawChartDraw.ConnectionShape, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMacro(openXmlElement, value?.Macro);
      SetPublished(openXmlElement, value?.Published);
      SetNonVisualConnectorShapeDrawingProperties(openXmlElement, value?.NonVisualConnectorShapeDrawingProperties);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetStyle(openXmlElement, value?.Style);
      return openXmlElement;
    }
    return default;
  }
}

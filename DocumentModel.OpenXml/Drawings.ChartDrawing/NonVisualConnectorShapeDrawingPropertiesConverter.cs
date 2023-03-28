namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Connector Non Visual Properties.
/// </summary>
public static class NonVisualConnectorShapeDrawingPropertiesConverter
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>();
    if (element != null)
      return DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingProperties(DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties openXmlElement, DMDrawsChartDraw.NonVisualDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties openXmlElement, DMDrawsChartDraw.NonVisualDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.NonVisualDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Non-Visual Connection Shape Drawing Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualConnectionShapeProperties? GetNonVisualConnectionShapeProperties(DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualConnectionShapeProperties>();
    if (element != null)
      return DMXDrawsChartDraw.NonVisualConnectionShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualConnectionShapeProperties(DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties openXmlElement, DMDrawsChartDraw.NonVisualConnectionShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualConnectionShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualConnectionShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualConnectionShapeProperties(DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties openXmlElement, DMDrawsChartDraw.NonVisualConnectionShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualConnectionShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.NonVisualConnectionShapePropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.NonVisualConnectionShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingProperties? CreateModelElement(DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualConnectionShapeProperties = GetNonVisualConnectionShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties? openXmlElement, DMDrawsChartDraw.NonVisualConnectorShapeDrawingProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualDrawingProperties(openXmlElement, value.NonVisualDrawingProperties, diffs, objName))
        ok = false;
      if (!CmpNonVisualConnectionShapeProperties(openXmlElement, value.NonVisualConnectionShapeProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.NonVisualConnectorShapeDrawingProperties value)
    where OpenXmlElementType: DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties openXmlElement, DMDrawsChartDraw.NonVisualConnectorShapeDrawingProperties value)
  {
    SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
    SetNonVisualConnectionShapeProperties(openXmlElement, value?.NonVisualConnectionShapeProperties);
  }
}

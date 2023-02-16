namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Shape Properties.
/// </summary>
public static class NonVisualShapePropertiesConverter
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>();
    if (element != null)
      return DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingProperties(DXDrawChartDraw.NonVisualShapeProperties openXmlElement, DMDrawsChartDraw.NonVisualDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualShapeProperties openXmlElement, DMDrawsChartDraw.NonVisualDrawingProperties? value)
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
  /// Non-Visual Shape Drawing Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualShapeDrawingProperties? GetNonVisualShapeDrawingProperties(DXDrawChartDraw.NonVisualShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualShapeDrawingProperties>();
    if (element != null)
      return DMXDrawsChartDraw.NonVisualShapeDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualShapeDrawingProperties(DXDrawChartDraw.NonVisualShapeProperties openXmlElement, DMDrawsChartDraw.NonVisualShapeDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualShapeDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualShapeDrawingProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualShapeDrawingProperties(DXDrawChartDraw.NonVisualShapeProperties openXmlElement, DMDrawsChartDraw.NonVisualShapeDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualShapeDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.NonVisualShapeDrawingPropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.NonVisualShapeDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualShapeProperties? CreateModelElement(DXDrawChartDraw.NonVisualShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualShapeProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualShapeDrawingProperties = GetNonVisualShapeDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawChartDraw.NonVisualShapeProperties? openXmlElement, DMDrawsChartDraw.NonVisualShapeProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualDrawingProperties(openXmlElement, value.NonVisualDrawingProperties, diffs, objName))
        ok = false;
      if (!CmpNonVisualShapeDrawingProperties(openXmlElement, value.NonVisualShapeDrawingProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.NonVisualShapeProperties? value)
    where OpenXmlElementType: DXDrawChartDraw.NonVisualShapeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualShapeDrawingProperties(openXmlElement, value?.NonVisualShapeDrawingProperties);
      return openXmlElement;
    }
    return default;
  }
}

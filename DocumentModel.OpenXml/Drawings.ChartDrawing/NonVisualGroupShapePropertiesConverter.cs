namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Group Shape Properties.
/// </summary>
public static class NonVisualGroupShapePropertiesConverter
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualGroupShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>();
    if (element != null)
      return DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingProperties(DXDrawChartDraw.NonVisualGroupShapeProperties openXmlElement, DMDrawsChartDraw.NonVisualDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualGroupShapeProperties openXmlElement, DMDrawsChartDraw.NonVisualDrawingProperties? value)
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
  /// Non-Visual Group Shape Drawing Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualGroupShapeDrawingProperties? GetNonVisualGroupShapeDrawingProperties(DXDrawChartDraw.NonVisualGroupShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualGroupShapeDrawingProperties>();
    if (element != null)
      return DMXDrawsChartDraw.NonVisualGroupShapeDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualGroupShapeDrawingProperties(DXDrawChartDraw.NonVisualGroupShapeProperties openXmlElement, DMDrawsChartDraw.NonVisualGroupShapeDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualGroupShapeDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualGroupShapeDrawingProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualGroupShapeDrawingProperties(DXDrawChartDraw.NonVisualGroupShapeProperties openXmlElement, DMDrawsChartDraw.NonVisualGroupShapeDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualGroupShapeDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.NonVisualGroupShapeDrawingPropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.NonVisualGroupShapeDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeProperties? CreateModelElement(DXDrawChartDraw.NonVisualGroupShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualGroupShapeDrawingProperties = GetNonVisualGroupShapeDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawChartDraw.NonVisualGroupShapeProperties? openXmlElement, DMDrawsChartDraw.NonVisualGroupShapeProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualDrawingProperties(openXmlElement, value.NonVisualDrawingProperties, diffs, objName))
        ok = false;
      if (!CmpNonVisualGroupShapeDrawingProperties(openXmlElement, value.NonVisualGroupShapeDrawingProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.NonVisualGroupShapeProperties value)
    where OpenXmlElementType: DXDrawChartDraw.NonVisualGroupShapeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawChartDraw.NonVisualGroupShapeProperties openXmlElement, DMDrawsChartDraw.NonVisualGroupShapeProperties value)
  {
    SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
    SetNonVisualGroupShapeDrawingProperties(openXmlElement, value?.NonVisualGroupShapeDrawingProperties);
  }
}

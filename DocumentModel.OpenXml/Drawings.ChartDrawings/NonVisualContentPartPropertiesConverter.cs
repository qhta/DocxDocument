namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NonVisualContentPartProperties Class converter from/to OpenXml.
///</summary>
public static class NonVisualContentPartPropertiesConverter
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  private static DMDrawsChartDraws.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXO2010DrawChartDraw.NonVisualContentPartProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010DrawChartDraw.NonVisualDrawingProperties>();
    if (element != null)
      return DMXDrawsChartDraws.NonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingProperties(DXO2010DrawChartDraw.NonVisualContentPartProperties openXmlElement, DMDrawsChartDraws.NonVisualDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010DrawChartDraw.NonVisualDrawingProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualDrawingProperties(DXO2010DrawChartDraw.NonVisualContentPartProperties openXmlElement, DMDrawsChartDraws.NonVisualDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010DrawChartDraw.NonVisualDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXO2010DrawChartDraw.NonVisualDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  private static DMDrawsChartDraws.NonVisualInkContentPartProperties? GetNonVisualInkContentPartProperties(DXO2010DrawChartDraw.NonVisualContentPartProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010DrawChartDraw.NonVisualInkContentPartProperties>();
    if (element != null)
      return DMXDrawsChartDraws.NonVisualInkContentPartPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualInkContentPartProperties(DXO2010DrawChartDraw.NonVisualContentPartProperties openXmlElement, DMDrawsChartDraws.NonVisualInkContentPartProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.NonVisualInkContentPartPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010DrawChartDraw.NonVisualInkContentPartProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualInkContentPartProperties(DXO2010DrawChartDraw.NonVisualContentPartProperties openXmlElement, DMDrawsChartDraws.NonVisualInkContentPartProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010DrawChartDraw.NonVisualInkContentPartProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.NonVisualInkContentPartPropertiesConverter.CreateOpenXmlElement<DXO2010DrawChartDraw.NonVisualInkContentPartProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.NonVisualContentPartProperties? CreateModelElement(DXO2010DrawChartDraw.NonVisualContentPartProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.NonVisualContentPartProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualInkContentPartProperties = GetNonVisualInkContentPartProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010DrawChartDraw.NonVisualContentPartProperties? openXmlElement, DMDrawsChartDraws.NonVisualContentPartProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualDrawingProperties(openXmlElement, value.NonVisualDrawingProperties, diffs, objName))
        ok = false;
      if (!CmpNonVisualInkContentPartProperties(openXmlElement, value.NonVisualInkContentPartProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.NonVisualContentPartProperties value)
    where OpenXmlElementType: DXO2010DrawChartDraw.NonVisualContentPartProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010DrawChartDraw.NonVisualContentPartProperties openXmlElement, DMDrawsChartDraws.NonVisualContentPartProperties value)
  {
    SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
    SetNonVisualInkContentPartProperties(openXmlElement, value?.NonVisualInkContentPartProperties);
  }
}

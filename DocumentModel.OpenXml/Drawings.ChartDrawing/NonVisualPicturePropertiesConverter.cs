namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Picture Properties.
/// </summary>
public static class NonVisualPicturePropertiesConverter
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualPictureProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>();
    if (element != null)
      return DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingProperties(DXDrawChartDraw.NonVisualPictureProperties openXmlElement, DMDrawsChartDraw.NonVisualDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualPictureProperties openXmlElement, DMDrawsChartDraw.NonVisualDrawingProperties? value)
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
  /// Non-Visual Picture Drawing Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualPictureDrawingProperties? GetNonVisualPictureDrawingProperties(DXDrawChartDraw.NonVisualPictureProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualPictureDrawingProperties>();
    if (element != null)
      return DMXDrawsChartDraw.NonVisualPictureDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualPictureDrawingProperties(DXDrawChartDraw.NonVisualPictureProperties openXmlElement, DMDrawsChartDraw.NonVisualPictureDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualPictureDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualPictureDrawingProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualPictureDrawingProperties(DXDrawChartDraw.NonVisualPictureProperties openXmlElement, DMDrawsChartDraw.NonVisualPictureDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualPictureDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.NonVisualPictureDrawingPropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.NonVisualPictureDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualPictureProperties? CreateModelElement(DXDrawChartDraw.NonVisualPictureProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualPictureProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualPictureDrawingProperties = GetNonVisualPictureDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawChartDraw.NonVisualPictureProperties? openXmlElement, DMDrawsChartDraw.NonVisualPictureProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualDrawingProperties(openXmlElement, value.NonVisualDrawingProperties, diffs, objName))
        ok = false;
      if (!CmpNonVisualPictureDrawingProperties(openXmlElement, value.NonVisualPictureDrawingProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.NonVisualPictureProperties? value)
    where OpenXmlElementType: DXDrawChartDraw.NonVisualPictureProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualPictureDrawingProperties(openXmlElement, value?.NonVisualPictureDrawingProperties);
      return openXmlElement;
    }
    return default;
  }
}

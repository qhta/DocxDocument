namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColors Class converter from/to OpenXml.
///</summary>
public static class ValueColorsConverter
{
  /// <summary>
  /// MinColorSolidColorFillProperties.
  /// </summary>
  private static DMDrawsChartDraws.MinColorSolidColorFillProperties? GetMinColorSolidColorFillProperties(DXO2016DrawChartDraw.ValueColors openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.MinColorSolidColorFillProperties>();
    if (element != null)
      return DMXDrawsChartDraws.MinColorSolidColorFillPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMinColorSolidColorFillProperties(DXO2016DrawChartDraw.ValueColors openXmlElement, DMDrawsChartDraws.MinColorSolidColorFillProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.MinColorSolidColorFillPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MinColorSolidColorFillProperties>(), value, diffs, objName);
  }
  
  private static void SetMinColorSolidColorFillProperties(DXO2016DrawChartDraw.ValueColors openXmlElement, DMDrawsChartDraws.MinColorSolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MinColorSolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.MinColorSolidColorFillPropertiesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.MinColorSolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// MidColorSolidColorFillProperties.
  /// </summary>
  private static DMDrawsChartDraws.MidColorSolidColorFillProperties? GetMidColorSolidColorFillProperties(DXO2016DrawChartDraw.ValueColors openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.MidColorSolidColorFillProperties>();
    if (element != null)
      return DMXDrawsChartDraws.MidColorSolidColorFillPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMidColorSolidColorFillProperties(DXO2016DrawChartDraw.ValueColors openXmlElement, DMDrawsChartDraws.MidColorSolidColorFillProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.MidColorSolidColorFillPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MidColorSolidColorFillProperties>(), value, diffs, objName);
  }
  
  private static void SetMidColorSolidColorFillProperties(DXO2016DrawChartDraw.ValueColors openXmlElement, DMDrawsChartDraws.MidColorSolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MidColorSolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.MidColorSolidColorFillPropertiesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.MidColorSolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// MaxColorSolidColorFillProperties.
  /// </summary>
  private static DMDrawsChartDraws.MaxColorSolidColorFillProperties? GetMaxColorSolidColorFillProperties(DXO2016DrawChartDraw.ValueColors openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.MaxColorSolidColorFillProperties>();
    if (element != null)
      return DMXDrawsChartDraws.MaxColorSolidColorFillPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMaxColorSolidColorFillProperties(DXO2016DrawChartDraw.ValueColors openXmlElement, DMDrawsChartDraws.MaxColorSolidColorFillProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.MaxColorSolidColorFillPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MaxColorSolidColorFillProperties>(), value, diffs, objName);
  }
  
  private static void SetMaxColorSolidColorFillProperties(DXO2016DrawChartDraw.ValueColors openXmlElement, DMDrawsChartDraws.MaxColorSolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MaxColorSolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.MaxColorSolidColorFillPropertiesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.MaxColorSolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ValueColors? CreateModelElement(DXO2016DrawChartDraw.ValueColors? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ValueColors();
      value.MinColorSolidColorFillProperties = GetMinColorSolidColorFillProperties(openXmlElement);
      value.MidColorSolidColorFillProperties = GetMidColorSolidColorFillProperties(openXmlElement);
      value.MaxColorSolidColorFillProperties = GetMaxColorSolidColorFillProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.ValueColors? openXmlElement, DMDrawsChartDraws.ValueColors? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMinColorSolidColorFillProperties(openXmlElement, value.MinColorSolidColorFillProperties, diffs, objName))
        ok = false;
      if (!CmpMidColorSolidColorFillProperties(openXmlElement, value.MidColorSolidColorFillProperties, diffs, objName))
        ok = false;
      if (!CmpMaxColorSolidColorFillProperties(openXmlElement, value.MaxColorSolidColorFillProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ValueColors value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ValueColors, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.ValueColors openXmlElement, DMDrawsChartDraws.ValueColors value)
  {
    SetMinColorSolidColorFillProperties(openXmlElement, value?.MinColorSolidColorFillProperties);
    SetMidColorSolidColorFillProperties(openXmlElement, value?.MidColorSolidColorFillProperties);
    SetMaxColorSolidColorFillProperties(openXmlElement, value?.MaxColorSolidColorFillProperties);
  }
}

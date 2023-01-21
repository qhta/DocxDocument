namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColors Class.
/// </summary>
public static class ValueColorsConverter
{
  /// <summary>
  /// MinColorSolidColorFillProperties.
  /// </summary>
  private static DMDrawsChartDraws.MinColorSolidColorFillProperties? GetMinColorSolidColorFillProperties(DXO2016DrawChartDraw.ValueColors openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.MinColorSolidColorFillProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraws.MinColorSolidColorFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.MidColorSolidColorFillProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraws.MidColorSolidColorFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.MaxColorSolidColorFillProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraws.MaxColorSolidColorFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsChartDraws.ValueColors? CreateModelElement(DXO2016DrawChartDraw.ValueColors? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.ValueColors();
      value.MinColorSolidColorFillProperties = GetMinColorSolidColorFillProperties(openXmlElement);
      value.MidColorSolidColorFillProperties = GetMidColorSolidColorFillProperties(openXmlElement);
      value.MaxColorSolidColorFillProperties = GetMaxColorSolidColorFillProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ValueColors? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ValueColors, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMinColorSolidColorFillProperties(openXmlElement, value?.MinColorSolidColorFillProperties);
      SetMidColorSolidColorFillProperties(openXmlElement, value?.MidColorSolidColorFillProperties);
      SetMaxColorSolidColorFillProperties(openXmlElement, value?.MaxColorSolidColorFillProperties);
      return openXmlElement;
    }
    return default;
  }
}

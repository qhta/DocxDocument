namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Trendline Class.
/// </summary>
public static class TrendlineConverter
{
  /// <summary>
  /// Trendline Name.
  /// </summary>
  private static String? GetTrendlineName(DXDrawCharts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.TrendlineName>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetTrendlineName(DXDrawCharts.Trendline openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TrendlineName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.TrendlineName { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.Trendline openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDrawCharts.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Trendline Type.
  /// </summary>
  private static DMDrawsCharts.TrendlineKind? GetTrendlineType(DXDrawCharts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TrendlineType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues, DMDrawsCharts.TrendlineKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTrendlineType(DXDrawCharts.Trendline openXmlElement, DMDrawsCharts.TrendlineKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TrendlineType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.TrendlineType, DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues, DMDrawsCharts.TrendlineKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Polynomial Trendline Order.
  /// </summary>
  private static Byte? GetPolynomialOrder(DXDrawCharts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PolynomialOrder>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPolynomialOrder(DXDrawCharts.Trendline openXmlElement, Byte? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PolynomialOrder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.PolynomialOrder{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Period.
  /// </summary>
  private static UInt32? GetPeriod(DXDrawCharts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Period>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPeriod(DXDrawCharts.Trendline openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Period>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Period{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Forward.
  /// </summary>
  private static Double? GetForward(DXDrawCharts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Forward>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetForward(DXDrawCharts.Trendline openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Forward>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Forward{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Backward.
  /// </summary>
  private static Double? GetBackward(DXDrawCharts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Backward>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetBackward(DXDrawCharts.Trendline openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Backward>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Backward{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Intercept.
  /// </summary>
  private static Double? GetIntercept(DXDrawCharts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Intercept>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetIntercept(DXDrawCharts.Trendline openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Intercept>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Intercept{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Display R Squared Value.
  /// </summary>
  private static Boolean? GetDisplayRSquaredValue(DXDrawCharts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DisplayRSquaredValue>();
    return itemElement != null;
  }
  
  private static void SetDisplayRSquaredValue(DXDrawCharts.Trendline openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DisplayRSquaredValue>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.DisplayRSquaredValue();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Display Equation.
  /// </summary>
  private static Boolean? GetDisplayEquation(DXDrawCharts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DisplayEquation>();
    return itemElement != null;
  }
  
  private static void SetDisplayEquation(DXDrawCharts.Trendline openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DisplayEquation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.DisplayEquation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Trendline Label.
  /// </summary>
  private static DMDrawsCharts.TrendlineLabel? GetTrendlineLabel(DXDrawCharts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.TrendlineLabel>();
    if (itemElement != null)
      return DMXDrawsCharts.TrendlineLabelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTrendlineLabel(DXDrawCharts.Trendline openXmlElement, DMDrawsCharts.TrendlineLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TrendlineLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.TrendlineLabelConverter.CreateOpenXmlElement<DXDrawCharts.TrendlineLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawCharts.Trendline openXmlElement, DMDrawsCharts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.Trendline? CreateModelElement(DXDrawCharts.Trendline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Trendline();
      value.TrendlineName = GetTrendlineName(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TrendlineType = GetTrendlineType(openXmlElement);
      value.PolynomialOrder = GetPolynomialOrder(openXmlElement);
      value.Period = GetPeriod(openXmlElement);
      value.Forward = GetForward(openXmlElement);
      value.Backward = GetBackward(openXmlElement);
      value.Intercept = GetIntercept(openXmlElement);
      value.DisplayRSquaredValue = GetDisplayRSquaredValue(openXmlElement);
      value.DisplayEquation = GetDisplayEquation(openXmlElement);
      value.TrendlineLabel = GetTrendlineLabel(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Trendline? value)
    where OpenXmlElementType: DXDrawCharts.Trendline, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTrendlineName(openXmlElement, value?.TrendlineName);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetTrendlineType(openXmlElement, value?.TrendlineType);
      SetPolynomialOrder(openXmlElement, value?.PolynomialOrder);
      SetPeriod(openXmlElement, value?.Period);
      SetForward(openXmlElement, value?.Forward);
      SetBackward(openXmlElement, value?.Backward);
      SetIntercept(openXmlElement, value?.Intercept);
      SetDisplayRSquaredValue(openXmlElement, value?.DisplayRSquaredValue);
      SetDisplayEquation(openXmlElement, value?.DisplayEquation);
      SetTrendlineLabel(openXmlElement, value?.TrendlineLabel);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}

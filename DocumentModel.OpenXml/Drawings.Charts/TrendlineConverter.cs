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
      return openXmlElement?.GetFirstChild<DXDrawCharts.TrendlineName>()?.Text;
  }
  
  private static bool CmpTrendlineName(DXDrawCharts.Trendline openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.TrendlineName>()?.Text == value;
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
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (element != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDrawCharts.Trendline openXmlElement, DMDrawsCharts.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues, DMDrawsCharts.TrendlineKind>(openXmlElement.GetFirstChild<DXDrawCharts.TrendlineType>()?.Val?.Value);
  }
  
  private static bool CmpTrendlineType(DXDrawCharts.Trendline openXmlElement, DMDrawsCharts.TrendlineKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues, DMDrawsCharts.TrendlineKind>(openXmlElement.GetFirstChild<DXDrawCharts.TrendlineType>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.GetFirstChild<DXDrawCharts.PolynomialOrder>()?.Val?.Value;
  }
  
  private static bool CmpPolynomialOrder(DXDrawCharts.Trendline openXmlElement, Byte? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PolynomialOrder>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.PolynomialOrder", itemElement?.Val?.Value, value);
    return false;
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
    return openXmlElement?.GetFirstChild<DXDrawCharts.Period>()?.Val?.Value;
  }
  
  private static bool CmpPeriod(DXDrawCharts.Trendline openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Period>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Period", itemElement?.Val?.Value, value);
    return false;
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
    return openXmlElement?.GetFirstChild<DXDrawCharts.Forward>()?.Val?.Value;
  }
  
  private static bool CmpForward(DXDrawCharts.Trendline openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Forward>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Forward", itemElement?.Val?.Value, value);
    return false;
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
    return openXmlElement?.GetFirstChild<DXDrawCharts.Backward>()?.Val?.Value;
  }
  
  private static bool CmpBackward(DXDrawCharts.Trendline openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Backward>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Backward", itemElement?.Val?.Value, value);
    return false;
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
    return openXmlElement?.GetFirstChild<DXDrawCharts.Intercept>()?.Val?.Value;
  }
  
  private static bool CmpIntercept(DXDrawCharts.Trendline openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Intercept>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Intercept", itemElement?.Val?.Value, value);
    return false;
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
    return openXmlElement.GetFirstChild<DXDrawCharts.DisplayRSquaredValue>() != null;
  }
  
  private static bool CmpDisplayRSquaredValue(DXDrawCharts.Trendline openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.DisplayRSquaredValue>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.DisplayRSquaredValue", val, value);
    return false;
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
    return openXmlElement.GetFirstChild<DXDrawCharts.DisplayEquation>() != null;
  }
  
  private static bool CmpDisplayEquation(DXDrawCharts.Trendline openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.DisplayEquation>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.DisplayEquation", val, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.TrendlineLabel>();
    if (element != null)
      return DMXDrawsCharts.TrendlineLabelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTrendlineLabel(DXDrawCharts.Trendline openXmlElement, DMDrawsCharts.TrendlineLabel? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.TrendlineLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.TrendlineLabel>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (element != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawCharts.Trendline openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.Charts.Trendline? CreateModelElement(DXDrawCharts.Trendline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Trendline();
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
  
  public static bool CompareModelElement(DXDrawCharts.Trendline? openXmlElement, DMDrawsCharts.Trendline? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTrendlineName(openXmlElement, value.TrendlineName, diffs, objName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName))
        ok = false;
      if (!CmpTrendlineType(openXmlElement, value.TrendlineType, diffs, objName))
        ok = false;
      if (!CmpPolynomialOrder(openXmlElement, value.PolynomialOrder, diffs, objName))
        ok = false;
      if (!CmpPeriod(openXmlElement, value.Period, diffs, objName))
        ok = false;
      if (!CmpForward(openXmlElement, value.Forward, diffs, objName))
        ok = false;
      if (!CmpBackward(openXmlElement, value.Backward, diffs, objName))
        ok = false;
      if (!CmpIntercept(openXmlElement, value.Intercept, diffs, objName))
        ok = false;
      if (!CmpDisplayRSquaredValue(openXmlElement, value.DisplayRSquaredValue, diffs, objName))
        ok = false;
      if (!CmpDisplayEquation(openXmlElement, value.DisplayEquation, diffs, objName))
        ok = false;
      if (!CmpTrendlineLabel(openXmlElement, value.TrendlineLabel, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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

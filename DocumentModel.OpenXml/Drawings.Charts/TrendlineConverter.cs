namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Trendline Class.
/// </summary>
public static class TrendlineConverter
{
  /// <summary>
  /// Trendline Name.
  /// </summary>
  private static String? GetTrendlineName(DXDC.Trendline openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.TrendlineName>()?.Text;
  }
  
  private static bool CmpTrendlineName(DXDC.Trendline openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXDC.TrendlineName>()?.Text == value;
  }
  
  private static void SetTrendlineName(DXDC.Trendline openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.TrendlineName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDC.TrendlineName { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXDC.Trendline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDC.Trendline openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetChartShapeProperties(DXDC.Trendline openXmlElement, DMDC.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Trendline Type.
  /// </summary>
  private static DMDC.TrendlineKind? GetTrendlineType(DXDC.Trendline openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues, DMDC.TrendlineKind>(openXmlElement.GetFirstChild<DXDC.TrendlineType>()?.Val?.Value);
  }
  
  private static bool CmpTrendlineType(DXDC.Trendline openXmlElement, DMDC.TrendlineKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues, DMDC.TrendlineKind>(openXmlElement.GetFirstChild<DXDC.TrendlineType>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetTrendlineType(DXDC.Trendline openXmlElement, DMDC.TrendlineKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.TrendlineType>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues, DMDC.TrendlineKind>(itemElement, (DMDC.TrendlineKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.TrendlineType, DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues, DMDC.TrendlineKind>((DMDC.TrendlineKind)value));
  }
  
  /// <summary>
  /// Polynomial Trendline Order.
  /// </summary>
  private static Byte? GetPolynomialOrder(DXDC.Trendline openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.PolynomialOrder>()?.Val);
  }
  
  private static bool CmpPolynomialOrder(DXDC.Trendline openXmlElement, Byte? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.PolynomialOrder>()?.Val, value, diffs, objName, "PolynomialOrder");
  }
  
  private static void SetPolynomialOrder(DXDC.Trendline openXmlElement, Byte? value)
  {
    SimpleValueConverter.SetValue<DXDC.PolynomialOrder,System.Byte>(openXmlElement, value);
  }
  
  /// <summary>
  /// Period.
  /// </summary>
  private static UInt32? GetPeriod(DXDC.Trendline openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Period>()?.Val);
  }
  
  private static bool CmpPeriod(DXDC.Trendline openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Period>()?.Val, value, diffs, objName, "Period");
  }
  
  private static void SetPeriod(DXDC.Trendline openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Period,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Forward.
  /// </summary>
  private static Double? GetForward(DXDC.Trendline openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Forward>()?.Val);
  }
  
  private static bool CmpForward(DXDC.Trendline openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Forward>()?.Val, value, diffs, objName, "Forward");
  }
  
  private static void SetForward(DXDC.Trendline openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.Forward,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Backward.
  /// </summary>
  private static Double? GetBackward(DXDC.Trendline openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Backward>()?.Val);
  }
  
  private static bool CmpBackward(DXDC.Trendline openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Backward>()?.Val, value, diffs, objName, "Backward");
  }
  
  private static void SetBackward(DXDC.Trendline openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.Backward,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Intercept.
  /// </summary>
  private static Double? GetIntercept(DXDC.Trendline openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Intercept>()?.Val);
  }
  
  private static bool CmpIntercept(DXDC.Trendline openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Intercept>()?.Val, value, diffs, objName, "Intercept");
  }
  
  private static void SetIntercept(DXDC.Trendline openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.Intercept,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// Display R Squared Value.
  /// </summary>
  private static Boolean? GetDisplayRSquaredValue(DXDC.Trendline openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.DisplayRSquaredValue>() != null;
  }
  
  private static bool CmpDisplayRSquaredValue(DXDC.Trendline openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.DisplayRSquaredValue>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.DisplayRSquaredValue", val, value);
    return false;
  }
  
  private static void SetDisplayRSquaredValue(DXDC.Trendline openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.DisplayRSquaredValue>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.DisplayRSquaredValue();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Display Equation.
  /// </summary>
  private static Boolean? GetDisplayEquation(DXDC.Trendline openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.DisplayEquation>() != null;
  }
  
  private static bool CmpDisplayEquation(DXDC.Trendline openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.DisplayEquation>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.DisplayEquation", val, value);
    return false;
  }
  
  private static void SetDisplayEquation(DXDC.Trendline openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.DisplayEquation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.DisplayEquation();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Trendline Label.
  /// </summary>
  private static DMDC.TrendlineLabel? GetTrendlineLabel(DXDC.Trendline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.TrendlineLabel>();
    if (element != null)
      return DMXDC.TrendlineLabelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTrendlineLabel(DXDC.Trendline openXmlElement, DMDC.TrendlineLabel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.TrendlineLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.TrendlineLabel>(), value, diffs, objName, propName);
  }
  
  private static void SetTrendlineLabel(DXDC.Trendline openXmlElement, DMDC.TrendlineLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.TrendlineLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.TrendlineLabelConverter.CreateOpenXmlElement<DXDC.TrendlineLabel>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDC.ExtensionList? GetExtensionList(DXDC.Trendline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.Trendline openXmlElement, DMDC.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDC.Trendline openXmlElement, DMDC.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Trendline? CreateModelElement(DXDC.Trendline? openXmlElement)
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
  
  public static bool CompareModelElement(DXDC.Trendline? openXmlElement, DMDC.Trendline? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTrendlineName(openXmlElement, value.TrendlineName, diffs, objName, propName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpTrendlineType(openXmlElement, value.TrendlineType, diffs, objName, propName))
        ok = false;
      if (!CmpPolynomialOrder(openXmlElement, value.PolynomialOrder, diffs, objName, propName))
        ok = false;
      if (!CmpPeriod(openXmlElement, value.Period, diffs, objName, propName))
        ok = false;
      if (!CmpForward(openXmlElement, value.Forward, diffs, objName, propName))
        ok = false;
      if (!CmpBackward(openXmlElement, value.Backward, diffs, objName, propName))
        ok = false;
      if (!CmpIntercept(openXmlElement, value.Intercept, diffs, objName, propName))
        ok = false;
      if (!CmpDisplayRSquaredValue(openXmlElement, value.DisplayRSquaredValue, diffs, objName, propName))
        ok = false;
      if (!CmpDisplayEquation(openXmlElement, value.DisplayEquation, diffs, objName, propName))
        ok = false;
      if (!CmpTrendlineLabel(openXmlElement, value.TrendlineLabel, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Trendline value)
    where OpenXmlElementType: DXDC.Trendline, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Trendline openXmlElement, DMDC.Trendline value)
  {
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
  }
}

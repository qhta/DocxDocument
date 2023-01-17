namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Trendline Class.
/// </summary>
public static class TrendlineConverter
{
  /// <summary>
  /// Trendline Name.
  /// </summary>
  private static String? GetTrendlineName(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TrendlineName>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetTrendlineName(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TrendlineName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.TrendlineName { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Trendline Type.
  /// </summary>
  private static DocumentModel.Drawings.Charts.TrendlineKind? GetTrendlineType(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TrendlineType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues, DocumentModel.Drawings.Charts.TrendlineKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTrendlineType(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement, DocumentModel.Drawings.Charts.TrendlineKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TrendlineType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TrendlineType, DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues, DocumentModel.Drawings.Charts.TrendlineKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Polynomial Trendline Order.
  /// </summary>
  private static Byte? GetPolynomialOrder(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PolynomialOrder>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPolynomialOrder(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement, Byte? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PolynomialOrder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.PolynomialOrder{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Period.
  /// </summary>
  private static UInt32? GetPeriod(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Period>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPeriod(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Period>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Period{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Forward.
  /// </summary>
  private static Double? GetForward(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Forward>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetForward(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Forward>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Forward{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Backward.
  /// </summary>
  private static Double? GetBackward(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Backward>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetBackward(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Backward>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Backward{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Intercept.
  /// </summary>
  private static Double? GetIntercept(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Intercept>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetIntercept(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Intercept>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Intercept{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Display R Squared Value.
  /// </summary>
  private static Boolean? GetDisplayRSquaredValue(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayRSquaredValue>();
    return itemElement != null;
  }
  
  private static void SetDisplayRSquaredValue(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayRSquaredValue>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.DisplayRSquaredValue();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Display Equation.
  /// </summary>
  private static Boolean? GetDisplayEquation(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayEquation>();
    return itemElement != null;
  }
  
  private static void SetDisplayEquation(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayEquation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.DisplayEquation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Trendline Label.
  /// </summary>
  private static DocumentModel.Drawings.Charts.TrendlineLabel? GetTrendlineLabel(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TrendlineLabel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.TrendlineLabelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTrendlineLabel(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement, DocumentModel.Drawings.Charts.TrendlineLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TrendlineLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.TrendlineLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TrendlineLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Trendline? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Trendline? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Trendline, new()
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

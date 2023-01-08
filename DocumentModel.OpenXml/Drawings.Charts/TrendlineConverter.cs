namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Trendline Class.
/// </summary>
public static class TrendlineConverter
{
  /// <summary>
  /// Trendline Name.
  /// </summary>
  public static String? GetTrendlineName(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Drawing.Charts.TrendlineName");
  }
  
  public static void SetTrendlineName(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Trendline Type.
  /// </summary>
  public static DocumentModel.Drawings.Charts.TrendlineKind? GetTrendlineType(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TrendlineType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues, DocumentModel.Drawings.Charts.TrendlineKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTrendlineType(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, DocumentModel.Drawings.Charts.TrendlineKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Polynomial Trendline Order.
  /// </summary>
  public static Byte? GetPolynomialOrder(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPolynomialOrder(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, Byte? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Period.
  /// </summary>
  public static UInt32? GetPeriod(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPeriod(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Forward.
  /// </summary>
  public static Double? GetForward(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetForward(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Backward.
  /// </summary>
  public static Double? GetBackward(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBackward(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Intercept.
  /// </summary>
  public static Double? GetIntercept(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetIntercept(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Display R Squared Value.
  /// </summary>
  public static Boolean? GetDisplayRSquaredValue(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDisplayRSquaredValue(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Display Equation.
  /// </summary>
  public static Boolean? GetDisplayEquation(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDisplayEquation(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Trendline Label.
  /// </summary>
  public static DocumentModel.Drawings.Charts.TrendlineLabel? GetTrendlineLabel(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTrendlineLabel(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, DocumentModel.Drawings.Charts.TrendlineLabel? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

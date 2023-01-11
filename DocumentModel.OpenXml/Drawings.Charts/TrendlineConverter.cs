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
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.TrendlineName");
  }
  
  public static void SetTrendlineName(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.TrendlineName");
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    if (openXmlElement != null)
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
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.PolynomialOrder");
  }
  
  public static void SetPolynomialOrder(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, Byte? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.PolynomialOrder");
  }
  
  /// <summary>
  /// Period.
  /// </summary>
  public static UInt32? GetPeriod(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Period");
  }
  
  public static void SetPeriod(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Period");
  }
  
  /// <summary>
  /// Forward.
  /// </summary>
  public static Double? GetForward(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Forward");
  }
  
  public static void SetForward(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Forward");
  }
  
  /// <summary>
  /// Backward.
  /// </summary>
  public static Double? GetBackward(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Backward");
  }
  
  public static void SetBackward(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Backward");
  }
  
  /// <summary>
  /// Intercept.
  /// </summary>
  public static Double? GetIntercept(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Intercept");
  }
  
  public static void SetIntercept(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Intercept");
  }
  
  /// <summary>
  /// Display R Squared Value.
  /// </summary>
  public static Boolean? GetDisplayRSquaredValue(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayRSquaredValue>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDisplayRSquaredValue(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Display Equation.
  /// </summary>
  public static Boolean? GetDisplayEquation(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayEquation>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDisplayEquation(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Trendline Label.
  /// </summary>
  public static DocumentModel.Drawings.Charts.TrendlineLabel? GetTrendlineLabel(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TrendlineLabel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.TrendlineLabelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTrendlineLabel(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, DocumentModel.Drawings.Charts.TrendlineLabel? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

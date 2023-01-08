namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ErrorBars Class.
/// </summary>
public static class ErrorBarsConverter
{
  /// <summary>
  /// Error Bar Direction.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ErrorBarDirectionKind? GetErrorDirection(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorDirection>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues, DocumentModel.Drawings.Charts.ErrorBarDirectionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetErrorDirection(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement, DocumentModel.Drawings.Charts.ErrorBarDirectionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorDirection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ErrorDirection, DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues, DocumentModel.Drawings.Charts.ErrorBarDirectionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Error Bar Type.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ErrorBarKind? GetErrorBarType(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues, DocumentModel.Drawings.Charts.ErrorBarKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetErrorBarType(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement, DocumentModel.Drawings.Charts.ErrorBarKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarType, DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues, DocumentModel.Drawings.Charts.ErrorBarKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Error Bar Value Type.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ErrorKind? GetErrorBarValueType(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValueType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorValues, DocumentModel.Drawings.Charts.ErrorKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetErrorBarValueType(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement, DocumentModel.Drawings.Charts.ErrorKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValueType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValueType, DocumentFormat.OpenXml.Drawing.Charts.ErrorValues, DocumentModel.Drawings.Charts.ErrorKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// No End Cap.
  /// </summary>
  public static Boolean? GetNoEndCap(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNoEndCap(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Plus.
  /// </summary>
  public static DocumentModel.Drawings.Charts.Plus? GetPlus(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPlus(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement, DocumentModel.Drawings.Charts.Plus? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Minus.
  /// </summary>
  public static DocumentModel.Drawings.Charts.Minus? GetMinus(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMinus(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement, DocumentModel.Drawings.Charts.Minus? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Error Bar Value.
  /// </summary>
  public static Double? GetErrorBarValue(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetErrorBarValue(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

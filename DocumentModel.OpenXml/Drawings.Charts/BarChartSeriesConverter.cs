namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Bar Chart Series.
/// </summary>
public static class BarChartSeriesConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  public static UInt32? GetIndex(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  public static UInt32? GetOrder(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetOrder(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  public static DocumentModel.Drawings.Charts.SeriesText? GetSeriesText(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSeriesText(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement, DocumentModel.Drawings.Charts.SeriesText? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// InvertIfNegative.
  /// </summary>
  public static Boolean? GetInvertIfNegative(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetInvertIfNegative(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public static DocumentModel.Drawings.Charts.PictureOptions? GetPictureOptions(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPictureOptions(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement, DocumentModel.Drawings.Charts.PictureOptions? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataPoint>? GetDataPoints(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataPoints(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataPoint>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Trendline>? GetTrendlines(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTrendlines(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Trendline>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.ErrorBars? GetErrorBars(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetErrorBars(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement, DocumentModel.Drawings.Charts.ErrorBars? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.CategoryAxisData? GetCategoryAxisData(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCategoryAxisData(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement, DocumentModel.Drawings.Charts.CategoryAxisData? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.Values? GetValues(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetValues(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement, DocumentModel.Drawings.Charts.Values? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.ShapeKind? GetShape(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Shape>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DocumentModel.Drawings.Charts.ShapeKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetShape(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement, DocumentModel.Drawings.Charts.ShapeKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Shape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Shape, DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DocumentModel.Drawings.Charts.ShapeKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BarSerExtensionList? GetBarSerExtensionList(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBarSerExtensionList(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement, DocumentModel.Drawings.Charts.BarSerExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the SeriesElementVisibilities Class.
/// </summary>
public static class SeriesElementVisibilitiesConverter
{
  /// <summary>
  /// connectorLines, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetConnectorLines(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities openXmlElement)
  {
    return openXmlElement?.ConnectorLines?.Value;
  }
  
  private static void SetConnectorLines(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ConnectorLines = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ConnectorLines = null;
  }
  
  /// <summary>
  /// meanLine, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetMeanLine(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities openXmlElement)
  {
    return openXmlElement?.MeanLine?.Value;
  }
  
  private static void SetMeanLine(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.MeanLine = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.MeanLine = null;
  }
  
  /// <summary>
  /// meanMarker, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetMeanMarker(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities openXmlElement)
  {
    return openXmlElement?.MeanMarker?.Value;
  }
  
  private static void SetMeanMarker(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.MeanMarker = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.MeanMarker = null;
  }
  
  /// <summary>
  /// nonoutliers, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetNonoutliers(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities openXmlElement)
  {
    return openXmlElement?.Nonoutliers?.Value;
  }
  
  private static void SetNonoutliers(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Nonoutliers = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Nonoutliers = null;
  }
  
  /// <summary>
  /// outliers, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetOutliers(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities openXmlElement)
  {
    return openXmlElement?.Outliers?.Value;
  }
  
  private static void SetOutliers(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Outliers = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Outliers = null;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.SeriesElementVisibilities? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.SeriesElementVisibilities();
      value.ConnectorLines = GetConnectorLines(openXmlElement);
      value.MeanLine = GetMeanLine(openXmlElement);
      value.MeanMarker = GetMeanMarker(openXmlElement);
      value.Nonoutliers = GetNonoutliers(openXmlElement);
      value.Outliers = GetOutliers(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.SeriesElementVisibilities? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetConnectorLines(openXmlElement, value?.ConnectorLines);
      SetMeanLine(openXmlElement, value?.MeanLine);
      SetMeanMarker(openXmlElement, value?.MeanMarker);
      SetNonoutliers(openXmlElement, value?.Nonoutliers);
      SetOutliers(openXmlElement, value?.Outliers);
      return openXmlElement;
    }
    return default;
  }
}

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the SeriesElementVisibilities Class.
/// </summary>
public static class SeriesElementVisibilitiesConverter
{
  /// <summary>
  /// connectorLines, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetConnectorLines(DXO16DCD.SeriesElementVisibilities openXmlElement)
  {
    return openXmlElement?.ConnectorLines?.Value;
  }
  
  private static bool CmpConnectorLines(DXO16DCD.SeriesElementVisibilities openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ConnectorLines?.Value == value) return true;
    diffs?.Add(objName, "ConnectorLines", openXmlElement?.ConnectorLines?.Value, value);
    return false;
  }
  
  private static void SetConnectorLines(DXO16DCD.SeriesElementVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ConnectorLines = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ConnectorLines = null;
  }
  
  /// <summary>
  /// meanLine, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetMeanLine(DXO16DCD.SeriesElementVisibilities openXmlElement)
  {
    return openXmlElement?.MeanLine?.Value;
  }
  
  private static bool CmpMeanLine(DXO16DCD.SeriesElementVisibilities openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.MeanLine?.Value == value) return true;
    diffs?.Add(objName, "MeanLine", openXmlElement?.MeanLine?.Value, value);
    return false;
  }
  
  private static void SetMeanLine(DXO16DCD.SeriesElementVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.MeanLine = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.MeanLine = null;
  }
  
  /// <summary>
  /// meanMarker, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetMeanMarker(DXO16DCD.SeriesElementVisibilities openXmlElement)
  {
    return openXmlElement?.MeanMarker?.Value;
  }
  
  private static bool CmpMeanMarker(DXO16DCD.SeriesElementVisibilities openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.MeanMarker?.Value == value) return true;
    diffs?.Add(objName, "MeanMarker", openXmlElement?.MeanMarker?.Value, value);
    return false;
  }
  
  private static void SetMeanMarker(DXO16DCD.SeriesElementVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.MeanMarker = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.MeanMarker = null;
  }
  
  /// <summary>
  /// nonoutliers, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetNonoutliers(DXO16DCD.SeriesElementVisibilities openXmlElement)
  {
    return openXmlElement?.Nonoutliers?.Value;
  }
  
  private static bool CmpNonoutliers(DXO16DCD.SeriesElementVisibilities openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Nonoutliers?.Value == value) return true;
    diffs?.Add(objName, "Nonoutliers", openXmlElement?.Nonoutliers?.Value, value);
    return false;
  }
  
  private static void SetNonoutliers(DXO16DCD.SeriesElementVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Nonoutliers = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Nonoutliers = null;
  }
  
  /// <summary>
  /// outliers, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetOutliers(DXO16DCD.SeriesElementVisibilities openXmlElement)
  {
    return openXmlElement?.Outliers?.Value;
  }
  
  private static bool CmpOutliers(DXO16DCD.SeriesElementVisibilities openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Outliers?.Value == value) return true;
    diffs?.Add(objName, "Outliers", openXmlElement?.Outliers?.Value, value);
    return false;
  }
  
  private static void SetOutliers(DXO16DCD.SeriesElementVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Outliers = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Outliers = null;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.SeriesElementVisibilities? CreateModelElement(DXO16DCD.SeriesElementVisibilities? openXmlElement)
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
  
  public static bool CompareModelElement(DXO16DCD.SeriesElementVisibilities? openXmlElement, DMDCDs.SeriesElementVisibilities? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpConnectorLines(openXmlElement, value.ConnectorLines, diffs, objName, propName))
        ok = false;
      if (!CmpMeanLine(openXmlElement, value.MeanLine, diffs, objName, propName))
        ok = false;
      if (!CmpMeanMarker(openXmlElement, value.MeanMarker, diffs, objName, propName))
        ok = false;
      if (!CmpNonoutliers(openXmlElement, value.Nonoutliers, diffs, objName, propName))
        ok = false;
      if (!CmpOutliers(openXmlElement, value.Outliers, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.SeriesElementVisibilities value)
    where OpenXmlElementType: DXO16DCD.SeriesElementVisibilities, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.SeriesElementVisibilities openXmlElement, DMDCDs.SeriesElementVisibilities value)
  {
    SetConnectorLines(openXmlElement, value?.ConnectorLines);
    SetMeanLine(openXmlElement, value?.MeanLine);
    SetMeanMarker(openXmlElement, value?.MeanMarker);
    SetNonoutliers(openXmlElement, value?.Nonoutliers);
    SetOutliers(openXmlElement, value?.Outliers);
  }
}

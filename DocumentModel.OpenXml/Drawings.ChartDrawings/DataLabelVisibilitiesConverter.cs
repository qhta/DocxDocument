using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the DataLabelVisibilities Class.
/// </summary>
public static class DataLabelVisibilitiesConverter
{
  /// <summary>
  ///   seriesName, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetSeriesName(DataLabelVisibilities? openXmlElement)
  {
    return openXmlElement?.SeriesName?.Value;
  }

  public static void SetSeriesName(DataLabelVisibilities? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SeriesName = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.SeriesName = null;
  }

  /// <summary>
  ///   categoryName, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetCategoryName(DataLabelVisibilities? openXmlElement)
  {
    return openXmlElement?.CategoryName?.Value;
  }

  public static void SetCategoryName(DataLabelVisibilities? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CategoryName = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.CategoryName = null;
  }

  /// <summary>
  ///   value, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetValue(DataLabelVisibilities? openXmlElement)
  {
    return openXmlElement?.Value?.Value;
  }

  public static void SetValue(DataLabelVisibilities? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Value = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Value = null;
  }

  public static DocumentModel.Drawings.ChartDrawings.DataLabelVisibilities? CreateModelElement(DataLabelVisibilities? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.DataLabelVisibilities();
      value.SeriesName = GetSeriesName(openXmlElement);
      value.CategoryName = GetCategoryName(openXmlElement);
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.DataLabelVisibilities? value)
    where OpenXmlElementType : DataLabelVisibilities, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSeriesName(openXmlElement, value?.SeriesName);
      SetCategoryName(openXmlElement, value?.CategoryName);
      SetValue(openXmlElement, value?.Value);
      return openXmlElement;
    }
    return default;
  }
}
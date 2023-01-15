using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using Chart = DocumentFormat.OpenXml.Drawing.Chart;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Chart to Animate.
/// </summary>
public static class ChartConverter
{
  /// <summary>
  ///   Series Index
  /// </summary>
  public static Int32? GetSeriesIndex(Chart? openXmlElement)
  {
    return openXmlElement?.SeriesIndex?.Value;
  }

  public static void SetSeriesIndex(Chart? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SeriesIndex = value;
  }

  /// <summary>
  ///   Category Index
  /// </summary>
  public static Int32? GetCategoryIndex(Chart? openXmlElement)
  {
    return openXmlElement?.CategoryIndex?.Value;
  }

  public static void SetCategoryIndex(Chart? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.CategoryIndex = value;
  }

  /// <summary>
  ///   Animation Build Step
  /// </summary>
  public static ChartBuildStepKind? GetBuildStep(Chart? openXmlElement)
  {
    return EnumValueConverter.GetValue<ChartBuildStepValues, ChartBuildStepKind>(openXmlElement?.BuildStep?.Value);
  }

  public static void SetBuildStep(Chart? openXmlElement, ChartBuildStepKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.BuildStep = EnumValueConverter.CreateEnumValue<ChartBuildStepValues, ChartBuildStepKind>(value);
  }

  public static DocumentModel.Drawings.Chart? CreateModelElement(Chart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Chart();
      value.SeriesIndex = GetSeriesIndex(openXmlElement);
      value.CategoryIndex = GetCategoryIndex(openXmlElement);
      value.BuildStep = GetBuildStep(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Chart? value)
    where OpenXmlElementType : Chart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSeriesIndex(openXmlElement, value?.SeriesIndex);
      SetCategoryIndex(openXmlElement, value?.CategoryIndex);
      SetBuildStep(openXmlElement, value?.BuildStep);
      return openXmlElement;
    }
    return default;
  }
}
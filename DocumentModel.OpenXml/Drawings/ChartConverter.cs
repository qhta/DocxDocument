namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Chart to Animate.
/// </summary>
public static class ChartConverter
{
  /// <summary>
  /// Series Index
  /// </summary>
  private static Int32? GetSeriesIndex(DocumentFormat.OpenXml.Drawing.Chart openXmlElement)
  {
    return openXmlElement.SeriesIndex?.Value;
  }
  
  private static void SetSeriesIndex(DocumentFormat.OpenXml.Drawing.Chart openXmlElement, Int32? value)
  {
    openXmlElement.SeriesIndex = value;
  }
  
  /// <summary>
  /// Category Index
  /// </summary>
  private static Int32? GetCategoryIndex(DocumentFormat.OpenXml.Drawing.Chart openXmlElement)
  {
    return openXmlElement.CategoryIndex?.Value;
  }
  
  private static void SetCategoryIndex(DocumentFormat.OpenXml.Drawing.Chart openXmlElement, Int32? value)
  {
    openXmlElement.CategoryIndex = value;
  }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  private static DocumentModel.Drawings.ChartBuildStepKind? GetBuildStep(DocumentFormat.OpenXml.Drawing.Chart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ChartBuildStepValues, DocumentModel.Drawings.ChartBuildStepKind>(openXmlElement?.BuildStep?.Value);
  }
  
  private static void SetBuildStep(DocumentFormat.OpenXml.Drawing.Chart openXmlElement, DocumentModel.Drawings.ChartBuildStepKind? value)
  {
    openXmlElement.BuildStep = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ChartBuildStepValues, DocumentModel.Drawings.ChartBuildStepKind>(value);
  }
  
  public static DocumentModel.Drawings.Chart? CreateModelElement(DocumentFormat.OpenXml.Drawing.Chart? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Chart, new()
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

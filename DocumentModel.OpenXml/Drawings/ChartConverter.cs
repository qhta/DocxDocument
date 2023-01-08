namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Chart to Animate.
/// </summary>
public static class ChartConverter
{
  /// <summary>
  /// Series Index
  /// </summary>
  public static Int32? GetSeriesIndex(DocumentFormat.OpenXml.Drawing.Chart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSeriesIndex(DocumentFormat.OpenXml.Drawing.Chart? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Category Index
  /// </summary>
  public static Int32? GetCategoryIndex(DocumentFormat.OpenXml.Drawing.Chart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCategoryIndex(DocumentFormat.OpenXml.Drawing.Chart? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  public static DocumentModel.Drawings.ChartBuildStepKind? GetBuildStep(DocumentFormat.OpenXml.Drawing.Chart? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ChartBuildStepValues, DocumentModel.Drawings.ChartBuildStepKind>(openXmlElement?.BuildStep?.Value);
  }
  
  public static void SetBuildStep(DocumentFormat.OpenXml.Drawing.Chart? openXmlElement, DocumentModel.Drawings.ChartBuildStepKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.BuildStep = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ChartBuildStepValues, DocumentModel.Drawings.ChartBuildStepKind>(value);
  }
  
}

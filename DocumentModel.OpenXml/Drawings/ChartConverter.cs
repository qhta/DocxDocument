namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Chart to Animate.
/// </summary>
public static class ChartConverter
{
  /// <summary>
  /// Series Index
  /// </summary>
  private static Int32? GetSeriesIndex(DXDraw.Chart openXmlElement)
  {
    return openXmlElement.SeriesIndex?.Value;
  }
  
  private static bool CmpSeriesIndex(DXDraw.Chart openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.SeriesIndex?.Value == value;
  }
  
  private static void SetSeriesIndex(DXDraw.Chart openXmlElement, Int32? value)
  {
    openXmlElement.SeriesIndex = value;
  }
  
  /// <summary>
  /// Category Index
  /// </summary>
  private static Int32? GetCategoryIndex(DXDraw.Chart openXmlElement)
  {
    return openXmlElement.CategoryIndex?.Value;
  }
  
  private static bool CmpCategoryIndex(DXDraw.Chart openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.CategoryIndex?.Value == value;
  }
  
  private static void SetCategoryIndex(DXDraw.Chart openXmlElement, Int32? value)
  {
    openXmlElement.CategoryIndex = value;
  }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  private static DMDraws.ChartBuildStepKind? GetBuildStep(DXDraw.Chart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ChartBuildStepValues, DMDraws.ChartBuildStepKind>(openXmlElement?.BuildStep?.Value);
  }
  
  private static bool CmpBuildStep(DXDraw.Chart openXmlElement, DMDraws.ChartBuildStepKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ChartBuildStepValues, DMDraws.ChartBuildStepKind>(openXmlElement?.BuildStep?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBuildStep(DXDraw.Chart openXmlElement, DMDraws.ChartBuildStepKind? value)
  {
    openXmlElement.BuildStep = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ChartBuildStepValues, DMDraws.ChartBuildStepKind>(value);
  }
  
  public static DMDraws.Chart? CreateModelElement(DXDraw.Chart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Chart();
      value.SeriesIndex = GetSeriesIndex(openXmlElement);
      value.CategoryIndex = GetCategoryIndex(openXmlElement);
      value.BuildStep = GetBuildStep(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.Chart? openXmlElement, DMDraws.Chart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSeriesIndex(openXmlElement, value.SeriesIndex, diffs, objName))
        ok = false;
      if (!CmpCategoryIndex(openXmlElement, value.CategoryIndex, diffs, objName))
        ok = false;
      if (!CmpBuildStep(openXmlElement, value.BuildStep, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Chart? value)
    where OpenXmlElementType: DXDraw.Chart, new()
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

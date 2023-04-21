namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Chart to Animate.
/// </summary>
public static class ChartConverter
{
  /// <summary>
  /// Series Index
  /// </summary>
  private static Int32? GetSeriesIndex(DXD.Chart openXmlElement)
  {
    return openXmlElement?.SeriesIndex?.Value;
  }
  
  private static bool CmpSeriesIndex(DXD.Chart openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SeriesIndex?.Value == value) return true;
    diffs?.Add(objName, "SeriesIndex", openXmlElement?.SeriesIndex?.Value, value);
    return false;
  }
  
  private static void SetSeriesIndex(DXD.Chart openXmlElement, Int32? value)
  {
    openXmlElement.SeriesIndex = value;
  }
  
  /// <summary>
  /// Category Index
  /// </summary>
  private static Int32? GetCategoryIndex(DXD.Chart openXmlElement)
  {
    return openXmlElement?.CategoryIndex?.Value;
  }
  
  private static bool CmpCategoryIndex(DXD.Chart openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CategoryIndex?.Value == value) return true;
    diffs?.Add(objName, "CategoryIndex", openXmlElement?.CategoryIndex?.Value, value);
    return false;
  }
  
  private static void SetCategoryIndex(DXD.Chart openXmlElement, Int32? value)
  {
    openXmlElement.CategoryIndex = value;
  }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  private static DMD.ChartBuildStepKind? GetBuildStep(DXD.Chart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ChartBuildStepValues, DMD.ChartBuildStepKind>(openXmlElement?.BuildStep?.Value);
  }
  
  private static bool CmpBuildStep(DXD.Chart openXmlElement, DMD.ChartBuildStepKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.ChartBuildStepValues, DMD.ChartBuildStepKind>(openXmlElement?.BuildStep?.Value, value, diffs, objName);
  }
  
  private static void SetBuildStep(DXD.Chart openXmlElement, DMD.ChartBuildStepKind? value)
  {
    openXmlElement.BuildStep = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ChartBuildStepValues, DMD.ChartBuildStepKind>(value);
  }
  
  public static DocumentModel.Drawings.Chart? CreateModelElement(DXD.Chart? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.Chart? openXmlElement, DMD.Chart? value, DiffList? diffs, string? objName)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Chart value)
    where OpenXmlElementType: DXD.Chart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Chart openXmlElement, DMD.Chart value)
  {
    SetSeriesIndex(openXmlElement, value?.SeriesIndex);
    SetCategoryIndex(openXmlElement, value?.CategoryIndex);
    SetBuildStep(openXmlElement, value?.BuildStep);
  }
}

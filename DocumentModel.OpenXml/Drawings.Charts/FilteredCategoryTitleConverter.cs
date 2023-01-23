namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredCategoryTitle Class.
/// </summary>
public static class FilteredCategoryTitleConverter
{
  /// <summary>
  /// AxisDataSourceType.
  /// </summary>
  private static DMDrawsCharts.AxisDataSourceType3? GetAxisDataSourceType(DXO2013DrawChart.FilteredCategoryTitle openXmlElement)
  {
    return DMXDrawsCharts.AxisDataSourceType3Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.AxisDataSourceType>());
  }
  
  private static bool CmpAxisDataSourceType(DXO2013DrawChart.FilteredCategoryTitle openXmlElement, DMDrawsCharts.AxisDataSourceType3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.AxisDataSourceType3Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.AxisDataSourceType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAxisDataSourceType(DXO2013DrawChart.FilteredCategoryTitle openXmlElement, DMDrawsCharts.AxisDataSourceType3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.AxisDataSourceType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.AxisDataSourceType3Converter.CreateOpenXmlElement<DXO2013DrawChart.AxisDataSourceType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.FilteredCategoryTitle? CreateModelElement(DXO2013DrawChart.FilteredCategoryTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.FilteredCategoryTitle();
      value.AxisDataSourceType = GetAxisDataSourceType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.FilteredCategoryTitle? openXmlElement, DMDrawsCharts.FilteredCategoryTitle? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAxisDataSourceType(openXmlElement, value.AxisDataSourceType, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FilteredCategoryTitle? value)
    where OpenXmlElementType: DXO2013DrawChart.FilteredCategoryTitle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAxisDataSourceType(openXmlElement, value?.AxisDataSourceType);
      return openXmlElement;
    }
    return default;
  }
}

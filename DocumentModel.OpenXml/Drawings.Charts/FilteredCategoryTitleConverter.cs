namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredCategoryTitle Class.
/// </summary>
public static class FilteredCategoryTitleConverter
{
  /// <summary>
  /// AxisDataSourceType.
  /// </summary>
  private static DMDC.AxisDataSourceType3? GetAxisDataSourceType(DXO13DC.FilteredCategoryTitle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.AxisDataSourceType>();
    if (element != null)
      return DMXDC.AxisDataSourceType3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAxisDataSourceType(DXO13DC.FilteredCategoryTitle openXmlElement, DMDC.AxisDataSourceType3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.AxisDataSourceType3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.AxisDataSourceType>(), value, diffs, objName, propName);
  }
  
  private static void SetAxisDataSourceType(DXO13DC.FilteredCategoryTitle openXmlElement, DMDC.AxisDataSourceType3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.AxisDataSourceType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.AxisDataSourceType3Converter.CreateOpenXmlElement<DXO13DC.AxisDataSourceType>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.FilteredCategoryTitle? CreateModelElement(DXO13DC.FilteredCategoryTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.FilteredCategoryTitle();
      value.AxisDataSourceType = GetAxisDataSourceType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.FilteredCategoryTitle? openXmlElement, DMDC.FilteredCategoryTitle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAxisDataSourceType(openXmlElement, value.AxisDataSourceType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.FilteredCategoryTitle value)
    where OpenXmlElementType: DXO13DC.FilteredCategoryTitle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.FilteredCategoryTitle openXmlElement, DMDC.FilteredCategoryTitle value)
  {
    SetAxisDataSourceType(openXmlElement, value?.AxisDataSourceType);
  }
}

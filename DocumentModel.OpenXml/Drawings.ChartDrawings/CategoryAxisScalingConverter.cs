namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the CategoryAxisScaling Class.
/// </summary>
public static class CategoryAxisScalingConverter
{
  /// <summary>
  /// gapWidth, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetGapWidth(DXO16DCD.CategoryAxisScaling openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GapWidth);
  }
  
  private static bool CmpGapWidth(DXO16DCD.CategoryAxisScaling openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GapWidth, value, diffs, objName, "GapWidth");
  }
  
  private static void SetGapWidth(DXO16DCD.CategoryAxisScaling openXmlElement, String? value)
  {
    openXmlElement.GapWidth = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMDCDs.CategoryAxisScaling? CreateModelElement(DXO16DCD.CategoryAxisScaling? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.CategoryAxisScaling();
      value.GapWidth = GetGapWidth(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.CategoryAxisScaling? openXmlElement, DMDCDs.CategoryAxisScaling? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGapWidth(openXmlElement, value.GapWidth, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.CategoryAxisScaling value)
    where OpenXmlElementType: DXO16DCD.CategoryAxisScaling, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.CategoryAxisScaling openXmlElement, DMDCDs.CategoryAxisScaling value)
  {
    SetGapWidth(openXmlElement, value?.GapWidth);
  }
}

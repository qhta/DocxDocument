namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataDisplayOptions16 Class.
/// </summary>
public static class DataDisplayOptions16Converter
{
  /// <summary>
  /// BooleanFalse.
  /// </summary>
  private static Boolean? GetBooleanFalse(DXDrawCharts.DataDisplayOptions16 openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2019DrawChart.BooleanFalse>() != null;
  }
  
  private static bool CmpBooleanFalse(DXDrawCharts.DataDisplayOptions16 openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2019DrawChart.BooleanFalse>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2019DrawChart.BooleanFalse", val, value);
    return false;
  }
  
  private static void SetBooleanFalse(DXDrawCharts.DataDisplayOptions16 openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2019DrawChart.BooleanFalse>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2019DrawChart.BooleanFalse();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataDisplayOptions16? CreateModelElement(DXDrawCharts.DataDisplayOptions16? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataDisplayOptions16();
      value.BooleanFalse = GetBooleanFalse(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.DataDisplayOptions16? openXmlElement, DMDrawsCharts.DataDisplayOptions16? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBooleanFalse(openXmlElement, value.BooleanFalse, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DataDisplayOptions16 value)
    where OpenXmlElementType: DXDrawCharts.DataDisplayOptions16, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.DataDisplayOptions16 openXmlElement, DMDrawsCharts.DataDisplayOptions16 value)
  {
    SetBooleanFalse(openXmlElement, value?.BooleanFalse);
  }
}

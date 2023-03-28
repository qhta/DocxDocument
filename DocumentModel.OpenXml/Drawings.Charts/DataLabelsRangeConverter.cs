namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataLabelsRange Class converter from/to OpenXml.
///</summary>
public static class DataLabelsRangeConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  private static String? GetFormula(DXO2013DrawChart.DataLabelsRange openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO2013DrawChart.Formula>()?.Text;
  }
  
  private static bool CmpFormula(DXO2013DrawChart.DataLabelsRange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2013DrawChart.Formula>()?.Text == value;
  }
  
  private static void SetFormula(DXO2013DrawChart.DataLabelsRange openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.Formula>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2013DrawChart.Formula { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataLabelsRangeChache.
  /// </summary>
  private static DMDrawsCharts.DataLabelsRangeChache? GetDataLabelsRangeChache(DXO2013DrawChart.DataLabelsRange openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.DataLabelsRangeChache>();
    if (element != null)
      return DMXDrawsCharts.DataLabelsRangeChacheConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabelsRangeChache(DXO2013DrawChart.DataLabelsRange openXmlElement, DMDrawsCharts.DataLabelsRangeChache? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsRangeChacheConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.DataLabelsRangeChache>(), value, diffs, objName);
  }
  
  private static void SetDataLabelsRangeChache(DXO2013DrawChart.DataLabelsRange openXmlElement, DMDrawsCharts.DataLabelsRangeChache? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.DataLabelsRangeChache>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DataLabelsRangeChacheConverter.CreateOpenXmlElement<DXO2013DrawChart.DataLabelsRangeChache>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabelsRange? CreateModelElement(DXO2013DrawChart.DataLabelsRange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataLabelsRange();
      value.Formula = GetFormula(openXmlElement);
      value.DataLabelsRangeChache = GetDataLabelsRangeChache(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.DataLabelsRange? openXmlElement, DMDrawsCharts.DataLabelsRange? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormula(openXmlElement, value.Formula, diffs, objName))
        ok = false;
      if (!CmpDataLabelsRangeChache(openXmlElement, value.DataLabelsRangeChache, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DataLabelsRange value)
    where OpenXmlElementType: DXO2013DrawChart.DataLabelsRange, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChart.DataLabelsRange openXmlElement, DMDrawsCharts.DataLabelsRange value)
  {
    SetFormula(openXmlElement, value?.Formula);
    SetDataLabelsRangeChache(openXmlElement, value?.DataLabelsRangeChache);
  }
}

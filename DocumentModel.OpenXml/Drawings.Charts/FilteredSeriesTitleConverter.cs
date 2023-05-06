namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredSeriesTitle Class.
/// </summary>
public static class FilteredSeriesTitleConverter
{
  /// <summary>
  /// ChartText.
  /// </summary>
  private static DMDC.ChartText3? GetChartText(DXO13DC.FilteredSeriesTitle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.ChartText>();
    if (element != null)
      return DMXDC.ChartText3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartText(DXO13DC.FilteredSeriesTitle openXmlElement, DMDC.ChartText3? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ChartText3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.ChartText>(), value, diffs, objName);
  }
  
  private static void SetChartText(DXO13DC.FilteredSeriesTitle openXmlElement, DMDC.ChartText3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.ChartText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartText3Converter.CreateOpenXmlElement<DXO13DC.ChartText>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredSeriesTitle? CreateModelElement(DXO13DC.FilteredSeriesTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredSeriesTitle();
      value.ChartText = GetChartText(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.FilteredSeriesTitle? openXmlElement, DMDC.FilteredSeriesTitle? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChartText(openXmlElement, value.ChartText, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.FilteredSeriesTitle value)
    where OpenXmlElementType: DXO13DC.FilteredSeriesTitle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.FilteredSeriesTitle openXmlElement, DMDC.FilteredSeriesTitle value)
  {
    SetChartText(openXmlElement, value?.ChartText);
  }
}

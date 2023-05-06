namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Band Format.
/// </summary>
public static class BandFormatConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXDC.BandFormat openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val);
  }
  
  private static bool CmpIndex(DXDC.BandFormat openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val, value, diffs, objName, "Index");
  }
  
  private static void SetIndex(DXDC.BandFormat openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Index,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXDC.BandFormat openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDC.BandFormat openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetChartShapeProperties(DXDC.BandFormat openXmlElement, DMDC.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.BandFormat? CreateModelElement(DXDC.BandFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BandFormat();
      value.Index = GetIndex(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.BandFormat? openXmlElement, DMDC.BandFormat? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.BandFormat value)
    where OpenXmlElementType: DXDC.BandFormat, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.BandFormat openXmlElement, DMDC.BandFormat value)
  {
    SetIndex(openXmlElement, value?.Index);
    SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
  }
}

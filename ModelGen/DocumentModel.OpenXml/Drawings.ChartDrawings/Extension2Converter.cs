namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Extension2 Class.
/// </summary>
public static class Extension2Converter
{
  /// <summary>
  /// uri, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetUri(DXO2016DrawChartDraw.Extension2 openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXO2016DrawChartDraw.Extension2 openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXO2016DrawChartDraw.Extension2 openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Extension2? CreateModelElement(DXO2016DrawChartDraw.Extension2? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Extension2();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.Extension2? openXmlElement, DMDrawsChartDraws.Extension2? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Extension2 value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Extension2, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.Extension2 openXmlElement, DMDrawsChartDraws.Extension2 value)
  {
    SetUri(openXmlElement, value?.Uri);
  }
}

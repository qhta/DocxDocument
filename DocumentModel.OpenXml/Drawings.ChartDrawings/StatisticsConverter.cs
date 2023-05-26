namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Statistics Class.
/// </summary>
public static class StatisticsConverter
{
  /// <summary>
  /// quartileMethod, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.QuartileMethod? GetQuartileMethod(DXO16DCD.Statistics openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod, DMDCDs.QuartileMethod>(openXmlElement?.QuartileMethod?.Value);
  }
  
  private static bool CmpQuartileMethod(DXO16DCD.Statistics openXmlElement, DMDCDs.QuartileMethod? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod, DMDCDs.QuartileMethod>(openXmlElement?.QuartileMethod?.Value, value, diffs, objName, propName);
  }
  
  private static void SetQuartileMethod(DXO16DCD.Statistics openXmlElement, DMDCDs.QuartileMethod? value)
  {
    openXmlElement.QuartileMethod = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod, DMDCDs.QuartileMethod>(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Statistics? CreateModelElement(DXO16DCD.Statistics? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Statistics();
      value.QuartileMethod = GetQuartileMethod(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.Statistics? openXmlElement, DMDCDs.Statistics? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpQuartileMethod(openXmlElement, value.QuartileMethod, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.Statistics value)
    where OpenXmlElementType: DXO16DCD.Statistics, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.Statistics openXmlElement, DMDCDs.Statistics value)
  {
    SetQuartileMethod(openXmlElement, value?.QuartileMethod);
  }
}

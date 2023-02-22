namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Statistics Class.
/// </summary>
public static class StatisticsConverter
{
  /// <summary>
  /// quartileMethod, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.QuartileMethod? GetQuartileMethod(DXO2016DrawChartDraw.Statistics openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod, DMDrawsChartDraws.QuartileMethod>(openXmlElement?.QuartileMethod?.Value);
  }
  
  private static bool CmpQuartileMethod(DXO2016DrawChartDraw.Statistics openXmlElement, DMDrawsChartDraws.QuartileMethod? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod, DMDrawsChartDraws.QuartileMethod>(openXmlElement?.QuartileMethod?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetQuartileMethod(DXO2016DrawChartDraw.Statistics openXmlElement, DMDrawsChartDraws.QuartileMethod? value)
  {
    openXmlElement.QuartileMethod = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod, DMDrawsChartDraws.QuartileMethod>(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Statistics? CreateModelElement(DXO2016DrawChartDraw.Statistics? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Statistics();
      value.QuartileMethod = GetQuartileMethod(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.Statistics? openXmlElement, DMDrawsChartDraws.Statistics? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpQuartileMethod(openXmlElement, value.QuartileMethod, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Statistics value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Statistics, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.Statistics openXmlElement, DMDrawsChartDraws.Statistics value)
  {
    SetQuartileMethod(openXmlElement, value?.QuartileMethod);
    }
  }

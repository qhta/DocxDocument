namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the OpenXmlFormulaElement Class.
/// </summary>
public static class OpenXmlFormulaElementConverter
{
  /// <summary>
  /// dir, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.FormulaDirection? GetDir(DXO2016DrawChartDraw.OpenXmlFormulaElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection, DMDrawsChartDraws.FormulaDirection>(openXmlElement?.Dir?.Value);
  }
  
  private static bool CmpDir(DXO2016DrawChartDraw.OpenXmlFormulaElement openXmlElement, DMDrawsChartDraws.FormulaDirection? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection, DMDrawsChartDraws.FormulaDirection>(openXmlElement?.Dir?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDir(DXO2016DrawChartDraw.OpenXmlFormulaElement openXmlElement, DMDrawsChartDraws.FormulaDirection? value)
  {
    openXmlElement.Dir = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection, DMDrawsChartDraws.FormulaDirection>(value);
  }
  
  public static DMDrawsChartDraws.OpenXmlFormulaElement? CreateModelElement(DXO2016DrawChartDraw.OpenXmlFormulaElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.OpenXmlFormulaElement();
      value.Dir = GetDir(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.OpenXmlFormulaElement? openXmlElement, DMDrawsChartDraws.OpenXmlFormulaElement? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDir(openXmlElement, value.Dir, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.OpenXmlFormulaElement? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.OpenXmlFormulaElement, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDir(openXmlElement, value?.Dir);
      return openXmlElement;
    }
    return default;
  }
}

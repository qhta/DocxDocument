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
  
  public static DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? CreateModelElement(DXO2016DrawChartDraw.OpenXmlFormulaElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement();
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.OpenXmlFormulaElement value)
    where OpenXmlElementType: DXO2016DrawChartDraw.OpenXmlFormulaElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.OpenXmlFormulaElement openXmlElement, DMDrawsChartDraws.OpenXmlFormulaElement value)
  {
    SetDir(openXmlElement, value?.Dir);
    }
  }

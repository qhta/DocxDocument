namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the OpenXmlFormulaElement Class.
/// </summary>
public static class OpenXmlFormulaElementConverter
{
  /// <summary>
  /// dir, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.FormulaDirection? GetDir(DXO16DCD.OpenXmlFormulaElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection, DMDCDs.FormulaDirection>(openXmlElement?.Dir?.Value);
  }
  
  private static bool CmpDir(DXO16DCD.OpenXmlFormulaElement openXmlElement, DMDCDs.FormulaDirection? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection, DMDCDs.FormulaDirection>(openXmlElement?.Dir?.Value, value, diffs, objName, propName);
  }
  
  private static void SetDir(DXO16DCD.OpenXmlFormulaElement openXmlElement, DMDCDs.FormulaDirection? value)
  {
    openXmlElement.Dir = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection, DMDCDs.FormulaDirection>(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? CreateModelElement(DXO16DCD.OpenXmlFormulaElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement();
      value.Dir = GetDir(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.OpenXmlFormulaElement? openXmlElement, DMDCDs.OpenXmlFormulaElement? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDir(openXmlElement, value.Dir, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.OpenXmlFormulaElement value)
    where OpenXmlElementType: DXO16DCD.OpenXmlFormulaElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.OpenXmlFormulaElement openXmlElement, DMDCDs.OpenXmlFormulaElement value)
  {
    SetDir(openXmlElement, value?.Dir);
  }
}

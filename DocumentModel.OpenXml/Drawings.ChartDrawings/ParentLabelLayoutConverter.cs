namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ParentLabelLayout Class.
/// </summary>
public static class ParentLabelLayoutConverter
{
  /// <summary>
  /// val, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.ParentLabelLayoutVal? GetParentLabelLayoutVal(DXO2016DrawChartDraw.ParentLabelLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal, DMDrawsChartDraws.ParentLabelLayoutVal>(openXmlElement?.ParentLabelLayoutVal?.Value);
  }
  
  private static bool CmpParentLabelLayoutVal(DXO2016DrawChartDraw.ParentLabelLayout openXmlElement, DMDrawsChartDraws.ParentLabelLayoutVal? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal, DMDrawsChartDraws.ParentLabelLayoutVal>(openXmlElement?.ParentLabelLayoutVal?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetParentLabelLayoutVal(DXO2016DrawChartDraw.ParentLabelLayout openXmlElement, DMDrawsChartDraws.ParentLabelLayoutVal? value)
  {
    openXmlElement.ParentLabelLayoutVal = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal, DMDrawsChartDraws.ParentLabelLayoutVal>(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ParentLabelLayout? CreateModelElement(DXO2016DrawChartDraw.ParentLabelLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ParentLabelLayout();
      value.ParentLabelLayoutVal = GetParentLabelLayoutVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.ParentLabelLayout? openXmlElement, DMDrawsChartDraws.ParentLabelLayout? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpParentLabelLayoutVal(openXmlElement, value.ParentLabelLayoutVal, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ParentLabelLayout value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ParentLabelLayout, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.ParentLabelLayout openXmlElement, DMDrawsChartDraws.ParentLabelLayout value)
  {
    SetParentLabelLayoutVal(openXmlElement, value?.ParentLabelLayoutVal);
  }
}

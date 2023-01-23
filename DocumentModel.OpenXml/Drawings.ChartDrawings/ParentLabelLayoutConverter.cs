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
  
  public static DMDrawsChartDraws.ParentLabelLayout? CreateModelElement(DXO2016DrawChartDraw.ParentLabelLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.ParentLabelLayout();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ParentLabelLayout? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ParentLabelLayout, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParentLabelLayoutVal(openXmlElement, value?.ParentLabelLayoutVal);
      return openXmlElement;
    }
    return default;
  }
}

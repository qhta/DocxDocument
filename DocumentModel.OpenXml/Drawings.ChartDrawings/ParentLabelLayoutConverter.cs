namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ParentLabelLayout Class.
/// </summary>
public static class ParentLabelLayoutConverter
{
  /// <summary>
  /// val, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.ParentLabelLayoutVal? GetParentLabelLayoutVal(DXO16DCD.ParentLabelLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal, DMDCDs.ParentLabelLayoutVal>(openXmlElement?.ParentLabelLayoutVal?.Value);
  }
  
  private static bool CmpParentLabelLayoutVal(DXO16DCD.ParentLabelLayout openXmlElement, DMDCDs.ParentLabelLayoutVal? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal, DMDCDs.ParentLabelLayoutVal>(openXmlElement?.ParentLabelLayoutVal?.Value, value, diffs, objName, propName);
  }
  
  private static void SetParentLabelLayoutVal(DXO16DCD.ParentLabelLayout openXmlElement, DMDCDs.ParentLabelLayoutVal? value)
  {
    openXmlElement.ParentLabelLayoutVal = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal, DMDCDs.ParentLabelLayoutVal>(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ParentLabelLayout? CreateModelElement(DXO16DCD.ParentLabelLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ParentLabelLayout();
      value.ParentLabelLayoutVal = GetParentLabelLayoutVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.ParentLabelLayout? openXmlElement, DMDCDs.ParentLabelLayout? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpParentLabelLayoutVal(openXmlElement, value.ParentLabelLayoutVal, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.ParentLabelLayout value)
    where OpenXmlElementType: DXO16DCD.ParentLabelLayout, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.ParentLabelLayout openXmlElement, DMDCDs.ParentLabelLayout value)
  {
    SetParentLabelLayoutVal(openXmlElement, value?.ParentLabelLayoutVal);
  }
}

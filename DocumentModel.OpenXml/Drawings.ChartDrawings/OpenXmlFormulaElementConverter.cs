namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the OpenXmlFormulaElement Class.
/// </summary>
public static class OpenXmlFormulaElementConverter
{
  /// <summary>
  /// dir, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.FormulaDirection? GetDir(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection, DocumentModel.Drawings.ChartDrawings.FormulaDirection>(openXmlElement?.Dir?.Value);
  }
  
  public static void SetDir(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement? openXmlElement, DocumentModel.Drawings.ChartDrawings.FormulaDirection? value)
  {
    if (openXmlElement != null)
      openXmlElement.Dir = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection, DocumentModel.Drawings.ChartDrawings.FormulaDirection>(value);
  }
  
}

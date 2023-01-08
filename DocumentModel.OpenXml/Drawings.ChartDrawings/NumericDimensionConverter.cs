namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumericDimension Class.
/// </summary>
public static class NumericDimensionConverter
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.NumericDimensionType? GetType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType, DocumentModel.Drawings.ChartDrawings.NumericDimensionType>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension? openXmlElement, DocumentModel.Drawings.ChartDrawings.NumericDimensionType? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType, DocumentModel.Drawings.ChartDrawings.NumericDimensionType>(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? GetFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension? openXmlElement, DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? GetNfFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNfFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension? openXmlElement, DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.NumericLevel>? GetNumericLevels(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNumericLevels(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.NumericLevel>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.NumericLevel? GetNumericLevel(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNumericLevel(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension? openXmlElement, DocumentModel.Drawings.ChartDrawings.NumericLevel? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

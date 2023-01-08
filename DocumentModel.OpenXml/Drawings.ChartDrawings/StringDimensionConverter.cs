namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the StringDimension Class.
/// </summary>
public static class StringDimensionConverter
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.StringDimensionType? GetType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType, DocumentModel.Drawings.ChartDrawings.StringDimensionType>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement, DocumentModel.Drawings.ChartDrawings.StringDimensionType? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType, DocumentModel.Drawings.ChartDrawings.StringDimensionType>(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? GetFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement, DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? GetNfFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNfFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement, DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.StringLevel>? GetStringLevels(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStringLevels(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.StringLevel>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.StringLevel? GetStringLevel(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStringLevel(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement, DocumentModel.Drawings.ChartDrawings.StringLevel? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

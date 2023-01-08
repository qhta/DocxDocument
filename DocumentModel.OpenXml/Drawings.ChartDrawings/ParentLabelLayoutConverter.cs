namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ParentLabelLayout Class.
/// </summary>
public static class ParentLabelLayoutConverter
{
  /// <summary>
  /// val, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ParentLabelLayoutVal? GetParentLabelLayoutVal(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal, DocumentModel.Drawings.ChartDrawings.ParentLabelLayoutVal>(openXmlElement?.ParentLabelLayoutVal?.Value);
  }
  
  public static void SetParentLabelLayoutVal(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout? openXmlElement, DocumentModel.Drawings.ChartDrawings.ParentLabelLayoutVal? value)
  {
    if (openXmlElement != null)
      openXmlElement.ParentLabelLayoutVal = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal, DocumentModel.Drawings.ChartDrawings.ParentLabelLayoutVal>(value);
  }
  
}

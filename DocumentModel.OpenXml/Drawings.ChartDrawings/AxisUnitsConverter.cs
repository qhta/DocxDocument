namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the AxisUnits Class.
/// </summary>
public static class AxisUnitsConverter
{
  /// <summary>
  /// unit, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.AxisUnit? GetUnit(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit, DocumentModel.Drawings.ChartDrawings.AxisUnit>(openXmlElement?.Unit?.Value);
  }
  
  public static void SetUnit(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits? openXmlElement, DocumentModel.Drawings.ChartDrawings.AxisUnit? value)
  {
    if (openXmlElement != null)
      openXmlElement.Unit = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit, DocumentModel.Drawings.ChartDrawings.AxisUnit>(value);
  }
  
  /// <summary>
  /// AxisUnitsLabel.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.AxisUnitsLabel? GetAxisUnitsLabel(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAxisUnitsLabel(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits? openXmlElement, DocumentModel.Drawings.ChartDrawings.AxisUnitsLabel? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

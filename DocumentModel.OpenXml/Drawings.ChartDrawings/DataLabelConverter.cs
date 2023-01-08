namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public static class DataLabelConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetIdx(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetIdx(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.DataLabelPos? GetPos(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DocumentModel.Drawings.ChartDrawings.DataLabelPos>(openXmlElement?.Pos?.Value);
  }
  
  public static void SetPos(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? openXmlElement, DocumentModel.Drawings.ChartDrawings.DataLabelPos? value)
  {
    if (openXmlElement != null)
      openXmlElement.Pos = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DocumentModel.Drawings.ChartDrawings.DataLabelPos>(value);
  }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.NumberFormat? GetNumberFormat(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNumberFormat(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? openXmlElement, DocumentModel.Drawings.ChartDrawings.NumberFormat? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? openXmlElement, DocumentModel.Drawings.ChartDrawings.ShapeProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.TxPrTextBody? GetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? openXmlElement, DocumentModel.Drawings.ChartDrawings.TxPrTextBody? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.DataLabelVisibilities? GetDataLabelVisibilities(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataLabelVisibilities(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? openXmlElement, DocumentModel.Drawings.ChartDrawings.DataLabelVisibilities? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// SeparatorXsdstring.
  /// </summary>
  public static String? GetSeparatorXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring");
  }
  
  public static void SetSeparatorXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

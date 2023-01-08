namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabels Class.
/// </summary>
public static class DataLabelsConverter
{
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.DataLabelPos? GetPos(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DocumentModel.Drawings.ChartDrawings.DataLabelPos>(openXmlElement?.Pos?.Value);
  }
  
  public static void SetPos(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, DocumentModel.Drawings.ChartDrawings.DataLabelPos? value)
  {
    if (openXmlElement != null)
      openXmlElement.Pos = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DocumentModel.Drawings.ChartDrawings.DataLabelPos>(value);
  }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.NumberFormat? GetNumberFormat(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNumberFormat(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, DocumentModel.Drawings.ChartDrawings.NumberFormat? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, DocumentModel.Drawings.ChartDrawings.ShapeProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.TxPrTextBody? GetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, DocumentModel.Drawings.ChartDrawings.TxPrTextBody? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.DataLabelVisibilities? GetDataLabelVisibilities(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataLabelVisibilities(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, DocumentModel.Drawings.ChartDrawings.DataLabelVisibilities? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// SeparatorXsdstring.
  /// </summary>
  public static String? GetSeparatorXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring");
  }
  
  public static void SetSeparatorXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataLabel>? GetItems(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataLabel>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataLabelHidden>? GetDataLabelHiddens(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataLabelHiddens(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataLabelHidden>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

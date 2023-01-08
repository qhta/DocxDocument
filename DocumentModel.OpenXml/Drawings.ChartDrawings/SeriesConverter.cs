namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Series Class.
/// </summary>
public static class SeriesConverter
{
  /// <summary>
  /// layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.SeriesLayout? GetLayoutId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout, DocumentModel.Drawings.ChartDrawings.SeriesLayout>(openXmlElement?.LayoutId?.Value);
  }
  
  public static void SetLayoutId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.SeriesLayout? value)
  {
    if (openXmlElement != null)
      openXmlElement.LayoutId = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout, DocumentModel.Drawings.ChartDrawings.SeriesLayout>(value);
  }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetHidden(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHidden(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetOwnerIdx(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetOwnerIdx(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetUniqueId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetUniqueId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetFormatIdx(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFormatIdx(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.Text? GetText(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetText(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.Text? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.ShapeProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ValueColors.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ValueColors? GetValueColors(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetValueColors(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.ValueColors? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ValueColorPositions.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ValueColorPositions? GetValueColorPositions(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetValueColorPositions(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.ValueColorPositions? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataPoint>? GetDataPoints(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataPoints(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataPoint>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.DataLabels? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static UInt32? GetDataId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.SeriesLayoutProperties? GetSeriesLayoutProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSeriesLayoutProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.SeriesLayoutProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<String>? GetAxisIds(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAxisIds(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, System.Collections.ObjectModel.Collection<String>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

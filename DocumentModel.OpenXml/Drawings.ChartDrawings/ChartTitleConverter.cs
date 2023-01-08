namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartTitle Class.
/// </summary>
public static class ChartTitleConverter
{
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.SidePos? GetPos(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos, DocumentModel.Drawings.ChartDrawings.SidePos>(openXmlElement?.Pos?.Value);
  }
  
  public static void SetPos(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement, DocumentModel.Drawings.ChartDrawings.SidePos? value)
  {
    if (openXmlElement != null)
      openXmlElement.Pos = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos, DocumentModel.Drawings.ChartDrawings.SidePos>(value);
  }
  
  /// <summary>
  /// align, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.PosAlign? GetAlign(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign, DocumentModel.Drawings.ChartDrawings.PosAlign>(openXmlElement?.Align?.Value);
  }
  
  public static void SetAlign(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement, DocumentModel.Drawings.ChartDrawings.PosAlign? value)
  {
    if (openXmlElement != null)
      openXmlElement.Align = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign, DocumentModel.Drawings.ChartDrawings.PosAlign>(value);
  }
  
  /// <summary>
  /// overlay, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetOverlay(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetOverlay(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.Text? GetText(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetText(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement, DocumentModel.Drawings.ChartDrawings.Text? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement, DocumentModel.Drawings.ChartDrawings.ShapeProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.TxPrTextBody? GetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement, DocumentModel.Drawings.ChartDrawings.TxPrTextBody? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

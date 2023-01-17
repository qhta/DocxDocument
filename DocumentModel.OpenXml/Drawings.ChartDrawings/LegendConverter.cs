namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Legend Class.
/// </summary>
public static class LegendConverter
{
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.SidePos? GetPos(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos, DocumentModel.Drawings.ChartDrawings.SidePos>(openXmlElement?.Pos?.Value);
  }
  
  private static void SetPos(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend openXmlElement, DocumentModel.Drawings.ChartDrawings.SidePos? value)
  {
    openXmlElement.Pos = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos, DocumentModel.Drawings.ChartDrawings.SidePos>(value);
  }
  
  /// <summary>
  /// align, this property is only available in Office 2016 and later.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.PosAlign? GetAlign(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign, DocumentModel.Drawings.ChartDrawings.PosAlign>(openXmlElement?.Align?.Value);
  }
  
  private static void SetAlign(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend openXmlElement, DocumentModel.Drawings.ChartDrawings.PosAlign? value)
  {
    openXmlElement.Align = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign, DocumentModel.Drawings.ChartDrawings.PosAlign>(value);
  }
  
  /// <summary>
  /// overlay, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetOverlay(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend openXmlElement)
  {
    return openXmlElement?.Overlay?.Value;
  }
  
  private static void SetOverlay(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Overlay = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Overlay = null;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend openXmlElement, DocumentModel.Drawings.ChartDrawings.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.TxPrTextBody? GetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.TxPrTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend openXmlElement, DocumentModel.Drawings.ChartDrawings.TxPrTextBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.TxPrTextBodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Legend? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Legend();
      value.Pos = GetPos(openXmlElement);
      value.Align = GetAlign(openXmlElement);
      value.Overlay = GetOverlay(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Legend? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPos(openXmlElement, value?.Pos);
      SetAlign(openXmlElement, value?.Align);
      SetOverlay(openXmlElement, value?.Overlay);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}

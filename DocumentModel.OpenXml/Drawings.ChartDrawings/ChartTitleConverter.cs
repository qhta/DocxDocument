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
    return openXmlElement?.Overlay?.Value;
  }
  
  public static void SetOverlay(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Overlay = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Overlay = null;
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.Text? GetText(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.TextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetText(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement, DocumentModel.Drawings.ChartDrawings.Text? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.TextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement, DocumentModel.Drawings.ChartDrawings.ShapeProperties? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.TxPrTextBody? GetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.TxPrTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement, DocumentModel.Drawings.ChartDrawings.TxPrTextBody? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ChartTitle? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ChartTitle();
      value.Pos = GetPos(openXmlElement);
      value.Align = GetAlign(openXmlElement);
      value.Overlay = GetOverlay(openXmlElement);
      value.Text = GetText(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ChartTitle? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartSpace Class.
/// </summary>
public static class ChartSpaceConverter
{
  /// <summary>
  /// ChartData.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.ChartData? GetChartData(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ChartDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartData(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement, DocumentModel.Drawings.ChartDrawings.ChartData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ChartDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.Chart? GetChart(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChart(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement, DocumentModel.Drawings.ChartDrawings.Chart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement, DocumentModel.Drawings.ChartDrawings.ShapeProperties? value)
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
  private static DocumentModel.Drawings.ChartDrawings.TxPrTextBody? GetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.TxPrTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement, DocumentModel.Drawings.ChartDrawings.TxPrTextBody? value)
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
  /// ColorMappingType.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.ColorMappingType? GetColorMappingType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ColorMappingTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorMappingType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement, DocumentModel.Drawings.ChartDrawings.ColorMappingType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ColorMappingTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FormatOverrides.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.FormatOverrides? GetFormatOverrides(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.FormatOverridesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFormatOverrides(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement, DocumentModel.Drawings.ChartDrawings.FormatOverrides? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.FormatOverridesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PrintSettings.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.PrintSettings? GetPrintSettings(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.PrintSettingsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPrintSettings(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement, DocumentModel.Drawings.ChartDrawings.PrintSettings? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.PrintSettingsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.ChartSpace? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ChartSpace();
      value.ChartData = GetChartData(openXmlElement);
      value.Chart = GetChart(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.ColorMappingType = GetColorMappingType(openXmlElement);
      value.FormatOverrides = GetFormatOverrides(openXmlElement);
      value.PrintSettings = GetPrintSettings(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ChartSpace? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartData(openXmlElement, value?.ChartData);
      SetChart(openXmlElement, value?.Chart);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
      SetColorMappingType(openXmlElement, value?.ColorMappingType);
      SetFormatOverrides(openXmlElement, value?.FormatOverrides);
      SetPrintSettings(openXmlElement, value?.PrintSettings);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}

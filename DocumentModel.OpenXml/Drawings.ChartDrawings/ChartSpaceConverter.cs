namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartSpace Class.
/// </summary>
public static class ChartSpaceConverter
{
  /// <summary>
  /// ChartData.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ChartData? GetChartData(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ChartDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartData(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement, DocumentModel.Drawings.ChartDrawings.ChartData? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Chart.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.Chart? GetChart(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChart(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement, DocumentModel.Drawings.ChartDrawings.Chart? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement, DocumentModel.Drawings.ChartDrawings.ShapeProperties? value)
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
  public static DocumentModel.Drawings.ChartDrawings.TxPrTextBody? GetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.TxPrTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTxPrTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement, DocumentModel.Drawings.ChartDrawings.TxPrTextBody? value)
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
  /// ColorMappingType.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ColorMappingType? GetColorMappingType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ColorMappingTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColorMappingType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement, DocumentModel.Drawings.ChartDrawings.ColorMappingType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// FormatOverrides.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.FormatOverrides? GetFormatOverrides(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.FormatOverridesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFormatOverrides(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement, DocumentModel.Drawings.ChartDrawings.FormatOverrides? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// PrintSettings.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.PrintSettings? GetPrintSettings(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.PrintSettingsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPrintSettings(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement, DocumentModel.Drawings.ChartDrawings.PrintSettings? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Marker.
/// </summary>
public static class MarkerConverter
{
  /// <summary>
  /// Symbol.
  /// </summary>
  private static DocumentModel.Drawings.Charts.MarkerStyleKind? GetSymbol(DocumentFormat.OpenXml.Drawing.Charts.Marker openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Symbol>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DocumentModel.Drawings.Charts.MarkerStyleKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetSymbol(DocumentFormat.OpenXml.Drawing.Charts.Marker openXmlElement, DocumentModel.Drawings.Charts.MarkerStyleKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Symbol>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Symbol, DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DocumentModel.Drawings.Charts.MarkerStyleKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Size.
  /// </summary>
  private static Byte? GetSize(DocumentFormat.OpenXml.Drawing.Charts.Marker openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Size>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSize(DocumentFormat.OpenXml.Drawing.Charts.Marker openXmlElement, Byte? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Size>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Size{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.Marker openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.Marker openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Marker openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Marker openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Marker? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Marker? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Marker();
      value.Symbol = GetSymbol(openXmlElement);
      value.Size = GetSize(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Marker? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Marker, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSymbol(openXmlElement, value?.Symbol);
      SetSize(openXmlElement, value?.Size);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}

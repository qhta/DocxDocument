namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ErrorBars Class.
/// </summary>
public static class ErrorBarsConverter
{
  /// <summary>
  /// Error Bar Direction.
  /// </summary>
  private static DocumentModel.Drawings.Charts.ErrorBarDirectionKind? GetErrorDirection(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorDirection>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues, DocumentModel.Drawings.Charts.ErrorBarDirectionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetErrorDirection(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement, DocumentModel.Drawings.Charts.ErrorBarDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorDirection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ErrorDirection, DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues, DocumentModel.Drawings.Charts.ErrorBarDirectionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Error Bar Type.
  /// </summary>
  private static DocumentModel.Drawings.Charts.ErrorBarKind? GetErrorBarType(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues, DocumentModel.Drawings.Charts.ErrorBarKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetErrorBarType(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement, DocumentModel.Drawings.Charts.ErrorBarKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarType, DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues, DocumentModel.Drawings.Charts.ErrorBarKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Error Bar Value Type.
  /// </summary>
  private static DocumentModel.Drawings.Charts.ErrorKind? GetErrorBarValueType(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValueType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorValues, DocumentModel.Drawings.Charts.ErrorKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetErrorBarValueType(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement, DocumentModel.Drawings.Charts.ErrorKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValueType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValueType, DocumentFormat.OpenXml.Drawing.Charts.ErrorValues, DocumentModel.Drawings.Charts.ErrorKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// No End Cap.
  /// </summary>
  private static Boolean? GetNoEndCap(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NoEndCap>();
    return itemElement != null;
  }
  
  private static void SetNoEndCap(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NoEndCap>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.NoEndCap();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Plus.
  /// </summary>
  private static DocumentModel.Drawings.Charts.Plus? GetPlus(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Plus>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PlusConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPlus(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement, DocumentModel.Drawings.Charts.Plus? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Plus>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.PlusConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Plus>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Minus.
  /// </summary>
  private static DocumentModel.Drawings.Charts.Minus? GetMinus(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Minus>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.MinusConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMinus(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement, DocumentModel.Drawings.Charts.Minus? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Minus>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.MinusConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Minus>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Error Bar Value.
  /// </summary>
  private static Double? GetErrorBarValue(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetErrorBarValue(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValue{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
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
  private static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.ErrorBars? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ErrorBars();
      value.ErrorDirection = GetErrorDirection(openXmlElement);
      value.ErrorBarType = GetErrorBarType(openXmlElement);
      value.ErrorBarValueType = GetErrorBarValueType(openXmlElement);
      value.NoEndCap = GetNoEndCap(openXmlElement);
      value.Plus = GetPlus(openXmlElement);
      value.Minus = GetMinus(openXmlElement);
      value.ErrorBarValue = GetErrorBarValue(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ErrorBars? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.ErrorBars, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetErrorDirection(openXmlElement, value?.ErrorDirection);
      SetErrorBarType(openXmlElement, value?.ErrorBarType);
      SetErrorBarValueType(openXmlElement, value?.ErrorBarValueType);
      SetNoEndCap(openXmlElement, value?.NoEndCap);
      SetPlus(openXmlElement, value?.Plus);
      SetMinus(openXmlElement, value?.Minus);
      SetErrorBarValue(openXmlElement, value?.ErrorBarValue);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}

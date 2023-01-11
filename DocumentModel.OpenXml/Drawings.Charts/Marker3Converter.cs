namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Marker Class.
/// </summary>
public static class Marker3Converter
{
  /// <summary>
  /// Symbol.
  /// </summary>
  public static DocumentModel.Drawings.Charts.MarkerStyleKind? GetSymbol(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Symbol>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DocumentModel.Drawings.Charts.MarkerStyleKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetSymbol(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker? openXmlElement, DocumentModel.Drawings.Charts.MarkerStyleKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Size.
  /// </summary>
  public static Byte? GetSize(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Size");
  }
  
  public static void SetSize(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker? openXmlElement, Byte? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Size");
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.Marker3? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Marker3();
      value.Symbol = GetSymbol(openXmlElement);
      value.Size = GetSize(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Marker3? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

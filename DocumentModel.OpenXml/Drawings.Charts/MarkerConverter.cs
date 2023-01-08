namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Marker.
/// </summary>
public static class MarkerConverter
{
  /// <summary>
  /// Symbol.
  /// </summary>
  public static DocumentModel.Drawings.Charts.MarkerStyleKind? GetSymbol(DocumentFormat.OpenXml.Drawing.Charts.Marker? openXmlElement)
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
  
  public static void SetSymbol(DocumentFormat.OpenXml.Drawing.Charts.Marker? openXmlElement, DocumentModel.Drawings.Charts.MarkerStyleKind? value)
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
  public static Byte? GetSize(DocumentFormat.OpenXml.Drawing.Charts.Marker? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSize(DocumentFormat.OpenXml.Drawing.Charts.Marker? openXmlElement, Byte? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.Marker? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.Marker? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Marker? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Marker? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

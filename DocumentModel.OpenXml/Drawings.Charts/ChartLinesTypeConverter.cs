namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartLinesType Class.
/// </summary>
public static class ChartLinesTypeConverter
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
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
  
  public static DocumentModel.Drawings.Charts.ChartLinesType? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartLinesType();
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ChartLinesType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Minor Gridlines.
/// </summary>
public static class MinorGridlinesConverter
{
  private static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
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
  
  public static DocumentModel.Drawings.Charts.MinorGridlines? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.MinorGridlines();
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.MinorGridlines? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      return openXmlElement;
    }
    return default;
  }
}

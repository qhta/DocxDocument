namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SurfaceChartExtension Class.
/// </summary>
public static class SurfaceChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DocumentModel.Drawings.Charts.FilteredSurfaceSeries? GetFilteredSurfaceSeries(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FilteredSurfaceSeriesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredSurfaceSeries(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension openXmlElement, DocumentModel.Drawings.Charts.FilteredSurfaceSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.FilteredSurfaceSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.SurfaceChartExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SurfaceChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredSurfaceSeries = GetFilteredSurfaceSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.SurfaceChartExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredSurfaceSeries(openXmlElement, value?.FilteredSurfaceSeries);
      return openXmlElement;
    }
    return default;
  }
}

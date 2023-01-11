namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Clear Class.
/// </summary>
public static class ClearConverter
{
  /// <summary>
  /// GeoLocationQueryResults.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResults? GetGeoLocationQueryResults(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResults>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoLocationQueryResultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGeoLocationQueryResults(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResults? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoLocationQueryResultsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResults>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// GeoDataEntityQueryResults.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResults? GetGeoDataEntityQueryResults(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResults>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoDataEntityQueryResultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGeoDataEntityQueryResults(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResults? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoDataEntityQueryResultsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResults>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// GeoDataPointToEntityQueryResults.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResults? GetGeoDataPointToEntityQueryResults(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResults>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoDataPointToEntityQueryResultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGeoDataPointToEntityQueryResults(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResults? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoDataPointToEntityQueryResultsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResults>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// GeoChildEntitiesQueryResults.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryResults? GetGeoChildEntitiesQueryResults(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResults>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoChildEntitiesQueryResultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGeoChildEntitiesQueryResults(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryResults? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoChildEntitiesQueryResultsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResults>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// GeoParentEntitiesQueryResults.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResults? GetGeoParentEntitiesQueryResults(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResults>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoParentEntitiesQueryResultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGeoParentEntitiesQueryResults(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResults? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoParentEntitiesQueryResultsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResults>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Clear? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Clear();
      value.GeoLocationQueryResults = GetGeoLocationQueryResults(openXmlElement);
      value.GeoDataEntityQueryResults = GetGeoDataEntityQueryResults(openXmlElement);
      value.GeoDataPointToEntityQueryResults = GetGeoDataPointToEntityQueryResults(openXmlElement);
      value.GeoChildEntitiesQueryResults = GetGeoChildEntitiesQueryResults(openXmlElement);
      value.GeoParentEntitiesQueryResults = GetGeoParentEntitiesQueryResults(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Clear? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

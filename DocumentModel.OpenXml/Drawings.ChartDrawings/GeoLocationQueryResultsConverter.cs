namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocationQueryResults Class.
/// </summary>
public static class GeoLocationQueryResultsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResult>? GetItems(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResult>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoLocationQueryResultConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResults? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResult>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoLocationQueryResultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResults? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResults? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResults, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

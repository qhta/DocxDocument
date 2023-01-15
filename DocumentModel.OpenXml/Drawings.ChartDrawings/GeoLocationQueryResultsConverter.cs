using DocumentModel.Drawings.ChartDrawings;
using GeoLocationQueryResults = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResults;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoLocationQueryResults Class.
/// </summary>
public static class GeoLocationQueryResultsConverter
{
  public static Collection<GeoLocationQueryResult>? GetItems(GeoLocationQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<GeoLocationQueryResult>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult>())
      {
        var newItem = GeoLocationQueryResultConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(GeoLocationQueryResults? openXmlElement, Collection<GeoLocationQueryResult>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = GeoLocationQueryResultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResults? CreateModelElement(GeoLocationQueryResults? openXmlElement)
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
    where OpenXmlElementType : GeoLocationQueryResults, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
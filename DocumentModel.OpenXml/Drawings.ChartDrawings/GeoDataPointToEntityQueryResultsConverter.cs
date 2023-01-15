using DocumentModel.Drawings.ChartDrawings;
using GeoDataPointToEntityQueryResults = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResults;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoDataPointToEntityQueryResults Class.
/// </summary>
public static class GeoDataPointToEntityQueryResultsConverter
{
  public static Collection<GeoDataPointToEntityQueryResult>? GetItems(GeoDataPointToEntityQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<GeoDataPointToEntityQueryResult>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResult>())
      {
        var newItem = GeoDataPointToEntityQueryResultConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(GeoDataPointToEntityQueryResults? openXmlElement, Collection<GeoDataPointToEntityQueryResult>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResult>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = GeoDataPointToEntityQueryResultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResult>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResults? CreateModelElement(GeoDataPointToEntityQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResults? value)
    where OpenXmlElementType : GeoDataPointToEntityQueryResults, new()
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
using DocumentModel.Drawings.ChartDrawings;
using GeoDataEntityQueryResults = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResults;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoDataEntityQueryResults Class.
/// </summary>
public static class GeoDataEntityQueryResultsConverter
{
  public static Collection<GeoDataEntityQueryResult>? GetItems(GeoDataEntityQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<GeoDataEntityQueryResult>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult>())
      {
        var newItem = GeoDataEntityQueryResultConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(GeoDataEntityQueryResults? openXmlElement, Collection<GeoDataEntityQueryResult>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = GeoDataEntityQueryResultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResults? CreateModelElement(GeoDataEntityQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResults? value)
    where OpenXmlElementType : GeoDataEntityQueryResults, new()
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
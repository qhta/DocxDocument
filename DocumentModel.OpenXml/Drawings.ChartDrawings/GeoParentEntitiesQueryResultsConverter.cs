using DocumentModel.Drawings.ChartDrawings;
using GeoParentEntitiesQueryResults = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResults;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoParentEntitiesQueryResults Class.
/// </summary>
public static class GeoParentEntitiesQueryResultsConverter
{
  public static Collection<GeoParentEntitiesQueryResult>? GetItems(GeoParentEntitiesQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<GeoParentEntitiesQueryResult>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult>())
      {
        var newItem = GeoParentEntitiesQueryResultConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(GeoParentEntitiesQueryResults? openXmlElement, Collection<GeoParentEntitiesQueryResult>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = GeoParentEntitiesQueryResultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResults? CreateModelElement(GeoParentEntitiesQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResults? value)
    where OpenXmlElementType : GeoParentEntitiesQueryResults, new()
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
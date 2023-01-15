using DocumentModel.Drawings.ChartDrawings;
using GeoChildEntities = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoChildEntities Class.
/// </summary>
public static class GeoChildEntitiesConverter
{
  public static Collection<GeoHierarchyEntity>? GetGeoHierarchyEntities(GeoChildEntities? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<GeoHierarchyEntity>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity>())
      {
        var newItem = GeoHierarchyEntityConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetGeoHierarchyEntities(GeoChildEntities? openXmlElement, Collection<GeoHierarchyEntity>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = GeoHierarchyEntityConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoChildEntities? CreateModelElement(GeoChildEntities? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoChildEntities();
      value.GeoHierarchyEntities = GetGeoHierarchyEntities(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoChildEntities? value)
    where OpenXmlElementType : GeoChildEntities, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoHierarchyEntities(openXmlElement, value?.GeoHierarchyEntities);
      return openXmlElement;
    }
    return default;
  }
}
namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntities Class.
/// </summary>
public static class GeoChildEntitiesConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntity> GetGeoHierarchyEntities(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntity>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoHierarchyEntityConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetGeoHierarchyEntities(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntity>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoHierarchyEntityConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoChildEntities? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities, new()
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

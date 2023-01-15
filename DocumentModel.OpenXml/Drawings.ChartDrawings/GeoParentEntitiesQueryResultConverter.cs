using DocumentModel.Drawings.ChartDrawings;
using GeoParentEntitiesQueryResult = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public static class GeoParentEntitiesQueryResultConverter
{
  /// <summary>
  ///   GeoParentEntitiesQuery.
  /// </summary>
  public static GeoParentEntitiesQuery? GetGeoParentEntitiesQuery(GeoParentEntitiesQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQuery>();
    if (itemElement != null)
      return GeoParentEntitiesQueryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGeoParentEntitiesQuery(GeoParentEntitiesQueryResult? openXmlElement, GeoParentEntitiesQuery? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQuery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoParentEntitiesQueryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQuery>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   GeoEntity.
  /// </summary>
  public static GeoEntity? GetGeoEntity(GeoParentEntitiesQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity>();
    if (itemElement != null)
      return GeoEntityConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGeoEntity(GeoParentEntitiesQueryResult? openXmlElement, GeoEntity? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoEntityConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   GeoParentEntity.
  /// </summary>
  public static GeoParentEntity? GetGeoParentEntity(GeoParentEntitiesQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity>();
    if (itemElement != null)
      return GeoParentEntityConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGeoParentEntity(GeoParentEntitiesQueryResult? openXmlElement, GeoParentEntity? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoParentEntityConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResult? CreateModelElement(GeoParentEntitiesQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResult();
      value.GeoParentEntitiesQuery = GetGeoParentEntitiesQuery(openXmlElement);
      value.GeoEntity = GetGeoEntity(openXmlElement);
      value.GeoParentEntity = GetGeoParentEntity(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResult? value)
    where OpenXmlElementType : GeoParentEntitiesQueryResult, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoParentEntitiesQuery(openXmlElement, value?.GeoParentEntitiesQuery);
      SetGeoEntity(openXmlElement, value?.GeoEntity);
      SetGeoParentEntity(openXmlElement, value?.GeoParentEntity);
      return openXmlElement;
    }
    return default;
  }
}
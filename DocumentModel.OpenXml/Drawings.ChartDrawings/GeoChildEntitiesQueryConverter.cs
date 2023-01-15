using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using GeoChildTypes = DocumentModel.Drawings.ChartDrawings.GeoChildTypes;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoChildEntitiesQuery Class.
/// </summary>
public static class GeoChildEntitiesQueryConverter
{
  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityId(GeoChildEntitiesQuery? openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }

  public static void SetEntityId(GeoChildEntitiesQuery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityId = new StringValue { Value = value };
      else
        openXmlElement.EntityId = null;
  }

  /// <summary>
  ///   GeoChildTypes.
  /// </summary>
  public static GeoChildTypes? GetGeoChildTypes(GeoChildEntitiesQuery? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildTypes>();
    if (itemElement != null)
      return GeoChildTypesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGeoChildTypes(GeoChildEntitiesQuery? openXmlElement, GeoChildTypes? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildTypes>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoChildTypesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildTypes>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQuery? CreateModelElement(GeoChildEntitiesQuery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQuery();
      value.EntityId = GetEntityId(openXmlElement);
      value.GeoChildTypes = GetGeoChildTypes(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQuery? value)
    where OpenXmlElementType : GeoChildEntitiesQuery, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityId(openXmlElement, value?.EntityId);
      SetGeoChildTypes(openXmlElement, value?.GeoChildTypes);
      return openXmlElement;
    }
    return default;
  }
}
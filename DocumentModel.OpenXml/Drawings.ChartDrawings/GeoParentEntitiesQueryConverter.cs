using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoParentEntitiesQuery Class.
/// </summary>
public static class GeoParentEntitiesQueryConverter
{
  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityId(GeoParentEntitiesQuery? openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }

  public static void SetEntityId(GeoParentEntitiesQuery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityId = new StringValue { Value = value };
      else
        openXmlElement.EntityId = null;
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQuery? CreateModelElement(GeoParentEntitiesQuery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQuery();
      value.EntityId = GetEntityId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQuery? value)
    where OpenXmlElementType : GeoParentEntitiesQuery, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityId(openXmlElement, value?.EntityId);
      return openXmlElement;
    }
    return default;
  }
}
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Copyrights = DocumentModel.Drawings.ChartDrawings.Copyrights;
using GeoPolygons = DocumentModel.Drawings.ChartDrawings.GeoPolygons;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoData Class.
/// </summary>
public static class GeoDataConverter
{
  /// <summary>
  ///   entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityName(GeoData? openXmlElement)
  {
    return openXmlElement?.EntityName?.Value;
  }

  public static void SetEntityName(GeoData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityName = new StringValue { Value = value };
      else
        openXmlElement.EntityName = null;
  }

  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityId(GeoData? openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }

  public static void SetEntityId(GeoData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityId = new StringValue { Value = value };
      else
        openXmlElement.EntityId = null;
  }

  /// <summary>
  ///   east, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetEast(GeoData? openXmlElement)
  {
    return openXmlElement?.East?.Value;
  }

  public static void SetEast(GeoData? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.East = value;
  }

  /// <summary>
  ///   west, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetWest(GeoData? openXmlElement)
  {
    return openXmlElement?.West?.Value;
  }

  public static void SetWest(GeoData? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.West = value;
  }

  /// <summary>
  ///   north, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetNorth(GeoData? openXmlElement)
  {
    return openXmlElement?.North?.Value;
  }

  public static void SetNorth(GeoData? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.North = value;
  }

  /// <summary>
  ///   south, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetSouth(GeoData? openXmlElement)
  {
    return openXmlElement?.South?.Value;
  }

  public static void SetSouth(GeoData? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.South = value;
  }

  /// <summary>
  ///   GeoPolygons.
  /// </summary>
  public static GeoPolygons? GetGeoPolygons(GeoData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygons>();
    if (itemElement != null)
      return GeoPolygonsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGeoPolygons(GeoData? openXmlElement, GeoPolygons? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygons>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoPolygonsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygons>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Copyrights.
  /// </summary>
  public static Copyrights? GetCopyrights(GeoData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights>();
    if (itemElement != null)
      return CopyrightsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCopyrights(GeoData? openXmlElement, Copyrights? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CopyrightsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoData? CreateModelElement(GeoData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoData();
      value.EntityName = GetEntityName(openXmlElement);
      value.EntityId = GetEntityId(openXmlElement);
      value.East = GetEast(openXmlElement);
      value.West = GetWest(openXmlElement);
      value.North = GetNorth(openXmlElement);
      value.South = GetSouth(openXmlElement);
      value.GeoPolygons = GetGeoPolygons(openXmlElement);
      value.Copyrights = GetCopyrights(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoData? value)
    where OpenXmlElementType : GeoData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityName(openXmlElement, value?.EntityName);
      SetEntityId(openXmlElement, value?.EntityId);
      SetEast(openXmlElement, value?.East);
      SetWest(openXmlElement, value?.West);
      SetNorth(openXmlElement, value?.North);
      SetSouth(openXmlElement, value?.South);
      SetGeoPolygons(openXmlElement, value?.GeoPolygons);
      SetCopyrights(openXmlElement, value?.Copyrights);
      return openXmlElement;
    }
    return default;
  }
}
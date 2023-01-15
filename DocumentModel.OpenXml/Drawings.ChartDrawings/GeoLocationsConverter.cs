using DocumentModel.Drawings.ChartDrawings;
using GeoLocations = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocations;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoLocations Class.
/// </summary>
public static class GeoLocationsConverter
{
  /// <summary>
  ///   GeoLocation.
  /// </summary>
  public static GeoLocation? GetGeoLocation(GeoLocations? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation>();
    if (itemElement != null)
      return GeoLocationConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGeoLocation(GeoLocations? openXmlElement, GeoLocation? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoLocationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoLocations? CreateModelElement(GeoLocations? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoLocations();
      value.GeoLocation = GetGeoLocation(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoLocations? value)
    where OpenXmlElementType : GeoLocations, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoLocation(openXmlElement, value?.GeoLocation);
      return openXmlElement;
    }
    return default;
  }
}
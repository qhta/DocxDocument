using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Clear = DocumentModel.Drawings.ChartDrawings.Clear;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoCache Class.
/// </summary>
public static class GeoCacheConverter
{
  /// <summary>
  ///   provider, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetProvider(GeoCache? openXmlElement)
  {
    return openXmlElement?.Provider?.Value;
  }

  public static void SetProvider(GeoCache? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Provider = new StringValue { Value = value };
      else
        openXmlElement.Provider = null;
  }

  public static String? GetXsdbase64Binary(GeoCache? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Xsdbase64Binary>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetXsdbase64Binary(GeoCache? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Xsdbase64Binary>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Xsdbase64Binary { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Clear? GetClear(GeoCache? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear>();
    if (itemElement != null)
      return ClearConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetClear(GeoCache? openXmlElement, Clear? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ClearConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoCache? CreateModelElement(GeoCache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoCache();
      value.Provider = GetProvider(openXmlElement);
      value.Xsdbase64Binary = GetXsdbase64Binary(openXmlElement);
      value.Clear = GetClear(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoCache? value)
    where OpenXmlElementType : GeoCache, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetProvider(openXmlElement, value?.Provider);
      SetXsdbase64Binary(openXmlElement, value?.Xsdbase64Binary);
      SetClear(openXmlElement, value?.Clear);
      return openXmlElement;
    }
    return default;
  }
}
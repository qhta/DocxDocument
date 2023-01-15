using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using Point2DType = DocumentModel.Drawings.Wordprocessing.Point2DType;

namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
///   Tight Wrapping Extents Polygon.
/// </summary>
public static class WrapPolygonConverter
{
  /// <summary>
  ///   Wrapping Points Modified
  /// </summary>
  public static Boolean? GetEdited(WrapPolygon? openXmlElement)
  {
    return openXmlElement?.Edited?.Value;
  }

  public static void SetEdited(WrapPolygon? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Edited = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Edited = null;
  }

  /// <summary>
  ///   Wrapping Polygon Start.
  /// </summary>
  public static Point2DType? GetStartPoint(WrapPolygon? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<StartPoint>();
    if (itemElement != null)
      return Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStartPoint(WrapPolygon? openXmlElement, Point2DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StartPoint>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Point2DTypeConverter.CreateOpenXmlElement<StartPoint>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Point2DType? GetLineTo(WrapPolygon? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LineTo>();
    if (itemElement != null)
      return Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineTo(WrapPolygon? openXmlElement, Point2DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LineTo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Point2DTypeConverter.CreateOpenXmlElement<LineTo>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Wordprocessing.WrapPolygon? CreateModelElement(WrapPolygon? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.WrapPolygon();
      value.Edited = GetEdited(openXmlElement);
      value.StartPoint = GetStartPoint(openXmlElement);
      value.LineTo = GetLineTo(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.WrapPolygon? value)
    where OpenXmlElementType : WrapPolygon, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEdited(openXmlElement, value?.Edited);
      SetStartPoint(openXmlElement, value?.StartPoint);
      SetLineTo(openXmlElement, value?.LineTo);
      return openXmlElement;
    }
    return default;
  }
}
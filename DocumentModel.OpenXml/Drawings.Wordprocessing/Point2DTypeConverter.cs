using DocumentFormat.OpenXml.Drawing.Wordprocessing;

namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
///   Defines the Point2DType Class.
/// </summary>
public static class Point2DTypeConverter
{
  /// <summary>
  ///   X-Axis Coordinate
  /// </summary>
  public static Int64? GetX(Point2DType? openXmlElement)
  {
    return openXmlElement?.X?.Value;
  }

  public static void SetX(Point2DType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.X = value;
  }

  /// <summary>
  ///   Y-Axis Coordinate
  /// </summary>
  public static Int64? GetY(Point2DType? openXmlElement)
  {
    return openXmlElement?.Y?.Value;
  }

  public static void SetY(Point2DType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Y = value;
  }

  public static DocumentModel.Drawings.Wordprocessing.Point2DType? CreateModelElement(Point2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.Point2DType();
      value.X = GetX(openXmlElement);
      value.Y = GetY(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.Point2DType? value)
    where OpenXmlElementType : Point2DType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetX(openXmlElement, value?.X);
      SetY(openXmlElement, value?.Y);
      return openXmlElement;
    }
    return default;
  }
}
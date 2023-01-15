using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the AdjustPoint2DType Class.
/// </summary>
public static class AdjustPoint2DTypeConverter
{
  /// <summary>
  ///   X-Coordinate
  /// </summary>
  public static String? GetX(AdjustPoint2DType? openXmlElement)
  {
    return openXmlElement?.X?.Value;
  }

  public static void SetX(AdjustPoint2DType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.X = new StringValue { Value = value };
      else
        openXmlElement.X = null;
  }

  /// <summary>
  ///   Y-Coordinate
  /// </summary>
  public static String? GetY(AdjustPoint2DType? openXmlElement)
  {
    return openXmlElement?.Y?.Value;
  }

  public static void SetY(AdjustPoint2DType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Y = new StringValue { Value = value };
      else
        openXmlElement.Y = null;
  }

  public static DocumentModel.Drawings.AdjustPoint2DType? CreateModelElement(AdjustPoint2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AdjustPoint2DType();
      value.X = GetX(openXmlElement);
      value.Y = GetY(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AdjustPoint2DType? value)
    where OpenXmlElementType : AdjustPoint2DType, new()
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
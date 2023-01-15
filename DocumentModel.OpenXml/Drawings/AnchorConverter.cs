using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Anchor Point.
/// </summary>
public static class AnchorConverter
{
  /// <summary>
  ///   X-Coordinate in 3D
  /// </summary>
  public static Int64? GetX(Anchor? openXmlElement)
  {
    return openXmlElement?.X?.Value;
  }

  public static void SetX(Anchor? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.X = value;
  }

  /// <summary>
  ///   Y-Coordinate in 3D
  /// </summary>
  public static Int64? GetY(Anchor? openXmlElement)
  {
    return openXmlElement?.Y?.Value;
  }

  public static void SetY(Anchor? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Y = value;
  }

  /// <summary>
  ///   Z-Coordinate in 3D
  /// </summary>
  public static Int64? GetZ(Anchor? openXmlElement)
  {
    return openXmlElement?.Z?.Value;
  }

  public static void SetZ(Anchor? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Z = value;
  }

  public static DocumentModel.Drawings.Anchor? CreateModelElement(Anchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Anchor();
      value.X = GetX(openXmlElement);
      value.Y = GetY(openXmlElement);
      value.Z = GetZ(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Anchor? value)
    where OpenXmlElementType : Anchor, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetX(openXmlElement, value?.X);
      SetY(openXmlElement, value?.Y);
      SetZ(openXmlElement, value?.Z);
      return openXmlElement;
    }
    return default;
  }
}
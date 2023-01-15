using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   No text in 3D scene.
/// </summary>
public static class FlatTextConverter
{
  /// <summary>
  ///   Z Coordinate
  /// </summary>
  public static Int64? GetZ(FlatText? openXmlElement)
  {
    return openXmlElement?.Z?.Value;
  }

  public static void SetZ(FlatText? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Z = value;
  }

  public static DocumentModel.Drawings.FlatText? CreateModelElement(FlatText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.FlatText();
      value.Z = GetZ(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.FlatText? value)
    where OpenXmlElementType : FlatText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetZ(openXmlElement, value?.Z);
      return openXmlElement;
    }
    return default;
  }
}
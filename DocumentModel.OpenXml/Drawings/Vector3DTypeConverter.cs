using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the Vector3DType Class.
/// </summary>
public static class Vector3DTypeConverter
{
  /// <summary>
  ///   Distance along X-axis in 3D
  /// </summary>
  public static Int64? GetDx(Vector3DType? openXmlElement)
  {
    return openXmlElement?.Dx?.Value;
  }

  public static void SetDx(Vector3DType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Dx = value;
  }

  /// <summary>
  ///   Distance along Y-axis in 3D
  /// </summary>
  public static Int64? GetDy(Vector3DType? openXmlElement)
  {
    return openXmlElement?.Dy?.Value;
  }

  public static void SetDy(Vector3DType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Dy = value;
  }

  /// <summary>
  ///   Distance along Z-axis in 3D
  /// </summary>
  public static Int64? GetDz(Vector3DType? openXmlElement)
  {
    return openXmlElement?.Dz?.Value;
  }

  public static void SetDz(Vector3DType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Dz = value;
  }

  public static DocumentModel.Drawings.Vector3DType? CreateModelElement(Vector3DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Vector3DType();
      value.Dx = GetDx(openXmlElement);
      value.Dy = GetDy(openXmlElement);
      value.Dz = GetDz(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Vector3DType? value)
    where OpenXmlElementType : Vector3DType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDx(openXmlElement, value?.Dx);
      SetDy(openXmlElement, value?.Dy);
      SetDz(openXmlElement, value?.Dz);
      return openXmlElement;
    }
    return default;
  }
}
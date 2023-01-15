using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Soft Edge Effect.
/// </summary>
public static class SoftEdgeConverter
{
  /// <summary>
  ///   Radius
  /// </summary>
  public static Int64? GetRadius(SoftEdge? openXmlElement)
  {
    return openXmlElement?.Radius?.Value;
  }

  public static void SetRadius(SoftEdge? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Radius = value;
  }

  public static DocumentModel.Drawings.SoftEdge? CreateModelElement(SoftEdge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.SoftEdge();
      value.Radius = GetRadius(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.SoftEdge? value)
    where OpenXmlElementType : SoftEdge, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadius(openXmlElement, value?.Radius);
      return openXmlElement;
    }
    return default;
  }
}
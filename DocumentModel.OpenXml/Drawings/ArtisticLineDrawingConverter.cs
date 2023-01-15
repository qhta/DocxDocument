using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ArtisticLineDrawing Class.
/// </summary>
public static class ArtisticLineDrawingConverter
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(ArtisticLineDrawing? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }

  public static void SetTransparancy(ArtisticLineDrawing? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }

  /// <summary>
  ///   pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetPencilSize(ArtisticLineDrawing? openXmlElement)
  {
    return openXmlElement?.PencilSize?.Value;
  }

  public static void SetPencilSize(ArtisticLineDrawing? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.PencilSize = value;
  }

  public static DocumentModel.Drawings.ArtisticLineDrawing? CreateModelElement(ArtisticLineDrawing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticLineDrawing();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.PencilSize = GetPencilSize(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticLineDrawing? value)
    where OpenXmlElementType : ArtisticLineDrawing, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetPencilSize(openXmlElement, value?.PencilSize);
      return openXmlElement;
    }
    return default;
  }
}
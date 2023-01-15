using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Relative Offset Effect.
/// </summary>
public static class RelativeOffsetConverter
{
  /// <summary>
  ///   Offset X
  /// </summary>
  public static Int32? GetOffsetX(RelativeOffset? openXmlElement)
  {
    return openXmlElement?.OffsetX?.Value;
  }

  public static void SetOffsetX(RelativeOffset? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.OffsetX = value;
  }

  /// <summary>
  ///   Offset Y
  /// </summary>
  public static Int32? GetOffsetY(RelativeOffset? openXmlElement)
  {
    return openXmlElement?.OffsetY?.Value;
  }

  public static void SetOffsetY(RelativeOffset? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.OffsetY = value;
  }

  public static DocumentModel.Drawings.RelativeOffset? CreateModelElement(RelativeOffset? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.RelativeOffset();
      value.OffsetX = GetOffsetX(openXmlElement);
      value.OffsetY = GetOffsetY(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.RelativeOffset? value)
    where OpenXmlElementType : RelativeOffset, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOffsetX(openXmlElement, value?.OffsetX);
      SetOffsetY(openXmlElement, value?.OffsetY);
      return openXmlElement;
    }
    return default;
  }
}
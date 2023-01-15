using DocumentFormat.OpenXml.Drawing.Wordprocessing;

namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
///   Object Extents Including Effects.
/// </summary>
public static class EffectExtentConverter
{
  /// <summary>
  ///   Additional Extent on Left Edge
  /// </summary>
  public static Int64? GetLeftEdge(EffectExtent? openXmlElement)
  {
    return openXmlElement?.LeftEdge?.Value;
  }

  public static void SetLeftEdge(EffectExtent? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.LeftEdge = value;
  }

  /// <summary>
  ///   Additional Extent on Top Edge
  /// </summary>
  public static Int64? GetTopEdge(EffectExtent? openXmlElement)
  {
    return openXmlElement?.TopEdge?.Value;
  }

  public static void SetTopEdge(EffectExtent? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.TopEdge = value;
  }

  /// <summary>
  ///   Additional Extent on Right Edge
  /// </summary>
  public static Int64? GetRightEdge(EffectExtent? openXmlElement)
  {
    return openXmlElement?.RightEdge?.Value;
  }

  public static void SetRightEdge(EffectExtent? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.RightEdge = value;
  }

  /// <summary>
  ///   Additional Extent on Bottom Edge
  /// </summary>
  public static Int64? GetBottomEdge(EffectExtent? openXmlElement)
  {
    return openXmlElement?.BottomEdge?.Value;
  }

  public static void SetBottomEdge(EffectExtent? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.BottomEdge = value;
  }

  public static DocumentModel.Drawings.Wordprocessing.EffectExtent? CreateModelElement(EffectExtent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.EffectExtent();
      value.LeftEdge = GetLeftEdge(openXmlElement);
      value.TopEdge = GetTopEdge(openXmlElement);
      value.RightEdge = GetRightEdge(openXmlElement);
      value.BottomEdge = GetBottomEdge(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.EffectExtent? value)
    where OpenXmlElementType : EffectExtent, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLeftEdge(openXmlElement, value?.LeftEdge);
      SetTopEdge(openXmlElement, value?.TopEdge);
      SetRightEdge(openXmlElement, value?.RightEdge);
      SetBottomEdge(openXmlElement, value?.BottomEdge);
      return openXmlElement;
    }
    return default;
  }
}
using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using EffectExtent = DocumentModel.Drawings.Wordprocessing.EffectExtent;

namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
///   Top and Bottom Wrapping.
/// </summary>
public static class WrapTopBottomConverter
{
  /// <summary>
  ///   Distance From Text on Top Edge
  /// </summary>
  public static UInt32? GetDistanceFromTop(WrapTopBottom? openXmlElement)
  {
    return openXmlElement?.DistanceFromTop?.Value;
  }

  public static void SetDistanceFromTop(WrapTopBottom? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromTop = value;
  }

  /// <summary>
  ///   Distance From Text on Bottom Edge
  /// </summary>
  public static UInt32? GetDistanceFromBottom(WrapTopBottom? openXmlElement)
  {
    return openXmlElement?.DistanceFromBottom?.Value;
  }

  public static void SetDistanceFromBottom(WrapTopBottom? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromBottom = value;
  }

  /// <summary>
  ///   Wrapping Boundaries.
  /// </summary>
  public static EffectExtent? GetEffectExtent(WrapTopBottom? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
    if (itemElement != null)
      return EffectExtentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffectExtent(WrapTopBottom? openXmlElement, EffectExtent? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectExtentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Wordprocessing.WrapTopBottom? CreateModelElement(WrapTopBottom? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.WrapTopBottom();
      value.DistanceFromTop = GetDistanceFromTop(openXmlElement);
      value.DistanceFromBottom = GetDistanceFromBottom(openXmlElement);
      value.EffectExtent = GetEffectExtent(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.WrapTopBottom? value)
    where OpenXmlElementType : WrapTopBottom, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDistanceFromTop(openXmlElement, value?.DistanceFromTop);
      SetDistanceFromBottom(openXmlElement, value?.DistanceFromBottom);
      SetEffectExtent(openXmlElement, value?.EffectExtent);
      return openXmlElement;
    }
    return default;
  }
}
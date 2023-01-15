using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentModel.Drawings.Wordprocessing;
using EffectExtent = DocumentModel.Drawings.Wordprocessing.EffectExtent;
using WrapSquare = DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare;

namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
///   Square Wrapping.
/// </summary>
public static class WrapSquareConverter
{
  /// <summary>
  ///   Text Wrapping Location
  /// </summary>
  public static WrapTextKind? GetWrapText(WrapSquare? openXmlElement)
  {
    return EnumValueConverter.GetValue<WrapTextValues, WrapTextKind>(openXmlElement?.WrapText?.Value);
  }

  public static void SetWrapText(WrapSquare? openXmlElement, WrapTextKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.WrapText = EnumValueConverter.CreateEnumValue<WrapTextValues, WrapTextKind>(value);
  }

  /// <summary>
  ///   Distance From Text (Top)
  /// </summary>
  public static UInt32? GetDistanceFromTop(WrapSquare? openXmlElement)
  {
    return openXmlElement?.DistanceFromTop?.Value;
  }

  public static void SetDistanceFromTop(WrapSquare? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromTop = value;
  }

  /// <summary>
  ///   Distance From Text on Bottom Edge
  /// </summary>
  public static UInt32? GetDistanceFromBottom(WrapSquare? openXmlElement)
  {
    return openXmlElement?.DistanceFromBottom?.Value;
  }

  public static void SetDistanceFromBottom(WrapSquare? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromBottom = value;
  }

  /// <summary>
  ///   Distance From Text on Left Edge
  /// </summary>
  public static UInt32? GetDistanceFromLeft(WrapSquare? openXmlElement)
  {
    return openXmlElement?.DistanceFromLeft?.Value;
  }

  public static void SetDistanceFromLeft(WrapSquare? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromLeft = value;
  }

  /// <summary>
  ///   Distance From Text on Right Edge
  /// </summary>
  public static UInt32? GetDistanceFromRight(WrapSquare? openXmlElement)
  {
    return openXmlElement?.DistanceFromRight?.Value;
  }

  public static void SetDistanceFromRight(WrapSquare? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromRight = value;
  }

  /// <summary>
  ///   Object Extents Including Effects.
  /// </summary>
  public static EffectExtent? GetEffectExtent(WrapSquare? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
    if (itemElement != null)
      return EffectExtentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffectExtent(WrapSquare? openXmlElement, EffectExtent? value)
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

  public static DocumentModel.Drawings.Wordprocessing.WrapSquare? CreateModelElement(WrapSquare? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.WrapSquare();
      value.WrapText = GetWrapText(openXmlElement);
      value.DistanceFromTop = GetDistanceFromTop(openXmlElement);
      value.DistanceFromBottom = GetDistanceFromBottom(openXmlElement);
      value.DistanceFromLeft = GetDistanceFromLeft(openXmlElement);
      value.DistanceFromRight = GetDistanceFromRight(openXmlElement);
      value.EffectExtent = GetEffectExtent(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.WrapSquare? value)
    where OpenXmlElementType : WrapSquare, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWrapText(openXmlElement, value?.WrapText);
      SetDistanceFromTop(openXmlElement, value?.DistanceFromTop);
      SetDistanceFromBottom(openXmlElement, value?.DistanceFromBottom);
      SetDistanceFromLeft(openXmlElement, value?.DistanceFromLeft);
      SetDistanceFromRight(openXmlElement, value?.DistanceFromRight);
      SetEffectExtent(openXmlElement, value?.EffectExtent);
      return openXmlElement;
    }
    return default;
  }
}
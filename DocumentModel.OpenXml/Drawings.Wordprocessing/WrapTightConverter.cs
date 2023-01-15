using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentModel.Drawings.Wordprocessing;
using WrapPolygon = DocumentModel.Drawings.Wordprocessing.WrapPolygon;
using WrapTight = DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight;

namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
///   Tight Wrapping.
/// </summary>
public static class WrapTightConverter
{
  /// <summary>
  ///   Text Wrapping Location
  /// </summary>
  public static WrapTextKind? GetWrapText(WrapTight? openXmlElement)
  {
    return EnumValueConverter.GetValue<WrapTextValues, WrapTextKind>(openXmlElement?.WrapText?.Value);
  }

  public static void SetWrapText(WrapTight? openXmlElement, WrapTextKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.WrapText = EnumValueConverter.CreateEnumValue<WrapTextValues, WrapTextKind>(value);
  }

  /// <summary>
  ///   Distance From Test on Left Edge
  /// </summary>
  public static UInt32? GetDistanceFromLeft(WrapTight? openXmlElement)
  {
    return openXmlElement?.DistanceFromLeft?.Value;
  }

  public static void SetDistanceFromLeft(WrapTight? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromLeft = value;
  }

  /// <summary>
  ///   Distance From Text on Right Edge
  /// </summary>
  public static UInt32? GetDistanceFromRight(WrapTight? openXmlElement)
  {
    return openXmlElement?.DistanceFromRight?.Value;
  }

  public static void SetDistanceFromRight(WrapTight? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromRight = value;
  }

  /// <summary>
  ///   Tight Wrapping Extents Polygon.
  /// </summary>
  public static WrapPolygon? GetWrapPolygon(WrapTight? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon>();
    if (itemElement != null)
      return WrapPolygonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWrapPolygon(WrapTight? openXmlElement, WrapPolygon? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WrapPolygonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Wordprocessing.WrapTight? CreateModelElement(WrapTight? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.WrapTight();
      value.WrapText = GetWrapText(openXmlElement);
      value.DistanceFromLeft = GetDistanceFromLeft(openXmlElement);
      value.DistanceFromRight = GetDistanceFromRight(openXmlElement);
      value.WrapPolygon = GetWrapPolygon(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.WrapTight? value)
    where OpenXmlElementType : WrapTight, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWrapText(openXmlElement, value?.WrapText);
      SetDistanceFromLeft(openXmlElement, value?.DistanceFromLeft);
      SetDistanceFromRight(openXmlElement, value?.DistanceFromRight);
      SetWrapPolygon(openXmlElement, value?.WrapPolygon);
      return openXmlElement;
    }
    return default;
  }
}
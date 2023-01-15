using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using Tile = DocumentFormat.OpenXml.Drawing.Tile;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Tile.
/// </summary>
public static class TileConverter
{
  /// <summary>
  ///   Horizontal Offset
  /// </summary>
  public static Int64? GetHorizontalOffset(Tile? openXmlElement)
  {
    return openXmlElement?.HorizontalOffset?.Value;
  }

  public static void SetHorizontalOffset(Tile? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalOffset = value;
  }

  /// <summary>
  ///   Vertical Offset
  /// </summary>
  public static Int64? GetVerticalOffset(Tile? openXmlElement)
  {
    return openXmlElement?.VerticalOffset?.Value;
  }

  public static void SetVerticalOffset(Tile? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalOffset = value;
  }

  /// <summary>
  ///   Horizontal Ratio
  /// </summary>
  public static Int32? GetHorizontalRatio(Tile? openXmlElement)
  {
    return openXmlElement?.HorizontalRatio?.Value;
  }

  public static void SetHorizontalRatio(Tile? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalRatio = value;
  }

  /// <summary>
  ///   Vertical Ratio
  /// </summary>
  public static Int32? GetVerticalRatio(Tile? openXmlElement)
  {
    return openXmlElement?.VerticalRatio?.Value;
  }

  public static void SetVerticalRatio(Tile? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalRatio = value;
  }

  /// <summary>
  ///   Tile Flipping
  /// </summary>
  public static TileFlipKind? GetFlip(Tile? openXmlElement)
  {
    return EnumValueConverter.GetValue<TileFlipValues, TileFlipKind>(openXmlElement?.Flip?.Value);
  }

  public static void SetFlip(Tile? openXmlElement, TileFlipKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Flip = EnumValueConverter.CreateEnumValue<TileFlipValues, TileFlipKind>(value);
  }

  /// <summary>
  ///   Alignment
  /// </summary>
  public static RectangleAlignmentKind? GetAlignment(Tile? openXmlElement)
  {
    return EnumValueConverter.GetValue<RectangleAlignmentValues, RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }

  public static void SetAlignment(Tile? openXmlElement, RectangleAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<RectangleAlignmentValues, RectangleAlignmentKind>(value);
  }

  public static DocumentModel.Drawings.Tile? CreateModelElement(Tile? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Tile();
      value.HorizontalOffset = GetHorizontalOffset(openXmlElement);
      value.VerticalOffset = GetVerticalOffset(openXmlElement);
      value.HorizontalRatio = GetHorizontalRatio(openXmlElement);
      value.VerticalRatio = GetVerticalRatio(openXmlElement);
      value.Flip = GetFlip(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Tile? value)
    where OpenXmlElementType : Tile, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHorizontalOffset(openXmlElement, value?.HorizontalOffset);
      SetVerticalOffset(openXmlElement, value?.VerticalOffset);
      SetHorizontalRatio(openXmlElement, value?.HorizontalRatio);
      SetVerticalRatio(openXmlElement, value?.VerticalRatio);
      SetFlip(openXmlElement, value?.Flip);
      SetAlignment(openXmlElement, value?.Alignment);
      return openXmlElement;
    }
    return default;
  }
}
using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using GradientFill = DocumentFormat.OpenXml.Drawing.GradientFill;
using GradientStopList = DocumentModel.Drawings.GradientStopList;
using LinearGradientFill = DocumentModel.Drawings.LinearGradientFill;
using PathGradientFill = DocumentModel.Drawings.PathGradientFill;
using RelativeRectangleType = DocumentModel.Drawings.RelativeRectangleType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the GradientFill Class.
/// </summary>
public static class GradientFillConverter
{
  /// <summary>
  ///   Tile Flip
  /// </summary>
  public static TileFlipKind? GetFlip(GradientFill? openXmlElement)
  {
    return EnumValueConverter.GetValue<TileFlipValues, TileFlipKind>(openXmlElement?.Flip?.Value);
  }

  public static void SetFlip(GradientFill? openXmlElement, TileFlipKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Flip = EnumValueConverter.CreateEnumValue<TileFlipValues, TileFlipKind>(value);
  }

  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  public static Boolean? GetRotateWithShape(GradientFill? openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }

  public static void SetRotateWithShape(GradientFill? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.RotateWithShape = null;
  }

  /// <summary>
  ///   Gradient Stop List.
  /// </summary>
  public static GradientStopList? GetGradientStopList(GradientFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientStopList>();
    if (itemElement != null)
      return GradientStopListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGradientStopList(GradientFill? openXmlElement, GradientStopList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientStopList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GradientStopListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.GradientStopList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LinearGradientFill? GetLinearGradientFill(GradientFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LinearGradientFill>();
    if (itemElement != null)
      return LinearGradientFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLinearGradientFill(GradientFill? openXmlElement, LinearGradientFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LinearGradientFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LinearGradientFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LinearGradientFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PathGradientFill? GetPathGradientFill(GradientFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PathGradientFill>();
    if (itemElement != null)
      return PathGradientFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPathGradientFill(GradientFill? openXmlElement, PathGradientFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PathGradientFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PathGradientFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PathGradientFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RelativeRectangleType? GetTileRectangle(GradientFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TileRectangle>();
    if (itemElement != null)
      return RelativeRectangleTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTileRectangle(GradientFill? openXmlElement, RelativeRectangleType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TileRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelativeRectangleTypeConverter.CreateOpenXmlElement<TileRectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.GradientFill? CreateModelElement(GradientFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.GradientFill();
      value.Flip = GetFlip(openXmlElement);
      value.RotateWithShape = GetRotateWithShape(openXmlElement);
      value.GradientStopList = GetGradientStopList(openXmlElement);
      value.LinearGradientFill = GetLinearGradientFill(openXmlElement);
      value.PathGradientFill = GetPathGradientFill(openXmlElement);
      value.TileRectangle = GetTileRectangle(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.GradientFill? value)
    where OpenXmlElementType : GradientFill, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFlip(openXmlElement, value?.Flip);
      SetRotateWithShape(openXmlElement, value?.RotateWithShape);
      SetGradientStopList(openXmlElement, value?.GradientStopList);
      SetLinearGradientFill(openXmlElement, value?.LinearGradientFill);
      SetPathGradientFill(openXmlElement, value?.PathGradientFill);
      SetTileRectangle(openXmlElement, value?.TileRectangle);
      return openXmlElement;
    }
    return default;
  }
}
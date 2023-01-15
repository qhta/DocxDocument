using DocumentFormat.OpenXml.Drawing;
using Blip = DocumentModel.Drawings.Blip;
using BlipFill = DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill;
using RelativeRectangleType = DocumentModel.Drawings.RelativeRectangleType;
using Stretch = DocumentModel.Drawings.Stretch;
using Tile = DocumentModel.Drawings.Tile;

namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
///   Picture Fill.
/// </summary>
public static class BlipFillConverter
{
  /// <summary>
  ///   DPI Setting
  /// </summary>
  public static UInt32? GetDpi(BlipFill? openXmlElement)
  {
    return openXmlElement?.Dpi?.Value;
  }

  public static void SetDpi(BlipFill? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Dpi = value;
  }

  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  public static Boolean? GetRotateWithShape(BlipFill? openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }

  public static void SetRotateWithShape(BlipFill? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.RotateWithShape = null;
  }

  /// <summary>
  ///   Blip.
  /// </summary>
  public static Blip? GetBlip(BlipFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blip>();
    if (itemElement != null)
      return BlipConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBlip(BlipFill? openXmlElement, Blip? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blip>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlipConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Blip>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Source Rectangle.
  /// </summary>
  public static RelativeRectangleType? GetSourceRectangle(BlipFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SourceRectangle>();
    if (itemElement != null)
      return RelativeRectangleTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSourceRectangle(BlipFill? openXmlElement, RelativeRectangleType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SourceRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelativeRectangleTypeConverter.CreateOpenXmlElement<SourceRectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Tile? GetTile(BlipFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Tile>();
    if (itemElement != null)
      return TileConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTile(BlipFill? openXmlElement, Tile? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Tile>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TileConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Tile>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Stretch? GetStretch(BlipFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Stretch>();
    if (itemElement != null)
      return StretchConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStretch(BlipFill? openXmlElement, Stretch? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Stretch>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StretchConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Stretch>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawing.BlipFill? CreateModelElement(BlipFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.BlipFill();
      value.Dpi = GetDpi(openXmlElement);
      value.RotateWithShape = GetRotateWithShape(openXmlElement);
      value.Blip = GetBlip(openXmlElement);
      value.SourceRectangle = GetSourceRectangle(openXmlElement);
      value.Tile = GetTile(openXmlElement);
      value.Stretch = GetStretch(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.BlipFill? value)
    where OpenXmlElementType : BlipFill, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDpi(openXmlElement, value?.Dpi);
      SetRotateWithShape(openXmlElement, value?.RotateWithShape);
      SetBlip(openXmlElement, value?.Blip);
      SetSourceRectangle(openXmlElement, value?.SourceRectangle);
      SetTile(openXmlElement, value?.Tile);
      SetStretch(openXmlElement, value?.Stretch);
      return openXmlElement;
    }
    return default;
  }
}
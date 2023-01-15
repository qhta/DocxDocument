using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Color = DocumentModel.Wordprocessing.Color;
using FramesetSplitbar = DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Frameset Splitter Properties.
/// </summary>
public static class FramesetSplitbarConverter
{
  /// <summary>
  ///   Frameset Splitter Width.
  /// </summary>
  public static String? GetWidth(FramesetSplitbar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Width>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetWidth(FramesetSplitbar? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Width>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Width { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Frameset Splitter Color.
  /// </summary>
  public static Color? GetColor(FramesetSplitbar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>();
    if (itemElement != null)
      return ColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColor(FramesetSplitbar? openXmlElement, Color? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Color>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Do Not Display Frameset Splitters.
  /// </summary>
  public static OnOffOnlyKind? GetNoBorder(FramesetSplitbar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoBorder>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetNoBorder(FramesetSplitbar? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<NoBorder, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Frameset Splitter Border Style.
  /// </summary>
  public static OnOffOnlyKind? GetFlatBorders(FramesetSplitbar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FlatBorders>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffOnlyValues, OnOffOnlyKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetFlatBorders(FramesetSplitbar? openXmlElement, OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FlatBorders>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<FlatBorders, OnOffOnlyValues, OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.FramesetSplitbar? CreateModelElement(FramesetSplitbar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FramesetSplitbar();
      value.Width = GetWidth(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.NoBorder = GetNoBorder(openXmlElement);
      value.FlatBorders = GetFlatBorders(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FramesetSplitbar? value)
    where OpenXmlElementType : FramesetSplitbar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetColor(openXmlElement, value?.Color);
      SetNoBorder(openXmlElement, value?.NoBorder);
      SetFlatBorders(openXmlElement, value?.FlatBorders);
      return openXmlElement;
    }
    return default;
  }
}
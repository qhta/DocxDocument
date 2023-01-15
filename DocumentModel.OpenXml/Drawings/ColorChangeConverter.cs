using DocumentFormat.OpenXml.Drawing;
using ColorFrom = DocumentModel.Drawings.ColorFrom;
using ColorTo = DocumentModel.Drawings.ColorTo;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Color Change Effect.
/// </summary>
public static class ColorChangeConverter
{
  /// <summary>
  ///   Consider Alpha Values
  /// </summary>
  public static Boolean? GetUseAlpha(ColorChange? openXmlElement)
  {
    return openXmlElement?.UseAlpha?.Value;
  }

  public static void SetUseAlpha(ColorChange? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UseAlpha = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.UseAlpha = null;
  }

  /// <summary>
  ///   Change Color From.
  /// </summary>
  public static ColorFrom? GetColorFrom(ColorChange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorFrom>();
    if (itemElement != null)
      return ColorFromConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorFrom(ColorChange? openXmlElement, ColorFrom? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorFrom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorFromConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ColorFrom>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Change Color To.
  /// </summary>
  public static ColorTo? GetColorTo(ColorChange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorTo>();
    if (itemElement != null)
      return ColorToConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorTo(ColorChange? openXmlElement, ColorTo? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorTo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorToConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ColorTo>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ColorChange? CreateModelElement(ColorChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ColorChange();
      value.UseAlpha = GetUseAlpha(openXmlElement);
      value.ColorFrom = GetColorFrom(openXmlElement);
      value.ColorTo = GetColorTo(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ColorChange? value)
    where OpenXmlElementType : ColorChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUseAlpha(openXmlElement, value?.UseAlpha);
      SetColorFrom(openXmlElement, value?.ColorFrom);
      SetColorTo(openXmlElement, value?.ColorTo);
      return openXmlElement;
    }
    return default;
  }
}
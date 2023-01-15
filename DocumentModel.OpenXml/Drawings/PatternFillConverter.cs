using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using BackgroundColor = DocumentModel.Drawings.BackgroundColor;
using ForegroundColor = DocumentModel.Drawings.ForegroundColor;
using PatternFill = DocumentFormat.OpenXml.Drawing.PatternFill;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Pattern Fill.
/// </summary>
public static class PatternFillConverter
{
  /// <summary>
  ///   Preset Pattern
  /// </summary>
  public static PresetPatternKind? GetPreset(PatternFill? openXmlElement)
  {
    return EnumValueConverter.GetValue<PresetPatternValues, PresetPatternKind>(openXmlElement?.Preset?.Value);
  }

  public static void SetPreset(PatternFill? openXmlElement, PresetPatternKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Preset = EnumValueConverter.CreateEnumValue<PresetPatternValues, PresetPatternKind>(value);
  }

  /// <summary>
  ///   Foreground color.
  /// </summary>
  public static ForegroundColor? GetForegroundColor(PatternFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ForegroundColor>();
    if (itemElement != null)
      return ForegroundColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetForegroundColor(PatternFill? openXmlElement, ForegroundColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ForegroundColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ForegroundColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ForegroundColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Background color.
  /// </summary>
  public static BackgroundColor? GetBackgroundColor(PatternFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BackgroundColor>();
    if (itemElement != null)
      return BackgroundColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackgroundColor(PatternFill? openXmlElement, BackgroundColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BackgroundColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BackgroundColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.PatternFill? CreateModelElement(PatternFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PatternFill();
      value.Preset = GetPreset(openXmlElement);
      value.ForegroundColor = GetForegroundColor(openXmlElement);
      value.BackgroundColor = GetBackgroundColor(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PatternFill? value)
    where OpenXmlElementType : PatternFill, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPreset(openXmlElement, value?.Preset);
      SetForegroundColor(openXmlElement, value?.ForegroundColor);
      SetBackgroundColor(openXmlElement, value?.BackgroundColor);
      return openXmlElement;
    }
    return default;
  }
}
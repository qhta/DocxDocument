using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using AdjustValueList = DocumentModel.Drawings.AdjustValueList;
using PresetTextWrap = DocumentFormat.OpenXml.Drawing.PresetTextWrap;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Preset Text Warp.
/// </summary>
public static class PresetTextWrapConverter
{
  /// <summary>
  ///   Preset Warp Shape
  /// </summary>
  public static TextShapeKind? GetPreset(PresetTextWrap? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextShapeValues, TextShapeKind>(openXmlElement?.Preset?.Value);
  }

  public static void SetPreset(PresetTextWrap? openXmlElement, TextShapeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Preset = EnumValueConverter.CreateEnumValue<TextShapeValues, TextShapeKind>(value);
  }

  /// <summary>
  ///   Adjust Value List.
  /// </summary>
  public static AdjustValueList? GetAdjustValueList(PresetTextWrap? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustValueList>();
    if (itemElement != null)
      return AdjustValueListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAdjustValueList(PresetTextWrap? openXmlElement, AdjustValueList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustValueList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AdjustValueListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AdjustValueList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.PresetTextWrap? CreateModelElement(PresetTextWrap? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PresetTextWrap();
      value.Preset = GetPreset(openXmlElement);
      value.AdjustValueList = GetAdjustValueList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PresetTextWrap? value)
    where OpenXmlElementType : PresetTextWrap, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPreset(openXmlElement, value?.Preset);
      SetAdjustValueList(openXmlElement, value?.AdjustValueList);
      return openXmlElement;
    }
    return default;
  }
}
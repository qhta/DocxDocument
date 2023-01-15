using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using ColorMappingType = DocumentFormat.OpenXml.Drawing.ColorMappingType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ColorMappingType Class.
/// </summary>
public static class ColorMappingTypeConverter
{
  /// <summary>
  ///   Background 1
  /// </summary>
  public static ColorSchemeIndexKind? GetBackground1(ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Background1?.Value);
  }

  public static void SetBackground1(ColorMappingType? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Background1 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Text 1
  /// </summary>
  public static ColorSchemeIndexKind? GetText1(ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Text1?.Value);
  }

  public static void SetText1(ColorMappingType? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Text1 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Background 2
  /// </summary>
  public static ColorSchemeIndexKind? GetBackground2(ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Background2?.Value);
  }

  public static void SetBackground2(ColorMappingType? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Background2 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Text 2
  /// </summary>
  public static ColorSchemeIndexKind? GetText2(ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Text2?.Value);
  }

  public static void SetText2(ColorMappingType? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Text2 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Accent 1
  /// </summary>
  public static ColorSchemeIndexKind? GetAccent1(ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Accent1?.Value);
  }

  public static void SetAccent1(ColorMappingType? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent1 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Accent 2
  /// </summary>
  public static ColorSchemeIndexKind? GetAccent2(ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Accent2?.Value);
  }

  public static void SetAccent2(ColorMappingType? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent2 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Accent 3
  /// </summary>
  public static ColorSchemeIndexKind? GetAccent3(ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Accent3?.Value);
  }

  public static void SetAccent3(ColorMappingType? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent3 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Accent 4
  /// </summary>
  public static ColorSchemeIndexKind? GetAccent4(ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Accent4?.Value);
  }

  public static void SetAccent4(ColorMappingType? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent4 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Accent 5
  /// </summary>
  public static ColorSchemeIndexKind? GetAccent5(ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Accent5?.Value);
  }

  public static void SetAccent5(ColorMappingType? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent5 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Accent 6
  /// </summary>
  public static ColorSchemeIndexKind? GetAccent6(ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Accent6?.Value);
  }

  public static void SetAccent6(ColorMappingType? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent6 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Hyperlink
  /// </summary>
  public static ColorSchemeIndexKind? GetHyperlink(ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Hyperlink?.Value);
  }

  public static void SetHyperlink(ColorMappingType? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Hyperlink = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Followed Hyperlink
  /// </summary>
  public static ColorSchemeIndexKind? GetFollowedHyperlink(ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.FollowedHyperlink?.Value);
  }

  public static void SetFollowedHyperlink(ColorMappingType? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.FollowedHyperlink = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(ColorMappingType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(ColorMappingType? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ColorMappingType? CreateModelElement(ColorMappingType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ColorMappingType();
      value.Background1 = GetBackground1(openXmlElement);
      value.Text1 = GetText1(openXmlElement);
      value.Background2 = GetBackground2(openXmlElement);
      value.Text2 = GetText2(openXmlElement);
      value.Accent1 = GetAccent1(openXmlElement);
      value.Accent2 = GetAccent2(openXmlElement);
      value.Accent3 = GetAccent3(openXmlElement);
      value.Accent4 = GetAccent4(openXmlElement);
      value.Accent5 = GetAccent5(openXmlElement);
      value.Accent6 = GetAccent6(openXmlElement);
      value.Hyperlink = GetHyperlink(openXmlElement);
      value.FollowedHyperlink = GetFollowedHyperlink(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ColorMappingType? value)
    where OpenXmlElementType : ColorMappingType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBackground1(openXmlElement, value?.Background1);
      SetText1(openXmlElement, value?.Text1);
      SetBackground2(openXmlElement, value?.Background2);
      SetText2(openXmlElement, value?.Text2);
      SetAccent1(openXmlElement, value?.Accent1);
      SetAccent2(openXmlElement, value?.Accent2);
      SetAccent3(openXmlElement, value?.Accent3);
      SetAccent4(openXmlElement, value?.Accent4);
      SetAccent5(openXmlElement, value?.Accent5);
      SetAccent6(openXmlElement, value?.Accent6);
      SetHyperlink(openXmlElement, value?.Hyperlink);
      SetFollowedHyperlink(openXmlElement, value?.FollowedHyperlink);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using ColorSchemeMapping = DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Theme Color Mappings.
/// </summary>
public static class ColorSchemeMappingConverter
{
  /// <summary>
  ///   Background 1 Theme Color Mapping
  /// </summary>
  public static ColorSchemeIndexKind? GetBackground1(ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Background1?.Value);
  }

  public static void SetBackground1(ColorSchemeMapping? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Background1 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Text 1 Theme Color Mapping
  /// </summary>
  public static ColorSchemeIndexKind? GetText1(ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Text1?.Value);
  }

  public static void SetText1(ColorSchemeMapping? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Text1 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Background 2 Theme Color Mapping
  /// </summary>
  public static ColorSchemeIndexKind? GetBackground2(ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Background2?.Value);
  }

  public static void SetBackground2(ColorSchemeMapping? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Background2 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Text 2 Theme Color Mapping
  /// </summary>
  public static ColorSchemeIndexKind? GetText2(ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Text2?.Value);
  }

  public static void SetText2(ColorSchemeMapping? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Text2 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Accent 1 Theme Color Mapping
  /// </summary>
  public static ColorSchemeIndexKind? GetAccent1(ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Accent1?.Value);
  }

  public static void SetAccent1(ColorSchemeMapping? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent1 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Accent 2 Theme Color Mapping
  /// </summary>
  public static ColorSchemeIndexKind? GetAccent2(ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Accent2?.Value);
  }

  public static void SetAccent2(ColorSchemeMapping? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent2 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Accent3 Theme Color Mapping
  /// </summary>
  public static ColorSchemeIndexKind? GetAccent3(ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Accent3?.Value);
  }

  public static void SetAccent3(ColorSchemeMapping? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent3 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Accent4 Theme Color Mapping
  /// </summary>
  public static ColorSchemeIndexKind? GetAccent4(ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Accent4?.Value);
  }

  public static void SetAccent4(ColorSchemeMapping? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent4 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Accent5 Theme Color Mapping
  /// </summary>
  public static ColorSchemeIndexKind? GetAccent5(ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Accent5?.Value);
  }

  public static void SetAccent5(ColorSchemeMapping? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent5 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Accent6 Theme Color Mapping
  /// </summary>
  public static ColorSchemeIndexKind? GetAccent6(ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Accent6?.Value);
  }

  public static void SetAccent6(ColorSchemeMapping? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent6 = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Hyperlink Theme Color Mapping
  /// </summary>
  public static ColorSchemeIndexKind? GetHyperlink(ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.Hyperlink?.Value);
  }

  public static void SetHyperlink(ColorSchemeMapping? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Hyperlink = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  /// <summary>
  ///   Followed Hyperlink Theme Color Mapping
  /// </summary>
  public static ColorSchemeIndexKind? GetFollowedHyperlink(ColorSchemeMapping? openXmlElement)
  {
    return EnumValueConverter.GetValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(openXmlElement?.FollowedHyperlink?.Value);
  }

  public static void SetFollowedHyperlink(ColorSchemeMapping? openXmlElement, ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.FollowedHyperlink = EnumValueConverter.CreateEnumValue<ColorSchemeIndexValues, ColorSchemeIndexKind>(value);
  }

  public static DocumentModel.Wordprocessing.ColorSchemeMapping? CreateModelElement(ColorSchemeMapping? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ColorSchemeMapping();
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
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ColorSchemeMapping? value)
    where OpenXmlElementType : ColorSchemeMapping, new()
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
      return openXmlElement;
    }
    return default;
  }
}
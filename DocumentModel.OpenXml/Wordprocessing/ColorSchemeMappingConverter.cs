namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Theme Color Mappings.
/// </summary>
public static class ColorSchemeMappingConverter
{
  /// <summary>
  /// Background 1 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetBackground1(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Background1?.Value);
  }
  
  private static void SetBackground1(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Background1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Text 1 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetText1(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Text1?.Value);
  }
  
  private static void SetText1(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Text1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Background 2 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetBackground2(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Background2?.Value);
  }
  
  private static void SetBackground2(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Background2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Text 2 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetText2(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Text2?.Value);
  }
  
  private static void SetText2(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Text2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 1 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetAccent1(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent1?.Value);
  }
  
  private static void SetAccent1(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 2 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetAccent2(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent2?.Value);
  }
  
  private static void SetAccent2(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent3 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetAccent3(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent3?.Value);
  }
  
  private static void SetAccent3(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent3 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent4 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetAccent4(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent4?.Value);
  }
  
  private static void SetAccent4(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent4 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent5 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetAccent5(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent5?.Value);
  }
  
  private static void SetAccent5(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent5 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent6 Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetAccent6(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Accent6?.Value);
  }
  
  private static void SetAccent6(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent6 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Hyperlink Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetHyperlink(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.Hyperlink?.Value);
  }
  
  private static void SetHyperlink(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.Hyperlink = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Followed Hyperlink Theme Color Mapping
  /// </summary>
  private static DMW.ColorSchemeIndexKind? GetFollowedHyperlink(DXW.ColorSchemeMapping openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(openXmlElement?.FollowedHyperlink?.Value);
  }
  
  private static void SetFollowedHyperlink(DXW.ColorSchemeMapping openXmlElement, DMW.ColorSchemeIndexKind? value)
  {
    openXmlElement.FollowedHyperlink = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues, DMW.ColorSchemeIndexKind>(value);
  }
  
  public static DMW.ColorSchemeMapping? CreateModelElement(DXW.ColorSchemeMapping? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ColorSchemeMapping();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ColorSchemeMapping? value)
    where OpenXmlElementType: DXW.ColorSchemeMapping, new()
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

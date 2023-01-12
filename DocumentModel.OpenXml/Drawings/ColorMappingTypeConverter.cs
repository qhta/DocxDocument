namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ColorMappingType Class.
/// </summary>
public static class ColorMappingTypeConverter
{
  /// <summary>
  /// Background 1
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetBackground1(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Background1?.Value);
  }
  
  public static void SetBackground1(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Background1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Text 1
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetText1(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Text1?.Value);
  }
  
  public static void SetText1(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Text1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Background 2
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetBackground2(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Background2?.Value);
  }
  
  public static void SetBackground2(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Background2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Text 2
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetText2(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Text2?.Value);
  }
  
  public static void SetText2(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Text2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 1
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent1(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent1?.Value);
  }
  
  public static void SetAccent1(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 2
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent2(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent2?.Value);
  }
  
  public static void SetAccent2(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 3
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent3(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent3?.Value);
  }
  
  public static void SetAccent3(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent3 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 4
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent4(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent4?.Value);
  }
  
  public static void SetAccent4(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent4 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 5
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent5(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent5?.Value);
  }
  
  public static void SetAccent5(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent5 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 6
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent6(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent6?.Value);
  }
  
  public static void SetAccent6(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent6 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Hyperlink
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetHyperlink(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Hyperlink?.Value);
  }
  
  public static void SetHyperlink(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Hyperlink = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Followed Hyperlink
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetFollowedHyperlink(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.FollowedHyperlink?.Value);
  }
  
  public static void SetFollowedHyperlink(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.FollowedHyperlink = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ColorMappingType? CreateModelElement(DocumentFormat.OpenXml.Drawing.ColorMappingType? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ColorMappingType, new()
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

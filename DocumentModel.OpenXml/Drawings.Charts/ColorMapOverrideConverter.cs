namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ColorMapOverride Class.
/// </summary>
public static class ColorMapOverrideConverter
{
  /// <summary>
  /// Background 1
  /// </summary>
  private static DocumentModel.Drawings.ColorSchemeIndexKind? GetBackground1(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Background1?.Value);
  }
  
  private static void SetBackground1(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    openXmlElement.Background1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Text 1
  /// </summary>
  private static DocumentModel.Drawings.ColorSchemeIndexKind? GetText1(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Text1?.Value);
  }
  
  private static void SetText1(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    openXmlElement.Text1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Background 2
  /// </summary>
  private static DocumentModel.Drawings.ColorSchemeIndexKind? GetBackground2(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Background2?.Value);
  }
  
  private static void SetBackground2(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    openXmlElement.Background2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Text 2
  /// </summary>
  private static DocumentModel.Drawings.ColorSchemeIndexKind? GetText2(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Text2?.Value);
  }
  
  private static void SetText2(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    openXmlElement.Text2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 1
  /// </summary>
  private static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent1(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent1?.Value);
  }
  
  private static void SetAccent1(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 2
  /// </summary>
  private static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent2(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent2?.Value);
  }
  
  private static void SetAccent2(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 3
  /// </summary>
  private static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent3(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent3?.Value);
  }
  
  private static void SetAccent3(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent3 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 4
  /// </summary>
  private static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent4(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent4?.Value);
  }
  
  private static void SetAccent4(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent4 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 5
  /// </summary>
  private static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent5(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent5?.Value);
  }
  
  private static void SetAccent5(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent5 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 6
  /// </summary>
  private static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent6(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent6?.Value);
  }
  
  private static void SetAccent6(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    openXmlElement.Accent6 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Hyperlink
  /// </summary>
  private static DocumentModel.Drawings.ColorSchemeIndexKind? GetHyperlink(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Hyperlink?.Value);
  }
  
  private static void SetHyperlink(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    openXmlElement.Hyperlink = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Followed Hyperlink
  /// </summary>
  private static DocumentModel.Drawings.ColorSchemeIndexKind? GetFollowedHyperlink(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.FollowedHyperlink?.Value);
  }
  
  private static void SetFollowedHyperlink(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    openXmlElement.FollowedHyperlink = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement, DocumentModel.Drawings.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.ColorMapOverride? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ColorMapOverride();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ColorMapOverride? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride, new()
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

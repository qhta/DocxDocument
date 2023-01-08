namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ColorMappingType Class.
/// </summary>
public static class ColorMappingTypeConverter
{
  /// <summary>
  /// Background 1
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetBackground1(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Background1?.Value);
  }
  
  public static void SetBackground1(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Background1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Text 1
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetText1(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Text1?.Value);
  }
  
  public static void SetText1(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Text1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Background 2
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetBackground2(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Background2?.Value);
  }
  
  public static void SetBackground2(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Background2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Text 2
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetText2(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Text2?.Value);
  }
  
  public static void SetText2(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Text2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 1
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent1(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent1?.Value);
  }
  
  public static void SetAccent1(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent1 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 2
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent2(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent2?.Value);
  }
  
  public static void SetAccent2(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent2 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 3
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent3(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent3?.Value);
  }
  
  public static void SetAccent3(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent3 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 4
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent4(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent4?.Value);
  }
  
  public static void SetAccent4(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent4 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 5
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent5(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent5?.Value);
  }
  
  public static void SetAccent5(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent5 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Accent 6
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetAccent6(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Accent6?.Value);
  }
  
  public static void SetAccent6(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Accent6 = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Hyperlink
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetHyperlink(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.Hyperlink?.Value);
  }
  
  public static void SetHyperlink(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Hyperlink = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// Followed Hyperlink
  /// </summary>
  public static DocumentModel.Drawings.ColorSchemeIndexKind? GetFollowedHyperlink(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(openXmlElement?.FollowedHyperlink?.Value);
  }
  
  public static void SetFollowedHyperlink(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ColorSchemeIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.FollowedHyperlink = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues, DocumentModel.Drawings.ColorSchemeIndexKind>(value);
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

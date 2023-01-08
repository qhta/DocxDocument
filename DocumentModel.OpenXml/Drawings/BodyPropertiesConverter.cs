namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BodyProperties Class.
/// </summary>
public static class BodyPropertiesConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  public static Int32? GetRotation(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRotation(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Paragraph Spacing
  /// </summary>
  public static Boolean? GetUseParagraphSpacing(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetUseParagraphSpacing(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Text Vertical Overflow
  /// </summary>
  public static DocumentModel.Drawings.TextVerticalOverflowKind? GetVerticalOverflow(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues, DocumentModel.Drawings.TextVerticalOverflowKind>(openXmlElement?.VerticalOverflow?.Value);
  }
  
  public static void SetVerticalOverflow(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, DocumentModel.Drawings.TextVerticalOverflowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalOverflow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues, DocumentModel.Drawings.TextVerticalOverflowKind>(value);
  }
  
  /// <summary>
  /// Text Horizontal Overflow
  /// </summary>
  public static DocumentModel.Drawings.TextHorizontalOverflowKind? GetHorizontalOverflow(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues, DocumentModel.Drawings.TextHorizontalOverflowKind>(openXmlElement?.HorizontalOverflow?.Value);
  }
  
  public static void SetHorizontalOverflow(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, DocumentModel.Drawings.TextHorizontalOverflowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalOverflow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues, DocumentModel.Drawings.TextHorizontalOverflowKind>(value);
  }
  
  /// <summary>
  /// Vertical Text
  /// </summary>
  public static DocumentModel.Drawings.TextVerticalKind? GetVertical(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues, DocumentModel.Drawings.TextVerticalKind>(openXmlElement?.Vertical?.Value);
  }
  
  public static void SetVertical(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, DocumentModel.Drawings.TextVerticalKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Vertical = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues, DocumentModel.Drawings.TextVerticalKind>(value);
  }
  
  /// <summary>
  /// Text Wrapping Type
  /// </summary>
  public static DocumentModel.Drawings.TextWrappingKind? GetWrap(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues, DocumentModel.Drawings.TextWrappingKind>(openXmlElement?.Wrap?.Value);
  }
  
  public static void SetWrap(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, DocumentModel.Drawings.TextWrappingKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Wrap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues, DocumentModel.Drawings.TextWrappingKind>(value);
  }
  
  /// <summary>
  /// Left Inset
  /// </summary>
  public static Int32? GetLeftInset(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLeftInset(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Top Inset
  /// </summary>
  public static Int32? GetTopInset(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTopInset(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Right Inset
  /// </summary>
  public static Int32? GetRightInset(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRightInset(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Bottom Inset
  /// </summary>
  public static Int32? GetBottomInset(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBottomInset(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Number of Columns
  /// </summary>
  public static Int32? GetColumnCount(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColumnCount(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Space Between Columns
  /// </summary>
  public static Int32? GetColumnSpacing(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColumnSpacing(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Columns Right-To-Left
  /// </summary>
  public static Boolean? GetRightToLeftColumns(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRightToLeftColumns(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// From WordArt
  /// </summary>
  public static Boolean? GetFromWordArt(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFromWordArt(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Anchor
  /// </summary>
  public static DocumentModel.Drawings.TextAnchoringKind? GetAnchor(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues, DocumentModel.Drawings.TextAnchoringKind>(openXmlElement?.Anchor?.Value);
  }
  
  public static void SetAnchor(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, DocumentModel.Drawings.TextAnchoringKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Anchor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues, DocumentModel.Drawings.TextAnchoringKind>(value);
  }
  
  /// <summary>
  /// Anchor Center
  /// </summary>
  public static Boolean? GetAnchorCenter(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAnchorCenter(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Force Anti-Alias
  /// </summary>
  public static Boolean? GetForceAntiAlias(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetForceAntiAlias(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Text Upright
  /// </summary>
  public static Boolean? GetUpRight(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetUpRight(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Compatible Line Spacing
  /// </summary>
  public static Boolean? GetCompatibleLineSpacing(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCompatibleLineSpacing(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Preset Text Shape.
  /// </summary>
  public static DocumentModel.Drawings.PresetTextWrap? GetPresetTextWrap(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPresetTextWrap(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, DocumentModel.Drawings.PresetTextWrap? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetNoAutoFit(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNoAutoFit(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.NormalAutoFit? GetNormalAutoFit(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNormalAutoFit(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, DocumentModel.Drawings.NormalAutoFit? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetShapeAutoFit(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShapeAutoFit(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Scene3DType? GetScene3DType(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetScene3DType(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, DocumentModel.Drawings.Scene3DType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Shape3DType? GetShape3DType(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShape3DType(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, DocumentModel.Drawings.Shape3DType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.FlatText? GetFlatText(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFlatText(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, DocumentModel.Drawings.FlatText? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.BodyProperties? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

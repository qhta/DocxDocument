namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the TextBodyProperties Class.
/// </summary>
public static class TextBodyPropertiesConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  private static Int32? GetRotation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return openXmlElement.Rotation?.Value;
  }
  
  private static void SetRotation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Paragraph Spacing
  /// </summary>
  private static Boolean? GetUseParagraphSpacing(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.UseParagraphSpacing?.Value;
  }
  
  private static void SetUseParagraphSpacing(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UseParagraphSpacing = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UseParagraphSpacing = null;
  }
  
  /// <summary>
  /// Text Vertical Overflow
  /// </summary>
  private static DocumentModel.Drawings.TextVerticalOverflowKind? GetVerticalOverflow(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues, DocumentModel.Drawings.TextVerticalOverflowKind>(openXmlElement?.VerticalOverflow?.Value);
  }
  
  private static void SetVerticalOverflow(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, DocumentModel.Drawings.TextVerticalOverflowKind? value)
  {
    openXmlElement.VerticalOverflow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues, DocumentModel.Drawings.TextVerticalOverflowKind>(value);
  }
  
  /// <summary>
  /// Text Horizontal Overflow
  /// </summary>
  private static DocumentModel.Drawings.TextHorizontalOverflowKind? GetHorizontalOverflow(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues, DocumentModel.Drawings.TextHorizontalOverflowKind>(openXmlElement?.HorizontalOverflow?.Value);
  }
  
  private static void SetHorizontalOverflow(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, DocumentModel.Drawings.TextHorizontalOverflowKind? value)
  {
    openXmlElement.HorizontalOverflow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues, DocumentModel.Drawings.TextHorizontalOverflowKind>(value);
  }
  
  /// <summary>
  /// Vertical Text
  /// </summary>
  private static DocumentModel.Drawings.TextVerticalKind? GetVertical(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues, DocumentModel.Drawings.TextVerticalKind>(openXmlElement?.Vertical?.Value);
  }
  
  private static void SetVertical(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, DocumentModel.Drawings.TextVerticalKind? value)
  {
    openXmlElement.Vertical = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues, DocumentModel.Drawings.TextVerticalKind>(value);
  }
  
  /// <summary>
  /// Text Wrapping Type
  /// </summary>
  private static DocumentModel.Drawings.TextWrappingKind? GetWrap(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues, DocumentModel.Drawings.TextWrappingKind>(openXmlElement?.Wrap?.Value);
  }
  
  private static void SetWrap(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, DocumentModel.Drawings.TextWrappingKind? value)
  {
    openXmlElement.Wrap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues, DocumentModel.Drawings.TextWrappingKind>(value);
  }
  
  /// <summary>
  /// Left Inset
  /// </summary>
  private static Int32? GetLeftInset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return openXmlElement.LeftInset?.Value;
  }
  
  private static void SetLeftInset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.LeftInset = value;
  }
  
  /// <summary>
  /// Top Inset
  /// </summary>
  private static Int32? GetTopInset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return openXmlElement.TopInset?.Value;
  }
  
  private static void SetTopInset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.TopInset = value;
  }
  
  /// <summary>
  /// Right Inset
  /// </summary>
  private static Int32? GetRightInset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return openXmlElement.RightInset?.Value;
  }
  
  private static void SetRightInset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.RightInset = value;
  }
  
  /// <summary>
  /// Bottom Inset
  /// </summary>
  private static Int32? GetBottomInset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return openXmlElement.BottomInset?.Value;
  }
  
  private static void SetBottomInset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.BottomInset = value;
  }
  
  /// <summary>
  /// Number of Columns
  /// </summary>
  private static Int32? GetColumnCount(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return openXmlElement.ColumnCount?.Value;
  }
  
  private static void SetColumnCount(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.ColumnCount = value;
  }
  
  /// <summary>
  /// Space Between Columns
  /// </summary>
  private static Int32? GetColumnSpacing(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return openXmlElement.ColumnSpacing?.Value;
  }
  
  private static void SetColumnSpacing(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.ColumnSpacing = value;
  }
  
  /// <summary>
  /// Columns Right-To-Left
  /// </summary>
  private static Boolean? GetRightToLeftColumns(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.RightToLeftColumns?.Value;
  }
  
  private static void SetRightToLeftColumns(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.RightToLeftColumns = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.RightToLeftColumns = null;
  }
  
  /// <summary>
  /// From WordArt
  /// </summary>
  private static Boolean? GetFromWordArt(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.FromWordArt?.Value;
  }
  
  private static void SetFromWordArt(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FromWordArt = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.FromWordArt = null;
  }
  
  /// <summary>
  /// Anchor
  /// </summary>
  private static DocumentModel.Drawings.TextAnchoringKind? GetAnchor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues, DocumentModel.Drawings.TextAnchoringKind>(openXmlElement?.Anchor?.Value);
  }
  
  private static void SetAnchor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, DocumentModel.Drawings.TextAnchoringKind? value)
  {
    openXmlElement.Anchor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues, DocumentModel.Drawings.TextAnchoringKind>(value);
  }
  
  /// <summary>
  /// Anchor Center
  /// </summary>
  private static Boolean? GetAnchorCenter(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.AnchorCenter?.Value;
  }
  
  private static void SetAnchorCenter(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AnchorCenter = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AnchorCenter = null;
  }
  
  /// <summary>
  /// Force Anti-Alias
  /// </summary>
  private static Boolean? GetForceAntiAlias(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.ForceAntiAlias?.Value;
  }
  
  private static void SetForceAntiAlias(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceAntiAlias = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ForceAntiAlias = null;
  }
  
  /// <summary>
  /// Text Upright
  /// </summary>
  private static Boolean? GetUpRight(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.UpRight?.Value;
  }
  
  private static void SetUpRight(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UpRight = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UpRight = null;
  }
  
  /// <summary>
  /// Compatible Line Spacing
  /// </summary>
  private static Boolean? GetCompatibleLineSpacing(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.CompatibleLineSpacing?.Value;
  }
  
  private static void SetCompatibleLineSpacing(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CompatibleLineSpacing = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.CompatibleLineSpacing = null;
  }
  
  /// <summary>
  /// Preset Text Shape.
  /// </summary>
  private static DocumentModel.Drawings.PresetTextWrap? GetPresetTextWrap(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetTextWrap>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PresetTextWrapConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPresetTextWrap(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, DocumentModel.Drawings.PresetTextWrap? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetTextWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.PresetTextWrapConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetTextWrap>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetNoAutoFit(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoAutoFit>();
    return itemElement != null;
  }
  
  private static void SetNoAutoFit(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoAutoFit>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.NoAutoFit();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.NormalAutoFit? GetNormalAutoFit(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.NormalAutoFit>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.NormalAutoFitConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNormalAutoFit(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, DocumentModel.Drawings.NormalAutoFit? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NormalAutoFit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.NormalAutoFitConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.NormalAutoFit>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShapeAutoFit(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeAutoFit>();
    return itemElement != null;
  }
  
  private static void SetShapeAutoFit(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeAutoFit>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.ShapeAutoFit();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Scene3DType? GetScene3DType(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Scene3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetScene3DType(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, DocumentModel.Drawings.Scene3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Scene3DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Scene3DType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Shape3DType? GetShape3DType(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Shape3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShape3DType(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, DocumentModel.Drawings.Shape3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Shape3DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Shape3DType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.FlatText? GetFlatText(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FlatText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FlatTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFlatText(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, DocumentModel.Drawings.FlatText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FlatText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.FlatTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FlatText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties openXmlElement, DocumentModel.Drawings.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartsStyle.TextBodyProperties? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.TextBodyProperties();
      value.Rotation = GetRotation(openXmlElement);
      value.UseParagraphSpacing = GetUseParagraphSpacing(openXmlElement);
      value.VerticalOverflow = GetVerticalOverflow(openXmlElement);
      value.HorizontalOverflow = GetHorizontalOverflow(openXmlElement);
      value.Vertical = GetVertical(openXmlElement);
      value.Wrap = GetWrap(openXmlElement);
      value.LeftInset = GetLeftInset(openXmlElement);
      value.TopInset = GetTopInset(openXmlElement);
      value.RightInset = GetRightInset(openXmlElement);
      value.BottomInset = GetBottomInset(openXmlElement);
      value.ColumnCount = GetColumnCount(openXmlElement);
      value.ColumnSpacing = GetColumnSpacing(openXmlElement);
      value.RightToLeftColumns = GetRightToLeftColumns(openXmlElement);
      value.FromWordArt = GetFromWordArt(openXmlElement);
      value.Anchor = GetAnchor(openXmlElement);
      value.AnchorCenter = GetAnchorCenter(openXmlElement);
      value.ForceAntiAlias = GetForceAntiAlias(openXmlElement);
      value.UpRight = GetUpRight(openXmlElement);
      value.CompatibleLineSpacing = GetCompatibleLineSpacing(openXmlElement);
      value.PresetTextWrap = GetPresetTextWrap(openXmlElement);
      value.NoAutoFit = GetNoAutoFit(openXmlElement);
      value.NormalAutoFit = GetNormalAutoFit(openXmlElement);
      value.ShapeAutoFit = GetShapeAutoFit(openXmlElement);
      value.Scene3DType = GetScene3DType(openXmlElement);
      value.Shape3DType = GetShape3DType(openXmlElement);
      value.FlatText = GetFlatText(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartsStyle.TextBodyProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRotation(openXmlElement, value?.Rotation);
      SetUseParagraphSpacing(openXmlElement, value?.UseParagraphSpacing);
      SetVerticalOverflow(openXmlElement, value?.VerticalOverflow);
      SetHorizontalOverflow(openXmlElement, value?.HorizontalOverflow);
      SetVertical(openXmlElement, value?.Vertical);
      SetWrap(openXmlElement, value?.Wrap);
      SetLeftInset(openXmlElement, value?.LeftInset);
      SetTopInset(openXmlElement, value?.TopInset);
      SetRightInset(openXmlElement, value?.RightInset);
      SetBottomInset(openXmlElement, value?.BottomInset);
      SetColumnCount(openXmlElement, value?.ColumnCount);
      SetColumnSpacing(openXmlElement, value?.ColumnSpacing);
      SetRightToLeftColumns(openXmlElement, value?.RightToLeftColumns);
      SetFromWordArt(openXmlElement, value?.FromWordArt);
      SetAnchor(openXmlElement, value?.Anchor);
      SetAnchorCenter(openXmlElement, value?.AnchorCenter);
      SetForceAntiAlias(openXmlElement, value?.ForceAntiAlias);
      SetUpRight(openXmlElement, value?.UpRight);
      SetCompatibleLineSpacing(openXmlElement, value?.CompatibleLineSpacing);
      SetPresetTextWrap(openXmlElement, value?.PresetTextWrap);
      SetNoAutoFit(openXmlElement, value?.NoAutoFit);
      SetNormalAutoFit(openXmlElement, value?.NormalAutoFit);
      SetShapeAutoFit(openXmlElement, value?.ShapeAutoFit);
      SetScene3DType(openXmlElement, value?.Scene3DType);
      SetShape3DType(openXmlElement, value?.Shape3DType);
      SetFlatText(openXmlElement, value?.FlatText);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}

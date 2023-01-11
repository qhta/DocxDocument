namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the TextBodyProperties Class.
/// </summary>
public static class TextBodyPropertiesConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  public static Int32? GetRotation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  public static void SetRotation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Paragraph Spacing
  /// </summary>
  public static Boolean? GetUseParagraphSpacing(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.UseParagraphSpacing?.Value;
  }
  
  public static void SetUseParagraphSpacing(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UseParagraphSpacing = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.UseParagraphSpacing = null;
  }
  
  /// <summary>
  /// Text Vertical Overflow
  /// </summary>
  public static DocumentModel.Drawings.TextVerticalOverflowKind? GetVerticalOverflow(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues, DocumentModel.Drawings.TextVerticalOverflowKind>(openXmlElement?.VerticalOverflow?.Value);
  }
  
  public static void SetVerticalOverflow(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, DocumentModel.Drawings.TextVerticalOverflowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalOverflow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues, DocumentModel.Drawings.TextVerticalOverflowKind>(value);
  }
  
  /// <summary>
  /// Text Horizontal Overflow
  /// </summary>
  public static DocumentModel.Drawings.TextHorizontalOverflowKind? GetHorizontalOverflow(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues, DocumentModel.Drawings.TextHorizontalOverflowKind>(openXmlElement?.HorizontalOverflow?.Value);
  }
  
  public static void SetHorizontalOverflow(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, DocumentModel.Drawings.TextHorizontalOverflowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalOverflow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues, DocumentModel.Drawings.TextHorizontalOverflowKind>(value);
  }
  
  /// <summary>
  /// Vertical Text
  /// </summary>
  public static DocumentModel.Drawings.TextVerticalKind? GetVertical(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues, DocumentModel.Drawings.TextVerticalKind>(openXmlElement?.Vertical?.Value);
  }
  
  public static void SetVertical(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, DocumentModel.Drawings.TextVerticalKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Vertical = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues, DocumentModel.Drawings.TextVerticalKind>(value);
  }
  
  /// <summary>
  /// Text Wrapping Type
  /// </summary>
  public static DocumentModel.Drawings.TextWrappingKind? GetWrap(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues, DocumentModel.Drawings.TextWrappingKind>(openXmlElement?.Wrap?.Value);
  }
  
  public static void SetWrap(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, DocumentModel.Drawings.TextWrappingKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Wrap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues, DocumentModel.Drawings.TextWrappingKind>(value);
  }
  
  /// <summary>
  /// Left Inset
  /// </summary>
  public static Int32? GetLeftInset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.LeftInset?.Value;
  }
  
  public static void SetLeftInset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.LeftInset = value;
  }
  
  /// <summary>
  /// Top Inset
  /// </summary>
  public static Int32? GetTopInset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.TopInset?.Value;
  }
  
  public static void SetTopInset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.TopInset = value;
  }
  
  /// <summary>
  /// Right Inset
  /// </summary>
  public static Int32? GetRightInset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.RightInset?.Value;
  }
  
  public static void SetRightInset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.RightInset = value;
  }
  
  /// <summary>
  /// Bottom Inset
  /// </summary>
  public static Int32? GetBottomInset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.BottomInset?.Value;
  }
  
  public static void SetBottomInset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.BottomInset = value;
  }
  
  /// <summary>
  /// Number of Columns
  /// </summary>
  public static Int32? GetColumnCount(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.ColumnCount?.Value;
  }
  
  public static void SetColumnCount(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColumnCount = value;
  }
  
  /// <summary>
  /// Space Between Columns
  /// </summary>
  public static Int32? GetColumnSpacing(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.ColumnSpacing?.Value;
  }
  
  public static void SetColumnSpacing(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColumnSpacing = value;
  }
  
  /// <summary>
  /// Columns Right-To-Left
  /// </summary>
  public static Boolean? GetRightToLeftColumns(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.RightToLeftColumns?.Value;
  }
  
  public static void SetRightToLeftColumns(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RightToLeftColumns = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.RightToLeftColumns = null;
  }
  
  /// <summary>
  /// From WordArt
  /// </summary>
  public static Boolean? GetFromWordArt(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.FromWordArt?.Value;
  }
  
  public static void SetFromWordArt(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FromWordArt = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.FromWordArt = null;
  }
  
  /// <summary>
  /// Anchor
  /// </summary>
  public static DocumentModel.Drawings.TextAnchoringKind? GetAnchor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues, DocumentModel.Drawings.TextAnchoringKind>(openXmlElement?.Anchor?.Value);
  }
  
  public static void SetAnchor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, DocumentModel.Drawings.TextAnchoringKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Anchor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues, DocumentModel.Drawings.TextAnchoringKind>(value);
  }
  
  /// <summary>
  /// Anchor Center
  /// </summary>
  public static Boolean? GetAnchorCenter(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.AnchorCenter?.Value;
  }
  
  public static void SetAnchorCenter(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AnchorCenter = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.AnchorCenter = null;
  }
  
  /// <summary>
  /// Force Anti-Alias
  /// </summary>
  public static Boolean? GetForceAntiAlias(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.ForceAntiAlias?.Value;
  }
  
  public static void SetForceAntiAlias(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ForceAntiAlias = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ForceAntiAlias = null;
  }
  
  /// <summary>
  /// Text Upright
  /// </summary>
  public static Boolean? GetUpRight(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.UpRight?.Value;
  }
  
  public static void SetUpRight(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UpRight = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.UpRight = null;
  }
  
  /// <summary>
  /// Compatible Line Spacing
  /// </summary>
  public static Boolean? GetCompatibleLineSpacing(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.CompatibleLineSpacing?.Value;
  }
  
  public static void SetCompatibleLineSpacing(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CompatibleLineSpacing = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.CompatibleLineSpacing = null;
  }
  
  /// <summary>
  /// Preset Text Shape.
  /// </summary>
  public static DocumentModel.Drawings.PresetTextWrap? GetPresetTextWrap(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetTextWrap>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PresetTextWrapConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPresetTextWrap(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, DocumentModel.Drawings.PresetTextWrap? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetNoAutoFit(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoAutoFit>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetNoAutoFit(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.NormalAutoFit? GetNormalAutoFit(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.NormalAutoFit>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.NormalAutoFitConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNormalAutoFit(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, DocumentModel.Drawings.NormalAutoFit? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetShapeAutoFit(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeAutoFit>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShapeAutoFit(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Scene3DType? GetScene3DType(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Scene3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetScene3DType(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, DocumentModel.Drawings.Scene3DType? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Shape3DType? GetShape3DType(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Shape3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShape3DType(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, DocumentModel.Drawings.Shape3DType? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.FlatText? GetFlatText(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FlatText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FlatTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFlatText(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, DocumentModel.Drawings.FlatText? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

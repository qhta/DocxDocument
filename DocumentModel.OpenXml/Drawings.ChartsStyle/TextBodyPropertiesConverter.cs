namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the TextBodyProperties Class.
/// </summary>
public static class TextBodyPropertiesConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  private static Int32? GetRotation(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  private static bool CmpRotation(DXO13DCS.TextBodyProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Rotation?.Value == value) return true;
    diffs?.Add(objName, "Rotation", openXmlElement?.Rotation?.Value, value);
    return false;
  }
  
  private static void SetRotation(DXO13DCS.TextBodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Paragraph Spacing
  /// </summary>
  private static Boolean? GetUseParagraphSpacing(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.UseParagraphSpacing?.Value;
  }
  
  private static bool CmpUseParagraphSpacing(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.UseParagraphSpacing?.Value == value) return true;
    diffs?.Add(objName, "UseParagraphSpacing", openXmlElement?.UseParagraphSpacing?.Value, value);
    return false;
  }
  
  private static void SetUseParagraphSpacing(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UseParagraphSpacing = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UseParagraphSpacing = null;
  }
  
  /// <summary>
  /// Text Vertical Overflow
  /// </summary>
  private static DMD.TextVerticalOverflowKind? GetVerticalOverflow(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues, DMD.TextVerticalOverflowKind>(openXmlElement?.VerticalOverflow?.Value);
  }
  
  private static bool CmpVerticalOverflow(DXO13DCS.TextBodyProperties openXmlElement, DMD.TextVerticalOverflowKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues, DMD.TextVerticalOverflowKind>(openXmlElement?.VerticalOverflow?.Value, value, diffs, objName);
  }
  
  private static void SetVerticalOverflow(DXO13DCS.TextBodyProperties openXmlElement, DMD.TextVerticalOverflowKind? value)
  {
    openXmlElement.VerticalOverflow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues, DMD.TextVerticalOverflowKind>(value);
  }
  
  /// <summary>
  /// Text Horizontal Overflow
  /// </summary>
  private static DMD.TextHorizontalOverflowKind? GetHorizontalOverflow(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues, DMD.TextHorizontalOverflowKind>(openXmlElement?.HorizontalOverflow?.Value);
  }
  
  private static bool CmpHorizontalOverflow(DXO13DCS.TextBodyProperties openXmlElement, DMD.TextHorizontalOverflowKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues, DMD.TextHorizontalOverflowKind>(openXmlElement?.HorizontalOverflow?.Value, value, diffs, objName);
  }
  
  private static void SetHorizontalOverflow(DXO13DCS.TextBodyProperties openXmlElement, DMD.TextHorizontalOverflowKind? value)
  {
    openXmlElement.HorizontalOverflow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues, DMD.TextHorizontalOverflowKind>(value);
  }
  
  /// <summary>
  /// Vertical Text
  /// </summary>
  private static DMD.TextVerticalKind? GetVertical(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues, DMD.TextVerticalKind>(openXmlElement?.Vertical?.Value);
  }
  
  private static bool CmpVertical(DXO13DCS.TextBodyProperties openXmlElement, DMD.TextVerticalKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues, DMD.TextVerticalKind>(openXmlElement?.Vertical?.Value, value, diffs, objName);
  }
  
  private static void SetVertical(DXO13DCS.TextBodyProperties openXmlElement, DMD.TextVerticalKind? value)
  {
    openXmlElement.Vertical = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues, DMD.TextVerticalKind>(value);
  }
  
  /// <summary>
  /// Text Wrapping Type
  /// </summary>
  private static DMD.TextWrappingKind? GetWrap(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues, DMD.TextWrappingKind>(openXmlElement?.Wrap?.Value);
  }
  
  private static bool CmpWrap(DXO13DCS.TextBodyProperties openXmlElement, DMD.TextWrappingKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues, DMD.TextWrappingKind>(openXmlElement?.Wrap?.Value, value, diffs, objName);
  }
  
  private static void SetWrap(DXO13DCS.TextBodyProperties openXmlElement, DMD.TextWrappingKind? value)
  {
    openXmlElement.Wrap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues, DMD.TextWrappingKind>(value);
  }
  
  /// <summary>
  /// Left Inset
  /// </summary>
  private static Int32? GetLeftInset(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.LeftInset?.Value;
  }
  
  private static bool CmpLeftInset(DXO13DCS.TextBodyProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LeftInset?.Value == value) return true;
    diffs?.Add(objName, "LeftInset", openXmlElement?.LeftInset?.Value, value);
    return false;
  }
  
  private static void SetLeftInset(DXO13DCS.TextBodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.LeftInset = value;
  }
  
  /// <summary>
  /// Top Inset
  /// </summary>
  private static Int32? GetTopInset(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.TopInset?.Value;
  }
  
  private static bool CmpTopInset(DXO13DCS.TextBodyProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.TopInset?.Value == value) return true;
    diffs?.Add(objName, "TopInset", openXmlElement?.TopInset?.Value, value);
    return false;
  }
  
  private static void SetTopInset(DXO13DCS.TextBodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.TopInset = value;
  }
  
  /// <summary>
  /// Right Inset
  /// </summary>
  private static Int32? GetRightInset(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.RightInset?.Value;
  }
  
  private static bool CmpRightInset(DXO13DCS.TextBodyProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RightInset?.Value == value) return true;
    diffs?.Add(objName, "RightInset", openXmlElement?.RightInset?.Value, value);
    return false;
  }
  
  private static void SetRightInset(DXO13DCS.TextBodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.RightInset = value;
  }
  
  /// <summary>
  /// Bottom Inset
  /// </summary>
  private static Int32? GetBottomInset(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.BottomInset?.Value;
  }
  
  private static bool CmpBottomInset(DXO13DCS.TextBodyProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BottomInset?.Value == value) return true;
    diffs?.Add(objName, "BottomInset", openXmlElement?.BottomInset?.Value, value);
    return false;
  }
  
  private static void SetBottomInset(DXO13DCS.TextBodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.BottomInset = value;
  }
  
  /// <summary>
  /// Number of Columns
  /// </summary>
  private static Int32? GetColumnCount(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.ColumnCount?.Value;
  }
  
  private static bool CmpColumnCount(DXO13DCS.TextBodyProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ColumnCount?.Value == value) return true;
    diffs?.Add(objName, "ColumnCount", openXmlElement?.ColumnCount?.Value, value);
    return false;
  }
  
  private static void SetColumnCount(DXO13DCS.TextBodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.ColumnCount = value;
  }
  
  /// <summary>
  /// Space Between Columns
  /// </summary>
  private static Int32? GetColumnSpacing(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.ColumnSpacing?.Value;
  }
  
  private static bool CmpColumnSpacing(DXO13DCS.TextBodyProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ColumnSpacing?.Value == value) return true;
    diffs?.Add(objName, "ColumnSpacing", openXmlElement?.ColumnSpacing?.Value, value);
    return false;
  }
  
  private static void SetColumnSpacing(DXO13DCS.TextBodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.ColumnSpacing = value;
  }
  
  /// <summary>
  /// Columns Right-To-Left
  /// </summary>
  private static Boolean? GetRightToLeftColumns(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.RightToLeftColumns?.Value;
  }
  
  private static bool CmpRightToLeftColumns(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RightToLeftColumns?.Value == value) return true;
    diffs?.Add(objName, "RightToLeftColumns", openXmlElement?.RightToLeftColumns?.Value, value);
    return false;
  }
  
  private static void SetRightToLeftColumns(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.RightToLeftColumns = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.RightToLeftColumns = null;
  }
  
  /// <summary>
  /// From WordArt
  /// </summary>
  private static Boolean? GetFromWordArt(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.FromWordArt?.Value;
  }
  
  private static bool CmpFromWordArt(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FromWordArt?.Value == value) return true;
    diffs?.Add(objName, "FromWordArt", openXmlElement?.FromWordArt?.Value, value);
    return false;
  }
  
  private static void SetFromWordArt(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FromWordArt = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.FromWordArt = null;
  }
  
  /// <summary>
  /// Anchor
  /// </summary>
  private static DMD.TextAnchoringKind? GetAnchor(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues, DMD.TextAnchoringKind>(openXmlElement?.Anchor?.Value);
  }
  
  private static bool CmpAnchor(DXO13DCS.TextBodyProperties openXmlElement, DMD.TextAnchoringKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues, DMD.TextAnchoringKind>(openXmlElement?.Anchor?.Value, value, diffs, objName);
  }
  
  private static void SetAnchor(DXO13DCS.TextBodyProperties openXmlElement, DMD.TextAnchoringKind? value)
  {
    openXmlElement.Anchor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues, DMD.TextAnchoringKind>(value);
  }
  
  /// <summary>
  /// Anchor Center
  /// </summary>
  private static Boolean? GetAnchorCenter(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.AnchorCenter?.Value;
  }
  
  private static bool CmpAnchorCenter(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AnchorCenter?.Value == value) return true;
    diffs?.Add(objName, "AnchorCenter", openXmlElement?.AnchorCenter?.Value, value);
    return false;
  }
  
  private static void SetAnchorCenter(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AnchorCenter = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AnchorCenter = null;
  }
  
  /// <summary>
  /// Force Anti-Alias
  /// </summary>
  private static Boolean? GetForceAntiAlias(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.ForceAntiAlias?.Value;
  }
  
  private static bool CmpForceAntiAlias(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ForceAntiAlias?.Value == value) return true;
    diffs?.Add(objName, "ForceAntiAlias", openXmlElement?.ForceAntiAlias?.Value, value);
    return false;
  }
  
  private static void SetForceAntiAlias(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceAntiAlias = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ForceAntiAlias = null;
  }
  
  /// <summary>
  /// Text Upright
  /// </summary>
  private static Boolean? GetUpRight(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.UpRight?.Value;
  }
  
  private static bool CmpUpRight(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.UpRight?.Value == value) return true;
    diffs?.Add(objName, "UpRight", openXmlElement?.UpRight?.Value, value);
    return false;
  }
  
  private static void SetUpRight(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UpRight = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UpRight = null;
  }
  
  /// <summary>
  /// Compatible Line Spacing
  /// </summary>
  private static Boolean? GetCompatibleLineSpacing(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return openXmlElement?.CompatibleLineSpacing?.Value;
  }
  
  private static bool CmpCompatibleLineSpacing(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CompatibleLineSpacing?.Value == value) return true;
    diffs?.Add(objName, "CompatibleLineSpacing", openXmlElement?.CompatibleLineSpacing?.Value, value);
    return false;
  }
  
  private static void SetCompatibleLineSpacing(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CompatibleLineSpacing = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.CompatibleLineSpacing = null;
  }
  
  /// <summary>
  /// Preset Text Shape.
  /// </summary>
  private static DMD.PresetTextWrap? GetPresetTextWrap(DXO13DCS.TextBodyProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PresetTextWrap>();
    if (element != null)
      return DMXD.PresetTextWrapConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetTextWrap(DXO13DCS.TextBodyProperties openXmlElement, DMD.PresetTextWrap? value, DiffList? diffs, string? objName)
  {
    return DMXD.PresetTextWrapConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PresetTextWrap>(), value, diffs, objName);
  }
  
  private static void SetPresetTextWrap(DXO13DCS.TextBodyProperties openXmlElement, DMD.PresetTextWrap? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PresetTextWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PresetTextWrapConverter.CreateOpenXmlElement<DXD.PresetTextWrap>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetNoAutoFit(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.NoAutoFit>() != null;
  }
  
  private static bool CmpNoAutoFit(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.NoAutoFit>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.NoAutoFit", val, value);
    return false;
  }
  
  private static void SetNoAutoFit(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.NoAutoFit>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.NoAutoFit();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.NormalAutoFit? GetNormalAutoFit(DXO13DCS.TextBodyProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.NormalAutoFit>();
    if (element != null)
      return DMXD.NormalAutoFitConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNormalAutoFit(DXO13DCS.TextBodyProperties openXmlElement, DMD.NormalAutoFit? value, DiffList? diffs, string? objName)
  {
    return DMXD.NormalAutoFitConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.NormalAutoFit>(), value, diffs, objName);
  }
  
  private static void SetNormalAutoFit(DXO13DCS.TextBodyProperties openXmlElement, DMD.NormalAutoFit? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.NormalAutoFit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.NormalAutoFitConverter.CreateOpenXmlElement<DXD.NormalAutoFit>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShapeAutoFit(DXO13DCS.TextBodyProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.ShapeAutoFit>() != null;
  }
  
  private static bool CmpShapeAutoFit(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.ShapeAutoFit>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.ShapeAutoFit", val, value);
    return false;
  }
  
  private static void SetShapeAutoFit(DXO13DCS.TextBodyProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.ShapeAutoFit>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.ShapeAutoFit();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Scene3DType? GetScene3DType(DXO13DCS.TextBodyProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Scene3DType>();
    if (element != null)
      return DMXD.Scene3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScene3DType(DXO13DCS.TextBodyProperties openXmlElement, DMD.Scene3DType? value, DiffList? diffs, string? objName)
  {
    return DMXD.Scene3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Scene3DType>(), value, diffs, objName);
  }
  
  private static void SetScene3DType(DXO13DCS.TextBodyProperties openXmlElement, DMD.Scene3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Scene3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Scene3DTypeConverter.CreateOpenXmlElement<DXD.Scene3DType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Shape3DType? GetShape3DType(DXO13DCS.TextBodyProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Shape3DType>();
    if (element != null)
      return DMXD.Shape3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape3DType(DXO13DCS.TextBodyProperties openXmlElement, DMD.Shape3DType? value, DiffList? diffs, string? objName)
  {
    return DMXD.Shape3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Shape3DType>(), value, diffs, objName);
  }
  
  private static void SetShape3DType(DXO13DCS.TextBodyProperties openXmlElement, DMD.Shape3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Shape3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Shape3DTypeConverter.CreateOpenXmlElement<DXD.Shape3DType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.FlatText? GetFlatText(DXO13DCS.TextBodyProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FlatText>();
    if (element != null)
      return DMXD.FlatTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFlatText(DXO13DCS.TextBodyProperties openXmlElement, DMD.FlatText? value, DiffList? diffs, string? objName)
  {
    return DMXD.FlatTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FlatText>(), value, diffs, objName);
  }
  
  private static void SetFlatText(DXO13DCS.TextBodyProperties openXmlElement, DMD.FlatText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FlatText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FlatTextConverter.CreateOpenXmlElement<DXD.FlatText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.ExtensionList? GetExtensionList(DXO13DCS.TextBodyProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO13DCS.TextBodyProperties openXmlElement, DMD.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO13DCS.TextBodyProperties openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.TextBodyProperties? CreateModelElement(DXO13DCS.TextBodyProperties? openXmlElement)
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
  
  public static bool CompareModelElement(DXO13DCS.TextBodyProperties? openXmlElement, DMDCS.TextBodyProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRotation(openXmlElement, value.Rotation, diffs, objName))
        ok = false;
      if (!CmpUseParagraphSpacing(openXmlElement, value.UseParagraphSpacing, diffs, objName))
        ok = false;
      if (!CmpVerticalOverflow(openXmlElement, value.VerticalOverflow, diffs, objName))
        ok = false;
      if (!CmpHorizontalOverflow(openXmlElement, value.HorizontalOverflow, diffs, objName))
        ok = false;
      if (!CmpVertical(openXmlElement, value.Vertical, diffs, objName))
        ok = false;
      if (!CmpWrap(openXmlElement, value.Wrap, diffs, objName))
        ok = false;
      if (!CmpLeftInset(openXmlElement, value.LeftInset, diffs, objName))
        ok = false;
      if (!CmpTopInset(openXmlElement, value.TopInset, diffs, objName))
        ok = false;
      if (!CmpRightInset(openXmlElement, value.RightInset, diffs, objName))
        ok = false;
      if (!CmpBottomInset(openXmlElement, value.BottomInset, diffs, objName))
        ok = false;
      if (!CmpColumnCount(openXmlElement, value.ColumnCount, diffs, objName))
        ok = false;
      if (!CmpColumnSpacing(openXmlElement, value.ColumnSpacing, diffs, objName))
        ok = false;
      if (!CmpRightToLeftColumns(openXmlElement, value.RightToLeftColumns, diffs, objName))
        ok = false;
      if (!CmpFromWordArt(openXmlElement, value.FromWordArt, diffs, objName))
        ok = false;
      if (!CmpAnchor(openXmlElement, value.Anchor, diffs, objName))
        ok = false;
      if (!CmpAnchorCenter(openXmlElement, value.AnchorCenter, diffs, objName))
        ok = false;
      if (!CmpForceAntiAlias(openXmlElement, value.ForceAntiAlias, diffs, objName))
        ok = false;
      if (!CmpUpRight(openXmlElement, value.UpRight, diffs, objName))
        ok = false;
      if (!CmpCompatibleLineSpacing(openXmlElement, value.CompatibleLineSpacing, diffs, objName))
        ok = false;
      if (!CmpPresetTextWrap(openXmlElement, value.PresetTextWrap, diffs, objName))
        ok = false;
      if (!CmpNoAutoFit(openXmlElement, value.NoAutoFit, diffs, objName))
        ok = false;
      if (!CmpNormalAutoFit(openXmlElement, value.NormalAutoFit, diffs, objName))
        ok = false;
      if (!CmpShapeAutoFit(openXmlElement, value.ShapeAutoFit, diffs, objName))
        ok = false;
      if (!CmpScene3DType(openXmlElement, value.Scene3DType, diffs, objName))
        ok = false;
      if (!CmpShape3DType(openXmlElement, value.Shape3DType, diffs, objName))
        ok = false;
      if (!CmpFlatText(openXmlElement, value.FlatText, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCS.TextBodyProperties value)
    where OpenXmlElementType: DXO13DCS.TextBodyProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DCS.TextBodyProperties openXmlElement, DMDCS.TextBodyProperties value)
  {
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
  }
}

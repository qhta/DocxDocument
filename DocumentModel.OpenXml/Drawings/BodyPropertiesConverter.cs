namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BodyProperties Class.
/// </summary>
public static class BodyPropertiesConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  private static Int32? GetRotation(DXD.BodyProperties openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  private static bool CmpRotation(DXD.BodyProperties openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Rotation?.Value == value) return true;
    diffs?.Add(objName, "Rotation", openXmlElement?.Rotation?.Value, value);
    return false;
  }
  
  private static void SetRotation(DXD.BodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Paragraph Spacing
  /// </summary>
  private static Boolean? GetUseParagraphSpacing(DXD.BodyProperties openXmlElement)
  {
    return openXmlElement?.UseParagraphSpacing?.Value;
  }
  
  private static bool CmpUseParagraphSpacing(DXD.BodyProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.UseParagraphSpacing?.Value == value) return true;
    diffs?.Add(objName, "UseParagraphSpacing", openXmlElement?.UseParagraphSpacing?.Value, value);
    return false;
  }
  
  private static void SetUseParagraphSpacing(DXD.BodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UseParagraphSpacing = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UseParagraphSpacing = null;
  }
  
  /// <summary>
  /// Text Vertical Overflow
  /// </summary>
  private static DMD.TextVerticalOverflowKind? GetVerticalOverflow(DXD.BodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues, DMD.TextVerticalOverflowKind>(openXmlElement?.VerticalOverflow?.Value);
  }
  
  private static bool CmpVerticalOverflow(DXD.BodyProperties openXmlElement, DMD.TextVerticalOverflowKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues, DMD.TextVerticalOverflowKind>(openXmlElement?.VerticalOverflow?.Value, value, diffs, objName, propName);
  }
  
  private static void SetVerticalOverflow(DXD.BodyProperties openXmlElement, DMD.TextVerticalOverflowKind? value)
  {
    openXmlElement.VerticalOverflow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues, DMD.TextVerticalOverflowKind>(value);
  }
  
  /// <summary>
  /// Text Horizontal Overflow
  /// </summary>
  private static DMD.TextHorizontalOverflowKind? GetHorizontalOverflow(DXD.BodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues, DMD.TextHorizontalOverflowKind>(openXmlElement?.HorizontalOverflow?.Value);
  }
  
  private static bool CmpHorizontalOverflow(DXD.BodyProperties openXmlElement, DMD.TextHorizontalOverflowKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues, DMD.TextHorizontalOverflowKind>(openXmlElement?.HorizontalOverflow?.Value, value, diffs, objName, propName);
  }
  
  private static void SetHorizontalOverflow(DXD.BodyProperties openXmlElement, DMD.TextHorizontalOverflowKind? value)
  {
    openXmlElement.HorizontalOverflow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues, DMD.TextHorizontalOverflowKind>(value);
  }
  
  /// <summary>
  /// Vertical Text
  /// </summary>
  private static DMD.TextVerticalKind? GetVertical(DXD.BodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues, DMD.TextVerticalKind>(openXmlElement?.Vertical?.Value);
  }
  
  private static bool CmpVertical(DXD.BodyProperties openXmlElement, DMD.TextVerticalKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues, DMD.TextVerticalKind>(openXmlElement?.Vertical?.Value, value, diffs, objName, propName);
  }
  
  private static void SetVertical(DXD.BodyProperties openXmlElement, DMD.TextVerticalKind? value)
  {
    openXmlElement.Vertical = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues, DMD.TextVerticalKind>(value);
  }
  
  /// <summary>
  /// Text Wrapping Type
  /// </summary>
  private static DMD.TextWrappingKind? GetWrap(DXD.BodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues, DMD.TextWrappingKind>(openXmlElement?.Wrap?.Value);
  }
  
  private static bool CmpWrap(DXD.BodyProperties openXmlElement, DMD.TextWrappingKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues, DMD.TextWrappingKind>(openXmlElement?.Wrap?.Value, value, diffs, objName, propName);
  }
  
  private static void SetWrap(DXD.BodyProperties openXmlElement, DMD.TextWrappingKind? value)
  {
    openXmlElement.Wrap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues, DMD.TextWrappingKind>(value);
  }
  
  /// <summary>
  /// Left Inset
  /// </summary>
  private static Int32? GetLeftInset(DXD.BodyProperties openXmlElement)
  {
    return openXmlElement?.LeftInset?.Value;
  }
  
  private static bool CmpLeftInset(DXD.BodyProperties openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.LeftInset?.Value == value) return true;
    diffs?.Add(objName, "LeftInset", openXmlElement?.LeftInset?.Value, value);
    return false;
  }
  
  private static void SetLeftInset(DXD.BodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.LeftInset = value;
  }
  
  /// <summary>
  /// Top Inset
  /// </summary>
  private static Int32? GetTopInset(DXD.BodyProperties openXmlElement)
  {
    return openXmlElement?.TopInset?.Value;
  }
  
  private static bool CmpTopInset(DXD.BodyProperties openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.TopInset?.Value == value) return true;
    diffs?.Add(objName, "TopInset", openXmlElement?.TopInset?.Value, value);
    return false;
  }
  
  private static void SetTopInset(DXD.BodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.TopInset = value;
  }
  
  /// <summary>
  /// Right Inset
  /// </summary>
  private static Int32? GetRightInset(DXD.BodyProperties openXmlElement)
  {
    return openXmlElement?.RightInset?.Value;
  }
  
  private static bool CmpRightInset(DXD.BodyProperties openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RightInset?.Value == value) return true;
    diffs?.Add(objName, "RightInset", openXmlElement?.RightInset?.Value, value);
    return false;
  }
  
  private static void SetRightInset(DXD.BodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.RightInset = value;
  }
  
  /// <summary>
  /// Bottom Inset
  /// </summary>
  private static Int32? GetBottomInset(DXD.BodyProperties openXmlElement)
  {
    return openXmlElement?.BottomInset?.Value;
  }
  
  private static bool CmpBottomInset(DXD.BodyProperties openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.BottomInset?.Value == value) return true;
    diffs?.Add(objName, "BottomInset", openXmlElement?.BottomInset?.Value, value);
    return false;
  }
  
  private static void SetBottomInset(DXD.BodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.BottomInset = value;
  }
  
  /// <summary>
  /// Number of Columns
  /// </summary>
  private static Int32? GetColumnCount(DXD.BodyProperties openXmlElement)
  {
    return openXmlElement?.ColumnCount?.Value;
  }
  
  private static bool CmpColumnCount(DXD.BodyProperties openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ColumnCount?.Value == value) return true;
    diffs?.Add(objName, "ColumnCount", openXmlElement?.ColumnCount?.Value, value);
    return false;
  }
  
  private static void SetColumnCount(DXD.BodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.ColumnCount = value;
  }
  
  /// <summary>
  /// Space Between Columns
  /// </summary>
  private static Int32? GetColumnSpacing(DXD.BodyProperties openXmlElement)
  {
    return openXmlElement?.ColumnSpacing?.Value;
  }
  
  private static bool CmpColumnSpacing(DXD.BodyProperties openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ColumnSpacing?.Value == value) return true;
    diffs?.Add(objName, "ColumnSpacing", openXmlElement?.ColumnSpacing?.Value, value);
    return false;
  }
  
  private static void SetColumnSpacing(DXD.BodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.ColumnSpacing = value;
  }
  
  /// <summary>
  /// Columns Right-To-Left
  /// </summary>
  private static Boolean? GetRightToLeftColumns(DXD.BodyProperties openXmlElement)
  {
    return openXmlElement?.RightToLeftColumns?.Value;
  }
  
  private static bool CmpRightToLeftColumns(DXD.BodyProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RightToLeftColumns?.Value == value) return true;
    diffs?.Add(objName, "RightToLeftColumns", openXmlElement?.RightToLeftColumns?.Value, value);
    return false;
  }
  
  private static void SetRightToLeftColumns(DXD.BodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.RightToLeftColumns = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.RightToLeftColumns = null;
  }
  
  /// <summary>
  /// From WordArt
  /// </summary>
  private static Boolean? GetFromWordArt(DXD.BodyProperties openXmlElement)
  {
    return openXmlElement?.FromWordArt?.Value;
  }
  
  private static bool CmpFromWordArt(DXD.BodyProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.FromWordArt?.Value == value) return true;
    diffs?.Add(objName, "FromWordArt", openXmlElement?.FromWordArt?.Value, value);
    return false;
  }
  
  private static void SetFromWordArt(DXD.BodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FromWordArt = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.FromWordArt = null;
  }
  
  /// <summary>
  /// Anchor
  /// </summary>
  private static DMD.TextAnchoringKind? GetAnchor(DXD.BodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues, DMD.TextAnchoringKind>(openXmlElement?.Anchor?.Value);
  }
  
  private static bool CmpAnchor(DXD.BodyProperties openXmlElement, DMD.TextAnchoringKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues, DMD.TextAnchoringKind>(openXmlElement?.Anchor?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAnchor(DXD.BodyProperties openXmlElement, DMD.TextAnchoringKind? value)
  {
    openXmlElement.Anchor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues, DMD.TextAnchoringKind>(value);
  }
  
  /// <summary>
  /// Anchor Center
  /// </summary>
  private static Boolean? GetAnchorCenter(DXD.BodyProperties openXmlElement)
  {
    return openXmlElement?.AnchorCenter?.Value;
  }
  
  private static bool CmpAnchorCenter(DXD.BodyProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.AnchorCenter?.Value == value) return true;
    diffs?.Add(objName, "AnchorCenter", openXmlElement?.AnchorCenter?.Value, value);
    return false;
  }
  
  private static void SetAnchorCenter(DXD.BodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AnchorCenter = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AnchorCenter = null;
  }
  
  /// <summary>
  /// Force Anti-Alias
  /// </summary>
  private static Boolean? GetForceAntiAlias(DXD.BodyProperties openXmlElement)
  {
    return openXmlElement?.ForceAntiAlias?.Value;
  }
  
  private static bool CmpForceAntiAlias(DXD.BodyProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ForceAntiAlias?.Value == value) return true;
    diffs?.Add(objName, "ForceAntiAlias", openXmlElement?.ForceAntiAlias?.Value, value);
    return false;
  }
  
  private static void SetForceAntiAlias(DXD.BodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceAntiAlias = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ForceAntiAlias = null;
  }
  
  /// <summary>
  /// Text Upright
  /// </summary>
  private static Boolean? GetUpRight(DXD.BodyProperties openXmlElement)
  {
    return openXmlElement?.UpRight?.Value;
  }
  
  private static bool CmpUpRight(DXD.BodyProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.UpRight?.Value == value) return true;
    diffs?.Add(objName, "UpRight", openXmlElement?.UpRight?.Value, value);
    return false;
  }
  
  private static void SetUpRight(DXD.BodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UpRight = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UpRight = null;
  }
  
  /// <summary>
  /// Compatible Line Spacing
  /// </summary>
  private static Boolean? GetCompatibleLineSpacing(DXD.BodyProperties openXmlElement)
  {
    return openXmlElement?.CompatibleLineSpacing?.Value;
  }
  
  private static bool CmpCompatibleLineSpacing(DXD.BodyProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.CompatibleLineSpacing?.Value == value) return true;
    diffs?.Add(objName, "CompatibleLineSpacing", openXmlElement?.CompatibleLineSpacing?.Value, value);
    return false;
  }
  
  private static void SetCompatibleLineSpacing(DXD.BodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CompatibleLineSpacing = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.CompatibleLineSpacing = null;
  }
  
  /// <summary>
  /// Preset Text Shape.
  /// </summary>
  private static DMD.PresetTextWrap? GetPresetTextWrap(DXD.BodyProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PresetTextWrap>();
    if (element != null)
      return DMXD.PresetTextWrapConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetTextWrap(DXD.BodyProperties openXmlElement, DMD.PresetTextWrap? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.PresetTextWrapConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PresetTextWrap>(), value, diffs, objName, propName);
  }
  
  private static void SetPresetTextWrap(DXD.BodyProperties openXmlElement, DMD.PresetTextWrap? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PresetTextWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PresetTextWrapConverter.CreateOpenXmlElement<DXD.PresetTextWrap>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetNoAutoFit(DXD.BodyProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.NoAutoFit>() != null;
  }
  
  private static bool CmpNoAutoFit(DXD.BodyProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.NoAutoFit>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.NoAutoFit", val, value);
    return false;
  }
  
  private static void SetNoAutoFit(DXD.BodyProperties openXmlElement, Boolean? value)
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
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.NormalAutoFit? GetNormalAutoFit(DXD.BodyProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.NormalAutoFit>();
    if (element != null)
      return DMXD.NormalAutoFitConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNormalAutoFit(DXD.BodyProperties openXmlElement, DMD.NormalAutoFit? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.NormalAutoFitConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.NormalAutoFit>(), value, diffs, objName, propName);
  }
  
  private static void SetNormalAutoFit(DXD.BodyProperties openXmlElement, DMD.NormalAutoFit? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.NormalAutoFit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.NormalAutoFitConverter.CreateOpenXmlElement<DXD.NormalAutoFit>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShapeAutoFit(DXD.BodyProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.ShapeAutoFit>() != null;
  }
  
  private static bool CmpShapeAutoFit(DXD.BodyProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.ShapeAutoFit>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.ShapeAutoFit", val, value);
    return false;
  }
  
  private static void SetShapeAutoFit(DXD.BodyProperties openXmlElement, Boolean? value)
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
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Scene3DType? GetScene3DType(DXD.BodyProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Scene3DType>();
    if (element != null)
      return DMXD.Scene3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScene3DType(DXD.BodyProperties openXmlElement, DMD.Scene3DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Scene3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Scene3DType>(), value, diffs, objName, propName);
  }
  
  private static void SetScene3DType(DXD.BodyProperties openXmlElement, DMD.Scene3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Scene3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Scene3DTypeConverter.CreateOpenXmlElement<DXD.Scene3DType>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Shape3DType? GetShape3DType(DXD.BodyProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Shape3DType>();
    if (element != null)
      return DMXD.Shape3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape3DType(DXD.BodyProperties openXmlElement, DMD.Shape3DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Shape3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Shape3DType>(), value, diffs, objName, propName);
  }
  
  private static void SetShape3DType(DXD.BodyProperties openXmlElement, DMD.Shape3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Shape3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Shape3DTypeConverter.CreateOpenXmlElement<DXD.Shape3DType>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.FlatText? GetFlatText(DXD.BodyProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FlatText>();
    if (element != null)
      return DMXD.FlatTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFlatText(DXD.BodyProperties openXmlElement, DMD.FlatText? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.FlatTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FlatText>(), value, diffs, objName, propName);
  }
  
  private static void SetFlatText(DXD.BodyProperties openXmlElement, DMD.FlatText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FlatText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FlatTextConverter.CreateOpenXmlElement<DXD.FlatText>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.ExtensionList? GetExtensionList(DXD.BodyProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.BodyProperties openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXD.BodyProperties openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.BodyProperties? CreateModelElement(DXD.BodyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.BodyProperties();
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
  
  public static bool CompareModelElement(DXD.BodyProperties? openXmlElement, DMD.BodyProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRotation(openXmlElement, value.Rotation, diffs, objName, propName))
        ok = false;
      if (!CmpUseParagraphSpacing(openXmlElement, value.UseParagraphSpacing, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalOverflow(openXmlElement, value.VerticalOverflow, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontalOverflow(openXmlElement, value.HorizontalOverflow, diffs, objName, propName))
        ok = false;
      if (!CmpVertical(openXmlElement, value.Vertical, diffs, objName, propName))
        ok = false;
      if (!CmpWrap(openXmlElement, value.Wrap, diffs, objName, propName))
        ok = false;
      if (!CmpLeftInset(openXmlElement, value.LeftInset, diffs, objName, propName))
        ok = false;
      if (!CmpTopInset(openXmlElement, value.TopInset, diffs, objName, propName))
        ok = false;
      if (!CmpRightInset(openXmlElement, value.RightInset, diffs, objName, propName))
        ok = false;
      if (!CmpBottomInset(openXmlElement, value.BottomInset, diffs, objName, propName))
        ok = false;
      if (!CmpColumnCount(openXmlElement, value.ColumnCount, diffs, objName, propName))
        ok = false;
      if (!CmpColumnSpacing(openXmlElement, value.ColumnSpacing, diffs, objName, propName))
        ok = false;
      if (!CmpRightToLeftColumns(openXmlElement, value.RightToLeftColumns, diffs, objName, propName))
        ok = false;
      if (!CmpFromWordArt(openXmlElement, value.FromWordArt, diffs, objName, propName))
        ok = false;
      if (!CmpAnchor(openXmlElement, value.Anchor, diffs, objName, propName))
        ok = false;
      if (!CmpAnchorCenter(openXmlElement, value.AnchorCenter, diffs, objName, propName))
        ok = false;
      if (!CmpForceAntiAlias(openXmlElement, value.ForceAntiAlias, diffs, objName, propName))
        ok = false;
      if (!CmpUpRight(openXmlElement, value.UpRight, diffs, objName, propName))
        ok = false;
      if (!CmpCompatibleLineSpacing(openXmlElement, value.CompatibleLineSpacing, diffs, objName, propName))
        ok = false;
      if (!CmpPresetTextWrap(openXmlElement, value.PresetTextWrap, diffs, objName, propName))
        ok = false;
      if (!CmpNoAutoFit(openXmlElement, value.NoAutoFit, diffs, objName, propName))
        ok = false;
      if (!CmpNormalAutoFit(openXmlElement, value.NormalAutoFit, diffs, objName, propName))
        ok = false;
      if (!CmpShapeAutoFit(openXmlElement, value.ShapeAutoFit, diffs, objName, propName))
        ok = false;
      if (!CmpScene3DType(openXmlElement, value.Scene3DType, diffs, objName, propName))
        ok = false;
      if (!CmpShape3DType(openXmlElement, value.Shape3DType, diffs, objName, propName))
        ok = false;
      if (!CmpFlatText(openXmlElement, value.FlatText, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.BodyProperties value)
    where OpenXmlElementType: DXD.BodyProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.BodyProperties openXmlElement, DMD.BodyProperties value)
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

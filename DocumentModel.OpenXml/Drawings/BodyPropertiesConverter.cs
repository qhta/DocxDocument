namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BodyProperties Class.
/// </summary>
public static class BodyPropertiesConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  private static Int32? GetRotation(DXDraw.BodyProperties openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  private static bool CmpRotation(DXDraw.BodyProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Rotation?.Value == value) return true;
    diffs?.Add(objName, "Rotation", openXmlElement?.Rotation?.Value, value);
    return false;
  }
  
  private static void SetRotation(DXDraw.BodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Paragraph Spacing
  /// </summary>
  private static Boolean? GetUseParagraphSpacing(DXDraw.BodyProperties openXmlElement)
  {
    return openXmlElement?.UseParagraphSpacing?.Value;
  }
  
  private static bool CmpUseParagraphSpacing(DXDraw.BodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.UseParagraphSpacing?.Value == value;
  }
  
  private static void SetUseParagraphSpacing(DXDraw.BodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UseParagraphSpacing = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UseParagraphSpacing = null;
  }
  
  /// <summary>
  /// Text Vertical Overflow
  /// </summary>
  private static DMDraws.TextVerticalOverflowKind? GetVerticalOverflow(DXDraw.BodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues, DMDraws.TextVerticalOverflowKind>(openXmlElement?.VerticalOverflow?.Value);
  }
  
  private static bool CmpVerticalOverflow(DXDraw.BodyProperties openXmlElement, DMDraws.TextVerticalOverflowKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues, DMDraws.TextVerticalOverflowKind>(openXmlElement?.VerticalOverflow?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVerticalOverflow(DXDraw.BodyProperties openXmlElement, DMDraws.TextVerticalOverflowKind? value)
  {
    openXmlElement.VerticalOverflow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues, DMDraws.TextVerticalOverflowKind>(value);
  }
  
  /// <summary>
  /// Text Horizontal Overflow
  /// </summary>
  private static DMDraws.TextHorizontalOverflowKind? GetHorizontalOverflow(DXDraw.BodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues, DMDraws.TextHorizontalOverflowKind>(openXmlElement?.HorizontalOverflow?.Value);
  }
  
  private static bool CmpHorizontalOverflow(DXDraw.BodyProperties openXmlElement, DMDraws.TextHorizontalOverflowKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues, DMDraws.TextHorizontalOverflowKind>(openXmlElement?.HorizontalOverflow?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHorizontalOverflow(DXDraw.BodyProperties openXmlElement, DMDraws.TextHorizontalOverflowKind? value)
  {
    openXmlElement.HorizontalOverflow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues, DMDraws.TextHorizontalOverflowKind>(value);
  }
  
  /// <summary>
  /// Vertical Text
  /// </summary>
  private static DMDraws.TextVerticalKind? GetVertical(DXDraw.BodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues, DMDraws.TextVerticalKind>(openXmlElement?.Vertical?.Value);
  }
  
  private static bool CmpVertical(DXDraw.BodyProperties openXmlElement, DMDraws.TextVerticalKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues, DMDraws.TextVerticalKind>(openXmlElement?.Vertical?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVertical(DXDraw.BodyProperties openXmlElement, DMDraws.TextVerticalKind? value)
  {
    openXmlElement.Vertical = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues, DMDraws.TextVerticalKind>(value);
  }
  
  /// <summary>
  /// Text Wrapping Type
  /// </summary>
  private static DMDraws.TextWrappingKind? GetWrap(DXDraw.BodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues, DMDraws.TextWrappingKind>(openXmlElement?.Wrap?.Value);
  }
  
  private static bool CmpWrap(DXDraw.BodyProperties openXmlElement, DMDraws.TextWrappingKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues, DMDraws.TextWrappingKind>(openXmlElement?.Wrap?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWrap(DXDraw.BodyProperties openXmlElement, DMDraws.TextWrappingKind? value)
  {
    openXmlElement.Wrap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues, DMDraws.TextWrappingKind>(value);
  }
  
  /// <summary>
  /// Left Inset
  /// </summary>
  private static Int32? GetLeftInset(DXDraw.BodyProperties openXmlElement)
  {
    return openXmlElement?.LeftInset?.Value;
  }
  
  private static bool CmpLeftInset(DXDraw.BodyProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LeftInset?.Value == value) return true;
    diffs?.Add(objName, "LeftInset", openXmlElement?.LeftInset?.Value, value);
    return false;
  }
  
  private static void SetLeftInset(DXDraw.BodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.LeftInset = value;
  }
  
  /// <summary>
  /// Top Inset
  /// </summary>
  private static Int32? GetTopInset(DXDraw.BodyProperties openXmlElement)
  {
    return openXmlElement?.TopInset?.Value;
  }
  
  private static bool CmpTopInset(DXDraw.BodyProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.TopInset?.Value == value) return true;
    diffs?.Add(objName, "TopInset", openXmlElement?.TopInset?.Value, value);
    return false;
  }
  
  private static void SetTopInset(DXDraw.BodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.TopInset = value;
  }
  
  /// <summary>
  /// Right Inset
  /// </summary>
  private static Int32? GetRightInset(DXDraw.BodyProperties openXmlElement)
  {
    return openXmlElement?.RightInset?.Value;
  }
  
  private static bool CmpRightInset(DXDraw.BodyProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RightInset?.Value == value) return true;
    diffs?.Add(objName, "RightInset", openXmlElement?.RightInset?.Value, value);
    return false;
  }
  
  private static void SetRightInset(DXDraw.BodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.RightInset = value;
  }
  
  /// <summary>
  /// Bottom Inset
  /// </summary>
  private static Int32? GetBottomInset(DXDraw.BodyProperties openXmlElement)
  {
    return openXmlElement?.BottomInset?.Value;
  }
  
  private static bool CmpBottomInset(DXDraw.BodyProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BottomInset?.Value == value) return true;
    diffs?.Add(objName, "BottomInset", openXmlElement?.BottomInset?.Value, value);
    return false;
  }
  
  private static void SetBottomInset(DXDraw.BodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.BottomInset = value;
  }
  
  /// <summary>
  /// Number of Columns
  /// </summary>
  private static Int32? GetColumnCount(DXDraw.BodyProperties openXmlElement)
  {
    return openXmlElement?.ColumnCount?.Value;
  }
  
  private static bool CmpColumnCount(DXDraw.BodyProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ColumnCount?.Value == value) return true;
    diffs?.Add(objName, "ColumnCount", openXmlElement?.ColumnCount?.Value, value);
    return false;
  }
  
  private static void SetColumnCount(DXDraw.BodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.ColumnCount = value;
  }
  
  /// <summary>
  /// Space Between Columns
  /// </summary>
  private static Int32? GetColumnSpacing(DXDraw.BodyProperties openXmlElement)
  {
    return openXmlElement?.ColumnSpacing?.Value;
  }
  
  private static bool CmpColumnSpacing(DXDraw.BodyProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ColumnSpacing?.Value == value) return true;
    diffs?.Add(objName, "ColumnSpacing", openXmlElement?.ColumnSpacing?.Value, value);
    return false;
  }
  
  private static void SetColumnSpacing(DXDraw.BodyProperties openXmlElement, Int32? value)
  {
    openXmlElement.ColumnSpacing = value;
  }
  
  /// <summary>
  /// Columns Right-To-Left
  /// </summary>
  private static Boolean? GetRightToLeftColumns(DXDraw.BodyProperties openXmlElement)
  {
    return openXmlElement?.RightToLeftColumns?.Value;
  }
  
  private static bool CmpRightToLeftColumns(DXDraw.BodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RightToLeftColumns?.Value == value;
  }
  
  private static void SetRightToLeftColumns(DXDraw.BodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.RightToLeftColumns = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.RightToLeftColumns = null;
  }
  
  /// <summary>
  /// From WordArt
  /// </summary>
  private static Boolean? GetFromWordArt(DXDraw.BodyProperties openXmlElement)
  {
    return openXmlElement?.FromWordArt?.Value;
  }
  
  private static bool CmpFromWordArt(DXDraw.BodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.FromWordArt?.Value == value;
  }
  
  private static void SetFromWordArt(DXDraw.BodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FromWordArt = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.FromWordArt = null;
  }
  
  /// <summary>
  /// Anchor
  /// </summary>
  private static DMDraws.TextAnchoringKind? GetAnchor(DXDraw.BodyProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues, DMDraws.TextAnchoringKind>(openXmlElement?.Anchor?.Value);
  }
  
  private static bool CmpAnchor(DXDraw.BodyProperties openXmlElement, DMDraws.TextAnchoringKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues, DMDraws.TextAnchoringKind>(openXmlElement?.Anchor?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAnchor(DXDraw.BodyProperties openXmlElement, DMDraws.TextAnchoringKind? value)
  {
    openXmlElement.Anchor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues, DMDraws.TextAnchoringKind>(value);
  }
  
  /// <summary>
  /// Anchor Center
  /// </summary>
  private static Boolean? GetAnchorCenter(DXDraw.BodyProperties openXmlElement)
  {
    return openXmlElement?.AnchorCenter?.Value;
  }
  
  private static bool CmpAnchorCenter(DXDraw.BodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AnchorCenter?.Value == value;
  }
  
  private static void SetAnchorCenter(DXDraw.BodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AnchorCenter = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AnchorCenter = null;
  }
  
  /// <summary>
  /// Force Anti-Alias
  /// </summary>
  private static Boolean? GetForceAntiAlias(DXDraw.BodyProperties openXmlElement)
  {
    return openXmlElement?.ForceAntiAlias?.Value;
  }
  
  private static bool CmpForceAntiAlias(DXDraw.BodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ForceAntiAlias?.Value == value;
  }
  
  private static void SetForceAntiAlias(DXDraw.BodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceAntiAlias = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ForceAntiAlias = null;
  }
  
  /// <summary>
  /// Text Upright
  /// </summary>
  private static Boolean? GetUpRight(DXDraw.BodyProperties openXmlElement)
  {
    return openXmlElement?.UpRight?.Value;
  }
  
  private static bool CmpUpRight(DXDraw.BodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.UpRight?.Value == value;
  }
  
  private static void SetUpRight(DXDraw.BodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UpRight = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UpRight = null;
  }
  
  /// <summary>
  /// Compatible Line Spacing
  /// </summary>
  private static Boolean? GetCompatibleLineSpacing(DXDraw.BodyProperties openXmlElement)
  {
    return openXmlElement?.CompatibleLineSpacing?.Value;
  }
  
  private static bool CmpCompatibleLineSpacing(DXDraw.BodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.CompatibleLineSpacing?.Value == value;
  }
  
  private static void SetCompatibleLineSpacing(DXDraw.BodyProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CompatibleLineSpacing = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.CompatibleLineSpacing = null;
  }
  
  /// <summary>
  /// Preset Text Shape.
  /// </summary>
  private static DMDraws.PresetTextWrap? GetPresetTextWrap(DXDraw.BodyProperties openXmlElement)
  {
    return DMXDraws.PresetTextWrapConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.PresetTextWrap>());
  }
  
  private static bool CmpPresetTextWrap(DXDraw.BodyProperties openXmlElement, DMDraws.PresetTextWrap? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PresetTextWrapConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PresetTextWrap>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetTextWrap(DXDraw.BodyProperties openXmlElement, DMDraws.PresetTextWrap? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PresetTextWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PresetTextWrapConverter.CreateOpenXmlElement<DXDraw.PresetTextWrap>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetNoAutoFit(DXDraw.BodyProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoAutoFit>() != null;
  }
  
  private static bool CmpNoAutoFit(DXDraw.BodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoAutoFit>() != null == value;
  }
  
  private static void SetNoAutoFit(DXDraw.BodyProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.NoAutoFit>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.NoAutoFit();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.NormalAutoFit? GetNormalAutoFit(DXDraw.BodyProperties openXmlElement)
  {
    return DMXDraws.NormalAutoFitConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.NormalAutoFit>());
  }
  
  private static bool CmpNormalAutoFit(DXDraw.BodyProperties openXmlElement, DMDraws.NormalAutoFit? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.NormalAutoFitConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.NormalAutoFit>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNormalAutoFit(DXDraw.BodyProperties openXmlElement, DMDraws.NormalAutoFit? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.NormalAutoFit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.NormalAutoFitConverter.CreateOpenXmlElement<DXDraw.NormalAutoFit>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShapeAutoFit(DXDraw.BodyProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.ShapeAutoFit>() != null;
  }
  
  private static bool CmpShapeAutoFit(DXDraw.BodyProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.ShapeAutoFit>() != null == value;
  }
  
  private static void SetShapeAutoFit(DXDraw.BodyProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.ShapeAutoFit>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.ShapeAutoFit();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Scene3DType? GetScene3DType(DXDraw.BodyProperties openXmlElement)
  {
    return DMXDraws.Scene3DTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Scene3DType>());
  }
  
  private static bool CmpScene3DType(DXDraw.BodyProperties openXmlElement, DMDraws.Scene3DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Scene3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Scene3DType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetScene3DType(DXDraw.BodyProperties openXmlElement, DMDraws.Scene3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Scene3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Scene3DTypeConverter.CreateOpenXmlElement<DXDraw.Scene3DType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Shape3DType? GetShape3DType(DXDraw.BodyProperties openXmlElement)
  {
    return DMXDraws.Shape3DTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Shape3DType>());
  }
  
  private static bool CmpShape3DType(DXDraw.BodyProperties openXmlElement, DMDraws.Shape3DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Shape3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Shape3DType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShape3DType(DXDraw.BodyProperties openXmlElement, DMDraws.Shape3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Shape3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Shape3DTypeConverter.CreateOpenXmlElement<DXDraw.Shape3DType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.FlatText? GetFlatText(DXDraw.BodyProperties openXmlElement)
  {
    return DMXDraws.FlatTextConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.FlatText>());
  }
  
  private static bool CmpFlatText(DXDraw.BodyProperties openXmlElement, DMDraws.FlatText? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.FlatTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.FlatText>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFlatText(DXDraw.BodyProperties openXmlElement, DMDraws.FlatText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FlatText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.FlatTextConverter.CreateOpenXmlElement<DXDraw.FlatText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.BodyProperties openXmlElement)
  {
    return DMXDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDraw.BodyProperties openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDraw.BodyProperties openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.BodyProperties? CreateModelElement(DXDraw.BodyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.BodyProperties();
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
  
  public static bool CompareModelElement(DXDraw.BodyProperties? openXmlElement, DMDraws.BodyProperties? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BodyProperties? value)
    where OpenXmlElementType: DXDraw.BodyProperties, new()
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

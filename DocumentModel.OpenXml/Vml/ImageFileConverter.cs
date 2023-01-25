namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Image File.
/// </summary>
public static class ImageFileConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// style
  /// </summary>
  private static String? GetStyle(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  private static bool CmpStyle(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Style?.Value == value;
  }
  
  private static void SetStyle(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Style = new StringValue { Value = value };
    else
      openXmlElement.Style = null;
  }
  
  /// <summary>
  /// href
  /// </summary>
  private static String? GetHref(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }
  
  private static bool CmpHref(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Href?.Value == value;
  }
  
  private static void SetHref(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Href = new StringValue { Value = value };
    else
      openXmlElement.Href = null;
  }
  
  /// <summary>
  /// target
  /// </summary>
  private static String? GetTarget(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Target?.Value;
  }
  
  private static bool CmpTarget(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Target?.Value == value;
  }
  
  private static void SetTarget(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Target = new StringValue { Value = value };
    else
      openXmlElement.Target = null;
  }
  
  /// <summary>
  /// class
  /// </summary>
  private static String? GetClass(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Class?.Value;
  }
  
  private static bool CmpClass(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Class?.Value == value;
  }
  
  private static void SetClass(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Class = new StringValue { Value = value };
    else
      openXmlElement.Class = null;
  }
  
  /// <summary>
  /// title
  /// </summary>
  private static String? GetTitle(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static bool CmpTitle(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Title?.Value == value;
  }
  
  private static void SetTitle(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// alt
  /// </summary>
  private static String? GetAlternate(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Alternate?.Value;
  }
  
  private static bool CmpAlternate(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Alternate?.Value == value;
  }
  
  private static void SetAlternate(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Alternate = new StringValue { Value = value };
    else
      openXmlElement.Alternate = null;
  }
  
  /// <summary>
  /// coordsize
  /// </summary>
  private static String? GetCoordinateSize(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.CoordinateSize?.Value;
  }
  
  private static bool CmpCoordinateSize(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.CoordinateSize?.Value == value;
  }
  
  private static void SetCoordinateSize(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CoordinateSize = new StringValue { Value = value };
    else
      openXmlElement.CoordinateSize = null;
  }
  
  /// <summary>
  /// wrapcoords
  /// </summary>
  private static String? GetWrapCoordinates(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.WrapCoordinates?.Value;
  }
  
  private static bool CmpWrapCoordinates(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.WrapCoordinates?.Value == value;
  }
  
  private static void SetWrapCoordinates(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.WrapCoordinates = new StringValue { Value = value };
    else
      openXmlElement.WrapCoordinates = null;
  }
  
  /// <summary>
  /// print
  /// </summary>
  private static Boolean? GetPrint(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Print?.Value;
  }
  
  private static bool CmpPrint(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Print?.Value == value;
  }
  
  private static void SetPrint(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Print = value;
    else
      openXmlElement.Print = null;
  }
  
  /// <summary>
  /// Optional String
  /// </summary>
  private static String? GetOptionalString(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.OptionalString?.Value;
  }
  
  private static bool CmpOptionalString(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.OptionalString?.Value == value;
  }
  
  private static void SetOptionalString(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OptionalString = new StringValue { Value = value };
    else
      openXmlElement.OptionalString = null;
  }
  
  /// <summary>
  /// Shape Handle Toggle
  /// </summary>
  private static Boolean? GetOned(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Oned?.Value;
  }
  
  private static bool CmpOned(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Oned?.Value == value;
  }
  
  private static void SetOned(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Oned = value;
    else
      openXmlElement.Oned = null;
  }
  
  /// <summary>
  /// Regroup ID
  /// </summary>
  private static Int64? GetRegroupId(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.RegroupId?.Value;
  }
  
  private static bool CmpRegroupId(DXVml.ImageFile openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RegroupId?.Value == value) return true;
    diffs?.Add(objName, "RegroupId", openXmlElement?.RegroupId?.Value, value);
    return false;
  }
  
  private static void SetRegroupId(DXVml.ImageFile openXmlElement, Int64? value)
  {
    openXmlElement.RegroupId = value;
  }
  
  /// <summary>
  /// Double-click Notification Toggle
  /// </summary>
  private static Boolean? GetDoubleClickNotify(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.DoubleClickNotify?.Value;
  }
  
  private static bool CmpDoubleClickNotify(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.DoubleClickNotify?.Value == value;
  }
  
  private static void SetDoubleClickNotify(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DoubleClickNotify = value;
    else
      openXmlElement.DoubleClickNotify = null;
  }
  
  /// <summary>
  /// Button Behavior Toggle
  /// </summary>
  private static Boolean? GetButton(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Button?.Value;
  }
  
  private static bool CmpButton(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Button?.Value == value;
  }
  
  private static void SetButton(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Button = value;
    else
      openXmlElement.Button = null;
  }
  
  /// <summary>
  /// Hide Script Anchors
  /// </summary>
  private static Boolean? GetUserHidden(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.UserHidden?.Value;
  }
  
  private static bool CmpUserHidden(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.UserHidden?.Value == value;
  }
  
  private static void SetUserHidden(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserHidden = value;
    else
      openXmlElement.UserHidden = null;
  }
  
  /// <summary>
  /// Graphical Bullet
  /// </summary>
  private static Boolean? GetBullet(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Bullet?.Value;
  }
  
  private static bool CmpBullet(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Bullet?.Value == value;
  }
  
  private static void SetBullet(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Bullet = value;
    else
      openXmlElement.Bullet = null;
  }
  
  /// <summary>
  /// Horizontal Rule Toggle
  /// </summary>
  private static Boolean? GetHorizontal(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Horizontal?.Value;
  }
  
  private static bool CmpHorizontal(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Horizontal?.Value == value;
  }
  
  private static void SetHorizontal(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Horizontal = value;
    else
      openXmlElement.Horizontal = null;
  }
  
  /// <summary>
  /// Horizontal Rule Standard Display Toggle
  /// </summary>
  private static Boolean? GetHorizontalStandard(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.HorizontalStandard?.Value;
  }
  
  private static bool CmpHorizontalStandard(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.HorizontalStandard?.Value == value;
  }
  
  private static void SetHorizontalStandard(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalStandard = value;
    else
      openXmlElement.HorizontalStandard = null;
  }
  
  /// <summary>
  /// Horizontal Rule 3D Shading Toggle
  /// </summary>
  private static Boolean? GetHorizontalNoShade(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.HorizontalNoShade?.Value;
  }
  
  private static bool CmpHorizontalNoShade(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.HorizontalNoShade?.Value == value;
  }
  
  private static void SetHorizontalNoShade(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalNoShade = value;
    else
      openXmlElement.HorizontalNoShade = null;
  }
  
  /// <summary>
  /// Horizontal Rule Length Percentage
  /// </summary>
  private static Single? GetHorizontalPercentage(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.HorizontalPercentage?.Value;
  }
  
  private static bool CmpHorizontalPercentage(DXVml.ImageFile openXmlElement, Single? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalPercentage?.Value == value) return true;
    diffs?.Add(objName, "HorizontalPercentage", openXmlElement?.HorizontalPercentage?.Value, value);
    return false;
  }
  
  private static void SetHorizontalPercentage(DXVml.ImageFile openXmlElement, Single? value)
  {
    openXmlElement.HorizontalPercentage = value;
  }
  
  /// <summary>
  /// Horizontal Rule Alignment
  /// </summary>
  private static DMVml.HorizontalRuleAlignmentKind? GetHorizontalAlignment(DXVml.ImageFile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMVml.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value);
  }
  
  private static bool CmpHorizontalAlignment(DXVml.ImageFile openXmlElement, DMVml.HorizontalRuleAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMVml.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHorizontalAlignment(DXVml.ImageFile openXmlElement, DMVml.HorizontalRuleAlignmentKind? value)
  {
    openXmlElement.HorizontalAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMVml.HorizontalRuleAlignmentKind>(value);
  }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  private static Boolean? GetAllowInCell(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }
  
  private static bool CmpAllowInCell(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AllowInCell?.Value == value;
  }
  
  private static void SetAllowInCell(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowInCell = value;
    else
      openXmlElement.AllowInCell = null;
  }
  
  /// <summary>
  /// Allow Shape Overlap
  /// </summary>
  private static Boolean? GetAllowOverlap(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  private static bool CmpAllowOverlap(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AllowOverlap?.Value == value;
  }
  
  private static void SetAllowOverlap(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowOverlap = value;
    else
      openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// Exists In Master Slide
  /// </summary>
  private static Boolean? GetUserDrawn(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.UserDrawn?.Value;
  }
  
  private static bool CmpUserDrawn(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.UserDrawn?.Value == value;
  }
  
  private static void SetUserDrawn(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserDrawn = value;
    else
      openXmlElement.UserDrawn = null;
  }
  
  /// <summary>
  /// Border Top Color
  /// </summary>
  private static String? GetBorderTopColor(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.BorderTopColor?.Value;
  }
  
  private static bool CmpBorderTopColor(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.BorderTopColor?.Value == value;
  }
  
  private static void SetBorderTopColor(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BorderTopColor = new StringValue { Value = value };
    else
      openXmlElement.BorderTopColor = null;
  }
  
  /// <summary>
  /// Border Left Color
  /// </summary>
  private static String? GetBorderLeftColor(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.BorderLeftColor?.Value;
  }
  
  private static bool CmpBorderLeftColor(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.BorderLeftColor?.Value == value;
  }
  
  private static void SetBorderLeftColor(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BorderLeftColor = new StringValue { Value = value };
    else
      openXmlElement.BorderLeftColor = null;
  }
  
  /// <summary>
  /// Bottom Border Color
  /// </summary>
  private static String? GetBorderBottomColor(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.BorderBottomColor?.Value;
  }
  
  private static bool CmpBorderBottomColor(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.BorderBottomColor?.Value == value;
  }
  
  private static void SetBorderBottomColor(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BorderBottomColor = new StringValue { Value = value };
    else
      openXmlElement.BorderBottomColor = null;
  }
  
  /// <summary>
  /// Border Right Color
  /// </summary>
  private static String? GetBorderRightColor(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.BorderRightColor?.Value;
  }
  
  private static bool CmpBorderRightColor(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.BorderRightColor?.Value == value;
  }
  
  private static void SetBorderRightColor(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BorderRightColor = new StringValue { Value = value };
    else
      openXmlElement.BorderRightColor = null;
  }
  
  /// <summary>
  /// Diagram Node Layout Identifier
  /// </summary>
  private static Int64? GetDiagramLayout(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.DiagramLayout?.Value;
  }
  
  private static bool CmpDiagramLayout(DXVml.ImageFile openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DiagramLayout?.Value == value) return true;
    diffs?.Add(objName, "DiagramLayout", openXmlElement?.DiagramLayout?.Value, value);
    return false;
  }
  
  private static void SetDiagramLayout(DXVml.ImageFile openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayout = value;
  }
  
  /// <summary>
  /// Diagram Node Identifier
  /// </summary>
  private static Int64? GetDiagramNodeKind(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.DiagramNodeKind?.Value;
  }
  
  private static bool CmpDiagramNodeKind(DXVml.ImageFile openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DiagramNodeKind?.Value == value) return true;
    diffs?.Add(objName, "DiagramNodeKind", openXmlElement?.DiagramNodeKind?.Value, value);
    return false;
  }
  
  private static void SetDiagramNodeKind(DXVml.ImageFile openXmlElement, Int64? value)
  {
    openXmlElement.DiagramNodeKind = value;
  }
  
  /// <summary>
  /// Diagram Node Recent Layout Identifier
  /// </summary>
  private static Int64? GetDiagramLayoutMostRecentUsed(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.DiagramLayoutMostRecentUsed?.Value;
  }
  
  private static bool CmpDiagramLayoutMostRecentUsed(DXVml.ImageFile openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DiagramLayoutMostRecentUsed?.Value == value) return true;
    diffs?.Add(objName, "DiagramLayoutMostRecentUsed", openXmlElement?.DiagramLayoutMostRecentUsed?.Value, value);
    return false;
  }
  
  private static void SetDiagramLayoutMostRecentUsed(DXVml.ImageFile openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayoutMostRecentUsed = value;
  }
  
  /// <summary>
  /// Text Inset Mode
  /// </summary>
  private static DMVml.InsetMarginKind? GetInsetMode(DXVml.ImageFile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }
  
  private static bool CmpInsetMode(DXVml.ImageFile openXmlElement, DMVml.InsetMarginKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(openXmlElement?.InsetMode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetInsetMode(DXVml.ImageFile openXmlElement, DMVml.InsetMarginKind? value)
  {
    openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(value);
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  private static Boolean? GetFilled(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Filled?.Value;
  }
  
  private static bool CmpFilled(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Filled?.Value == value;
  }
  
  private static void SetFilled(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Filled = value;
    else
      openXmlElement.Filled = null;
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  private static String? GetFillColor(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.FillColor?.Value;
  }
  
  private static bool CmpFillColor(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.FillColor?.Value == value;
  }
  
  private static void SetFillColor(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FillColor = new StringValue { Value = value };
    else
      openXmlElement.FillColor = null;
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  private static Boolean? GetStroked(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Stroked?.Value;
  }
  
  private static bool CmpStroked(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Stroked?.Value == value;
  }
  
  private static void SetStroked(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Stroked = value;
    else
      openXmlElement.Stroked = null;
  }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  private static String? GetStrokeColor(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.StrokeColor?.Value;
  }
  
  private static bool CmpStrokeColor(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.StrokeColor?.Value == value;
  }
  
  private static void SetStrokeColor(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StrokeColor = new StringValue { Value = value };
    else
      openXmlElement.StrokeColor = null;
  }
  
  /// <summary>
  /// Shape Stroke Weight
  /// </summary>
  private static String? GetStrokeWeight(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.StrokeWeight?.Value;
  }
  
  private static bool CmpStrokeWeight(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.StrokeWeight?.Value == value;
  }
  
  private static void SetStrokeWeight(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StrokeWeight = new StringValue { Value = value };
    else
      openXmlElement.StrokeWeight = null;
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  private static Boolean? GetInsetPen(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.InsetPen?.Value;
  }
  
  private static bool CmpInsetPen(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsetPen?.Value == value;
  }
  
  private static void SetInsetPen(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InsetPen = value;
    else
      openXmlElement.InsetPen = null;
  }
  
  /// <summary>
  /// Optional Number
  /// </summary>
  private static Int32? GetOptionalNumber(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.OptionalNumber?.Value;
  }
  
  private static bool CmpOptionalNumber(DXVml.ImageFile openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.OptionalNumber?.Value == value) return true;
    diffs?.Add(objName, "OptionalNumber", openXmlElement?.OptionalNumber?.Value, value);
    return false;
  }
  
  private static void SetOptionalNumber(DXVml.ImageFile openXmlElement, Int32? value)
  {
    openXmlElement.OptionalNumber = value;
  }
  
  /// <summary>
  /// Shape Connector Type
  /// </summary>
  private static DMVml.ConnectorKind? GetConnectorType(DXVml.ImageFile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMVml.ConnectorKind>(openXmlElement?.ConnectorType?.Value);
  }
  
  private static bool CmpConnectorType(DXVml.ImageFile openXmlElement, DMVml.ConnectorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMVml.ConnectorKind>(openXmlElement?.ConnectorType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetConnectorType(DXVml.ImageFile openXmlElement, DMVml.ConnectorKind? value)
  {
    openXmlElement.ConnectorType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMVml.ConnectorKind>(value);
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  private static DMVml.BlackAndWhiteMode? GetBlackWhiteMode(DXVml.ImageFile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static bool CmpBlackWhiteMode(DXVml.ImageFile openXmlElement, DMVml.BlackAndWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBlackWhiteMode(DXVml.ImageFile openXmlElement, DMVml.BlackAndWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  private static DMVml.BlackAndWhiteMode? GetPureBlackWhiteMode(DXVml.ImageFile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value);
  }
  
  private static bool CmpPureBlackWhiteMode(DXVml.ImageFile openXmlElement, DMVml.BlackAndWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPureBlackWhiteMode(DXVml.ImageFile openXmlElement, DMVml.BlackAndWhiteMode? value)
  {
    openXmlElement.PureBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  private static DMVml.BlackAndWhiteMode? GetNormalBlackWhiteMode(DXVml.ImageFile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value);
  }
  
  private static bool CmpNormalBlackWhiteMode(DXVml.ImageFile openXmlElement, DMVml.BlackAndWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNormalBlackWhiteMode(DXVml.ImageFile openXmlElement, DMVml.BlackAndWhiteMode? value)
  {
    openXmlElement.NormalBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  private static Boolean? GetForceDash(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }
  
  private static bool CmpForceDash(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ForceDash?.Value == value;
  }
  
  private static void SetForceDash(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceDash = value;
    else
      openXmlElement.ForceDash = null;
  }
  
  /// <summary>
  /// Embedded Object Icon Toggle
  /// </summary>
  private static Boolean? GetOleIcon(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.OleIcon?.Value;
  }
  
  private static bool CmpOleIcon(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.OleIcon?.Value == value;
  }
  
  private static void SetOleIcon(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.OleIcon = value;
    else
      openXmlElement.OleIcon = null;
  }
  
  /// <summary>
  /// Embedded Object Toggle
  /// </summary>
  private static Boolean? GetOle(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Ole?.Value;
  }
  
  private static bool CmpOle(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Ole?.Value == value;
  }
  
  private static void SetOle(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Ole = value;
    else
      openXmlElement.Ole = null;
  }
  
  /// <summary>
  /// Relative Resize Toggle
  /// </summary>
  private static Boolean? GetPreferRelative(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.PreferRelative?.Value;
  }
  
  private static bool CmpPreferRelative(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.PreferRelative?.Value == value;
  }
  
  private static void SetPreferRelative(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.PreferRelative = value;
    else
      openXmlElement.PreferRelative = null;
  }
  
  /// <summary>
  /// Clip to Wrapping Polygon
  /// </summary>
  private static Boolean? GetClipToWrap(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.ClipToWrap?.Value;
  }
  
  private static bool CmpClipToWrap(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ClipToWrap?.Value == value;
  }
  
  private static void SetClipToWrap(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ClipToWrap = value;
    else
      openXmlElement.ClipToWrap = null;
  }
  
  /// <summary>
  /// Clipping Toggle
  /// </summary>
  private static Boolean? GetClip(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Clip?.Value;
  }
  
  private static bool CmpClip(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Clip?.Value == value;
  }
  
  private static void SetClip(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Clip = value;
    else
      openXmlElement.Clip = null;
  }
  
  /// <summary>
  /// Image Source
  /// </summary>
  private static String? GetSource(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Source?.Value;
  }
  
  private static bool CmpSource(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Source?.Value == value;
  }
  
  private static void SetSource(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Source = new StringValue { Value = value };
    else
      openXmlElement.Source = null;
  }
  
  /// <summary>
  /// Image Left Crop
  /// </summary>
  private static String? GetCropLeft(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.CropLeft?.Value;
  }
  
  private static bool CmpCropLeft(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.CropLeft?.Value == value;
  }
  
  private static void SetCropLeft(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CropLeft = new StringValue { Value = value };
    else
      openXmlElement.CropLeft = null;
  }
  
  /// <summary>
  /// Image Top Crop
  /// </summary>
  private static String? GetCropTop(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.CropTop?.Value;
  }
  
  private static bool CmpCropTop(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.CropTop?.Value == value;
  }
  
  private static void SetCropTop(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CropTop = new StringValue { Value = value };
    else
      openXmlElement.CropTop = null;
  }
  
  /// <summary>
  /// Image Right Crop
  /// </summary>
  private static String? GetCropRight(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.CropRight?.Value;
  }
  
  private static bool CmpCropRight(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.CropRight?.Value == value;
  }
  
  private static void SetCropRight(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CropRight = new StringValue { Value = value };
    else
      openXmlElement.CropRight = null;
  }
  
  /// <summary>
  /// Image Bottom Crop
  /// </summary>
  private static String? GetCropBottom(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.CropBottom?.Value;
  }
  
  private static bool CmpCropBottom(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.CropBottom?.Value == value;
  }
  
  private static void SetCropBottom(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CropBottom = new StringValue { Value = value };
    else
      openXmlElement.CropBottom = null;
  }
  
  /// <summary>
  /// Image Intensity
  /// </summary>
  private static String? GetGain(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Gain?.Value;
  }
  
  private static bool CmpGain(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Gain?.Value == value;
  }
  
  private static void SetGain(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Gain = new StringValue { Value = value };
    else
      openXmlElement.Gain = null;
  }
  
  /// <summary>
  /// Image Brightness
  /// </summary>
  private static String? GetBlackLevel(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.BlackLevel?.Value;
  }
  
  private static bool CmpBlackLevel(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.BlackLevel?.Value == value;
  }
  
  private static void SetBlackLevel(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BlackLevel = new StringValue { Value = value };
    else
      openXmlElement.BlackLevel = null;
  }
  
  /// <summary>
  /// Image Gamma Correction
  /// </summary>
  private static String? GetGamma(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.Gamma?.Value;
  }
  
  private static bool CmpGamma(DXVml.ImageFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Gamma?.Value == value;
  }
  
  private static void SetGamma(DXVml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Gamma = new StringValue { Value = value };
    else
      openXmlElement.Gamma = null;
  }
  
  /// <summary>
  /// Image Grayscale Toggle
  /// </summary>
  private static Boolean? GetGrayScale(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.GrayScale?.Value;
  }
  
  private static bool CmpGrayScale(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GrayScale?.Value == value;
  }
  
  private static void SetGrayScale(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.GrayScale = value;
    else
      openXmlElement.GrayScale = null;
  }
  
  /// <summary>
  /// Image Bilevel Toggle
  /// </summary>
  private static Boolean? GetBiLevel(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement?.BiLevel?.Value;
  }
  
  private static bool CmpBiLevel(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.BiLevel?.Value == value;
  }
  
  private static void SetBiLevel(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BiLevel = value;
    else
      openXmlElement.BiLevel = null;
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  private static Byte[]? GetGfxdata(DXVml.ImageFile openXmlElement)
  {
    if (openXmlElement?.Gfxdata?.Value != null)
      return Convert.FromBase64String(openXmlElement.Gfxdata.Value);
    return null;
  }
  
  private static bool CmpGfxdata(DXVml.ImageFile openXmlElement, Byte[]? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Gfxdata?.Value != null)
      if (Convert.FromBase64String(openXmlElement.Gfxdata.Value) == value)
        return true;
    if (openXmlElement?.Gfxdata?.Value == null && value == null) return true;
    diffs?.Add(objName, "Gfxdata", openXmlElement?.Gfxdata?.Value, value);
    return false;
  }
  
  private static void SetGfxdata(DXVml.ImageFile openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.Gfxdata = Convert.ToBase64String(value);
    else
      openXmlElement.Gfxdata = null;
  }
  
  private static DMVml.Path? GetPath(DXVml.ImageFile openXmlElement)
  {
    return DMXVml.PathConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Path>());
  }
  
  private static bool CmpPath(DXVml.ImageFile openXmlElement, DMVml.Path? value, DiffList? diffs, string? objName)
  {
    return DMXVml.PathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Path>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPath(DXVml.ImageFile openXmlElement, DMVml.Path? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Path>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.PathConverter.CreateOpenXmlElement<DXVml.Path>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Formulas? GetFormulas(DXVml.ImageFile openXmlElement)
  {
    return DMXVml.FormulasConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Formulas>());
  }
  
  private static bool CmpFormulas(DXVml.ImageFile openXmlElement, DMVml.Formulas? value, DiffList? diffs, string? objName)
  {
    return DMXVml.FormulasConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Formulas>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFormulas(DXVml.ImageFile openXmlElement, DMVml.Formulas? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Formulas>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.FormulasConverter.CreateOpenXmlElement<DXVml.Formulas>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.ShapeHandles? GetShapeHandles(DXVml.ImageFile openXmlElement)
  {
    return DMXVml.ShapeHandlesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.ShapeHandles>());
  }
  
  private static bool CmpShapeHandles(DXVml.ImageFile openXmlElement, DMVml.ShapeHandles? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShapeHandlesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.ShapeHandles>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeHandles(DXVml.ImageFile openXmlElement, DMVml.ShapeHandles? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.ShapeHandles>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ShapeHandlesConverter.CreateOpenXmlElement<DXVml.ShapeHandles>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Fill? GetFill(DXVml.ImageFile openXmlElement)
  {
    return DMXVml.FillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Fill>());
  }
  
  private static bool CmpFill(DXVml.ImageFile openXmlElement, DMVml.Fill? value, DiffList? diffs, string? objName)
  {
    return DMXVml.FillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Fill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFill(DXVml.ImageFile openXmlElement, DMVml.Fill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Fill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.FillConverter.CreateOpenXmlElement<DXVml.Fill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Stroke? GetStroke(DXVml.ImageFile openXmlElement)
  {
    return DMXVml.StrokeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Stroke>());
  }
  
  private static bool CmpStroke(DXVml.ImageFile openXmlElement, DMVml.Stroke? value, DiffList? diffs, string? objName)
  {
    return DMXVml.StrokeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Stroke>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStroke(DXVml.ImageFile openXmlElement, DMVml.Stroke? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Stroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.StrokeConverter.CreateOpenXmlElement<DXVml.Stroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Shadow? GetShadow(DXVml.ImageFile openXmlElement)
  {
    return DMXVml.ShadowConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Shadow>());
  }
  
  private static bool CmpShadow(DXVml.ImageFile openXmlElement, DMVml.Shadow? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Shadow>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShadow(DXVml.ImageFile openXmlElement, DMVml.Shadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Shadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ShadowConverter.CreateOpenXmlElement<DXVml.Shadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.TextBox? GetTextBox(DXVml.ImageFile openXmlElement)
  {
    return DMXVml.TextBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.TextBox>());
  }
  
  private static bool CmpTextBox(DXVml.ImageFile openXmlElement, DMVml.TextBox? value, DiffList? diffs, string? objName)
  {
    return DMXVml.TextBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.TextBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextBox(DXVml.ImageFile openXmlElement, DMVml.TextBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.TextBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.TextBoxConverter.CreateOpenXmlElement<DXVml.TextBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.TextPath? GetTextPath(DXVml.ImageFile openXmlElement)
  {
    return DMXVml.TextPathConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.TextPath>());
  }
  
  private static bool CmpTextPath(DXVml.ImageFile openXmlElement, DMVml.TextPath? value, DiffList? diffs, string? objName)
  {
    return DMXVml.TextPathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.TextPath>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextPath(DXVml.ImageFile openXmlElement, DMVml.TextPath? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.TextPath>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.TextPathConverter.CreateOpenXmlElement<DXVml.TextPath>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.ImageData? GetImageData(DXVml.ImageFile openXmlElement)
  {
    return DMXVml.ImageDataConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.ImageData>());
  }
  
  private static bool CmpImageData(DXVml.ImageFile openXmlElement, DMVml.ImageData? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ImageDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.ImageData>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetImageData(DXVml.ImageFile openXmlElement, DMVml.ImageData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.ImageData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ImageDataConverter.CreateOpenXmlElement<DXVml.ImageData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Skew? GetSkew(DXVml.ImageFile openXmlElement)
  {
    return DMXVml.SkewConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.Skew>());
  }
  
  private static bool CmpSkew(DXVml.ImageFile openXmlElement, DMVml.Skew? value, DiffList? diffs, string? objName)
  {
    return DMXVml.SkewConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Skew>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSkew(DXVml.ImageFile openXmlElement, DMVml.Skew? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.Skew>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.SkewConverter.CreateOpenXmlElement<DXVmlO.Skew>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Extrusion? GetExtrusion(DXVml.ImageFile openXmlElement)
  {
    return DMXVml.ExtrusionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.Extrusion>());
  }
  
  private static bool CmpExtrusion(DXVml.ImageFile openXmlElement, DMVml.Extrusion? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ExtrusionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Extrusion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtrusion(DXVml.ImageFile openXmlElement, DMVml.Extrusion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.Extrusion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ExtrusionConverter.CreateOpenXmlElement<DXVmlO.Extrusion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Callout? GetCallout(DXVml.ImageFile openXmlElement)
  {
    return DMXVml.CalloutConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.Callout>());
  }
  
  private static bool CmpCallout(DXVml.ImageFile openXmlElement, DMVml.Callout? value, DiffList? diffs, string? objName)
  {
    return DMXVml.CalloutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Callout>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCallout(DXVml.ImageFile openXmlElement, DMVml.Callout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.Callout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.CalloutConverter.CreateOpenXmlElement<DXVmlO.Callout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Lock? GetLock(DXVml.ImageFile openXmlElement)
  {
    return DMXVml.LockConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.Lock>());
  }
  
  private static bool CmpLock(DXVml.ImageFile openXmlElement, DMVml.Lock? value, DiffList? diffs, string? objName)
  {
    return DMXVml.LockConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Lock>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLock(DXVml.ImageFile openXmlElement, DMVml.Lock? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.Lock>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.LockConverter.CreateOpenXmlElement<DXVmlO.Lock>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.ClipPath? GetClipPath(DXVml.ImageFile openXmlElement)
  {
    return DMXVml.ClipPathConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.ClipPath>());
  }
  
  private static bool CmpClipPath(DXVml.ImageFile openXmlElement, DMVml.ClipPath? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ClipPathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.ClipPath>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetClipPath(DXVml.ImageFile openXmlElement, DMVml.ClipPath? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.ClipPath>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ClipPathConverter.CreateOpenXmlElement<DXVmlO.ClipPath>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.SignatureLine? GetSignatureLine(DXVml.ImageFile openXmlElement)
  {
    return DMXVml.SignatureLineConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.SignatureLine>());
  }
  
  private static bool CmpSignatureLine(DXVml.ImageFile openXmlElement, DMVml.SignatureLine? value, DiffList? diffs, string? objName)
  {
    return DMXVml.SignatureLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.SignatureLine>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSignatureLine(DXVml.ImageFile openXmlElement, DMVml.SignatureLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.SignatureLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.SignatureLineConverter.CreateOpenXmlElement<DXVmlO.SignatureLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMWVml.TextWrap? GetTextWrap(DXVml.ImageFile openXmlElement)
  {
    return DMXWVml.TextWrapConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlW.TextWrap>());
  }
  
  private static bool CmpTextWrap(DXVml.ImageFile openXmlElement, DMWVml.TextWrap? value, DiffList? diffs, string? objName)
  {
    return DMXWVml.TextWrapConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlW.TextWrap>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextWrap(DXVml.ImageFile openXmlElement, DMWVml.TextWrap? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlW.TextWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWVml.TextWrapConverter.CreateOpenXmlElement<DXVmlW.TextWrap>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAnchorLock(DXVml.ImageFile openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXVmlW.AnchorLock>() != null;
  }
  
  private static bool CmpAnchorLock(DXVml.ImageFile openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXVmlW.AnchorLock>() != null == value;
  }
  
  private static void SetAnchorLock(DXVml.ImageFile openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXVmlW.AnchorLock>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXVmlW.AnchorLock();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMWVml.BorderType? GetTopBorder(DXVml.ImageFile openXmlElement)
  {
    return DMXWVml.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlW.TopBorder>());
  }
  
  private static bool CmpTopBorder(DXVml.ImageFile openXmlElement, DMWVml.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXWVml.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlW.TopBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTopBorder(DXVml.ImageFile openXmlElement, DMWVml.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlW.TopBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWVml.BorderTypeConverter.CreateOpenXmlElement<DXVmlW.TopBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMWVml.BorderType? GetBottomBorder(DXVml.ImageFile openXmlElement)
  {
    return DMXWVml.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlW.BottomBorder>());
  }
  
  private static bool CmpBottomBorder(DXVml.ImageFile openXmlElement, DMWVml.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXWVml.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlW.BottomBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBottomBorder(DXVml.ImageFile openXmlElement, DMWVml.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlW.BottomBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWVml.BorderTypeConverter.CreateOpenXmlElement<DXVmlW.BottomBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMWVml.BorderType? GetLeftBorder(DXVml.ImageFile openXmlElement)
  {
    return DMXWVml.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlW.LeftBorder>());
  }
  
  private static bool CmpLeftBorder(DXVml.ImageFile openXmlElement, DMWVml.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXWVml.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlW.LeftBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLeftBorder(DXVml.ImageFile openXmlElement, DMWVml.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlW.LeftBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWVml.BorderTypeConverter.CreateOpenXmlElement<DXVmlW.LeftBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMWVml.BorderType? GetRightBorder(DXVml.ImageFile openXmlElement)
  {
    return DMXWVml.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlW.RightBorder>());
  }
  
  private static bool CmpRightBorder(DXVml.ImageFile openXmlElement, DMWVml.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXWVml.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlW.RightBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRightBorder(DXVml.ImageFile openXmlElement, DMWVml.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlW.RightBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWVml.BorderTypeConverter.CreateOpenXmlElement<DXVmlW.RightBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMVml.ImageFile? CreateModelElement(DXVml.ImageFile? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.ImageFile();
      value.Id = GetId(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.Href = GetHref(openXmlElement);
      value.Target = GetTarget(openXmlElement);
      value.Class = GetClass(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.Alternate = GetAlternate(openXmlElement);
      value.CoordinateSize = GetCoordinateSize(openXmlElement);
      value.WrapCoordinates = GetWrapCoordinates(openXmlElement);
      value.Print = GetPrint(openXmlElement);
      value.OptionalString = GetOptionalString(openXmlElement);
      value.Oned = GetOned(openXmlElement);
      value.RegroupId = GetRegroupId(openXmlElement);
      value.DoubleClickNotify = GetDoubleClickNotify(openXmlElement);
      value.Button = GetButton(openXmlElement);
      value.UserHidden = GetUserHidden(openXmlElement);
      value.Bullet = GetBullet(openXmlElement);
      value.Horizontal = GetHorizontal(openXmlElement);
      value.HorizontalStandard = GetHorizontalStandard(openXmlElement);
      value.HorizontalNoShade = GetHorizontalNoShade(openXmlElement);
      value.HorizontalPercentage = GetHorizontalPercentage(openXmlElement);
      value.HorizontalAlignment = GetHorizontalAlignment(openXmlElement);
      value.AllowInCell = GetAllowInCell(openXmlElement);
      value.AllowOverlap = GetAllowOverlap(openXmlElement);
      value.UserDrawn = GetUserDrawn(openXmlElement);
      value.BorderTopColor = GetBorderTopColor(openXmlElement);
      value.BorderLeftColor = GetBorderLeftColor(openXmlElement);
      value.BorderBottomColor = GetBorderBottomColor(openXmlElement);
      value.BorderRightColor = GetBorderRightColor(openXmlElement);
      value.DiagramLayout = GetDiagramLayout(openXmlElement);
      value.DiagramNodeKind = GetDiagramNodeKind(openXmlElement);
      value.DiagramLayoutMostRecentUsed = GetDiagramLayoutMostRecentUsed(openXmlElement);
      value.InsetMode = GetInsetMode(openXmlElement);
      value.Filled = GetFilled(openXmlElement);
      value.FillColor = GetFillColor(openXmlElement);
      value.Stroked = GetStroked(openXmlElement);
      value.StrokeColor = GetStrokeColor(openXmlElement);
      value.StrokeWeight = GetStrokeWeight(openXmlElement);
      value.InsetPen = GetInsetPen(openXmlElement);
      value.OptionalNumber = GetOptionalNumber(openXmlElement);
      value.ConnectorType = GetConnectorType(openXmlElement);
      value.BlackWhiteMode = GetBlackWhiteMode(openXmlElement);
      value.PureBlackWhiteMode = GetPureBlackWhiteMode(openXmlElement);
      value.NormalBlackWhiteMode = GetNormalBlackWhiteMode(openXmlElement);
      value.ForceDash = GetForceDash(openXmlElement);
      value.OleIcon = GetOleIcon(openXmlElement);
      value.Ole = GetOle(openXmlElement);
      value.PreferRelative = GetPreferRelative(openXmlElement);
      value.ClipToWrap = GetClipToWrap(openXmlElement);
      value.Clip = GetClip(openXmlElement);
      value.Source = GetSource(openXmlElement);
      value.CropLeft = GetCropLeft(openXmlElement);
      value.CropTop = GetCropTop(openXmlElement);
      value.CropRight = GetCropRight(openXmlElement);
      value.CropBottom = GetCropBottom(openXmlElement);
      value.Gain = GetGain(openXmlElement);
      value.BlackLevel = GetBlackLevel(openXmlElement);
      value.Gamma = GetGamma(openXmlElement);
      value.GrayScale = GetGrayScale(openXmlElement);
      value.BiLevel = GetBiLevel(openXmlElement);
      value.Gfxdata = GetGfxdata(openXmlElement);
      value.Path = GetPath(openXmlElement);
      value.Formulas = GetFormulas(openXmlElement);
      value.ShapeHandles = GetShapeHandles(openXmlElement);
      value.Fill = GetFill(openXmlElement);
      value.Stroke = GetStroke(openXmlElement);
      value.Shadow = GetShadow(openXmlElement);
      value.TextBox = GetTextBox(openXmlElement);
      value.TextPath = GetTextPath(openXmlElement);
      value.ImageData = GetImageData(openXmlElement);
      value.Skew = GetSkew(openXmlElement);
      value.Extrusion = GetExtrusion(openXmlElement);
      value.Callout = GetCallout(openXmlElement);
      value.Lock = GetLock(openXmlElement);
      value.ClipPath = GetClipPath(openXmlElement);
      value.SignatureLine = GetSignatureLine(openXmlElement);
      value.TextWrap = GetTextWrap(openXmlElement);
      value.AnchorLock = GetAnchorLock(openXmlElement);
      value.TopBorder = GetTopBorder(openXmlElement);
      value.BottomBorder = GetBottomBorder(openXmlElement);
      value.LeftBorder = GetLeftBorder(openXmlElement);
      value.RightBorder = GetRightBorder(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVml.ImageFile? openXmlElement, DMVml.ImageFile? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName))
        ok = false;
      if (!CmpHref(openXmlElement, value.Href, diffs, objName))
        ok = false;
      if (!CmpTarget(openXmlElement, value.Target, diffs, objName))
        ok = false;
      if (!CmpClass(openXmlElement, value.Class, diffs, objName))
        ok = false;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName))
        ok = false;
      if (!CmpAlternate(openXmlElement, value.Alternate, diffs, objName))
        ok = false;
      if (!CmpCoordinateSize(openXmlElement, value.CoordinateSize, diffs, objName))
        ok = false;
      if (!CmpWrapCoordinates(openXmlElement, value.WrapCoordinates, diffs, objName))
        ok = false;
      if (!CmpPrint(openXmlElement, value.Print, diffs, objName))
        ok = false;
      if (!CmpOptionalString(openXmlElement, value.OptionalString, diffs, objName))
        ok = false;
      if (!CmpOned(openXmlElement, value.Oned, diffs, objName))
        ok = false;
      if (!CmpRegroupId(openXmlElement, value.RegroupId, diffs, objName))
        ok = false;
      if (!CmpDoubleClickNotify(openXmlElement, value.DoubleClickNotify, diffs, objName))
        ok = false;
      if (!CmpButton(openXmlElement, value.Button, diffs, objName))
        ok = false;
      if (!CmpUserHidden(openXmlElement, value.UserHidden, diffs, objName))
        ok = false;
      if (!CmpBullet(openXmlElement, value.Bullet, diffs, objName))
        ok = false;
      if (!CmpHorizontal(openXmlElement, value.Horizontal, diffs, objName))
        ok = false;
      if (!CmpHorizontalStandard(openXmlElement, value.HorizontalStandard, diffs, objName))
        ok = false;
      if (!CmpHorizontalNoShade(openXmlElement, value.HorizontalNoShade, diffs, objName))
        ok = false;
      if (!CmpHorizontalPercentage(openXmlElement, value.HorizontalPercentage, diffs, objName))
        ok = false;
      if (!CmpHorizontalAlignment(openXmlElement, value.HorizontalAlignment, diffs, objName))
        ok = false;
      if (!CmpAllowInCell(openXmlElement, value.AllowInCell, diffs, objName))
        ok = false;
      if (!CmpAllowOverlap(openXmlElement, value.AllowOverlap, diffs, objName))
        ok = false;
      if (!CmpUserDrawn(openXmlElement, value.UserDrawn, diffs, objName))
        ok = false;
      if (!CmpBorderTopColor(openXmlElement, value.BorderTopColor, diffs, objName))
        ok = false;
      if (!CmpBorderLeftColor(openXmlElement, value.BorderLeftColor, diffs, objName))
        ok = false;
      if (!CmpBorderBottomColor(openXmlElement, value.BorderBottomColor, diffs, objName))
        ok = false;
      if (!CmpBorderRightColor(openXmlElement, value.BorderRightColor, diffs, objName))
        ok = false;
      if (!CmpDiagramLayout(openXmlElement, value.DiagramLayout, diffs, objName))
        ok = false;
      if (!CmpDiagramNodeKind(openXmlElement, value.DiagramNodeKind, diffs, objName))
        ok = false;
      if (!CmpDiagramLayoutMostRecentUsed(openXmlElement, value.DiagramLayoutMostRecentUsed, diffs, objName))
        ok = false;
      if (!CmpInsetMode(openXmlElement, value.InsetMode, diffs, objName))
        ok = false;
      if (!CmpFilled(openXmlElement, value.Filled, diffs, objName))
        ok = false;
      if (!CmpFillColor(openXmlElement, value.FillColor, diffs, objName))
        ok = false;
      if (!CmpStroked(openXmlElement, value.Stroked, diffs, objName))
        ok = false;
      if (!CmpStrokeColor(openXmlElement, value.StrokeColor, diffs, objName))
        ok = false;
      if (!CmpStrokeWeight(openXmlElement, value.StrokeWeight, diffs, objName))
        ok = false;
      if (!CmpInsetPen(openXmlElement, value.InsetPen, diffs, objName))
        ok = false;
      if (!CmpOptionalNumber(openXmlElement, value.OptionalNumber, diffs, objName))
        ok = false;
      if (!CmpConnectorType(openXmlElement, value.ConnectorType, diffs, objName))
        ok = false;
      if (!CmpBlackWhiteMode(openXmlElement, value.BlackWhiteMode, diffs, objName))
        ok = false;
      if (!CmpPureBlackWhiteMode(openXmlElement, value.PureBlackWhiteMode, diffs, objName))
        ok = false;
      if (!CmpNormalBlackWhiteMode(openXmlElement, value.NormalBlackWhiteMode, diffs, objName))
        ok = false;
      if (!CmpForceDash(openXmlElement, value.ForceDash, diffs, objName))
        ok = false;
      if (!CmpOleIcon(openXmlElement, value.OleIcon, diffs, objName))
        ok = false;
      if (!CmpOle(openXmlElement, value.Ole, diffs, objName))
        ok = false;
      if (!CmpPreferRelative(openXmlElement, value.PreferRelative, diffs, objName))
        ok = false;
      if (!CmpClipToWrap(openXmlElement, value.ClipToWrap, diffs, objName))
        ok = false;
      if (!CmpClip(openXmlElement, value.Clip, diffs, objName))
        ok = false;
      if (!CmpSource(openXmlElement, value.Source, diffs, objName))
        ok = false;
      if (!CmpCropLeft(openXmlElement, value.CropLeft, diffs, objName))
        ok = false;
      if (!CmpCropTop(openXmlElement, value.CropTop, diffs, objName))
        ok = false;
      if (!CmpCropRight(openXmlElement, value.CropRight, diffs, objName))
        ok = false;
      if (!CmpCropBottom(openXmlElement, value.CropBottom, diffs, objName))
        ok = false;
      if (!CmpGain(openXmlElement, value.Gain, diffs, objName))
        ok = false;
      if (!CmpBlackLevel(openXmlElement, value.BlackLevel, diffs, objName))
        ok = false;
      if (!CmpGamma(openXmlElement, value.Gamma, diffs, objName))
        ok = false;
      if (!CmpGrayScale(openXmlElement, value.GrayScale, diffs, objName))
        ok = false;
      if (!CmpBiLevel(openXmlElement, value.BiLevel, diffs, objName))
        ok = false;
      if (!CmpGfxdata(openXmlElement, value.Gfxdata, diffs, objName))
        ok = false;
      if (!CmpPath(openXmlElement, value.Path, diffs, objName))
        ok = false;
      if (!CmpFormulas(openXmlElement, value.Formulas, diffs, objName))
        ok = false;
      if (!CmpShapeHandles(openXmlElement, value.ShapeHandles, diffs, objName))
        ok = false;
      if (!CmpFill(openXmlElement, value.Fill, diffs, objName))
        ok = false;
      if (!CmpStroke(openXmlElement, value.Stroke, diffs, objName))
        ok = false;
      if (!CmpShadow(openXmlElement, value.Shadow, diffs, objName))
        ok = false;
      if (!CmpTextBox(openXmlElement, value.TextBox, diffs, objName))
        ok = false;
      if (!CmpTextPath(openXmlElement, value.TextPath, diffs, objName))
        ok = false;
      if (!CmpImageData(openXmlElement, value.ImageData, diffs, objName))
        ok = false;
      if (!CmpSkew(openXmlElement, value.Skew, diffs, objName))
        ok = false;
      if (!CmpExtrusion(openXmlElement, value.Extrusion, diffs, objName))
        ok = false;
      if (!CmpCallout(openXmlElement, value.Callout, diffs, objName))
        ok = false;
      if (!CmpLock(openXmlElement, value.Lock, diffs, objName))
        ok = false;
      if (!CmpClipPath(openXmlElement, value.ClipPath, diffs, objName))
        ok = false;
      if (!CmpSignatureLine(openXmlElement, value.SignatureLine, diffs, objName))
        ok = false;
      if (!CmpTextWrap(openXmlElement, value.TextWrap, diffs, objName))
        ok = false;
      if (!CmpAnchorLock(openXmlElement, value.AnchorLock, diffs, objName))
        ok = false;
      if (!CmpTopBorder(openXmlElement, value.TopBorder, diffs, objName))
        ok = false;
      if (!CmpBottomBorder(openXmlElement, value.BottomBorder, diffs, objName))
        ok = false;
      if (!CmpLeftBorder(openXmlElement, value.LeftBorder, diffs, objName))
        ok = false;
      if (!CmpRightBorder(openXmlElement, value.RightBorder, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.ImageFile? value)
    where OpenXmlElementType: DXVml.ImageFile, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetStyle(openXmlElement, value?.Style);
      SetHref(openXmlElement, value?.Href);
      SetTarget(openXmlElement, value?.Target);
      SetClass(openXmlElement, value?.Class);
      SetTitle(openXmlElement, value?.Title);
      SetAlternate(openXmlElement, value?.Alternate);
      SetCoordinateSize(openXmlElement, value?.CoordinateSize);
      SetWrapCoordinates(openXmlElement, value?.WrapCoordinates);
      SetPrint(openXmlElement, value?.Print);
      SetOptionalString(openXmlElement, value?.OptionalString);
      SetOned(openXmlElement, value?.Oned);
      SetRegroupId(openXmlElement, value?.RegroupId);
      SetDoubleClickNotify(openXmlElement, value?.DoubleClickNotify);
      SetButton(openXmlElement, value?.Button);
      SetUserHidden(openXmlElement, value?.UserHidden);
      SetBullet(openXmlElement, value?.Bullet);
      SetHorizontal(openXmlElement, value?.Horizontal);
      SetHorizontalStandard(openXmlElement, value?.HorizontalStandard);
      SetHorizontalNoShade(openXmlElement, value?.HorizontalNoShade);
      SetHorizontalPercentage(openXmlElement, value?.HorizontalPercentage);
      SetHorizontalAlignment(openXmlElement, value?.HorizontalAlignment);
      SetAllowInCell(openXmlElement, value?.AllowInCell);
      SetAllowOverlap(openXmlElement, value?.AllowOverlap);
      SetUserDrawn(openXmlElement, value?.UserDrawn);
      SetBorderTopColor(openXmlElement, value?.BorderTopColor);
      SetBorderLeftColor(openXmlElement, value?.BorderLeftColor);
      SetBorderBottomColor(openXmlElement, value?.BorderBottomColor);
      SetBorderRightColor(openXmlElement, value?.BorderRightColor);
      SetDiagramLayout(openXmlElement, value?.DiagramLayout);
      SetDiagramNodeKind(openXmlElement, value?.DiagramNodeKind);
      SetDiagramLayoutMostRecentUsed(openXmlElement, value?.DiagramLayoutMostRecentUsed);
      SetInsetMode(openXmlElement, value?.InsetMode);
      SetFilled(openXmlElement, value?.Filled);
      SetFillColor(openXmlElement, value?.FillColor);
      SetStroked(openXmlElement, value?.Stroked);
      SetStrokeColor(openXmlElement, value?.StrokeColor);
      SetStrokeWeight(openXmlElement, value?.StrokeWeight);
      SetInsetPen(openXmlElement, value?.InsetPen);
      SetOptionalNumber(openXmlElement, value?.OptionalNumber);
      SetConnectorType(openXmlElement, value?.ConnectorType);
      SetBlackWhiteMode(openXmlElement, value?.BlackWhiteMode);
      SetPureBlackWhiteMode(openXmlElement, value?.PureBlackWhiteMode);
      SetNormalBlackWhiteMode(openXmlElement, value?.NormalBlackWhiteMode);
      SetForceDash(openXmlElement, value?.ForceDash);
      SetOleIcon(openXmlElement, value?.OleIcon);
      SetOle(openXmlElement, value?.Ole);
      SetPreferRelative(openXmlElement, value?.PreferRelative);
      SetClipToWrap(openXmlElement, value?.ClipToWrap);
      SetClip(openXmlElement, value?.Clip);
      SetSource(openXmlElement, value?.Source);
      SetCropLeft(openXmlElement, value?.CropLeft);
      SetCropTop(openXmlElement, value?.CropTop);
      SetCropRight(openXmlElement, value?.CropRight);
      SetCropBottom(openXmlElement, value?.CropBottom);
      SetGain(openXmlElement, value?.Gain);
      SetBlackLevel(openXmlElement, value?.BlackLevel);
      SetGamma(openXmlElement, value?.Gamma);
      SetGrayScale(openXmlElement, value?.GrayScale);
      SetBiLevel(openXmlElement, value?.BiLevel);
      SetGfxdata(openXmlElement, value?.Gfxdata);
      SetPath(openXmlElement, value?.Path);
      SetFormulas(openXmlElement, value?.Formulas);
      SetShapeHandles(openXmlElement, value?.ShapeHandles);
      SetFill(openXmlElement, value?.Fill);
      SetStroke(openXmlElement, value?.Stroke);
      SetShadow(openXmlElement, value?.Shadow);
      SetTextBox(openXmlElement, value?.TextBox);
      SetTextPath(openXmlElement, value?.TextPath);
      SetImageData(openXmlElement, value?.ImageData);
      SetSkew(openXmlElement, value?.Skew);
      SetExtrusion(openXmlElement, value?.Extrusion);
      SetCallout(openXmlElement, value?.Callout);
      SetLock(openXmlElement, value?.Lock);
      SetClipPath(openXmlElement, value?.ClipPath);
      SetSignatureLine(openXmlElement, value?.SignatureLine);
      SetTextWrap(openXmlElement, value?.TextWrap);
      SetAnchorLock(openXmlElement, value?.AnchorLock);
      SetTopBorder(openXmlElement, value?.TopBorder);
      SetBottomBorder(openXmlElement, value?.BottomBorder);
      SetLeftBorder(openXmlElement, value?.LeftBorder);
      SetRightBorder(openXmlElement, value?.RightBorder);
      return openXmlElement;
    }
    return default;
  }
}

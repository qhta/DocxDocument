namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Multiple Path Line.
/// </summary>
public static class PolyLineConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  private static String? GetStyle(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  private static bool CmpStyle(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Style?.Value == value;
  }
  
  private static void SetStyle(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Style = new StringValue { Value = value };
    else
      openXmlElement.Style = null;
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  private static String? GetHref(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }
  
  private static bool CmpHref(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Href?.Value == value;
  }
  
  private static void SetHref(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Href = new StringValue { Value = value };
    else
      openXmlElement.Href = null;
  }
  
  /// <summary>
  /// Hyperlink Display Target
  /// </summary>
  private static String? GetTarget(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Target?.Value;
  }
  
  private static bool CmpTarget(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Target?.Value == value;
  }
  
  private static void SetTarget(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Target = new StringValue { Value = value };
    else
      openXmlElement.Target = null;
  }
  
  /// <summary>
  /// CSS Reference
  /// </summary>
  private static String? GetClass(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Class?.Value;
  }
  
  private static bool CmpClass(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Class?.Value == value;
  }
  
  private static void SetClass(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Class = new StringValue { Value = value };
    else
      openXmlElement.Class = null;
  }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  private static String? GetTitle(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static bool CmpTitle(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Title?.Value == value;
  }
  
  private static void SetTitle(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Alternate Text
  /// </summary>
  private static String? GetAlternate(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Alternate?.Value;
  }
  
  private static bool CmpAlternate(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Alternate?.Value == value;
  }
  
  private static void SetAlternate(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Alternate = new StringValue { Value = value };
    else
      openXmlElement.Alternate = null;
  }
  
  /// <summary>
  /// Coordinate Space Size
  /// </summary>
  private static String? GetCoordinateSize(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.CoordinateSize?.Value;
  }
  
  private static bool CmpCoordinateSize(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.CoordinateSize?.Value == value;
  }
  
  private static void SetCoordinateSize(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CoordinateSize = new StringValue { Value = value };
    else
      openXmlElement.CoordinateSize = null;
  }
  
  /// <summary>
  /// Coordinate Space Origin
  /// </summary>
  private static String? GetCoordinateOrigin(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.CoordinateOrigin?.Value;
  }
  
  private static bool CmpCoordinateOrigin(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.CoordinateOrigin?.Value == value;
  }
  
  private static void SetCoordinateOrigin(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CoordinateOrigin = new StringValue { Value = value };
    else
      openXmlElement.CoordinateOrigin = null;
  }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  private static String? GetWrapCoordinates(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.WrapCoordinates?.Value;
  }
  
  private static bool CmpWrapCoordinates(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.WrapCoordinates?.Value == value;
  }
  
  private static void SetWrapCoordinates(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.WrapCoordinates = new StringValue { Value = value };
    else
      openXmlElement.WrapCoordinates = null;
  }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  private static Boolean? GetPrint(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Print?.Value;
  }
  
  private static bool CmpPrint(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Print?.Value == value;
  }
  
  private static void SetPrint(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Print = value;
    else
      openXmlElement.Print = null;
  }
  
  /// <summary>
  /// Optional String
  /// </summary>
  private static String? GetOptionalString(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.OptionalString?.Value;
  }
  
  private static bool CmpOptionalString(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.OptionalString?.Value == value;
  }
  
  private static void SetOptionalString(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OptionalString = new StringValue { Value = value };
    else
      openXmlElement.OptionalString = null;
  }
  
  /// <summary>
  /// Shape Handle Toggle
  /// </summary>
  private static Boolean? GetOned(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Oned?.Value;
  }
  
  private static bool CmpOned(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Oned?.Value == value;
  }
  
  private static void SetOned(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Oned = value;
    else
      openXmlElement.Oned = null;
  }
  
  /// <summary>
  /// Regroup ID
  /// </summary>
  private static Int64? GetRegroupId(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.RegroupId?.Value;
  }
  
  private static bool CmpRegroupId(DXVml.PolyLine openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RegroupId?.Value == value) return true;
    diffs?.Add(objName, "RegroupId", openXmlElement?.RegroupId?.Value, value);
    return false;
  }
  
  private static void SetRegroupId(DXVml.PolyLine openXmlElement, Int64? value)
  {
    openXmlElement.RegroupId = value;
  }
  
  /// <summary>
  /// Double-click Notification Toggle
  /// </summary>
  private static Boolean? GetDoubleClickNotify(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.DoubleClickNotify?.Value;
  }
  
  private static bool CmpDoubleClickNotify(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.DoubleClickNotify?.Value == value;
  }
  
  private static void SetDoubleClickNotify(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DoubleClickNotify = value;
    else
      openXmlElement.DoubleClickNotify = null;
  }
  
  /// <summary>
  /// Button Behavior Toggle
  /// </summary>
  private static Boolean? GetButton(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Button?.Value;
  }
  
  private static bool CmpButton(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Button?.Value == value;
  }
  
  private static void SetButton(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Button = value;
    else
      openXmlElement.Button = null;
  }
  
  /// <summary>
  /// Hide Script Anchors
  /// </summary>
  private static Boolean? GetUserHidden(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.UserHidden?.Value;
  }
  
  private static bool CmpUserHidden(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.UserHidden?.Value == value;
  }
  
  private static void SetUserHidden(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserHidden = value;
    else
      openXmlElement.UserHidden = null;
  }
  
  /// <summary>
  /// Graphical Bullet
  /// </summary>
  private static Boolean? GetBullet(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Bullet?.Value;
  }
  
  private static bool CmpBullet(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Bullet?.Value == value;
  }
  
  private static void SetBullet(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Bullet = value;
    else
      openXmlElement.Bullet = null;
  }
  
  /// <summary>
  /// Horizontal Rule Toggle
  /// </summary>
  private static Boolean? GetHorizontal(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Horizontal?.Value;
  }
  
  private static bool CmpHorizontal(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Horizontal?.Value == value;
  }
  
  private static void SetHorizontal(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Horizontal = value;
    else
      openXmlElement.Horizontal = null;
  }
  
  /// <summary>
  /// Horizontal Rule Standard Display Toggle
  /// </summary>
  private static Boolean? GetHorizontalStandard(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.HorizontalStandard?.Value;
  }
  
  private static bool CmpHorizontalStandard(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.HorizontalStandard?.Value == value;
  }
  
  private static void SetHorizontalStandard(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalStandard = value;
    else
      openXmlElement.HorizontalStandard = null;
  }
  
  /// <summary>
  /// Horizontal Rule 3D Shading Toggle
  /// </summary>
  private static Boolean? GetHorizontalNoShade(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.HorizontalNoShade?.Value;
  }
  
  private static bool CmpHorizontalNoShade(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.HorizontalNoShade?.Value == value;
  }
  
  private static void SetHorizontalNoShade(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalNoShade = value;
    else
      openXmlElement.HorizontalNoShade = null;
  }
  
  /// <summary>
  /// Horizontal Rule Length Percentage
  /// </summary>
  private static Single? GetHorizontalPercentage(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.HorizontalPercentage?.Value;
  }
  
  private static bool CmpHorizontalPercentage(DXVml.PolyLine openXmlElement, Single? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalPercentage?.Value == value) return true;
    diffs?.Add(objName, "HorizontalPercentage", openXmlElement?.HorizontalPercentage?.Value, value);
    return false;
  }
  
  private static void SetHorizontalPercentage(DXVml.PolyLine openXmlElement, Single? value)
  {
    openXmlElement.HorizontalPercentage = value;
  }
  
  /// <summary>
  /// Horizontal Rule Alignment
  /// </summary>
  private static DMVml.HorizontalRuleAlignmentKind? GetHorizontalAlignment(DXVml.PolyLine openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMVml.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value);
  }
  
  private static bool CmpHorizontalAlignment(DXVml.PolyLine openXmlElement, DMVml.HorizontalRuleAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMVml.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHorizontalAlignment(DXVml.PolyLine openXmlElement, DMVml.HorizontalRuleAlignmentKind? value)
  {
    openXmlElement.HorizontalAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMVml.HorizontalRuleAlignmentKind>(value);
  }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  private static Boolean? GetAllowInCell(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }
  
  private static bool CmpAllowInCell(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AllowInCell?.Value == value;
  }
  
  private static void SetAllowInCell(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowInCell = value;
    else
      openXmlElement.AllowInCell = null;
  }
  
  /// <summary>
  /// Allow Shape Overlap
  /// </summary>
  private static Boolean? GetAllowOverlap(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  private static bool CmpAllowOverlap(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AllowOverlap?.Value == value;
  }
  
  private static void SetAllowOverlap(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowOverlap = value;
    else
      openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// Exists In Master Slide
  /// </summary>
  private static Boolean? GetUserDrawn(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.UserDrawn?.Value;
  }
  
  private static bool CmpUserDrawn(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.UserDrawn?.Value == value;
  }
  
  private static void SetUserDrawn(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserDrawn = value;
    else
      openXmlElement.UserDrawn = null;
  }
  
  /// <summary>
  /// Border Top Color
  /// </summary>
  private static String? GetBorderTopColor(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.BorderTopColor?.Value;
  }
  
  private static bool CmpBorderTopColor(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.BorderTopColor?.Value == value;
  }
  
  private static void SetBorderTopColor(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BorderTopColor = new StringValue { Value = value };
    else
      openXmlElement.BorderTopColor = null;
  }
  
  /// <summary>
  /// Border Left Color
  /// </summary>
  private static String? GetBorderLeftColor(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.BorderLeftColor?.Value;
  }
  
  private static bool CmpBorderLeftColor(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.BorderLeftColor?.Value == value;
  }
  
  private static void SetBorderLeftColor(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BorderLeftColor = new StringValue { Value = value };
    else
      openXmlElement.BorderLeftColor = null;
  }
  
  /// <summary>
  /// Bottom Border Color
  /// </summary>
  private static String? GetBorderBottomColor(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.BorderBottomColor?.Value;
  }
  
  private static bool CmpBorderBottomColor(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.BorderBottomColor?.Value == value;
  }
  
  private static void SetBorderBottomColor(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BorderBottomColor = new StringValue { Value = value };
    else
      openXmlElement.BorderBottomColor = null;
  }
  
  /// <summary>
  /// Border Right Color
  /// </summary>
  private static String? GetBorderRightColor(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.BorderRightColor?.Value;
  }
  
  private static bool CmpBorderRightColor(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.BorderRightColor?.Value == value;
  }
  
  private static void SetBorderRightColor(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BorderRightColor = new StringValue { Value = value };
    else
      openXmlElement.BorderRightColor = null;
  }
  
  /// <summary>
  /// Diagram Node Layout Identifier
  /// </summary>
  private static Int64? GetDiagramLayout(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.DiagramLayout?.Value;
  }
  
  private static bool CmpDiagramLayout(DXVml.PolyLine openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DiagramLayout?.Value == value) return true;
    diffs?.Add(objName, "DiagramLayout", openXmlElement?.DiagramLayout?.Value, value);
    return false;
  }
  
  private static void SetDiagramLayout(DXVml.PolyLine openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayout = value;
  }
  
  /// <summary>
  /// Diagram Node Identifier
  /// </summary>
  private static Int64? GetDiagramNodeKind(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.DiagramNodeKind?.Value;
  }
  
  private static bool CmpDiagramNodeKind(DXVml.PolyLine openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DiagramNodeKind?.Value == value) return true;
    diffs?.Add(objName, "DiagramNodeKind", openXmlElement?.DiagramNodeKind?.Value, value);
    return false;
  }
  
  private static void SetDiagramNodeKind(DXVml.PolyLine openXmlElement, Int64? value)
  {
    openXmlElement.DiagramNodeKind = value;
  }
  
  /// <summary>
  /// Diagram Node Recent Layout Identifier
  /// </summary>
  private static Int64? GetDiagramLayoutMostRecentUsed(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.DiagramLayoutMostRecentUsed?.Value;
  }
  
  private static bool CmpDiagramLayoutMostRecentUsed(DXVml.PolyLine openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DiagramLayoutMostRecentUsed?.Value == value) return true;
    diffs?.Add(objName, "DiagramLayoutMostRecentUsed", openXmlElement?.DiagramLayoutMostRecentUsed?.Value, value);
    return false;
  }
  
  private static void SetDiagramLayoutMostRecentUsed(DXVml.PolyLine openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayoutMostRecentUsed = value;
  }
  
  /// <summary>
  /// Text Inset Mode
  /// </summary>
  private static DMVml.InsetMarginKind? GetInsetMode(DXVml.PolyLine openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }
  
  private static bool CmpInsetMode(DXVml.PolyLine openXmlElement, DMVml.InsetMarginKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(openXmlElement?.InsetMode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetInsetMode(DXVml.PolyLine openXmlElement, DMVml.InsetMarginKind? value)
  {
    openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(value);
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  private static Boolean? GetFilled(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Filled?.Value;
  }
  
  private static bool CmpFilled(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Filled?.Value == value;
  }
  
  private static void SetFilled(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Filled = value;
    else
      openXmlElement.Filled = null;
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  private static String? GetFillColor(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.FillColor?.Value;
  }
  
  private static bool CmpFillColor(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.FillColor?.Value == value;
  }
  
  private static void SetFillColor(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FillColor = new StringValue { Value = value };
    else
      openXmlElement.FillColor = null;
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  private static Boolean? GetStroked(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Stroked?.Value;
  }
  
  private static bool CmpStroked(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Stroked?.Value == value;
  }
  
  private static void SetStroked(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Stroked = value;
    else
      openXmlElement.Stroked = null;
  }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  private static String? GetStrokeColor(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.StrokeColor?.Value;
  }
  
  private static bool CmpStrokeColor(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.StrokeColor?.Value == value;
  }
  
  private static void SetStrokeColor(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StrokeColor = new StringValue { Value = value };
    else
      openXmlElement.StrokeColor = null;
  }
  
  /// <summary>
  /// Shape Stroke Weight
  /// </summary>
  private static String? GetStrokeWeight(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.StrokeWeight?.Value;
  }
  
  private static bool CmpStrokeWeight(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.StrokeWeight?.Value == value;
  }
  
  private static void SetStrokeWeight(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StrokeWeight = new StringValue { Value = value };
    else
      openXmlElement.StrokeWeight = null;
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  private static Boolean? GetInsetPen(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.InsetPen?.Value;
  }
  
  private static bool CmpInsetPen(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsetPen?.Value == value;
  }
  
  private static void SetInsetPen(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InsetPen = value;
    else
      openXmlElement.InsetPen = null;
  }
  
  /// <summary>
  /// Optional Number
  /// </summary>
  private static Int32? GetOptionalNumber(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.OptionalNumber?.Value;
  }
  
  private static bool CmpOptionalNumber(DXVml.PolyLine openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.OptionalNumber?.Value == value) return true;
    diffs?.Add(objName, "OptionalNumber", openXmlElement?.OptionalNumber?.Value, value);
    return false;
  }
  
  private static void SetOptionalNumber(DXVml.PolyLine openXmlElement, Int32? value)
  {
    openXmlElement.OptionalNumber = value;
  }
  
  /// <summary>
  /// Shape Connector Type
  /// </summary>
  private static DMVml.ConnectorKind? GetConnectorType(DXVml.PolyLine openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMVml.ConnectorKind>(openXmlElement?.ConnectorType?.Value);
  }
  
  private static bool CmpConnectorType(DXVml.PolyLine openXmlElement, DMVml.ConnectorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMVml.ConnectorKind>(openXmlElement?.ConnectorType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetConnectorType(DXVml.PolyLine openXmlElement, DMVml.ConnectorKind? value)
  {
    openXmlElement.ConnectorType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMVml.ConnectorKind>(value);
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  private static DMVml.BlackAndWhiteMode? GetBlackWhiteMode(DXVml.PolyLine openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static bool CmpBlackWhiteMode(DXVml.PolyLine openXmlElement, DMVml.BlackAndWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBlackWhiteMode(DXVml.PolyLine openXmlElement, DMVml.BlackAndWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  private static DMVml.BlackAndWhiteMode? GetPureBlackWhiteMode(DXVml.PolyLine openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value);
  }
  
  private static bool CmpPureBlackWhiteMode(DXVml.PolyLine openXmlElement, DMVml.BlackAndWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPureBlackWhiteMode(DXVml.PolyLine openXmlElement, DMVml.BlackAndWhiteMode? value)
  {
    openXmlElement.PureBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  private static DMVml.BlackAndWhiteMode? GetNormalBlackWhiteMode(DXVml.PolyLine openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value);
  }
  
  private static bool CmpNormalBlackWhiteMode(DXVml.PolyLine openXmlElement, DMVml.BlackAndWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNormalBlackWhiteMode(DXVml.PolyLine openXmlElement, DMVml.BlackAndWhiteMode? value)
  {
    openXmlElement.NormalBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  private static Boolean? GetForceDash(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }
  
  private static bool CmpForceDash(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ForceDash?.Value == value;
  }
  
  private static void SetForceDash(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceDash = value;
    else
      openXmlElement.ForceDash = null;
  }
  
  /// <summary>
  /// Embedded Object Icon Toggle
  /// </summary>
  private static Boolean? GetOleIcon(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.OleIcon?.Value;
  }
  
  private static bool CmpOleIcon(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.OleIcon?.Value == value;
  }
  
  private static void SetOleIcon(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.OleIcon = value;
    else
      openXmlElement.OleIcon = null;
  }
  
  /// <summary>
  /// Embedded Object Toggle
  /// </summary>
  private static Boolean? GetOle(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Ole?.Value;
  }
  
  private static bool CmpOle(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Ole?.Value == value;
  }
  
  private static void SetOle(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Ole = value;
    else
      openXmlElement.Ole = null;
  }
  
  /// <summary>
  /// Relative Resize Toggle
  /// </summary>
  private static Boolean? GetPreferRelative(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.PreferRelative?.Value;
  }
  
  private static bool CmpPreferRelative(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.PreferRelative?.Value == value;
  }
  
  private static void SetPreferRelative(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.PreferRelative = value;
    else
      openXmlElement.PreferRelative = null;
  }
  
  /// <summary>
  /// Clip to Wrapping Polygon
  /// </summary>
  private static Boolean? GetClipToWrap(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.ClipToWrap?.Value;
  }
  
  private static bool CmpClipToWrap(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ClipToWrap?.Value == value;
  }
  
  private static void SetClipToWrap(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ClipToWrap = value;
    else
      openXmlElement.ClipToWrap = null;
  }
  
  /// <summary>
  /// Clipping Toggle
  /// </summary>
  private static Boolean? GetClip(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Clip?.Value;
  }
  
  private static bool CmpClip(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Clip?.Value == value;
  }
  
  private static void SetClip(DXVml.PolyLine openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Clip = value;
    else
      openXmlElement.Clip = null;
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  private static Byte[]? GetGfxdata(DXVml.PolyLine openXmlElement)
  {
    if (openXmlElement?.Gfxdata?.Value != null)
      return Convert.FromBase64String(openXmlElement.Gfxdata.Value);
    return null;
  }
  
  private static bool CmpGfxdata(DXVml.PolyLine openXmlElement, Byte[]? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Gfxdata?.Value != null)
      if (Convert.FromBase64String(openXmlElement.Gfxdata.Value) == value)
        return true;
    if (openXmlElement?.Gfxdata?.Value == null && value == null) return true;
    diffs?.Add(objName, "Gfxdata", openXmlElement?.Gfxdata?.Value, value);
    return false;
  }
  
  private static void SetGfxdata(DXVml.PolyLine openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.Gfxdata = Convert.ToBase64String(value);
    else
      openXmlElement.Gfxdata = null;
  }
  
  /// <summary>
  /// Points for Compound Line
  /// </summary>
  private static String? GetPoints(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement?.Points?.Value;
  }
  
  private static bool CmpPoints(DXVml.PolyLine openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Points?.Value == value;
  }
  
  private static void SetPoints(DXVml.PolyLine openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Points = new StringValue { Value = value };
    else
      openXmlElement.Points = null;
  }
  
  private static DMVml.Path? GetPath(DXVml.PolyLine openXmlElement)
  {
    return DMXVml.PathConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Path>());
  }
  
  private static bool CmpPath(DXVml.PolyLine openXmlElement, DMVml.Path? value, DiffList? diffs, string? objName)
  {
    return DMXVml.PathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Path>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPath(DXVml.PolyLine openXmlElement, DMVml.Path? value)
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
  
  private static DMVml.Formulas? GetFormulas(DXVml.PolyLine openXmlElement)
  {
    return DMXVml.FormulasConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Formulas>());
  }
  
  private static bool CmpFormulas(DXVml.PolyLine openXmlElement, DMVml.Formulas? value, DiffList? diffs, string? objName)
  {
    return DMXVml.FormulasConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Formulas>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFormulas(DXVml.PolyLine openXmlElement, DMVml.Formulas? value)
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
  
  private static DMVml.ShapeHandles? GetShapeHandles(DXVml.PolyLine openXmlElement)
  {
    return DMXVml.ShapeHandlesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.ShapeHandles>());
  }
  
  private static bool CmpShapeHandles(DXVml.PolyLine openXmlElement, DMVml.ShapeHandles? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShapeHandlesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.ShapeHandles>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeHandles(DXVml.PolyLine openXmlElement, DMVml.ShapeHandles? value)
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
  
  private static DMVml.Fill? GetFill(DXVml.PolyLine openXmlElement)
  {
    return DMXVml.FillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Fill>());
  }
  
  private static bool CmpFill(DXVml.PolyLine openXmlElement, DMVml.Fill? value, DiffList? diffs, string? objName)
  {
    return DMXVml.FillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Fill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFill(DXVml.PolyLine openXmlElement, DMVml.Fill? value)
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
  
  private static DMVml.Stroke? GetStroke(DXVml.PolyLine openXmlElement)
  {
    return DMXVml.StrokeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Stroke>());
  }
  
  private static bool CmpStroke(DXVml.PolyLine openXmlElement, DMVml.Stroke? value, DiffList? diffs, string? objName)
  {
    return DMXVml.StrokeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Stroke>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStroke(DXVml.PolyLine openXmlElement, DMVml.Stroke? value)
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
  
  private static DMVml.Shadow? GetShadow(DXVml.PolyLine openXmlElement)
  {
    return DMXVml.ShadowConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Shadow>());
  }
  
  private static bool CmpShadow(DXVml.PolyLine openXmlElement, DMVml.Shadow? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Shadow>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShadow(DXVml.PolyLine openXmlElement, DMVml.Shadow? value)
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
  
  private static DMVml.TextBox? GetTextBox(DXVml.PolyLine openXmlElement)
  {
    return DMXVml.TextBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.TextBox>());
  }
  
  private static bool CmpTextBox(DXVml.PolyLine openXmlElement, DMVml.TextBox? value, DiffList? diffs, string? objName)
  {
    return DMXVml.TextBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.TextBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextBox(DXVml.PolyLine openXmlElement, DMVml.TextBox? value)
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
  
  private static DMVml.TextPath? GetTextPath(DXVml.PolyLine openXmlElement)
  {
    return DMXVml.TextPathConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.TextPath>());
  }
  
  private static bool CmpTextPath(DXVml.PolyLine openXmlElement, DMVml.TextPath? value, DiffList? diffs, string? objName)
  {
    return DMXVml.TextPathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.TextPath>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextPath(DXVml.PolyLine openXmlElement, DMVml.TextPath? value)
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
  
  private static DMVml.ImageData? GetImageData(DXVml.PolyLine openXmlElement)
  {
    return DMXVml.ImageDataConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.ImageData>());
  }
  
  private static bool CmpImageData(DXVml.PolyLine openXmlElement, DMVml.ImageData? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ImageDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.ImageData>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetImageData(DXVml.PolyLine openXmlElement, DMVml.ImageData? value)
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
  
  private static DMVml.Skew? GetSkew(DXVml.PolyLine openXmlElement)
  {
    return DMXVml.SkewConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.Skew>());
  }
  
  private static bool CmpSkew(DXVml.PolyLine openXmlElement, DMVml.Skew? value, DiffList? diffs, string? objName)
  {
    return DMXVml.SkewConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Skew>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSkew(DXVml.PolyLine openXmlElement, DMVml.Skew? value)
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
  
  private static DMVml.Extrusion? GetExtrusion(DXVml.PolyLine openXmlElement)
  {
    return DMXVml.ExtrusionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.Extrusion>());
  }
  
  private static bool CmpExtrusion(DXVml.PolyLine openXmlElement, DMVml.Extrusion? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ExtrusionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Extrusion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtrusion(DXVml.PolyLine openXmlElement, DMVml.Extrusion? value)
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
  
  private static DMVml.Callout? GetCallout(DXVml.PolyLine openXmlElement)
  {
    return DMXVml.CalloutConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.Callout>());
  }
  
  private static bool CmpCallout(DXVml.PolyLine openXmlElement, DMVml.Callout? value, DiffList? diffs, string? objName)
  {
    return DMXVml.CalloutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Callout>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCallout(DXVml.PolyLine openXmlElement, DMVml.Callout? value)
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
  
  private static DMVml.Lock? GetLock(DXVml.PolyLine openXmlElement)
  {
    return DMXVml.LockConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.Lock>());
  }
  
  private static bool CmpLock(DXVml.PolyLine openXmlElement, DMVml.Lock? value, DiffList? diffs, string? objName)
  {
    return DMXVml.LockConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Lock>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLock(DXVml.PolyLine openXmlElement, DMVml.Lock? value)
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
  
  private static DMVml.ClipPath? GetClipPath(DXVml.PolyLine openXmlElement)
  {
    return DMXVml.ClipPathConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.ClipPath>());
  }
  
  private static bool CmpClipPath(DXVml.PolyLine openXmlElement, DMVml.ClipPath? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ClipPathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.ClipPath>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetClipPath(DXVml.PolyLine openXmlElement, DMVml.ClipPath? value)
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
  
  private static DMVml.SignatureLine? GetSignatureLine(DXVml.PolyLine openXmlElement)
  {
    return DMXVml.SignatureLineConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.SignatureLine>());
  }
  
  private static bool CmpSignatureLine(DXVml.PolyLine openXmlElement, DMVml.SignatureLine? value, DiffList? diffs, string? objName)
  {
    return DMXVml.SignatureLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.SignatureLine>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSignatureLine(DXVml.PolyLine openXmlElement, DMVml.SignatureLine? value)
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
  
  private static DMWVml.TextWrap? GetTextWrap(DXVml.PolyLine openXmlElement)
  {
    return DMXWVml.TextWrapConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlW.TextWrap>());
  }
  
  private static bool CmpTextWrap(DXVml.PolyLine openXmlElement, DMWVml.TextWrap? value, DiffList? diffs, string? objName)
  {
    return DMXWVml.TextWrapConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlW.TextWrap>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextWrap(DXVml.PolyLine openXmlElement, DMWVml.TextWrap? value)
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
  
  private static Boolean? GetAnchorLock(DXVml.PolyLine openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXVmlW.AnchorLock>() != null;
  }
  
  private static bool CmpAnchorLock(DXVml.PolyLine openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXVmlW.AnchorLock>() != null == value;
  }
  
  private static void SetAnchorLock(DXVml.PolyLine openXmlElement, Boolean? value)
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
  
  private static DMWVml.BorderType? GetTopBorder(DXVml.PolyLine openXmlElement)
  {
    return DMXWVml.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlW.TopBorder>());
  }
  
  private static bool CmpTopBorder(DXVml.PolyLine openXmlElement, DMWVml.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXWVml.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlW.TopBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTopBorder(DXVml.PolyLine openXmlElement, DMWVml.BorderType? value)
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
  
  private static DMWVml.BorderType? GetBottomBorder(DXVml.PolyLine openXmlElement)
  {
    return DMXWVml.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlW.BottomBorder>());
  }
  
  private static bool CmpBottomBorder(DXVml.PolyLine openXmlElement, DMWVml.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXWVml.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlW.BottomBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBottomBorder(DXVml.PolyLine openXmlElement, DMWVml.BorderType? value)
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
  
  private static DMWVml.BorderType? GetLeftBorder(DXVml.PolyLine openXmlElement)
  {
    return DMXWVml.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlW.LeftBorder>());
  }
  
  private static bool CmpLeftBorder(DXVml.PolyLine openXmlElement, DMWVml.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXWVml.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlW.LeftBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLeftBorder(DXVml.PolyLine openXmlElement, DMWVml.BorderType? value)
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
  
  private static DMWVml.BorderType? GetRightBorder(DXVml.PolyLine openXmlElement)
  {
    return DMXWVml.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlW.RightBorder>());
  }
  
  private static bool CmpRightBorder(DXVml.PolyLine openXmlElement, DMWVml.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXWVml.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlW.RightBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRightBorder(DXVml.PolyLine openXmlElement, DMWVml.BorderType? value)
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
  
  private static DMVml.Ink? GetInk(DXVml.PolyLine openXmlElement)
  {
    return DMXVml.InkConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.Ink>());
  }
  
  private static bool CmpInk(DXVml.PolyLine openXmlElement, DMVml.Ink? value, DiffList? diffs, string? objName)
  {
    return DMXVml.InkConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Ink>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetInk(DXVml.PolyLine openXmlElement, DMVml.Ink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.Ink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.InkConverter.CreateOpenXmlElement<DXVmlO.Ink>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMVml.PolyLine? CreateModelElement(DXVml.PolyLine? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.PolyLine();
      value.Id = GetId(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.Href = GetHref(openXmlElement);
      value.Target = GetTarget(openXmlElement);
      value.Class = GetClass(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.Alternate = GetAlternate(openXmlElement);
      value.CoordinateSize = GetCoordinateSize(openXmlElement);
      value.CoordinateOrigin = GetCoordinateOrigin(openXmlElement);
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
      value.Gfxdata = GetGfxdata(openXmlElement);
      value.Points = GetPoints(openXmlElement);
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
      value.Ink = GetInk(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVml.PolyLine? openXmlElement, DMVml.PolyLine? value, DiffList? diffs, string? objName)
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
      if (!CmpCoordinateOrigin(openXmlElement, value.CoordinateOrigin, diffs, objName))
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
      if (!CmpGfxdata(openXmlElement, value.Gfxdata, diffs, objName))
        ok = false;
      if (!CmpPoints(openXmlElement, value.Points, diffs, objName))
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
      if (!CmpInk(openXmlElement, value.Ink, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.PolyLine? value)
    where OpenXmlElementType: DXVml.PolyLine, new()
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
      SetCoordinateOrigin(openXmlElement, value?.CoordinateOrigin);
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
      SetGfxdata(openXmlElement, value?.Gfxdata);
      SetPoints(openXmlElement, value?.Points);
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
      SetInk(openXmlElement, value?.Ink);
      return openXmlElement;
    }
    return default;
  }
}

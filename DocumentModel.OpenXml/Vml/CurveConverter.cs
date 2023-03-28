namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Bezier Curve converter from/to OpenXml.
///</summary>
public static class CurveConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  private static String? GetStyle(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Style);
  }
  
  private static bool CmpStyle(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Style, value, diffs, objName, "Style");
  }
  
  private static void SetStyle(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.Style = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  private static String? GetHref(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Href);
  }
  
  private static bool CmpHref(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Href, value, diffs, objName, "Href");
  }
  
  private static void SetHref(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.Href = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Hyperlink Display Target
  /// </summary>
  private static String? GetTarget(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Target);
  }
  
  private static bool CmpTarget(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Target, value, diffs, objName, "Target");
  }
  
  private static void SetTarget(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.Target = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// CSS Reference
  /// </summary>
  private static String? GetClass(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Class);
  }
  
  private static bool CmpClass(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Class, value, diffs, objName, "Class");
  }
  
  private static void SetClass(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.Class = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  private static String? GetTitle(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Title);
  }
  
  private static bool CmpTitle(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Title, value, diffs, objName, "Title");
  }
  
  private static void SetTitle(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.Title = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Alternate Text
  /// </summary>
  private static String? GetAlternate(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Alternate);
  }
  
  private static bool CmpAlternate(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Alternate, value, diffs, objName, "Alternate");
  }
  
  private static void SetAlternate(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.Alternate = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Coordinate Space Size
  /// </summary>
  private static String? GetCoordinateSize(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CoordinateSize);
  }
  
  private static bool CmpCoordinateSize(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CoordinateSize, value, diffs, objName, "CoordinateSize");
  }
  
  private static void SetCoordinateSize(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.CoordinateSize = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Coordinate Space Origin
  /// </summary>
  private static String? GetCoordinateOrigin(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CoordinateOrigin);
  }
  
  private static bool CmpCoordinateOrigin(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CoordinateOrigin, value, diffs, objName, "CoordinateOrigin");
  }
  
  private static void SetCoordinateOrigin(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.CoordinateOrigin = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  private static String? GetWrapCoordinates(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.WrapCoordinates);
  }
  
  private static bool CmpWrapCoordinates(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.WrapCoordinates, value, diffs, objName, "WrapCoordinates");
  }
  
  private static void SetWrapCoordinates(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.WrapCoordinates = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  private static Boolean? GetPrint(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.Print?.Value;
  }
  
  private static bool CmpPrint(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Print?.Value == value) return true;
    diffs?.Add(objName, "Print", openXmlElement?.Print?.Value, value);
    return false;
  }
  
  private static void SetPrint(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Print = value;
    else
      openXmlElement.Print = null;
  }
  
  /// <summary>
  /// Optional String
  /// </summary>
  private static String? GetOptionalString(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.OptionalString);
  }
  
  private static bool CmpOptionalString(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.OptionalString, value, diffs, objName, "OptionalString");
  }
  
  private static void SetOptionalString(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.OptionalString = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Handle Toggle
  /// </summary>
  private static Boolean? GetOned(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.Oned?.Value;
  }
  
  private static bool CmpOned(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Oned?.Value == value) return true;
    diffs?.Add(objName, "Oned", openXmlElement?.Oned?.Value, value);
    return false;
  }
  
  private static void SetOned(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Oned = value;
    else
      openXmlElement.Oned = null;
  }
  
  /// <summary>
  /// Regroup ID
  /// </summary>
  private static Int64? GetRegroupId(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.RegroupId?.Value;
  }
  
  private static bool CmpRegroupId(DXVml.Curve openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RegroupId?.Value == value) return true;
    diffs?.Add(objName, "RegroupId", openXmlElement?.RegroupId?.Value, value);
    return false;
  }
  
  private static void SetRegroupId(DXVml.Curve openXmlElement, Int64? value)
  {
    openXmlElement.RegroupId = value;
  }
  
  /// <summary>
  /// Double-click Notification Toggle
  /// </summary>
  private static Boolean? GetDoubleClickNotify(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.DoubleClickNotify?.Value;
  }
  
  private static bool CmpDoubleClickNotify(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DoubleClickNotify?.Value == value) return true;
    diffs?.Add(objName, "DoubleClickNotify", openXmlElement?.DoubleClickNotify?.Value, value);
    return false;
  }
  
  private static void SetDoubleClickNotify(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DoubleClickNotify = value;
    else
      openXmlElement.DoubleClickNotify = null;
  }
  
  /// <summary>
  /// Button Behavior Toggle
  /// </summary>
  private static Boolean? GetButton(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.Button?.Value;
  }
  
  private static bool CmpButton(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Button?.Value == value) return true;
    diffs?.Add(objName, "Button", openXmlElement?.Button?.Value, value);
    return false;
  }
  
  private static void SetButton(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Button = value;
    else
      openXmlElement.Button = null;
  }
  
  /// <summary>
  /// Hide Script Anchors
  /// </summary>
  private static Boolean? GetUserHidden(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.UserHidden?.Value;
  }
  
  private static bool CmpUserHidden(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.UserHidden?.Value == value) return true;
    diffs?.Add(objName, "UserHidden", openXmlElement?.UserHidden?.Value, value);
    return false;
  }
  
  private static void SetUserHidden(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserHidden = value;
    else
      openXmlElement.UserHidden = null;
  }
  
  /// <summary>
  /// Graphical Bullet
  /// </summary>
  private static Boolean? GetBullet(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.Bullet?.Value;
  }
  
  private static bool CmpBullet(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Bullet?.Value == value) return true;
    diffs?.Add(objName, "Bullet", openXmlElement?.Bullet?.Value, value);
    return false;
  }
  
  private static void SetBullet(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Bullet = value;
    else
      openXmlElement.Bullet = null;
  }
  
  /// <summary>
  /// Horizontal Rule Toggle
  /// </summary>
  private static Boolean? GetHorizontal(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.Horizontal?.Value;
  }
  
  private static bool CmpHorizontal(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Horizontal?.Value == value) return true;
    diffs?.Add(objName, "Horizontal", openXmlElement?.Horizontal?.Value, value);
    return false;
  }
  
  private static void SetHorizontal(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Horizontal = value;
    else
      openXmlElement.Horizontal = null;
  }
  
  /// <summary>
  /// Horizontal Rule Standard Display Toggle
  /// </summary>
  private static Boolean? GetHorizontalStandard(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.HorizontalStandard?.Value;
  }
  
  private static bool CmpHorizontalStandard(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalStandard?.Value == value) return true;
    diffs?.Add(objName, "HorizontalStandard", openXmlElement?.HorizontalStandard?.Value, value);
    return false;
  }
  
  private static void SetHorizontalStandard(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalStandard = value;
    else
      openXmlElement.HorizontalStandard = null;
  }
  
  /// <summary>
  /// Horizontal Rule 3D Shading Toggle
  /// </summary>
  private static Boolean? GetHorizontalNoShade(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.HorizontalNoShade?.Value;
  }
  
  private static bool CmpHorizontalNoShade(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalNoShade?.Value == value) return true;
    diffs?.Add(objName, "HorizontalNoShade", openXmlElement?.HorizontalNoShade?.Value, value);
    return false;
  }
  
  private static void SetHorizontalNoShade(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalNoShade = value;
    else
      openXmlElement.HorizontalNoShade = null;
  }
  
  /// <summary>
  /// Horizontal Rule Length Percentage
  /// </summary>
  private static Single? GetHorizontalPercentage(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.HorizontalPercentage?.Value;
  }
  
  private static bool CmpHorizontalPercentage(DXVml.Curve openXmlElement, Single? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalPercentage?.Value == value) return true;
    diffs?.Add(objName, "HorizontalPercentage", openXmlElement?.HorizontalPercentage?.Value, value);
    return false;
  }
  
  private static void SetHorizontalPercentage(DXVml.Curve openXmlElement, Single? value)
  {
    openXmlElement.HorizontalPercentage = value;
  }
  
  /// <summary>
  /// Horizontal Rule Alignment
  /// </summary>
  private static DMVml.HorizontalRuleAlignmentKind? GetHorizontalAlignment(DXVml.Curve openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMVml.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value);
  }
  
  private static bool CmpHorizontalAlignment(DXVml.Curve openXmlElement, DMVml.HorizontalRuleAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMVml.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value, value, diffs, objName);
  }
  
  private static void SetHorizontalAlignment(DXVml.Curve openXmlElement, DMVml.HorizontalRuleAlignmentKind? value)
  {
    openXmlElement.HorizontalAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMVml.HorizontalRuleAlignmentKind>(value);
  }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  private static Boolean? GetAllowInCell(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }
  
  private static bool CmpAllowInCell(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowInCell?.Value == value) return true;
    diffs?.Add(objName, "AllowInCell", openXmlElement?.AllowInCell?.Value, value);
    return false;
  }
  
  private static void SetAllowInCell(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowInCell = value;
    else
      openXmlElement.AllowInCell = null;
  }
  
  /// <summary>
  /// Allow Shape Overlap
  /// </summary>
  private static Boolean? GetAllowOverlap(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  private static bool CmpAllowOverlap(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowOverlap?.Value == value) return true;
    diffs?.Add(objName, "AllowOverlap", openXmlElement?.AllowOverlap?.Value, value);
    return false;
  }
  
  private static void SetAllowOverlap(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowOverlap = value;
    else
      openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// Exists In Master Slide
  /// </summary>
  private static Boolean? GetUserDrawn(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.UserDrawn?.Value;
  }
  
  private static bool CmpUserDrawn(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.UserDrawn?.Value == value) return true;
    diffs?.Add(objName, "UserDrawn", openXmlElement?.UserDrawn?.Value, value);
    return false;
  }
  
  private static void SetUserDrawn(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserDrawn = value;
    else
      openXmlElement.UserDrawn = null;
  }
  
  /// <summary>
  /// Border Top Color
  /// </summary>
  private static String? GetBorderTopColor(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.BorderTopColor);
  }
  
  private static bool CmpBorderTopColor(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.BorderTopColor, value, diffs, objName, "BorderTopColor");
  }
  
  private static void SetBorderTopColor(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.BorderTopColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Border Left Color
  /// </summary>
  private static String? GetBorderLeftColor(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.BorderLeftColor);
  }
  
  private static bool CmpBorderLeftColor(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.BorderLeftColor, value, diffs, objName, "BorderLeftColor");
  }
  
  private static void SetBorderLeftColor(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.BorderLeftColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Bottom Border Color
  /// </summary>
  private static String? GetBorderBottomColor(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.BorderBottomColor);
  }
  
  private static bool CmpBorderBottomColor(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.BorderBottomColor, value, diffs, objName, "BorderBottomColor");
  }
  
  private static void SetBorderBottomColor(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.BorderBottomColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Border Right Color
  /// </summary>
  private static String? GetBorderRightColor(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.BorderRightColor);
  }
  
  private static bool CmpBorderRightColor(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.BorderRightColor, value, diffs, objName, "BorderRightColor");
  }
  
  private static void SetBorderRightColor(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.BorderRightColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Diagram Node Layout Identifier
  /// </summary>
  private static Int64? GetDiagramLayout(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.DiagramLayout?.Value;
  }
  
  private static bool CmpDiagramLayout(DXVml.Curve openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DiagramLayout?.Value == value) return true;
    diffs?.Add(objName, "DiagramLayout", openXmlElement?.DiagramLayout?.Value, value);
    return false;
  }
  
  private static void SetDiagramLayout(DXVml.Curve openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayout = value;
  }
  
  /// <summary>
  /// Diagram Node Identifier
  /// </summary>
  private static Int64? GetDiagramNodeKind(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.DiagramNodeKind?.Value;
  }
  
  private static bool CmpDiagramNodeKind(DXVml.Curve openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DiagramNodeKind?.Value == value) return true;
    diffs?.Add(objName, "DiagramNodeKind", openXmlElement?.DiagramNodeKind?.Value, value);
    return false;
  }
  
  private static void SetDiagramNodeKind(DXVml.Curve openXmlElement, Int64? value)
  {
    openXmlElement.DiagramNodeKind = value;
  }
  
  /// <summary>
  /// Diagram Node Recent Layout Identifier
  /// </summary>
  private static Int64? GetDiagramLayoutMostRecentUsed(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.DiagramLayoutMostRecentUsed?.Value;
  }
  
  private static bool CmpDiagramLayoutMostRecentUsed(DXVml.Curve openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DiagramLayoutMostRecentUsed?.Value == value) return true;
    diffs?.Add(objName, "DiagramLayoutMostRecentUsed", openXmlElement?.DiagramLayoutMostRecentUsed?.Value, value);
    return false;
  }
  
  private static void SetDiagramLayoutMostRecentUsed(DXVml.Curve openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayoutMostRecentUsed = value;
  }
  
  /// <summary>
  /// Text Inset Mode
  /// </summary>
  private static DMVml.InsetMarginKind? GetInsetMode(DXVml.Curve openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }
  
  private static bool CmpInsetMode(DXVml.Curve openXmlElement, DMVml.InsetMarginKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(openXmlElement?.InsetMode?.Value, value, diffs, objName);
  }
  
  private static void SetInsetMode(DXVml.Curve openXmlElement, DMVml.InsetMarginKind? value)
  {
    openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(value);
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  private static Boolean? GetFilled(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.Filled?.Value;
  }
  
  private static bool CmpFilled(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Filled?.Value == value) return true;
    diffs?.Add(objName, "Filled", openXmlElement?.Filled?.Value, value);
    return false;
  }
  
  private static void SetFilled(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Filled = value;
    else
      openXmlElement.Filled = null;
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  private static String? GetFillColor(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FillColor);
  }
  
  private static bool CmpFillColor(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FillColor, value, diffs, objName, "FillColor");
  }
  
  private static void SetFillColor(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.FillColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  private static Boolean? GetStroked(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.Stroked?.Value;
  }
  
  private static bool CmpStroked(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Stroked?.Value == value) return true;
    diffs?.Add(objName, "Stroked", openXmlElement?.Stroked?.Value, value);
    return false;
  }
  
  private static void SetStroked(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Stroked = value;
    else
      openXmlElement.Stroked = null;
  }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  private static String? GetStrokeColor(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.StrokeColor);
  }
  
  private static bool CmpStrokeColor(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.StrokeColor, value, diffs, objName, "StrokeColor");
  }
  
  private static void SetStrokeColor(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.StrokeColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Stroke Weight
  /// </summary>
  private static String? GetStrokeWeight(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.StrokeWeight);
  }
  
  private static bool CmpStrokeWeight(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.StrokeWeight, value, diffs, objName, "StrokeWeight");
  }
  
  private static void SetStrokeWeight(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.StrokeWeight = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  private static Boolean? GetInsetPen(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.InsetPen?.Value;
  }
  
  private static bool CmpInsetPen(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsetPen?.Value == value) return true;
    diffs?.Add(objName, "InsetPen", openXmlElement?.InsetPen?.Value, value);
    return false;
  }
  
  private static void SetInsetPen(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InsetPen = value;
    else
      openXmlElement.InsetPen = null;
  }
  
  /// <summary>
  /// Optional Number
  /// </summary>
  private static Int32? GetOptionalNumber(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.OptionalNumber?.Value;
  }
  
  private static bool CmpOptionalNumber(DXVml.Curve openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.OptionalNumber?.Value == value) return true;
    diffs?.Add(objName, "OptionalNumber", openXmlElement?.OptionalNumber?.Value, value);
    return false;
  }
  
  private static void SetOptionalNumber(DXVml.Curve openXmlElement, Int32? value)
  {
    openXmlElement.OptionalNumber = value;
  }
  
  /// <summary>
  /// Shape Connector Type
  /// </summary>
  private static DMVml.ConnectorKind? GetConnectorType(DXVml.Curve openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMVml.ConnectorKind>(openXmlElement?.ConnectorType?.Value);
  }
  
  private static bool CmpConnectorType(DXVml.Curve openXmlElement, DMVml.ConnectorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMVml.ConnectorKind>(openXmlElement?.ConnectorType?.Value, value, diffs, objName);
  }
  
  private static void SetConnectorType(DXVml.Curve openXmlElement, DMVml.ConnectorKind? value)
  {
    openXmlElement.ConnectorType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMVml.ConnectorKind>(value);
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  private static DMVml.BlackAndWhiteMode? GetBlackWhiteMode(DXVml.Curve openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static bool CmpBlackWhiteMode(DXVml.Curve openXmlElement, DMVml.BlackAndWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value, value, diffs, objName);
  }
  
  private static void SetBlackWhiteMode(DXVml.Curve openXmlElement, DMVml.BlackAndWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  private static DMVml.BlackAndWhiteMode? GetPureBlackWhiteMode(DXVml.Curve openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value);
  }
  
  private static bool CmpPureBlackWhiteMode(DXVml.Curve openXmlElement, DMVml.BlackAndWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value, value, diffs, objName);
  }
  
  private static void SetPureBlackWhiteMode(DXVml.Curve openXmlElement, DMVml.BlackAndWhiteMode? value)
  {
    openXmlElement.PureBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  private static DMVml.BlackAndWhiteMode? GetNormalBlackWhiteMode(DXVml.Curve openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value);
  }
  
  private static bool CmpNormalBlackWhiteMode(DXVml.Curve openXmlElement, DMVml.BlackAndWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value, value, diffs, objName);
  }
  
  private static void SetNormalBlackWhiteMode(DXVml.Curve openXmlElement, DMVml.BlackAndWhiteMode? value)
  {
    openXmlElement.NormalBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  private static Boolean? GetForceDash(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }
  
  private static bool CmpForceDash(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ForceDash?.Value == value) return true;
    diffs?.Add(objName, "ForceDash", openXmlElement?.ForceDash?.Value, value);
    return false;
  }
  
  private static void SetForceDash(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceDash = value;
    else
      openXmlElement.ForceDash = null;
  }
  
  /// <summary>
  /// Embedded Object Icon Toggle
  /// </summary>
  private static Boolean? GetOleIcon(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.OleIcon?.Value;
  }
  
  private static bool CmpOleIcon(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.OleIcon?.Value == value) return true;
    diffs?.Add(objName, "OleIcon", openXmlElement?.OleIcon?.Value, value);
    return false;
  }
  
  private static void SetOleIcon(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.OleIcon = value;
    else
      openXmlElement.OleIcon = null;
  }
  
  /// <summary>
  /// Embedded Object Toggle
  /// </summary>
  private static Boolean? GetOle(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.Ole?.Value;
  }
  
  private static bool CmpOle(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Ole?.Value == value) return true;
    diffs?.Add(objName, "Ole", openXmlElement?.Ole?.Value, value);
    return false;
  }
  
  private static void SetOle(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Ole = value;
    else
      openXmlElement.Ole = null;
  }
  
  /// <summary>
  /// Relative Resize Toggle
  /// </summary>
  private static Boolean? GetPreferRelative(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.PreferRelative?.Value;
  }
  
  private static bool CmpPreferRelative(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PreferRelative?.Value == value) return true;
    diffs?.Add(objName, "PreferRelative", openXmlElement?.PreferRelative?.Value, value);
    return false;
  }
  
  private static void SetPreferRelative(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.PreferRelative = value;
    else
      openXmlElement.PreferRelative = null;
  }
  
  /// <summary>
  /// Clip to Wrapping Polygon
  /// </summary>
  private static Boolean? GetClipToWrap(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.ClipToWrap?.Value;
  }
  
  private static bool CmpClipToWrap(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ClipToWrap?.Value == value) return true;
    diffs?.Add(objName, "ClipToWrap", openXmlElement?.ClipToWrap?.Value, value);
    return false;
  }
  
  private static void SetClipToWrap(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ClipToWrap = value;
    else
      openXmlElement.ClipToWrap = null;
  }
  
  /// <summary>
  /// Clipping Toggle
  /// </summary>
  private static Boolean? GetClip(DXVml.Curve openXmlElement)
  {
    return openXmlElement?.Clip?.Value;
  }
  
  private static bool CmpClip(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Clip?.Value == value) return true;
    diffs?.Add(objName, "Clip", openXmlElement?.Clip?.Value, value);
    return false;
  }
  
  private static void SetClip(DXVml.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Clip = value;
    else
      openXmlElement.Clip = null;
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  private static DM.Base64Binary? GetGfxdata(DXVml.Curve openXmlElement)
  {
    if (openXmlElement?.Gfxdata?.Value != null)
      return Convert.FromBase64String(openXmlElement.Gfxdata.Value);
    return null;
  }
  
  private static bool CmpGfxdata(DXVml.Curve openXmlElement, DM.Base64Binary? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Gfxdata?.Value != null && value != null)
      if (Convert.FromBase64String(openXmlElement.Gfxdata.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement?.Gfxdata?.Value == null && value == null) return true;
    diffs?.Add(objName, "Gfxdata", openXmlElement?.Gfxdata?.Value, value);
    return false;
  }
  
  private static void SetGfxdata(DXVml.Curve openXmlElement, DM.Base64Binary? value)
  {
    if (value != null)
      openXmlElement.Gfxdata = Convert.ToBase64String(value);
    else
      openXmlElement.Gfxdata = null;
  }
  
  /// <summary>
  /// Curve Starting Point
  /// </summary>
  private static String? GetFrom(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.From);
  }
  
  private static bool CmpFrom(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.From, value, diffs, objName, "From");
  }
  
  private static void SetFrom(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.From = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// First Curve Control Point
  /// </summary>
  private static String? GetControl1(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Control1);
  }
  
  private static bool CmpControl1(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Control1, value, diffs, objName, "Control1");
  }
  
  private static void SetControl1(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.Control1 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Second Curve Control Point
  /// </summary>
  private static String? GetControl2(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Control2);
  }
  
  private static bool CmpControl2(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Control2, value, diffs, objName, "Control2");
  }
  
  private static void SetControl2(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.Control2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Curve Ending Point
  /// </summary>
  private static String? GetTo(DXVml.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.To);
  }
  
  private static bool CmpTo(DXVml.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.To, value, diffs, objName, "To");
  }
  
  private static void SetTo(DXVml.Curve openXmlElement, String? value)
  {
    openXmlElement.To = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMVml.Path? GetPath(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.Path>();
    if (element != null)
      return DMXVml.PathConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPath(DXVml.Curve openXmlElement, DMVml.Path? value, DiffList? diffs, string? objName)
  {
    return DMXVml.PathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Path>(), value, diffs, objName);
  }
  
  private static void SetPath(DXVml.Curve openXmlElement, DMVml.Path? value)
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
  
  private static DMVml.Formulas? GetFormulas(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.Formulas>();
    if (element != null)
      return DMXVml.FormulasConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFormulas(DXVml.Curve openXmlElement, DMVml.Formulas? value, DiffList? diffs, string? objName)
  {
    return DMXVml.FormulasConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Formulas>(), value, diffs, objName);
  }
  
  private static void SetFormulas(DXVml.Curve openXmlElement, DMVml.Formulas? value)
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
  
  private static DMVml.ShapeHandles? GetShapeHandles(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.ShapeHandles>();
    if (element != null)
      return DMXVml.ShapeHandlesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeHandles(DXVml.Curve openXmlElement, DMVml.ShapeHandles? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShapeHandlesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.ShapeHandles>(), value, diffs, objName);
  }
  
  private static void SetShapeHandles(DXVml.Curve openXmlElement, DMVml.ShapeHandles? value)
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
  
  private static DMVml.Fill? GetFill(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.Fill>();
    if (element != null)
      return DMXVml.FillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFill(DXVml.Curve openXmlElement, DMVml.Fill? value, DiffList? diffs, string? objName)
  {
    return DMXVml.FillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Fill>(), value, diffs, objName);
  }
  
  private static void SetFill(DXVml.Curve openXmlElement, DMVml.Fill? value)
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
  
  private static DMVml.Stroke? GetStroke(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.Stroke>();
    if (element != null)
      return DMXVml.StrokeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStroke(DXVml.Curve openXmlElement, DMVml.Stroke? value, DiffList? diffs, string? objName)
  {
    return DMXVml.StrokeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Stroke>(), value, diffs, objName);
  }
  
  private static void SetStroke(DXVml.Curve openXmlElement, DMVml.Stroke? value)
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
  
  private static DMVml.Shadow? GetShadow(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.Shadow>();
    if (element != null)
      return DMXVml.ShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShadow(DXVml.Curve openXmlElement, DMVml.Shadow? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Shadow>(), value, diffs, objName);
  }
  
  private static void SetShadow(DXVml.Curve openXmlElement, DMVml.Shadow? value)
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
  
  private static DMVml.TextBox? GetTextBox(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.TextBox>();
    if (element != null)
      return DMXVml.TextBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextBox(DXVml.Curve openXmlElement, DMVml.TextBox? value, DiffList? diffs, string? objName)
  {
    return DMXVml.TextBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.TextBox>(), value, diffs, objName);
  }
  
  private static void SetTextBox(DXVml.Curve openXmlElement, DMVml.TextBox? value)
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
  
  private static DMVml.TextPath? GetTextPath(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.TextPath>();
    if (element != null)
      return DMXVml.TextPathConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextPath(DXVml.Curve openXmlElement, DMVml.TextPath? value, DiffList? diffs, string? objName)
  {
    return DMXVml.TextPathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.TextPath>(), value, diffs, objName);
  }
  
  private static void SetTextPath(DXVml.Curve openXmlElement, DMVml.TextPath? value)
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
  
  private static DMVml.ImageData? GetImageData(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.ImageData>();
    if (element != null)
      return DMXVml.ImageDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageData(DXVml.Curve openXmlElement, DMVml.ImageData? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ImageDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.ImageData>(), value, diffs, objName);
  }
  
  private static void SetImageData(DXVml.Curve openXmlElement, DMVml.ImageData? value)
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
  
  private static DMVml.Skew? GetSkew(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlO.Skew>();
    if (element != null)
      return DMXVml.SkewConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSkew(DXVml.Curve openXmlElement, DMVml.Skew? value, DiffList? diffs, string? objName)
  {
    return DMXVml.SkewConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Skew>(), value, diffs, objName);
  }
  
  private static void SetSkew(DXVml.Curve openXmlElement, DMVml.Skew? value)
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
  
  private static DMVml.Extrusion? GetExtrusion(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlO.Extrusion>();
    if (element != null)
      return DMXVml.ExtrusionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtrusion(DXVml.Curve openXmlElement, DMVml.Extrusion? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ExtrusionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Extrusion>(), value, diffs, objName);
  }
  
  private static void SetExtrusion(DXVml.Curve openXmlElement, DMVml.Extrusion? value)
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
  
  private static DMVml.Callout? GetCallout(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlO.Callout>();
    if (element != null)
      return DMXVml.CalloutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCallout(DXVml.Curve openXmlElement, DMVml.Callout? value, DiffList? diffs, string? objName)
  {
    return DMXVml.CalloutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Callout>(), value, diffs, objName);
  }
  
  private static void SetCallout(DXVml.Curve openXmlElement, DMVml.Callout? value)
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
  
  private static DMVml.Lock? GetLock(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlO.Lock>();
    if (element != null)
      return DMXVml.LockConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLock(DXVml.Curve openXmlElement, DMVml.Lock? value, DiffList? diffs, string? objName)
  {
    return DMXVml.LockConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Lock>(), value, diffs, objName);
  }
  
  private static void SetLock(DXVml.Curve openXmlElement, DMVml.Lock? value)
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
  
  private static DMVml.ClipPath? GetClipPath(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlO.ClipPath>();
    if (element != null)
      return DMXVml.ClipPathConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpClipPath(DXVml.Curve openXmlElement, DMVml.ClipPath? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ClipPathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.ClipPath>(), value, diffs, objName);
  }
  
  private static void SetClipPath(DXVml.Curve openXmlElement, DMVml.ClipPath? value)
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
  
  private static DMVml.SignatureLine? GetSignatureLine(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlO.SignatureLine>();
    if (element != null)
      return DMXVml.SignatureLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSignatureLine(DXVml.Curve openXmlElement, DMVml.SignatureLine? value, DiffList? diffs, string? objName)
  {
    return DMXVml.SignatureLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.SignatureLine>(), value, diffs, objName);
  }
  
  private static void SetSignatureLine(DXVml.Curve openXmlElement, DMVml.SignatureLine? value)
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
  
  private static DMWVml.TextWrap? GetTextWrap(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlW.TextWrap>();
    if (element != null)
      return DMXWVml.TextWrapConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextWrap(DXVml.Curve openXmlElement, DMWVml.TextWrap? value, DiffList? diffs, string? objName)
  {
    return DMXWVml.TextWrapConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlW.TextWrap>(), value, diffs, objName);
  }
  
  private static void SetTextWrap(DXVml.Curve openXmlElement, DMWVml.TextWrap? value)
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
  
  private static Boolean? GetAnchorLock(DXVml.Curve openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXVmlW.AnchorLock>() != null;
  }
  
  private static bool CmpAnchorLock(DXVml.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXVmlW.AnchorLock>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXVmlW.AnchorLock", val, value);
    return false;
  }
  
  private static void SetAnchorLock(DXVml.Curve openXmlElement, Boolean? value)
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
  
  private static DMWVml.BorderType? GetTopBorder(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlW.TopBorder>();
    if (element != null)
      return DMXWVml.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTopBorder(DXVml.Curve openXmlElement, DMWVml.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXWVml.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlW.TopBorder>(), value, diffs, objName);
  }
  
  private static void SetTopBorder(DXVml.Curve openXmlElement, DMWVml.BorderType? value)
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
  
  private static DMWVml.BorderType? GetBottomBorder(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlW.BottomBorder>();
    if (element != null)
      return DMXWVml.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBottomBorder(DXVml.Curve openXmlElement, DMWVml.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXWVml.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlW.BottomBorder>(), value, diffs, objName);
  }
  
  private static void SetBottomBorder(DXVml.Curve openXmlElement, DMWVml.BorderType? value)
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
  
  private static DMWVml.BorderType? GetLeftBorder(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlW.LeftBorder>();
    if (element != null)
      return DMXWVml.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLeftBorder(DXVml.Curve openXmlElement, DMWVml.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXWVml.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlW.LeftBorder>(), value, diffs, objName);
  }
  
  private static void SetLeftBorder(DXVml.Curve openXmlElement, DMWVml.BorderType? value)
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
  
  private static DMWVml.BorderType? GetRightBorder(DXVml.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlW.RightBorder>();
    if (element != null)
      return DMXWVml.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRightBorder(DXVml.Curve openXmlElement, DMWVml.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXWVml.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlW.RightBorder>(), value, diffs, objName);
  }
  
  private static void SetRightBorder(DXVml.Curve openXmlElement, DMWVml.BorderType? value)
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
  
  public static DocumentModel.Vml.Curve? CreateModelElement(DXVml.Curve? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Curve();
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
      value.From = GetFrom(openXmlElement);
      value.Control1 = GetControl1(openXmlElement);
      value.Control2 = GetControl2(openXmlElement);
      value.To = GetTo(openXmlElement);
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
  
  public static bool CompareModelElement(DXVml.Curve? openXmlElement, DMVml.Curve? value, DiffList? diffs, string? objName)
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
      if (!CmpFrom(openXmlElement, value.From, diffs, objName))
        ok = false;
      if (!CmpControl1(openXmlElement, value.Control1, diffs, objName))
        ok = false;
      if (!CmpControl2(openXmlElement, value.Control2, diffs, objName))
        ok = false;
      if (!CmpTo(openXmlElement, value.To, diffs, objName))
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.Curve value)
    where OpenXmlElementType: DXVml.Curve, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVml.Curve openXmlElement, DMVml.Curve value)
  {
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
    SetFrom(openXmlElement, value?.From);
    SetControl1(openXmlElement, value?.Control1);
    SetControl2(openXmlElement, value?.Control2);
    SetTo(openXmlElement, value?.To);
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
  }
}

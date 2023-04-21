namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Bezier Curve.
/// </summary>
public static class CurveConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  private static String? GetStyle(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Style);
  }
  
  private static bool CmpStyle(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Style, value, diffs, objName, "Style");
  }
  
  private static void SetStyle(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.Style = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  private static String? GetHref(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Href);
  }
  
  private static bool CmpHref(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Href, value, diffs, objName, "Href");
  }
  
  private static void SetHref(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.Href = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Hyperlink Display Target
  /// </summary>
  private static String? GetTarget(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Target);
  }
  
  private static bool CmpTarget(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Target, value, diffs, objName, "Target");
  }
  
  private static void SetTarget(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.Target = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// CSS Reference
  /// </summary>
  private static String? GetClass(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Class);
  }
  
  private static bool CmpClass(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Class, value, diffs, objName, "Class");
  }
  
  private static void SetClass(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.Class = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  private static String? GetTitle(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Title);
  }
  
  private static bool CmpTitle(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Title, value, diffs, objName, "Title");
  }
  
  private static void SetTitle(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.Title = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Alternate Text
  /// </summary>
  private static String? GetAlternate(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Alternate);
  }
  
  private static bool CmpAlternate(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Alternate, value, diffs, objName, "Alternate");
  }
  
  private static void SetAlternate(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.Alternate = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Coordinate Space Size
  /// </summary>
  private static String? GetCoordinateSize(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CoordinateSize);
  }
  
  private static bool CmpCoordinateSize(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CoordinateSize, value, diffs, objName, "CoordinateSize");
  }
  
  private static void SetCoordinateSize(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.CoordinateSize = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Coordinate Space Origin
  /// </summary>
  private static String? GetCoordinateOrigin(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CoordinateOrigin);
  }
  
  private static bool CmpCoordinateOrigin(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CoordinateOrigin, value, diffs, objName, "CoordinateOrigin");
  }
  
  private static void SetCoordinateOrigin(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.CoordinateOrigin = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  private static String? GetWrapCoordinates(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.WrapCoordinates);
  }
  
  private static bool CmpWrapCoordinates(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.WrapCoordinates, value, diffs, objName, "WrapCoordinates");
  }
  
  private static void SetWrapCoordinates(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.WrapCoordinates = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  private static Boolean? GetPrint(DXV.Curve openXmlElement)
  {
    return openXmlElement?.Print?.Value;
  }
  
  private static bool CmpPrint(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Print?.Value == value) return true;
    diffs?.Add(objName, "Print", openXmlElement?.Print?.Value, value);
    return false;
  }
  
  private static void SetPrint(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Print = value;
    else
      openXmlElement.Print = null;
  }
  
  /// <summary>
  /// Optional String
  /// </summary>
  private static String? GetOptionalString(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.OptionalString);
  }
  
  private static bool CmpOptionalString(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.OptionalString, value, diffs, objName, "OptionalString");
  }
  
  private static void SetOptionalString(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.OptionalString = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Handle Toggle
  /// </summary>
  private static Boolean? GetOned(DXV.Curve openXmlElement)
  {
    return openXmlElement?.Oned?.Value;
  }
  
  private static bool CmpOned(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Oned?.Value == value) return true;
    diffs?.Add(objName, "Oned", openXmlElement?.Oned?.Value, value);
    return false;
  }
  
  private static void SetOned(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Oned = value;
    else
      openXmlElement.Oned = null;
  }
  
  /// <summary>
  /// Regroup ID
  /// </summary>
  private static Int64? GetRegroupId(DXV.Curve openXmlElement)
  {
    return openXmlElement?.RegroupId?.Value;
  }
  
  private static bool CmpRegroupId(DXV.Curve openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RegroupId?.Value == value) return true;
    diffs?.Add(objName, "RegroupId", openXmlElement?.RegroupId?.Value, value);
    return false;
  }
  
  private static void SetRegroupId(DXV.Curve openXmlElement, Int64? value)
  {
    openXmlElement.RegroupId = value;
  }
  
  /// <summary>
  /// Double-click Notification Toggle
  /// </summary>
  private static Boolean? GetDoubleClickNotify(DXV.Curve openXmlElement)
  {
    return openXmlElement?.DoubleClickNotify?.Value;
  }
  
  private static bool CmpDoubleClickNotify(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DoubleClickNotify?.Value == value) return true;
    diffs?.Add(objName, "DoubleClickNotify", openXmlElement?.DoubleClickNotify?.Value, value);
    return false;
  }
  
  private static void SetDoubleClickNotify(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DoubleClickNotify = value;
    else
      openXmlElement.DoubleClickNotify = null;
  }
  
  /// <summary>
  /// Button Behavior Toggle
  /// </summary>
  private static Boolean? GetButton(DXV.Curve openXmlElement)
  {
    return openXmlElement?.Button?.Value;
  }
  
  private static bool CmpButton(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Button?.Value == value) return true;
    diffs?.Add(objName, "Button", openXmlElement?.Button?.Value, value);
    return false;
  }
  
  private static void SetButton(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Button = value;
    else
      openXmlElement.Button = null;
  }
  
  /// <summary>
  /// Hide Script Anchors
  /// </summary>
  private static Boolean? GetUserHidden(DXV.Curve openXmlElement)
  {
    return openXmlElement?.UserHidden?.Value;
  }
  
  private static bool CmpUserHidden(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.UserHidden?.Value == value) return true;
    diffs?.Add(objName, "UserHidden", openXmlElement?.UserHidden?.Value, value);
    return false;
  }
  
  private static void SetUserHidden(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserHidden = value;
    else
      openXmlElement.UserHidden = null;
  }
  
  /// <summary>
  /// Graphical Bullet
  /// </summary>
  private static Boolean? GetBullet(DXV.Curve openXmlElement)
  {
    return openXmlElement?.Bullet?.Value;
  }
  
  private static bool CmpBullet(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Bullet?.Value == value) return true;
    diffs?.Add(objName, "Bullet", openXmlElement?.Bullet?.Value, value);
    return false;
  }
  
  private static void SetBullet(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Bullet = value;
    else
      openXmlElement.Bullet = null;
  }
  
  /// <summary>
  /// Horizontal Rule Toggle
  /// </summary>
  private static Boolean? GetHorizontal(DXV.Curve openXmlElement)
  {
    return openXmlElement?.Horizontal?.Value;
  }
  
  private static bool CmpHorizontal(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Horizontal?.Value == value) return true;
    diffs?.Add(objName, "Horizontal", openXmlElement?.Horizontal?.Value, value);
    return false;
  }
  
  private static void SetHorizontal(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Horizontal = value;
    else
      openXmlElement.Horizontal = null;
  }
  
  /// <summary>
  /// Horizontal Rule Standard Display Toggle
  /// </summary>
  private static Boolean? GetHorizontalStandard(DXV.Curve openXmlElement)
  {
    return openXmlElement?.HorizontalStandard?.Value;
  }
  
  private static bool CmpHorizontalStandard(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalStandard?.Value == value) return true;
    diffs?.Add(objName, "HorizontalStandard", openXmlElement?.HorizontalStandard?.Value, value);
    return false;
  }
  
  private static void SetHorizontalStandard(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalStandard = value;
    else
      openXmlElement.HorizontalStandard = null;
  }
  
  /// <summary>
  /// Horizontal Rule 3D Shading Toggle
  /// </summary>
  private static Boolean? GetHorizontalNoShade(DXV.Curve openXmlElement)
  {
    return openXmlElement?.HorizontalNoShade?.Value;
  }
  
  private static bool CmpHorizontalNoShade(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalNoShade?.Value == value) return true;
    diffs?.Add(objName, "HorizontalNoShade", openXmlElement?.HorizontalNoShade?.Value, value);
    return false;
  }
  
  private static void SetHorizontalNoShade(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalNoShade = value;
    else
      openXmlElement.HorizontalNoShade = null;
  }
  
  /// <summary>
  /// Horizontal Rule Length Percentage
  /// </summary>
  private static Single? GetHorizontalPercentage(DXV.Curve openXmlElement)
  {
    return openXmlElement?.HorizontalPercentage?.Value;
  }
  
  private static bool CmpHorizontalPercentage(DXV.Curve openXmlElement, Single? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalPercentage?.Value == value) return true;
    diffs?.Add(objName, "HorizontalPercentage", openXmlElement?.HorizontalPercentage?.Value, value);
    return false;
  }
  
  private static void SetHorizontalPercentage(DXV.Curve openXmlElement, Single? value)
  {
    openXmlElement.HorizontalPercentage = value;
  }
  
  /// <summary>
  /// Horizontal Rule Alignment
  /// </summary>
  private static DMV.HorizontalRuleAlignmentKind? GetHorizontalAlignment(DXV.Curve openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMV.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value);
  }
  
  private static bool CmpHorizontalAlignment(DXV.Curve openXmlElement, DMV.HorizontalRuleAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMV.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value, value, diffs, objName);
  }
  
  private static void SetHorizontalAlignment(DXV.Curve openXmlElement, DMV.HorizontalRuleAlignmentKind? value)
  {
    openXmlElement.HorizontalAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMV.HorizontalRuleAlignmentKind>(value);
  }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  private static Boolean? GetAllowInCell(DXV.Curve openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }
  
  private static bool CmpAllowInCell(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowInCell?.Value == value) return true;
    diffs?.Add(objName, "AllowInCell", openXmlElement?.AllowInCell?.Value, value);
    return false;
  }
  
  private static void SetAllowInCell(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowInCell = value;
    else
      openXmlElement.AllowInCell = null;
  }
  
  /// <summary>
  /// Allow Shape Overlap
  /// </summary>
  private static Boolean? GetAllowOverlap(DXV.Curve openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  private static bool CmpAllowOverlap(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowOverlap?.Value == value) return true;
    diffs?.Add(objName, "AllowOverlap", openXmlElement?.AllowOverlap?.Value, value);
    return false;
  }
  
  private static void SetAllowOverlap(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowOverlap = value;
    else
      openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// Exists In Master Slide
  /// </summary>
  private static Boolean? GetUserDrawn(DXV.Curve openXmlElement)
  {
    return openXmlElement?.UserDrawn?.Value;
  }
  
  private static bool CmpUserDrawn(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.UserDrawn?.Value == value) return true;
    diffs?.Add(objName, "UserDrawn", openXmlElement?.UserDrawn?.Value, value);
    return false;
  }
  
  private static void SetUserDrawn(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserDrawn = value;
    else
      openXmlElement.UserDrawn = null;
  }
  
  /// <summary>
  /// Border Top Color
  /// </summary>
  private static String? GetBorderTopColor(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.BorderTopColor);
  }
  
  private static bool CmpBorderTopColor(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.BorderTopColor, value, diffs, objName, "BorderTopColor");
  }
  
  private static void SetBorderTopColor(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.BorderTopColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Border Left Color
  /// </summary>
  private static String? GetBorderLeftColor(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.BorderLeftColor);
  }
  
  private static bool CmpBorderLeftColor(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.BorderLeftColor, value, diffs, objName, "BorderLeftColor");
  }
  
  private static void SetBorderLeftColor(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.BorderLeftColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Bottom Border Color
  /// </summary>
  private static String? GetBorderBottomColor(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.BorderBottomColor);
  }
  
  private static bool CmpBorderBottomColor(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.BorderBottomColor, value, diffs, objName, "BorderBottomColor");
  }
  
  private static void SetBorderBottomColor(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.BorderBottomColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Border Right Color
  /// </summary>
  private static String? GetBorderRightColor(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.BorderRightColor);
  }
  
  private static bool CmpBorderRightColor(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.BorderRightColor, value, diffs, objName, "BorderRightColor");
  }
  
  private static void SetBorderRightColor(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.BorderRightColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Diagram Node Layout Identifier
  /// </summary>
  private static Int64? GetDiagramLayout(DXV.Curve openXmlElement)
  {
    return openXmlElement?.DiagramLayout?.Value;
  }
  
  private static bool CmpDiagramLayout(DXV.Curve openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DiagramLayout?.Value == value) return true;
    diffs?.Add(objName, "DiagramLayout", openXmlElement?.DiagramLayout?.Value, value);
    return false;
  }
  
  private static void SetDiagramLayout(DXV.Curve openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayout = value;
  }
  
  /// <summary>
  /// Diagram Node Identifier
  /// </summary>
  private static Int64? GetDiagramNodeKind(DXV.Curve openXmlElement)
  {
    return openXmlElement?.DiagramNodeKind?.Value;
  }
  
  private static bool CmpDiagramNodeKind(DXV.Curve openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DiagramNodeKind?.Value == value) return true;
    diffs?.Add(objName, "DiagramNodeKind", openXmlElement?.DiagramNodeKind?.Value, value);
    return false;
  }
  
  private static void SetDiagramNodeKind(DXV.Curve openXmlElement, Int64? value)
  {
    openXmlElement.DiagramNodeKind = value;
  }
  
  /// <summary>
  /// Diagram Node Recent Layout Identifier
  /// </summary>
  private static Int64? GetDiagramLayoutMostRecentUsed(DXV.Curve openXmlElement)
  {
    return openXmlElement?.DiagramLayoutMostRecentUsed?.Value;
  }
  
  private static bool CmpDiagramLayoutMostRecentUsed(DXV.Curve openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DiagramLayoutMostRecentUsed?.Value == value) return true;
    diffs?.Add(objName, "DiagramLayoutMostRecentUsed", openXmlElement?.DiagramLayoutMostRecentUsed?.Value, value);
    return false;
  }
  
  private static void SetDiagramLayoutMostRecentUsed(DXV.Curve openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayoutMostRecentUsed = value;
  }
  
  /// <summary>
  /// Text Inset Mode
  /// </summary>
  private static DMV.InsetMarginKind? GetInsetMode(DXV.Curve openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMV.InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }
  
  private static bool CmpInsetMode(DXV.Curve openXmlElement, DMV.InsetMarginKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMV.InsetMarginKind>(openXmlElement?.InsetMode?.Value, value, diffs, objName);
  }
  
  private static void SetInsetMode(DXV.Curve openXmlElement, DMV.InsetMarginKind? value)
  {
    openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMV.InsetMarginKind>(value);
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  private static Boolean? GetFilled(DXV.Curve openXmlElement)
  {
    return openXmlElement?.Filled?.Value;
  }
  
  private static bool CmpFilled(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Filled?.Value == value) return true;
    diffs?.Add(objName, "Filled", openXmlElement?.Filled?.Value, value);
    return false;
  }
  
  private static void SetFilled(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Filled = value;
    else
      openXmlElement.Filled = null;
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  private static String? GetFillColor(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FillColor);
  }
  
  private static bool CmpFillColor(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FillColor, value, diffs, objName, "FillColor");
  }
  
  private static void SetFillColor(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.FillColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  private static Boolean? GetStroked(DXV.Curve openXmlElement)
  {
    return openXmlElement?.Stroked?.Value;
  }
  
  private static bool CmpStroked(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Stroked?.Value == value) return true;
    diffs?.Add(objName, "Stroked", openXmlElement?.Stroked?.Value, value);
    return false;
  }
  
  private static void SetStroked(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Stroked = value;
    else
      openXmlElement.Stroked = null;
  }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  private static String? GetStrokeColor(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.StrokeColor);
  }
  
  private static bool CmpStrokeColor(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.StrokeColor, value, diffs, objName, "StrokeColor");
  }
  
  private static void SetStrokeColor(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.StrokeColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Stroke Weight
  /// </summary>
  private static String? GetStrokeWeight(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.StrokeWeight);
  }
  
  private static bool CmpStrokeWeight(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.StrokeWeight, value, diffs, objName, "StrokeWeight");
  }
  
  private static void SetStrokeWeight(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.StrokeWeight = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  private static Boolean? GetInsetPen(DXV.Curve openXmlElement)
  {
    return openXmlElement?.InsetPen?.Value;
  }
  
  private static bool CmpInsetPen(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsetPen?.Value == value) return true;
    diffs?.Add(objName, "InsetPen", openXmlElement?.InsetPen?.Value, value);
    return false;
  }
  
  private static void SetInsetPen(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InsetPen = value;
    else
      openXmlElement.InsetPen = null;
  }
  
  /// <summary>
  /// Optional Number
  /// </summary>
  private static Int32? GetOptionalNumber(DXV.Curve openXmlElement)
  {
    return openXmlElement?.OptionalNumber?.Value;
  }
  
  private static bool CmpOptionalNumber(DXV.Curve openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.OptionalNumber?.Value == value) return true;
    diffs?.Add(objName, "OptionalNumber", openXmlElement?.OptionalNumber?.Value, value);
    return false;
  }
  
  private static void SetOptionalNumber(DXV.Curve openXmlElement, Int32? value)
  {
    openXmlElement.OptionalNumber = value;
  }
  
  /// <summary>
  /// Shape Connector Type
  /// </summary>
  private static DMV.ConnectorKind? GetConnectorType(DXV.Curve openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMV.ConnectorKind>(openXmlElement?.ConnectorType?.Value);
  }
  
  private static bool CmpConnectorType(DXV.Curve openXmlElement, DMV.ConnectorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMV.ConnectorKind>(openXmlElement?.ConnectorType?.Value, value, diffs, objName);
  }
  
  private static void SetConnectorType(DXV.Curve openXmlElement, DMV.ConnectorKind? value)
  {
    openXmlElement.ConnectorType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMV.ConnectorKind>(value);
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  private static DMV.BlackAndWhiteMode? GetBlackWhiteMode(DXV.Curve openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static bool CmpBlackWhiteMode(DXV.Curve openXmlElement, DMV.BlackAndWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value, value, diffs, objName);
  }
  
  private static void SetBlackWhiteMode(DXV.Curve openXmlElement, DMV.BlackAndWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  private static DMV.BlackAndWhiteMode? GetPureBlackWhiteMode(DXV.Curve openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value);
  }
  
  private static bool CmpPureBlackWhiteMode(DXV.Curve openXmlElement, DMV.BlackAndWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value, value, diffs, objName);
  }
  
  private static void SetPureBlackWhiteMode(DXV.Curve openXmlElement, DMV.BlackAndWhiteMode? value)
  {
    openXmlElement.PureBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  private static DMV.BlackAndWhiteMode? GetNormalBlackWhiteMode(DXV.Curve openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value);
  }
  
  private static bool CmpNormalBlackWhiteMode(DXV.Curve openXmlElement, DMV.BlackAndWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value, value, diffs, objName);
  }
  
  private static void SetNormalBlackWhiteMode(DXV.Curve openXmlElement, DMV.BlackAndWhiteMode? value)
  {
    openXmlElement.NormalBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  private static Boolean? GetForceDash(DXV.Curve openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }
  
  private static bool CmpForceDash(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ForceDash?.Value == value) return true;
    diffs?.Add(objName, "ForceDash", openXmlElement?.ForceDash?.Value, value);
    return false;
  }
  
  private static void SetForceDash(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceDash = value;
    else
      openXmlElement.ForceDash = null;
  }
  
  /// <summary>
  /// Embedded Object Icon Toggle
  /// </summary>
  private static Boolean? GetOleIcon(DXV.Curve openXmlElement)
  {
    return openXmlElement?.OleIcon?.Value;
  }
  
  private static bool CmpOleIcon(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.OleIcon?.Value == value) return true;
    diffs?.Add(objName, "OleIcon", openXmlElement?.OleIcon?.Value, value);
    return false;
  }
  
  private static void SetOleIcon(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.OleIcon = value;
    else
      openXmlElement.OleIcon = null;
  }
  
  /// <summary>
  /// Embedded Object Toggle
  /// </summary>
  private static Boolean? GetOle(DXV.Curve openXmlElement)
  {
    return openXmlElement?.Ole?.Value;
  }
  
  private static bool CmpOle(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Ole?.Value == value) return true;
    diffs?.Add(objName, "Ole", openXmlElement?.Ole?.Value, value);
    return false;
  }
  
  private static void SetOle(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Ole = value;
    else
      openXmlElement.Ole = null;
  }
  
  /// <summary>
  /// Relative Resize Toggle
  /// </summary>
  private static Boolean? GetPreferRelative(DXV.Curve openXmlElement)
  {
    return openXmlElement?.PreferRelative?.Value;
  }
  
  private static bool CmpPreferRelative(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PreferRelative?.Value == value) return true;
    diffs?.Add(objName, "PreferRelative", openXmlElement?.PreferRelative?.Value, value);
    return false;
  }
  
  private static void SetPreferRelative(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.PreferRelative = value;
    else
      openXmlElement.PreferRelative = null;
  }
  
  /// <summary>
  /// Clip to Wrapping Polygon
  /// </summary>
  private static Boolean? GetClipToWrap(DXV.Curve openXmlElement)
  {
    return openXmlElement?.ClipToWrap?.Value;
  }
  
  private static bool CmpClipToWrap(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ClipToWrap?.Value == value) return true;
    diffs?.Add(objName, "ClipToWrap", openXmlElement?.ClipToWrap?.Value, value);
    return false;
  }
  
  private static void SetClipToWrap(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ClipToWrap = value;
    else
      openXmlElement.ClipToWrap = null;
  }
  
  /// <summary>
  /// Clipping Toggle
  /// </summary>
  private static Boolean? GetClip(DXV.Curve openXmlElement)
  {
    return openXmlElement?.Clip?.Value;
  }
  
  private static bool CmpClip(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Clip?.Value == value) return true;
    diffs?.Add(objName, "Clip", openXmlElement?.Clip?.Value, value);
    return false;
  }
  
  private static void SetClip(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Clip = value;
    else
      openXmlElement.Clip = null;
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  private static DM.Base64Binary? GetGfxdata(DXV.Curve openXmlElement)
  {
    if (openXmlElement?.Gfxdata?.Value != null)
      return Convert.FromBase64String(openXmlElement.Gfxdata.Value);
    return null;
  }
  
  private static bool CmpGfxdata(DXV.Curve openXmlElement, DM.Base64Binary? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Gfxdata?.Value != null && value != null)
      if (Convert.FromBase64String(openXmlElement.Gfxdata.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement?.Gfxdata?.Value == null && value == null) return true;
    diffs?.Add(objName, "Gfxdata", openXmlElement?.Gfxdata?.Value, value);
    return false;
  }
  
  private static void SetGfxdata(DXV.Curve openXmlElement, DM.Base64Binary? value)
  {
    if (value != null)
      openXmlElement.Gfxdata = Convert.ToBase64String(value);
    else
      openXmlElement.Gfxdata = null;
  }
  
  /// <summary>
  /// Curve Starting Point
  /// </summary>
  private static String? GetFrom(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.From);
  }
  
  private static bool CmpFrom(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.From, value, diffs, objName, "From");
  }
  
  private static void SetFrom(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.From = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// First Curve Control Point
  /// </summary>
  private static String? GetControl1(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Control1);
  }
  
  private static bool CmpControl1(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Control1, value, diffs, objName, "Control1");
  }
  
  private static void SetControl1(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.Control1 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Second Curve Control Point
  /// </summary>
  private static String? GetControl2(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Control2);
  }
  
  private static bool CmpControl2(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Control2, value, diffs, objName, "Control2");
  }
  
  private static void SetControl2(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.Control2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Curve Ending Point
  /// </summary>
  private static String? GetTo(DXV.Curve openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.To);
  }
  
  private static bool CmpTo(DXV.Curve openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.To, value, diffs, objName, "To");
  }
  
  private static void SetTo(DXV.Curve openXmlElement, String? value)
  {
    openXmlElement.To = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMV.Path? GetPath(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Path>();
    if (element != null)
      return DMXV.PathConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPath(DXV.Curve openXmlElement, DMV.Path? value, DiffList? diffs, string? objName)
  {
    return DMXV.PathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Path>(), value, diffs, objName);
  }
  
  private static void SetPath(DXV.Curve openXmlElement, DMV.Path? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Path>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.PathConverter.CreateOpenXmlElement<DXV.Path>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.Formulas? GetFormulas(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Formulas>();
    if (element != null)
      return DMXV.FormulasConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFormulas(DXV.Curve openXmlElement, DMV.Formulas? value, DiffList? diffs, string? objName)
  {
    return DMXV.FormulasConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Formulas>(), value, diffs, objName);
  }
  
  private static void SetFormulas(DXV.Curve openXmlElement, DMV.Formulas? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Formulas>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.FormulasConverter.CreateOpenXmlElement<DXV.Formulas>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.ShapeHandles? GetShapeHandles(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.ShapeHandles>();
    if (element != null)
      return DMXV.ShapeHandlesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeHandles(DXV.Curve openXmlElement, DMV.ShapeHandles? value, DiffList? diffs, string? objName)
  {
    return DMXV.ShapeHandlesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.ShapeHandles>(), value, diffs, objName);
  }
  
  private static void SetShapeHandles(DXV.Curve openXmlElement, DMV.ShapeHandles? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.ShapeHandles>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ShapeHandlesConverter.CreateOpenXmlElement<DXV.ShapeHandles>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.Fill? GetFill(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Fill>();
    if (element != null)
      return DMXV.FillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFill(DXV.Curve openXmlElement, DMV.Fill? value, DiffList? diffs, string? objName)
  {
    return DMXV.FillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Fill>(), value, diffs, objName);
  }
  
  private static void SetFill(DXV.Curve openXmlElement, DMV.Fill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Fill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.FillConverter.CreateOpenXmlElement<DXV.Fill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.Stroke? GetStroke(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Stroke>();
    if (element != null)
      return DMXV.StrokeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStroke(DXV.Curve openXmlElement, DMV.Stroke? value, DiffList? diffs, string? objName)
  {
    return DMXV.StrokeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Stroke>(), value, diffs, objName);
  }
  
  private static void SetStroke(DXV.Curve openXmlElement, DMV.Stroke? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Stroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.StrokeConverter.CreateOpenXmlElement<DXV.Stroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.Shadow? GetShadow(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Shadow>();
    if (element != null)
      return DMXV.ShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShadow(DXV.Curve openXmlElement, DMV.Shadow? value, DiffList? diffs, string? objName)
  {
    return DMXV.ShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Shadow>(), value, diffs, objName);
  }
  
  private static void SetShadow(DXV.Curve openXmlElement, DMV.Shadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Shadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ShadowConverter.CreateOpenXmlElement<DXV.Shadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.TextBox? GetTextBox(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.TextBox>();
    if (element != null)
      return DMXV.TextBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextBox(DXV.Curve openXmlElement, DMV.TextBox? value, DiffList? diffs, string? objName)
  {
    return DMXV.TextBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.TextBox>(), value, diffs, objName);
  }
  
  private static void SetTextBox(DXV.Curve openXmlElement, DMV.TextBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.TextBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.TextBoxConverter.CreateOpenXmlElement<DXV.TextBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.TextPath? GetTextPath(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.TextPath>();
    if (element != null)
      return DMXV.TextPathConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextPath(DXV.Curve openXmlElement, DMV.TextPath? value, DiffList? diffs, string? objName)
  {
    return DMXV.TextPathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.TextPath>(), value, diffs, objName);
  }
  
  private static void SetTextPath(DXV.Curve openXmlElement, DMV.TextPath? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.TextPath>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.TextPathConverter.CreateOpenXmlElement<DXV.TextPath>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.ImageData? GetImageData(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.ImageData>();
    if (element != null)
      return DMXV.ImageDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageData(DXV.Curve openXmlElement, DMV.ImageData? value, DiffList? diffs, string? objName)
  {
    return DMXV.ImageDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.ImageData>(), value, diffs, objName);
  }
  
  private static void SetImageData(DXV.Curve openXmlElement, DMV.ImageData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.ImageData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ImageDataConverter.CreateOpenXmlElement<DXV.ImageData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.Skew? GetSkew(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.Skew>();
    if (element != null)
      return DMXV.SkewConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSkew(DXV.Curve openXmlElement, DMV.Skew? value, DiffList? diffs, string? objName)
  {
    return DMXV.SkewConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.Skew>(), value, diffs, objName);
  }
  
  private static void SetSkew(DXV.Curve openXmlElement, DMV.Skew? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.Skew>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.SkewConverter.CreateOpenXmlElement<DXVO.Skew>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.Extrusion? GetExtrusion(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.Extrusion>();
    if (element != null)
      return DMXV.ExtrusionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtrusion(DXV.Curve openXmlElement, DMV.Extrusion? value, DiffList? diffs, string? objName)
  {
    return DMXV.ExtrusionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.Extrusion>(), value, diffs, objName);
  }
  
  private static void SetExtrusion(DXV.Curve openXmlElement, DMV.Extrusion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.Extrusion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ExtrusionConverter.CreateOpenXmlElement<DXVO.Extrusion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.Callout? GetCallout(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.Callout>();
    if (element != null)
      return DMXV.CalloutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCallout(DXV.Curve openXmlElement, DMV.Callout? value, DiffList? diffs, string? objName)
  {
    return DMXV.CalloutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.Callout>(), value, diffs, objName);
  }
  
  private static void SetCallout(DXV.Curve openXmlElement, DMV.Callout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.Callout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.CalloutConverter.CreateOpenXmlElement<DXVO.Callout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.Lock? GetLock(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.Lock>();
    if (element != null)
      return DMXV.LockConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLock(DXV.Curve openXmlElement, DMV.Lock? value, DiffList? diffs, string? objName)
  {
    return DMXV.LockConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.Lock>(), value, diffs, objName);
  }
  
  private static void SetLock(DXV.Curve openXmlElement, DMV.Lock? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.Lock>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.LockConverter.CreateOpenXmlElement<DXVO.Lock>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.ClipPath? GetClipPath(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.ClipPath>();
    if (element != null)
      return DMXV.ClipPathConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpClipPath(DXV.Curve openXmlElement, DMV.ClipPath? value, DiffList? diffs, string? objName)
  {
    return DMXV.ClipPathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.ClipPath>(), value, diffs, objName);
  }
  
  private static void SetClipPath(DXV.Curve openXmlElement, DMV.ClipPath? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.ClipPath>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ClipPathConverter.CreateOpenXmlElement<DXVO.ClipPath>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMV.SignatureLine? GetSignatureLine(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.SignatureLine>();
    if (element != null)
      return DMXV.SignatureLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSignatureLine(DXV.Curve openXmlElement, DMV.SignatureLine? value, DiffList? diffs, string? objName)
  {
    return DMXV.SignatureLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.SignatureLine>(), value, diffs, objName);
  }
  
  private static void SetSignatureLine(DXV.Curve openXmlElement, DMV.SignatureLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.SignatureLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.SignatureLineConverter.CreateOpenXmlElement<DXVO.SignatureLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMWV.TextWrap? GetTextWrap(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVW.TextWrap>();
    if (element != null)
      return DMXWV.TextWrapConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextWrap(DXV.Curve openXmlElement, DMWV.TextWrap? value, DiffList? diffs, string? objName)
  {
    return DMXWV.TextWrapConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVW.TextWrap>(), value, diffs, objName);
  }
  
  private static void SetTextWrap(DXV.Curve openXmlElement, DMWV.TextWrap? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVW.TextWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWV.TextWrapConverter.CreateOpenXmlElement<DXVW.TextWrap>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAnchorLock(DXV.Curve openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXVW.AnchorLock>() != null;
  }
  
  private static bool CmpAnchorLock(DXV.Curve openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXVW.AnchorLock>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXVW.AnchorLock", val, value);
    return false;
  }
  
  private static void SetAnchorLock(DXV.Curve openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXVW.AnchorLock>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXVW.AnchorLock();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMWV.BorderType? GetTopBorder(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVW.TopBorder>();
    if (element != null)
      return DMXWV.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTopBorder(DXV.Curve openXmlElement, DMWV.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXWV.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVW.TopBorder>(), value, diffs, objName);
  }
  
  private static void SetTopBorder(DXV.Curve openXmlElement, DMWV.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVW.TopBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWV.BorderTypeConverter.CreateOpenXmlElement<DXVW.TopBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMWV.BorderType? GetBottomBorder(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVW.BottomBorder>();
    if (element != null)
      return DMXWV.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBottomBorder(DXV.Curve openXmlElement, DMWV.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXWV.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVW.BottomBorder>(), value, diffs, objName);
  }
  
  private static void SetBottomBorder(DXV.Curve openXmlElement, DMWV.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVW.BottomBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWV.BorderTypeConverter.CreateOpenXmlElement<DXVW.BottomBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMWV.BorderType? GetLeftBorder(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVW.LeftBorder>();
    if (element != null)
      return DMXWV.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLeftBorder(DXV.Curve openXmlElement, DMWV.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXWV.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVW.LeftBorder>(), value, diffs, objName);
  }
  
  private static void SetLeftBorder(DXV.Curve openXmlElement, DMWV.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVW.LeftBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWV.BorderTypeConverter.CreateOpenXmlElement<DXVW.LeftBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMWV.BorderType? GetRightBorder(DXV.Curve openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVW.RightBorder>();
    if (element != null)
      return DMXWV.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRightBorder(DXV.Curve openXmlElement, DMWV.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXWV.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVW.RightBorder>(), value, diffs, objName);
  }
  
  private static void SetRightBorder(DXV.Curve openXmlElement, DMWV.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVW.RightBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWV.BorderTypeConverter.CreateOpenXmlElement<DXVW.RightBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.Curve? CreateModelElement(DXV.Curve? openXmlElement)
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
  
  public static bool CompareModelElement(DXV.Curve? openXmlElement, DMV.Curve? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Curve value)
    where OpenXmlElementType: DXV.Curve, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXV.Curve openXmlElement, DMV.Curve value)
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

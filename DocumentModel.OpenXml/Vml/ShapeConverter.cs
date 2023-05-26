namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Definition.
/// </summary>
public static class ShapeConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  private static String? GetStyle(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Style);
  }
  
  private static bool CmpStyle(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Style, value, diffs, objName, "Style");
  }
  
  private static void SetStyle(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.Style = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  private static String? GetHref(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Href);
  }
  
  private static bool CmpHref(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Href, value, diffs, objName, "Href");
  }
  
  private static void SetHref(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.Href = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Hyperlink Display Target
  /// </summary>
  private static String? GetTarget(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Target);
  }
  
  private static bool CmpTarget(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Target, value, diffs, objName, "Target");
  }
  
  private static void SetTarget(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.Target = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// CSS Reference
  /// </summary>
  private static String? GetClass(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Class);
  }
  
  private static bool CmpClass(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Class, value, diffs, objName, "Class");
  }
  
  private static void SetClass(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.Class = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  private static String? GetTitle(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Title);
  }
  
  private static bool CmpTitle(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Title, value, diffs, objName, "Title");
  }
  
  private static void SetTitle(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.Title = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Alternate Text
  /// </summary>
  private static String? GetAlternate(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Alternate);
  }
  
  private static bool CmpAlternate(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Alternate, value, diffs, objName, "Alternate");
  }
  
  private static void SetAlternate(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.Alternate = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Coordinate Space Size
  /// </summary>
  private static String? GetCoordinateSize(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CoordinateSize);
  }
  
  private static bool CmpCoordinateSize(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CoordinateSize, value, diffs, objName, "CoordinateSize");
  }
  
  private static void SetCoordinateSize(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.CoordinateSize = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Coordinate Space Origin
  /// </summary>
  private static String? GetCoordinateOrigin(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CoordinateOrigin);
  }
  
  private static bool CmpCoordinateOrigin(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CoordinateOrigin, value, diffs, objName, "CoordinateOrigin");
  }
  
  private static void SetCoordinateOrigin(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.CoordinateOrigin = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  private static String? GetWrapCoordinates(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.WrapCoordinates);
  }
  
  private static bool CmpWrapCoordinates(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.WrapCoordinates, value, diffs, objName, "WrapCoordinates");
  }
  
  private static void SetWrapCoordinates(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.WrapCoordinates = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  private static Boolean? GetPrint(DXV.Shape openXmlElement)
  {
    return openXmlElement?.Print?.Value;
  }
  
  private static bool CmpPrint(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Print?.Value == value) return true;
    diffs?.Add(objName, "Print", openXmlElement?.Print?.Value, value);
    return false;
  }
  
  private static void SetPrint(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Print = value;
    else
      openXmlElement.Print = null;
  }
  
  /// <summary>
  /// Optional String
  /// </summary>
  private static String? GetOptionalString(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.OptionalString);
  }
  
  private static bool CmpOptionalString(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.OptionalString, value, diffs, objName, "OptionalString");
  }
  
  private static void SetOptionalString(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.OptionalString = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Handle Toggle
  /// </summary>
  private static Boolean? GetOned(DXV.Shape openXmlElement)
  {
    return openXmlElement?.Oned?.Value;
  }
  
  private static bool CmpOned(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Oned?.Value == value) return true;
    diffs?.Add(objName, "Oned", openXmlElement?.Oned?.Value, value);
    return false;
  }
  
  private static void SetOned(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Oned = value;
    else
      openXmlElement.Oned = null;
  }
  
  /// <summary>
  /// Regroup ID
  /// </summary>
  private static Int64? GetRegroupId(DXV.Shape openXmlElement)
  {
    return openXmlElement?.RegroupId?.Value;
  }
  
  private static bool CmpRegroupId(DXV.Shape openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RegroupId?.Value == value) return true;
    diffs?.Add(objName, "RegroupId", openXmlElement?.RegroupId?.Value, value);
    return false;
  }
  
  private static void SetRegroupId(DXV.Shape openXmlElement, Int64? value)
  {
    openXmlElement.RegroupId = value;
  }
  
  /// <summary>
  /// Double-click Notification Toggle
  /// </summary>
  private static Boolean? GetDoubleClickNotify(DXV.Shape openXmlElement)
  {
    return openXmlElement?.DoubleClickNotify?.Value;
  }
  
  private static bool CmpDoubleClickNotify(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DoubleClickNotify?.Value == value) return true;
    diffs?.Add(objName, "DoubleClickNotify", openXmlElement?.DoubleClickNotify?.Value, value);
    return false;
  }
  
  private static void SetDoubleClickNotify(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DoubleClickNotify = value;
    else
      openXmlElement.DoubleClickNotify = null;
  }
  
  /// <summary>
  /// Button Behavior Toggle
  /// </summary>
  private static Boolean? GetButton(DXV.Shape openXmlElement)
  {
    return openXmlElement?.Button?.Value;
  }
  
  private static bool CmpButton(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Button?.Value == value) return true;
    diffs?.Add(objName, "Button", openXmlElement?.Button?.Value, value);
    return false;
  }
  
  private static void SetButton(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Button = value;
    else
      openXmlElement.Button = null;
  }
  
  /// <summary>
  /// Hide Script Anchors
  /// </summary>
  private static Boolean? GetUserHidden(DXV.Shape openXmlElement)
  {
    return openXmlElement?.UserHidden?.Value;
  }
  
  private static bool CmpUserHidden(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.UserHidden?.Value == value) return true;
    diffs?.Add(objName, "UserHidden", openXmlElement?.UserHidden?.Value, value);
    return false;
  }
  
  private static void SetUserHidden(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserHidden = value;
    else
      openXmlElement.UserHidden = null;
  }
  
  /// <summary>
  /// Graphical Bullet
  /// </summary>
  private static Boolean? GetBullet(DXV.Shape openXmlElement)
  {
    return openXmlElement?.Bullet?.Value;
  }
  
  private static bool CmpBullet(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Bullet?.Value == value) return true;
    diffs?.Add(objName, "Bullet", openXmlElement?.Bullet?.Value, value);
    return false;
  }
  
  private static void SetBullet(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Bullet = value;
    else
      openXmlElement.Bullet = null;
  }
  
  /// <summary>
  /// Horizontal Rule Toggle
  /// </summary>
  private static Boolean? GetHorizontal(DXV.Shape openXmlElement)
  {
    return openXmlElement?.Horizontal?.Value;
  }
  
  private static bool CmpHorizontal(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Horizontal?.Value == value) return true;
    diffs?.Add(objName, "Horizontal", openXmlElement?.Horizontal?.Value, value);
    return false;
  }
  
  private static void SetHorizontal(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Horizontal = value;
    else
      openXmlElement.Horizontal = null;
  }
  
  /// <summary>
  /// Horizontal Rule Standard Display Toggle
  /// </summary>
  private static Boolean? GetHorizontalStandard(DXV.Shape openXmlElement)
  {
    return openXmlElement?.HorizontalStandard?.Value;
  }
  
  private static bool CmpHorizontalStandard(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.HorizontalStandard?.Value == value) return true;
    diffs?.Add(objName, "HorizontalStandard", openXmlElement?.HorizontalStandard?.Value, value);
    return false;
  }
  
  private static void SetHorizontalStandard(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalStandard = value;
    else
      openXmlElement.HorizontalStandard = null;
  }
  
  /// <summary>
  /// Horizontal Rule 3D Shading Toggle
  /// </summary>
  private static Boolean? GetHorizontalNoShade(DXV.Shape openXmlElement)
  {
    return openXmlElement?.HorizontalNoShade?.Value;
  }
  
  private static bool CmpHorizontalNoShade(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.HorizontalNoShade?.Value == value) return true;
    diffs?.Add(objName, "HorizontalNoShade", openXmlElement?.HorizontalNoShade?.Value, value);
    return false;
  }
  
  private static void SetHorizontalNoShade(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalNoShade = value;
    else
      openXmlElement.HorizontalNoShade = null;
  }
  
  /// <summary>
  /// Horizontal Rule Length Percentage
  /// </summary>
  private static Single? GetHorizontalPercentage(DXV.Shape openXmlElement)
  {
    return openXmlElement?.HorizontalPercentage?.Value;
  }
  
  private static bool CmpHorizontalPercentage(DXV.Shape openXmlElement, Single? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.HorizontalPercentage?.Value == value) return true;
    diffs?.Add(objName, "HorizontalPercentage", openXmlElement?.HorizontalPercentage?.Value, value);
    return false;
  }
  
  private static void SetHorizontalPercentage(DXV.Shape openXmlElement, Single? value)
  {
    openXmlElement.HorizontalPercentage = value;
  }
  
  /// <summary>
  /// Horizontal Rule Alignment
  /// </summary>
  private static DMV.HorizontalRuleAlignmentKind? GetHorizontalAlignment(DXV.Shape openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMV.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value);
  }
  
  private static bool CmpHorizontalAlignment(DXV.Shape openXmlElement, DMV.HorizontalRuleAlignmentKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMV.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value, value, diffs, objName, propName);
  }
  
  private static void SetHorizontalAlignment(DXV.Shape openXmlElement, DMV.HorizontalRuleAlignmentKind? value)
  {
    openXmlElement.HorizontalAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMV.HorizontalRuleAlignmentKind>(value);
  }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  private static Boolean? GetAllowInCell(DXV.Shape openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }
  
  private static bool CmpAllowInCell(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.AllowInCell?.Value == value) return true;
    diffs?.Add(objName, "AllowInCell", openXmlElement?.AllowInCell?.Value, value);
    return false;
  }
  
  private static void SetAllowInCell(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowInCell = value;
    else
      openXmlElement.AllowInCell = null;
  }
  
  /// <summary>
  /// Allow Shape Overlap
  /// </summary>
  private static Boolean? GetAllowOverlap(DXV.Shape openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  private static bool CmpAllowOverlap(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.AllowOverlap?.Value == value) return true;
    diffs?.Add(objName, "AllowOverlap", openXmlElement?.AllowOverlap?.Value, value);
    return false;
  }
  
  private static void SetAllowOverlap(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowOverlap = value;
    else
      openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// Exists In Master Slide
  /// </summary>
  private static Boolean? GetUserDrawn(DXV.Shape openXmlElement)
  {
    return openXmlElement?.UserDrawn?.Value;
  }
  
  private static bool CmpUserDrawn(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.UserDrawn?.Value == value) return true;
    diffs?.Add(objName, "UserDrawn", openXmlElement?.UserDrawn?.Value, value);
    return false;
  }
  
  private static void SetUserDrawn(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserDrawn = value;
    else
      openXmlElement.UserDrawn = null;
  }
  
  /// <summary>
  /// Border Top Color
  /// </summary>
  private static String? GetBorderTopColor(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.BorderTopColor);
  }
  
  private static bool CmpBorderTopColor(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.BorderTopColor, value, diffs, objName, "BorderTopColor");
  }
  
  private static void SetBorderTopColor(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.BorderTopColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Border Left Color
  /// </summary>
  private static String? GetBorderLeftColor(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.BorderLeftColor);
  }
  
  private static bool CmpBorderLeftColor(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.BorderLeftColor, value, diffs, objName, "BorderLeftColor");
  }
  
  private static void SetBorderLeftColor(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.BorderLeftColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Bottom Border Color
  /// </summary>
  private static String? GetBorderBottomColor(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.BorderBottomColor);
  }
  
  private static bool CmpBorderBottomColor(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.BorderBottomColor, value, diffs, objName, "BorderBottomColor");
  }
  
  private static void SetBorderBottomColor(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.BorderBottomColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Border Right Color
  /// </summary>
  private static String? GetBorderRightColor(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.BorderRightColor);
  }
  
  private static bool CmpBorderRightColor(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.BorderRightColor, value, diffs, objName, "BorderRightColor");
  }
  
  private static void SetBorderRightColor(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.BorderRightColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Diagram Node Layout Identifier
  /// </summary>
  private static Int64? GetDiagramLayout(DXV.Shape openXmlElement)
  {
    return openXmlElement?.DiagramLayout?.Value;
  }
  
  private static bool CmpDiagramLayout(DXV.Shape openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DiagramLayout?.Value == value) return true;
    diffs?.Add(objName, "DiagramLayout", openXmlElement?.DiagramLayout?.Value, value);
    return false;
  }
  
  private static void SetDiagramLayout(DXV.Shape openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayout = value;
  }
  
  /// <summary>
  /// Diagram Node Identifier
  /// </summary>
  private static Int64? GetDiagramNodeKind(DXV.Shape openXmlElement)
  {
    return openXmlElement?.DiagramNodeKind?.Value;
  }
  
  private static bool CmpDiagramNodeKind(DXV.Shape openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DiagramNodeKind?.Value == value) return true;
    diffs?.Add(objName, "DiagramNodeKind", openXmlElement?.DiagramNodeKind?.Value, value);
    return false;
  }
  
  private static void SetDiagramNodeKind(DXV.Shape openXmlElement, Int64? value)
  {
    openXmlElement.DiagramNodeKind = value;
  }
  
  /// <summary>
  /// Diagram Node Recent Layout Identifier
  /// </summary>
  private static Int64? GetDiagramLayoutMostRecentUsed(DXV.Shape openXmlElement)
  {
    return openXmlElement?.DiagramLayoutMostRecentUsed?.Value;
  }
  
  private static bool CmpDiagramLayoutMostRecentUsed(DXV.Shape openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DiagramLayoutMostRecentUsed?.Value == value) return true;
    diffs?.Add(objName, "DiagramLayoutMostRecentUsed", openXmlElement?.DiagramLayoutMostRecentUsed?.Value, value);
    return false;
  }
  
  private static void SetDiagramLayoutMostRecentUsed(DXV.Shape openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayoutMostRecentUsed = value;
  }
  
  /// <summary>
  /// Text Inset Mode
  /// </summary>
  private static DMV.InsetMarginKind? GetInsetMode(DXV.Shape openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMV.InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }
  
  private static bool CmpInsetMode(DXV.Shape openXmlElement, DMV.InsetMarginKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMV.InsetMarginKind>(openXmlElement?.InsetMode?.Value, value, diffs, objName, propName);
  }
  
  private static void SetInsetMode(DXV.Shape openXmlElement, DMV.InsetMarginKind? value)
  {
    openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMV.InsetMarginKind>(value);
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  private static Boolean? GetFilled(DXV.Shape openXmlElement)
  {
    return openXmlElement?.Filled?.Value;
  }
  
  private static bool CmpFilled(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Filled?.Value == value) return true;
    diffs?.Add(objName, "Filled", openXmlElement?.Filled?.Value, value);
    return false;
  }
  
  private static void SetFilled(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Filled = value;
    else
      openXmlElement.Filled = null;
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  private static String? GetFillColor(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FillColor);
  }
  
  private static bool CmpFillColor(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FillColor, value, diffs, objName, "FillColor");
  }
  
  private static void SetFillColor(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.FillColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  private static Boolean? GetStroked(DXV.Shape openXmlElement)
  {
    return openXmlElement?.Stroked?.Value;
  }
  
  private static bool CmpStroked(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Stroked?.Value == value) return true;
    diffs?.Add(objName, "Stroked", openXmlElement?.Stroked?.Value, value);
    return false;
  }
  
  private static void SetStroked(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Stroked = value;
    else
      openXmlElement.Stroked = null;
  }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  private static String? GetStrokeColor(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.StrokeColor);
  }
  
  private static bool CmpStrokeColor(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.StrokeColor, value, diffs, objName, "StrokeColor");
  }
  
  private static void SetStrokeColor(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.StrokeColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Stroke Weight
  /// </summary>
  private static String? GetStrokeWeight(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.StrokeWeight);
  }
  
  private static bool CmpStrokeWeight(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.StrokeWeight, value, diffs, objName, "StrokeWeight");
  }
  
  private static void SetStrokeWeight(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.StrokeWeight = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  private static Boolean? GetInsetPen(DXV.Shape openXmlElement)
  {
    return openXmlElement?.InsetPen?.Value;
  }
  
  private static bool CmpInsetPen(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.InsetPen?.Value == value) return true;
    diffs?.Add(objName, "InsetPen", openXmlElement?.InsetPen?.Value, value);
    return false;
  }
  
  private static void SetInsetPen(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InsetPen = value;
    else
      openXmlElement.InsetPen = null;
  }
  
  /// <summary>
  /// Optional Number
  /// </summary>
  private static Int32? GetOptionalNumber(DXV.Shape openXmlElement)
  {
    return openXmlElement?.OptionalNumber?.Value;
  }
  
  private static bool CmpOptionalNumber(DXV.Shape openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.OptionalNumber?.Value == value) return true;
    diffs?.Add(objName, "OptionalNumber", openXmlElement?.OptionalNumber?.Value, value);
    return false;
  }
  
  private static void SetOptionalNumber(DXV.Shape openXmlElement, Int32? value)
  {
    openXmlElement.OptionalNumber = value;
  }
  
  /// <summary>
  /// Shape Connector Type
  /// </summary>
  private static DMV.ConnectorKind? GetConnectorType(DXV.Shape openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMV.ConnectorKind>(openXmlElement?.ConnectorType?.Value);
  }
  
  private static bool CmpConnectorType(DXV.Shape openXmlElement, DMV.ConnectorKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMV.ConnectorKind>(openXmlElement?.ConnectorType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetConnectorType(DXV.Shape openXmlElement, DMV.ConnectorKind? value)
  {
    openXmlElement.ConnectorType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMV.ConnectorKind>(value);
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  private static DMV.BlackAndWhiteMode? GetBlackWhiteMode(DXV.Shape openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static bool CmpBlackWhiteMode(DXV.Shape openXmlElement, DMV.BlackAndWhiteMode? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value, value, diffs, objName, propName);
  }
  
  private static void SetBlackWhiteMode(DXV.Shape openXmlElement, DMV.BlackAndWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  private static DMV.BlackAndWhiteMode? GetPureBlackWhiteMode(DXV.Shape openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value);
  }
  
  private static bool CmpPureBlackWhiteMode(DXV.Shape openXmlElement, DMV.BlackAndWhiteMode? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPureBlackWhiteMode(DXV.Shape openXmlElement, DMV.BlackAndWhiteMode? value)
  {
    openXmlElement.PureBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  private static DMV.BlackAndWhiteMode? GetNormalBlackWhiteMode(DXV.Shape openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value);
  }
  
  private static bool CmpNormalBlackWhiteMode(DXV.Shape openXmlElement, DMV.BlackAndWhiteMode? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value, value, diffs, objName, propName);
  }
  
  private static void SetNormalBlackWhiteMode(DXV.Shape openXmlElement, DMV.BlackAndWhiteMode? value)
  {
    openXmlElement.NormalBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMV.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  private static Boolean? GetForceDash(DXV.Shape openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }
  
  private static bool CmpForceDash(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ForceDash?.Value == value) return true;
    diffs?.Add(objName, "ForceDash", openXmlElement?.ForceDash?.Value, value);
    return false;
  }
  
  private static void SetForceDash(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceDash = value;
    else
      openXmlElement.ForceDash = null;
  }
  
  /// <summary>
  /// Embedded Object Icon Toggle
  /// </summary>
  private static Boolean? GetOleIcon(DXV.Shape openXmlElement)
  {
    return openXmlElement?.OleIcon?.Value;
  }
  
  private static bool CmpOleIcon(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.OleIcon?.Value == value) return true;
    diffs?.Add(objName, "OleIcon", openXmlElement?.OleIcon?.Value, value);
    return false;
  }
  
  private static void SetOleIcon(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.OleIcon = value;
    else
      openXmlElement.OleIcon = null;
  }
  
  /// <summary>
  /// Embedded Object Toggle
  /// </summary>
  private static Boolean? GetOle(DXV.Shape openXmlElement)
  {
    return openXmlElement?.Ole?.Value;
  }
  
  private static bool CmpOle(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Ole?.Value == value) return true;
    diffs?.Add(objName, "Ole", openXmlElement?.Ole?.Value, value);
    return false;
  }
  
  private static void SetOle(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Ole = value;
    else
      openXmlElement.Ole = null;
  }
  
  /// <summary>
  /// Relative Resize Toggle
  /// </summary>
  private static Boolean? GetPreferRelative(DXV.Shape openXmlElement)
  {
    return openXmlElement?.PreferRelative?.Value;
  }
  
  private static bool CmpPreferRelative(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.PreferRelative?.Value == value) return true;
    diffs?.Add(objName, "PreferRelative", openXmlElement?.PreferRelative?.Value, value);
    return false;
  }
  
  private static void SetPreferRelative(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.PreferRelative = value;
    else
      openXmlElement.PreferRelative = null;
  }
  
  /// <summary>
  /// Clip to Wrapping Polygon
  /// </summary>
  private static Boolean? GetClipToWrap(DXV.Shape openXmlElement)
  {
    return openXmlElement?.ClipToWrap?.Value;
  }
  
  private static bool CmpClipToWrap(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ClipToWrap?.Value == value) return true;
    diffs?.Add(objName, "ClipToWrap", openXmlElement?.ClipToWrap?.Value, value);
    return false;
  }
  
  private static void SetClipToWrap(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ClipToWrap = value;
    else
      openXmlElement.ClipToWrap = null;
  }
  
  /// <summary>
  /// Clipping Toggle
  /// </summary>
  private static Boolean? GetClip(DXV.Shape openXmlElement)
  {
    return openXmlElement?.Clip?.Value;
  }
  
  private static bool CmpClip(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Clip?.Value == value) return true;
    diffs?.Add(objName, "Clip", openXmlElement?.Clip?.Value, value);
    return false;
  }
  
  private static void SetClip(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Clip = value;
    else
      openXmlElement.Clip = null;
  }
  
  /// <summary>
  /// Shape Type Reference
  /// </summary>
  private static String? GetType(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Type);
  }
  
  private static bool CmpType(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Type, value, diffs, objName, "Type");
  }
  
  private static void SetType(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.Type = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Adjustment Parameters
  /// </summary>
  private static String? GetAdjustment(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Adjustment);
  }
  
  private static bool CmpAdjustment(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Adjustment, value, diffs, objName, "Adjustment");
  }
  
  private static void SetAdjustment(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.Adjustment = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Edge Path
  /// </summary>
  private static String? GetEdgePath(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.EdgePath);
  }
  
  private static bool CmpEdgePath(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.EdgePath, value, diffs, objName, "EdgePath");
  }
  
  private static void SetEdgePath(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.EdgePath = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  private static DM.Base64Binary? GetEncodedPackage(DXV.Shape openXmlElement)
  {
    if (openXmlElement?.EncodedPackage?.Value != null)
      return Convert.FromBase64String(openXmlElement.EncodedPackage.Value);
    return null;
  }
  
  private static bool CmpEncodedPackage(DXV.Shape openXmlElement, DM.Base64Binary? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.EncodedPackage?.Value != null && value != null)
      if (Convert.FromBase64String(openXmlElement.EncodedPackage.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement?.EncodedPackage?.Value == null && value == null) return true;
    diffs?.Add(objName, "EncodedPackage", openXmlElement?.EncodedPackage?.Value, value);
    return false;
  }
  
  private static void SetEncodedPackage(DXV.Shape openXmlElement, DM.Base64Binary? value)
  {
    if (value != null)
      openXmlElement.EncodedPackage = Convert.ToBase64String(value);
    else
      openXmlElement.EncodedPackage = null;
  }
  
  /// <summary>
  /// Storage for Alternate Math Content
  /// </summary>
  private static String? GetEquationXml(DXV.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.EquationXml);
  }
  
  private static bool CmpEquationXml(DXV.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.EquationXml, value, diffs, objName, "EquationXml");
  }
  
  private static void SetEquationXml(DXV.Shape openXmlElement, String? value)
  {
    openXmlElement.EquationXml = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMV.Path? GetPath(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Path>();
    if (element != null)
      return DMXV.PathConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPath(DXV.Shape openXmlElement, DMV.Path? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.PathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Path>(), value, diffs, objName, propName);
  }
  
  private static void SetPath(DXV.Shape openXmlElement, DMV.Path? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Path>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.PathConverter.CreateOpenXmlElement<DXV.Path>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Formulas? GetFormulas(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Formulas>();
    if (element != null)
      return DMXV.FormulasConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFormulas(DXV.Shape openXmlElement, DMV.Formulas? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.FormulasConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Formulas>(), value, diffs, objName, propName);
  }
  
  private static void SetFormulas(DXV.Shape openXmlElement, DMV.Formulas? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Formulas>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.FormulasConverter.CreateOpenXmlElement<DXV.Formulas>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.ShapeHandles? GetShapeHandles(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.ShapeHandles>();
    if (element != null)
      return DMXV.ShapeHandlesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeHandles(DXV.Shape openXmlElement, DMV.ShapeHandles? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.ShapeHandlesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.ShapeHandles>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeHandles(DXV.Shape openXmlElement, DMV.ShapeHandles? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.ShapeHandles>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ShapeHandlesConverter.CreateOpenXmlElement<DXV.ShapeHandles>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Fill? GetFill(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Fill>();
    if (element != null)
      return DMXV.FillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFill(DXV.Shape openXmlElement, DMV.Fill? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.FillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Fill>(), value, diffs, objName, propName);
  }
  
  private static void SetFill(DXV.Shape openXmlElement, DMV.Fill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Fill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.FillConverter.CreateOpenXmlElement<DXV.Fill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Stroke? GetStroke(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Stroke>();
    if (element != null)
      return DMXV.StrokeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStroke(DXV.Shape openXmlElement, DMV.Stroke? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.StrokeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Stroke>(), value, diffs, objName, propName);
  }
  
  private static void SetStroke(DXV.Shape openXmlElement, DMV.Stroke? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Stroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.StrokeConverter.CreateOpenXmlElement<DXV.Stroke>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Shadow? GetShadow(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Shadow>();
    if (element != null)
      return DMXV.ShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShadow(DXV.Shape openXmlElement, DMV.Shadow? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.ShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Shadow>(), value, diffs, objName, propName);
  }
  
  private static void SetShadow(DXV.Shape openXmlElement, DMV.Shadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Shadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ShadowConverter.CreateOpenXmlElement<DXV.Shadow>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.TextBox? GetTextBox(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.TextBox>();
    if (element != null)
      return DMXV.TextBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextBox(DXV.Shape openXmlElement, DMV.TextBox? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.TextBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.TextBox>(), value, diffs, objName, propName);
  }
  
  private static void SetTextBox(DXV.Shape openXmlElement, DMV.TextBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.TextBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.TextBoxConverter.CreateOpenXmlElement<DXV.TextBox>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.TextPath? GetTextPath(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.TextPath>();
    if (element != null)
      return DMXV.TextPathConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextPath(DXV.Shape openXmlElement, DMV.TextPath? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.TextPathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.TextPath>(), value, diffs, objName, propName);
  }
  
  private static void SetTextPath(DXV.Shape openXmlElement, DMV.TextPath? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.TextPath>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.TextPathConverter.CreateOpenXmlElement<DXV.TextPath>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.ImageData? GetImageData(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.ImageData>();
    if (element != null)
      return DMXV.ImageDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageData(DXV.Shape openXmlElement, DMV.ImageData? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.ImageDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.ImageData>(), value, diffs, objName, propName);
  }
  
  private static void SetImageData(DXV.Shape openXmlElement, DMV.ImageData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.ImageData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ImageDataConverter.CreateOpenXmlElement<DXV.ImageData>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Skew? GetSkew(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.Skew>();
    if (element != null)
      return DMXV.SkewConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSkew(DXV.Shape openXmlElement, DMV.Skew? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.SkewConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.Skew>(), value, diffs, objName, propName);
  }
  
  private static void SetSkew(DXV.Shape openXmlElement, DMV.Skew? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.Skew>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.SkewConverter.CreateOpenXmlElement<DXVO.Skew>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Extrusion? GetExtrusion(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.Extrusion>();
    if (element != null)
      return DMXV.ExtrusionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtrusion(DXV.Shape openXmlElement, DMV.Extrusion? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.ExtrusionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.Extrusion>(), value, diffs, objName, propName);
  }
  
  private static void SetExtrusion(DXV.Shape openXmlElement, DMV.Extrusion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.Extrusion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ExtrusionConverter.CreateOpenXmlElement<DXVO.Extrusion>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Callout? GetCallout(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.Callout>();
    if (element != null)
      return DMXV.CalloutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCallout(DXV.Shape openXmlElement, DMV.Callout? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.CalloutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.Callout>(), value, diffs, objName, propName);
  }
  
  private static void SetCallout(DXV.Shape openXmlElement, DMV.Callout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.Callout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.CalloutConverter.CreateOpenXmlElement<DXVO.Callout>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Lock? GetLock(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.Lock>();
    if (element != null)
      return DMXV.LockConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLock(DXV.Shape openXmlElement, DMV.Lock? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.LockConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.Lock>(), value, diffs, objName, propName);
  }
  
  private static void SetLock(DXV.Shape openXmlElement, DMV.Lock? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.Lock>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.LockConverter.CreateOpenXmlElement<DXVO.Lock>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.ClipPath? GetClipPath(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.ClipPath>();
    if (element != null)
      return DMXV.ClipPathConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpClipPath(DXV.Shape openXmlElement, DMV.ClipPath? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.ClipPathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.ClipPath>(), value, diffs, objName, propName);
  }
  
  private static void SetClipPath(DXV.Shape openXmlElement, DMV.ClipPath? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.ClipPath>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ClipPathConverter.CreateOpenXmlElement<DXVO.ClipPath>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.SignatureLine? GetSignatureLine(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.SignatureLine>();
    if (element != null)
      return DMXV.SignatureLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSignatureLine(DXV.Shape openXmlElement, DMV.SignatureLine? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.SignatureLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.SignatureLine>(), value, diffs, objName, propName);
  }
  
  private static void SetSignatureLine(DXV.Shape openXmlElement, DMV.SignatureLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.SignatureLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.SignatureLineConverter.CreateOpenXmlElement<DXVO.SignatureLine>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMWV.TextWrap? GetTextWrap(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVW.TextWrap>();
    if (element != null)
      return DMXWV.TextWrapConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextWrap(DXV.Shape openXmlElement, DMWV.TextWrap? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXWV.TextWrapConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVW.TextWrap>(), value, diffs, objName, propName);
  }
  
  private static void SetTextWrap(DXV.Shape openXmlElement, DMWV.TextWrap? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVW.TextWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWV.TextWrapConverter.CreateOpenXmlElement<DXVW.TextWrap>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetAnchorLock(DXV.Shape openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXVW.AnchorLock>() != null;
  }
  
  private static bool CmpAnchorLock(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXVW.AnchorLock>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXVW.AnchorLock", val, value);
    return false;
  }
  
  private static void SetAnchorLock(DXV.Shape openXmlElement, Boolean? value)
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
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMWV.BorderType? GetTopBorder(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVW.TopBorder>();
    if (element != null)
      return DMXWV.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTopBorder(DXV.Shape openXmlElement, DMWV.BorderType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXWV.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVW.TopBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetTopBorder(DXV.Shape openXmlElement, DMWV.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVW.TopBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWV.BorderTypeConverter.CreateOpenXmlElement<DXVW.TopBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMWV.BorderType? GetBottomBorder(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVW.BottomBorder>();
    if (element != null)
      return DMXWV.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBottomBorder(DXV.Shape openXmlElement, DMWV.BorderType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXWV.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVW.BottomBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetBottomBorder(DXV.Shape openXmlElement, DMWV.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVW.BottomBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWV.BorderTypeConverter.CreateOpenXmlElement<DXVW.BottomBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMWV.BorderType? GetLeftBorder(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVW.LeftBorder>();
    if (element != null)
      return DMXWV.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLeftBorder(DXV.Shape openXmlElement, DMWV.BorderType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXWV.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVW.LeftBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetLeftBorder(DXV.Shape openXmlElement, DMWV.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVW.LeftBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWV.BorderTypeConverter.CreateOpenXmlElement<DXVW.LeftBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMWV.BorderType? GetRightBorder(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVW.RightBorder>();
    if (element != null)
      return DMXWV.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRightBorder(DXV.Shape openXmlElement, DMWV.BorderType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXWV.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVW.RightBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetRightBorder(DXV.Shape openXmlElement, DMWV.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVW.RightBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWV.BorderTypeConverter.CreateOpenXmlElement<DXVW.RightBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Ink? GetInk(DXV.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.Ink>();
    if (element != null)
      return DMXV.InkConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInk(DXV.Shape openXmlElement, DMV.Ink? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.InkConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.Ink>(), value, diffs, objName, propName);
  }
  
  private static void SetInk(DXV.Shape openXmlElement, DMV.Ink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.Ink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.InkConverter.CreateOpenXmlElement<DXVO.Ink>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetInkAnnotationFlag(DXV.Shape openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXVP.InkAnnotationFlag>() != null;
  }
  
  private static bool CmpInkAnnotationFlag(DXV.Shape openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXVP.InkAnnotationFlag>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXVP.InkAnnotationFlag", val, value);
    return false;
  }
  
  private static void SetInkAnnotationFlag(DXV.Shape openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXVP.InkAnnotationFlag>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXVP.InkAnnotationFlag();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.Shape? CreateModelElement(DXV.Shape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Shape();
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
      value.Type = GetType(openXmlElement);
      value.Adjustment = GetAdjustment(openXmlElement);
      value.EdgePath = GetEdgePath(openXmlElement);
      value.EncodedPackage = GetEncodedPackage(openXmlElement);
      value.EquationXml = GetEquationXml(openXmlElement);
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
      value.InkAnnotationFlag = GetInkAnnotationFlag(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXV.Shape? openXmlElement, DMV.Shape? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName, propName))
        ok = false;
      if (!CmpHref(openXmlElement, value.Href, diffs, objName, propName))
        ok = false;
      if (!CmpTarget(openXmlElement, value.Target, diffs, objName, propName))
        ok = false;
      if (!CmpClass(openXmlElement, value.Class, diffs, objName, propName))
        ok = false;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName, propName))
        ok = false;
      if (!CmpAlternate(openXmlElement, value.Alternate, diffs, objName, propName))
        ok = false;
      if (!CmpCoordinateSize(openXmlElement, value.CoordinateSize, diffs, objName, propName))
        ok = false;
      if (!CmpCoordinateOrigin(openXmlElement, value.CoordinateOrigin, diffs, objName, propName))
        ok = false;
      if (!CmpWrapCoordinates(openXmlElement, value.WrapCoordinates, diffs, objName, propName))
        ok = false;
      if (!CmpPrint(openXmlElement, value.Print, diffs, objName, propName))
        ok = false;
      if (!CmpOptionalString(openXmlElement, value.OptionalString, diffs, objName, propName))
        ok = false;
      if (!CmpOned(openXmlElement, value.Oned, diffs, objName, propName))
        ok = false;
      if (!CmpRegroupId(openXmlElement, value.RegroupId, diffs, objName, propName))
        ok = false;
      if (!CmpDoubleClickNotify(openXmlElement, value.DoubleClickNotify, diffs, objName, propName))
        ok = false;
      if (!CmpButton(openXmlElement, value.Button, diffs, objName, propName))
        ok = false;
      if (!CmpUserHidden(openXmlElement, value.UserHidden, diffs, objName, propName))
        ok = false;
      if (!CmpBullet(openXmlElement, value.Bullet, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontal(openXmlElement, value.Horizontal, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontalStandard(openXmlElement, value.HorizontalStandard, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontalNoShade(openXmlElement, value.HorizontalNoShade, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontalPercentage(openXmlElement, value.HorizontalPercentage, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontalAlignment(openXmlElement, value.HorizontalAlignment, diffs, objName, propName))
        ok = false;
      if (!CmpAllowInCell(openXmlElement, value.AllowInCell, diffs, objName, propName))
        ok = false;
      if (!CmpAllowOverlap(openXmlElement, value.AllowOverlap, diffs, objName, propName))
        ok = false;
      if (!CmpUserDrawn(openXmlElement, value.UserDrawn, diffs, objName, propName))
        ok = false;
      if (!CmpBorderTopColor(openXmlElement, value.BorderTopColor, diffs, objName, propName))
        ok = false;
      if (!CmpBorderLeftColor(openXmlElement, value.BorderLeftColor, diffs, objName, propName))
        ok = false;
      if (!CmpBorderBottomColor(openXmlElement, value.BorderBottomColor, diffs, objName, propName))
        ok = false;
      if (!CmpBorderRightColor(openXmlElement, value.BorderRightColor, diffs, objName, propName))
        ok = false;
      if (!CmpDiagramLayout(openXmlElement, value.DiagramLayout, diffs, objName, propName))
        ok = false;
      if (!CmpDiagramNodeKind(openXmlElement, value.DiagramNodeKind, diffs, objName, propName))
        ok = false;
      if (!CmpDiagramLayoutMostRecentUsed(openXmlElement, value.DiagramLayoutMostRecentUsed, diffs, objName, propName))
        ok = false;
      if (!CmpInsetMode(openXmlElement, value.InsetMode, diffs, objName, propName))
        ok = false;
      if (!CmpFilled(openXmlElement, value.Filled, diffs, objName, propName))
        ok = false;
      if (!CmpFillColor(openXmlElement, value.FillColor, diffs, objName, propName))
        ok = false;
      if (!CmpStroked(openXmlElement, value.Stroked, diffs, objName, propName))
        ok = false;
      if (!CmpStrokeColor(openXmlElement, value.StrokeColor, diffs, objName, propName))
        ok = false;
      if (!CmpStrokeWeight(openXmlElement, value.StrokeWeight, diffs, objName, propName))
        ok = false;
      if (!CmpInsetPen(openXmlElement, value.InsetPen, diffs, objName, propName))
        ok = false;
      if (!CmpOptionalNumber(openXmlElement, value.OptionalNumber, diffs, objName, propName))
        ok = false;
      if (!CmpConnectorType(openXmlElement, value.ConnectorType, diffs, objName, propName))
        ok = false;
      if (!CmpBlackWhiteMode(openXmlElement, value.BlackWhiteMode, diffs, objName, propName))
        ok = false;
      if (!CmpPureBlackWhiteMode(openXmlElement, value.PureBlackWhiteMode, diffs, objName, propName))
        ok = false;
      if (!CmpNormalBlackWhiteMode(openXmlElement, value.NormalBlackWhiteMode, diffs, objName, propName))
        ok = false;
      if (!CmpForceDash(openXmlElement, value.ForceDash, diffs, objName, propName))
        ok = false;
      if (!CmpOleIcon(openXmlElement, value.OleIcon, diffs, objName, propName))
        ok = false;
      if (!CmpOle(openXmlElement, value.Ole, diffs, objName, propName))
        ok = false;
      if (!CmpPreferRelative(openXmlElement, value.PreferRelative, diffs, objName, propName))
        ok = false;
      if (!CmpClipToWrap(openXmlElement, value.ClipToWrap, diffs, objName, propName))
        ok = false;
      if (!CmpClip(openXmlElement, value.Clip, diffs, objName, propName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName, propName))
        ok = false;
      if (!CmpAdjustment(openXmlElement, value.Adjustment, diffs, objName, propName))
        ok = false;
      if (!CmpEdgePath(openXmlElement, value.EdgePath, diffs, objName, propName))
        ok = false;
      if (!CmpEncodedPackage(openXmlElement, value.EncodedPackage, diffs, objName, propName))
        ok = false;
      if (!CmpEquationXml(openXmlElement, value.EquationXml, diffs, objName, propName))
        ok = false;
      if (!CmpPath(openXmlElement, value.Path, diffs, objName, propName))
        ok = false;
      if (!CmpFormulas(openXmlElement, value.Formulas, diffs, objName, propName))
        ok = false;
      if (!CmpShapeHandles(openXmlElement, value.ShapeHandles, diffs, objName, propName))
        ok = false;
      if (!CmpFill(openXmlElement, value.Fill, diffs, objName, propName))
        ok = false;
      if (!CmpStroke(openXmlElement, value.Stroke, diffs, objName, propName))
        ok = false;
      if (!CmpShadow(openXmlElement, value.Shadow, diffs, objName, propName))
        ok = false;
      if (!CmpTextBox(openXmlElement, value.TextBox, diffs, objName, propName))
        ok = false;
      if (!CmpTextPath(openXmlElement, value.TextPath, diffs, objName, propName))
        ok = false;
      if (!CmpImageData(openXmlElement, value.ImageData, diffs, objName, propName))
        ok = false;
      if (!CmpSkew(openXmlElement, value.Skew, diffs, objName, propName))
        ok = false;
      if (!CmpExtrusion(openXmlElement, value.Extrusion, diffs, objName, propName))
        ok = false;
      if (!CmpCallout(openXmlElement, value.Callout, diffs, objName, propName))
        ok = false;
      if (!CmpLock(openXmlElement, value.Lock, diffs, objName, propName))
        ok = false;
      if (!CmpClipPath(openXmlElement, value.ClipPath, diffs, objName, propName))
        ok = false;
      if (!CmpSignatureLine(openXmlElement, value.SignatureLine, diffs, objName, propName))
        ok = false;
      if (!CmpTextWrap(openXmlElement, value.TextWrap, diffs, objName, propName))
        ok = false;
      if (!CmpAnchorLock(openXmlElement, value.AnchorLock, diffs, objName, propName))
        ok = false;
      if (!CmpTopBorder(openXmlElement, value.TopBorder, diffs, objName, propName))
        ok = false;
      if (!CmpBottomBorder(openXmlElement, value.BottomBorder, diffs, objName, propName))
        ok = false;
      if (!CmpLeftBorder(openXmlElement, value.LeftBorder, diffs, objName, propName))
        ok = false;
      if (!CmpRightBorder(openXmlElement, value.RightBorder, diffs, objName, propName))
        ok = false;
      if (!CmpInk(openXmlElement, value.Ink, diffs, objName, propName))
        ok = false;
      if (!CmpInkAnnotationFlag(openXmlElement, value.InkAnnotationFlag, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Shape value)
    where OpenXmlElementType: DXV.Shape, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXV.Shape openXmlElement, DMV.Shape value)
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
    SetType(openXmlElement, value?.Type);
    SetAdjustment(openXmlElement, value?.Adjustment);
    SetEdgePath(openXmlElement, value?.EdgePath);
    SetEncodedPackage(openXmlElement, value?.EncodedPackage);
    SetEquationXml(openXmlElement, value?.EquationXml);
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
    SetInkAnnotationFlag(openXmlElement, value?.InkAnnotationFlag);
  }
}

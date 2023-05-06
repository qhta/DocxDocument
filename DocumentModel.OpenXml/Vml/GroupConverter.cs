namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Group.
/// </summary>
public static class GroupConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXV.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXV.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXV.Group openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  private static String? GetStyle(DXV.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Style);
  }
  
  private static bool CmpStyle(DXV.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Style, value, diffs, objName, "Style");
  }
  
  private static void SetStyle(DXV.Group openXmlElement, String? value)
  {
    openXmlElement.Style = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  private static String? GetHref(DXV.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Href);
  }
  
  private static bool CmpHref(DXV.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Href, value, diffs, objName, "Href");
  }
  
  private static void SetHref(DXV.Group openXmlElement, String? value)
  {
    openXmlElement.Href = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Hyperlink Display Target
  /// </summary>
  private static String? GetTarget(DXV.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Target);
  }
  
  private static bool CmpTarget(DXV.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Target, value, diffs, objName, "Target");
  }
  
  private static void SetTarget(DXV.Group openXmlElement, String? value)
  {
    openXmlElement.Target = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// CSS Reference
  /// </summary>
  private static String? GetClass(DXV.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Class);
  }
  
  private static bool CmpClass(DXV.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Class, value, diffs, objName, "Class");
  }
  
  private static void SetClass(DXV.Group openXmlElement, String? value)
  {
    openXmlElement.Class = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  private static String? GetTitle(DXV.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Title);
  }
  
  private static bool CmpTitle(DXV.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Title, value, diffs, objName, "Title");
  }
  
  private static void SetTitle(DXV.Group openXmlElement, String? value)
  {
    openXmlElement.Title = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Alternate Text
  /// </summary>
  private static String? GetAlternate(DXV.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Alternate);
  }
  
  private static bool CmpAlternate(DXV.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Alternate, value, diffs, objName, "Alternate");
  }
  
  private static void SetAlternate(DXV.Group openXmlElement, String? value)
  {
    openXmlElement.Alternate = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Coordinate Space Size
  /// </summary>
  private static String? GetCoordinateSize(DXV.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CoordinateSize);
  }
  
  private static bool CmpCoordinateSize(DXV.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CoordinateSize, value, diffs, objName, "CoordinateSize");
  }
  
  private static void SetCoordinateSize(DXV.Group openXmlElement, String? value)
  {
    openXmlElement.CoordinateSize = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Coordinate Space Origin
  /// </summary>
  private static String? GetCoordinateOrigin(DXV.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CoordinateOrigin);
  }
  
  private static bool CmpCoordinateOrigin(DXV.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CoordinateOrigin, value, diffs, objName, "CoordinateOrigin");
  }
  
  private static void SetCoordinateOrigin(DXV.Group openXmlElement, String? value)
  {
    openXmlElement.CoordinateOrigin = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  private static String? GetWrapCoordinates(DXV.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.WrapCoordinates);
  }
  
  private static bool CmpWrapCoordinates(DXV.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.WrapCoordinates, value, diffs, objName, "WrapCoordinates");
  }
  
  private static void SetWrapCoordinates(DXV.Group openXmlElement, String? value)
  {
    openXmlElement.WrapCoordinates = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  private static Boolean? GetPrint(DXV.Group openXmlElement)
  {
    return openXmlElement?.Print?.Value;
  }
  
  private static bool CmpPrint(DXV.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Print?.Value == value) return true;
    diffs?.Add(objName, "Print", openXmlElement?.Print?.Value, value);
    return false;
  }
  
  private static void SetPrint(DXV.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Print = value;
    else
      openXmlElement.Print = null;
  }
  
  /// <summary>
  /// spid
  /// </summary>
  private static String? GetOptionalString(DXV.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.OptionalString);
  }
  
  private static bool CmpOptionalString(DXV.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.OptionalString, value, diffs, objName, "OptionalString");
  }
  
  private static void SetOptionalString(DXV.Group openXmlElement, String? value)
  {
    openXmlElement.OptionalString = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// oned
  /// </summary>
  private static Boolean? GetOned(DXV.Group openXmlElement)
  {
    return openXmlElement?.Oned?.Value;
  }
  
  private static bool CmpOned(DXV.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Oned?.Value == value) return true;
    diffs?.Add(objName, "Oned", openXmlElement?.Oned?.Value, value);
    return false;
  }
  
  private static void SetOned(DXV.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Oned = value;
    else
      openXmlElement.Oned = null;
  }
  
  /// <summary>
  /// regroupid
  /// </summary>
  private static Int64? GetRegroupId(DXV.Group openXmlElement)
  {
    return openXmlElement?.RegroupId?.Value;
  }
  
  private static bool CmpRegroupId(DXV.Group openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RegroupId?.Value == value) return true;
    diffs?.Add(objName, "RegroupId", openXmlElement?.RegroupId?.Value, value);
    return false;
  }
  
  private static void SetRegroupId(DXV.Group openXmlElement, Int64? value)
  {
    openXmlElement.RegroupId = value;
  }
  
  /// <summary>
  /// doubleclicknotify
  /// </summary>
  private static Boolean? GetDoubleClickNotify(DXV.Group openXmlElement)
  {
    return openXmlElement?.DoubleClickNotify?.Value;
  }
  
  private static bool CmpDoubleClickNotify(DXV.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DoubleClickNotify?.Value == value) return true;
    diffs?.Add(objName, "DoubleClickNotify", openXmlElement?.DoubleClickNotify?.Value, value);
    return false;
  }
  
  private static void SetDoubleClickNotify(DXV.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DoubleClickNotify = value;
    else
      openXmlElement.DoubleClickNotify = null;
  }
  
  /// <summary>
  /// button
  /// </summary>
  private static Boolean? GetButton(DXV.Group openXmlElement)
  {
    return openXmlElement?.Button?.Value;
  }
  
  private static bool CmpButton(DXV.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Button?.Value == value) return true;
    diffs?.Add(objName, "Button", openXmlElement?.Button?.Value, value);
    return false;
  }
  
  private static void SetButton(DXV.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Button = value;
    else
      openXmlElement.Button = null;
  }
  
  /// <summary>
  /// userhidden
  /// </summary>
  private static Boolean? GetUserHidden(DXV.Group openXmlElement)
  {
    return openXmlElement?.UserHidden?.Value;
  }
  
  private static bool CmpUserHidden(DXV.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.UserHidden?.Value == value) return true;
    diffs?.Add(objName, "UserHidden", openXmlElement?.UserHidden?.Value, value);
    return false;
  }
  
  private static void SetUserHidden(DXV.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserHidden = value;
    else
      openXmlElement.UserHidden = null;
  }
  
  /// <summary>
  /// bullet
  /// </summary>
  private static Boolean? GetBullet(DXV.Group openXmlElement)
  {
    return openXmlElement?.Bullet?.Value;
  }
  
  private static bool CmpBullet(DXV.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Bullet?.Value == value) return true;
    diffs?.Add(objName, "Bullet", openXmlElement?.Bullet?.Value, value);
    return false;
  }
  
  private static void SetBullet(DXV.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Bullet = value;
    else
      openXmlElement.Bullet = null;
  }
  
  /// <summary>
  /// hr
  /// </summary>
  private static Boolean? GetHorizontal(DXV.Group openXmlElement)
  {
    return openXmlElement?.Horizontal?.Value;
  }
  
  private static bool CmpHorizontal(DXV.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Horizontal?.Value == value) return true;
    diffs?.Add(objName, "Horizontal", openXmlElement?.Horizontal?.Value, value);
    return false;
  }
  
  private static void SetHorizontal(DXV.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Horizontal = value;
    else
      openXmlElement.Horizontal = null;
  }
  
  /// <summary>
  /// hrstd
  /// </summary>
  private static Boolean? GetHorizontalStandard(DXV.Group openXmlElement)
  {
    return openXmlElement?.HorizontalStandard?.Value;
  }
  
  private static bool CmpHorizontalStandard(DXV.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalStandard?.Value == value) return true;
    diffs?.Add(objName, "HorizontalStandard", openXmlElement?.HorizontalStandard?.Value, value);
    return false;
  }
  
  private static void SetHorizontalStandard(DXV.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalStandard = value;
    else
      openXmlElement.HorizontalStandard = null;
  }
  
  /// <summary>
  /// hrnoshade
  /// </summary>
  private static Boolean? GetHorizontalNoShade(DXV.Group openXmlElement)
  {
    return openXmlElement?.HorizontalNoShade?.Value;
  }
  
  private static bool CmpHorizontalNoShade(DXV.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalNoShade?.Value == value) return true;
    diffs?.Add(objName, "HorizontalNoShade", openXmlElement?.HorizontalNoShade?.Value, value);
    return false;
  }
  
  private static void SetHorizontalNoShade(DXV.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalNoShade = value;
    else
      openXmlElement.HorizontalNoShade = null;
  }
  
  /// <summary>
  /// hrpct
  /// </summary>
  private static Single? GetHorizontalPercentage(DXV.Group openXmlElement)
  {
    return openXmlElement?.HorizontalPercentage?.Value;
  }
  
  private static bool CmpHorizontalPercentage(DXV.Group openXmlElement, Single? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalPercentage?.Value == value) return true;
    diffs?.Add(objName, "HorizontalPercentage", openXmlElement?.HorizontalPercentage?.Value, value);
    return false;
  }
  
  private static void SetHorizontalPercentage(DXV.Group openXmlElement, Single? value)
  {
    openXmlElement.HorizontalPercentage = value;
  }
  
  /// <summary>
  /// hralign
  /// </summary>
  private static DMV.HorizontalRuleAlignmentKind? GetHorizontalAlignment(DXV.Group openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMV.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value);
  }
  
  private static bool CmpHorizontalAlignment(DXV.Group openXmlElement, DMV.HorizontalRuleAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMV.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value, value, diffs, objName);
  }
  
  private static void SetHorizontalAlignment(DXV.Group openXmlElement, DMV.HorizontalRuleAlignmentKind? value)
  {
    openXmlElement.HorizontalAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMV.HorizontalRuleAlignmentKind>(value);
  }
  
  /// <summary>
  /// allowincell
  /// </summary>
  private static Boolean? GetAllowInCell(DXV.Group openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }
  
  private static bool CmpAllowInCell(DXV.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowInCell?.Value == value) return true;
    diffs?.Add(objName, "AllowInCell", openXmlElement?.AllowInCell?.Value, value);
    return false;
  }
  
  private static void SetAllowInCell(DXV.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowInCell = value;
    else
      openXmlElement.AllowInCell = null;
  }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  private static Boolean? GetAllowOverlap(DXV.Group openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  private static bool CmpAllowOverlap(DXV.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowOverlap?.Value == value) return true;
    diffs?.Add(objName, "AllowOverlap", openXmlElement?.AllowOverlap?.Value, value);
    return false;
  }
  
  private static void SetAllowOverlap(DXV.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowOverlap = value;
    else
      openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// userdrawn
  /// </summary>
  private static Boolean? GetUserDrawn(DXV.Group openXmlElement)
  {
    return openXmlElement?.UserDrawn?.Value;
  }
  
  private static bool CmpUserDrawn(DXV.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.UserDrawn?.Value == value) return true;
    diffs?.Add(objName, "UserDrawn", openXmlElement?.UserDrawn?.Value, value);
    return false;
  }
  
  private static void SetUserDrawn(DXV.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserDrawn = value;
    else
      openXmlElement.UserDrawn = null;
  }
  
  /// <summary>
  /// dgmlayout
  /// </summary>
  private static Int64? GetDiagramLayout(DXV.Group openXmlElement)
  {
    return openXmlElement?.DiagramLayout?.Value;
  }
  
  private static bool CmpDiagramLayout(DXV.Group openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DiagramLayout?.Value == value) return true;
    diffs?.Add(objName, "DiagramLayout", openXmlElement?.DiagramLayout?.Value, value);
    return false;
  }
  
  private static void SetDiagramLayout(DXV.Group openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayout = value;
  }
  
  /// <summary>
  /// dgmnodekind
  /// </summary>
  private static Int64? GetDiagramNodeKind(DXV.Group openXmlElement)
  {
    return openXmlElement?.DiagramNodeKind?.Value;
  }
  
  private static bool CmpDiagramNodeKind(DXV.Group openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DiagramNodeKind?.Value == value) return true;
    diffs?.Add(objName, "DiagramNodeKind", openXmlElement?.DiagramNodeKind?.Value, value);
    return false;
  }
  
  private static void SetDiagramNodeKind(DXV.Group openXmlElement, Int64? value)
  {
    openXmlElement.DiagramNodeKind = value;
  }
  
  /// <summary>
  /// dgmlayoutmru
  /// </summary>
  private static Int64? GetDiagramLayoutMostRecentUsed(DXV.Group openXmlElement)
  {
    return openXmlElement?.DiagramLayoutMostRecentUsed?.Value;
  }
  
  private static bool CmpDiagramLayoutMostRecentUsed(DXV.Group openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DiagramLayoutMostRecentUsed?.Value == value) return true;
    diffs?.Add(objName, "DiagramLayoutMostRecentUsed", openXmlElement?.DiagramLayoutMostRecentUsed?.Value, value);
    return false;
  }
  
  private static void SetDiagramLayoutMostRecentUsed(DXV.Group openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayoutMostRecentUsed = value;
  }
  
  /// <summary>
  /// insetmode
  /// </summary>
  private static DMV.InsetMarginKind? GetInsetMode(DXV.Group openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMV.InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }
  
  private static bool CmpInsetMode(DXV.Group openXmlElement, DMV.InsetMarginKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMV.InsetMarginKind>(openXmlElement?.InsetMode?.Value, value, diffs, objName);
  }
  
  private static void SetInsetMode(DXV.Group openXmlElement, DMV.InsetMarginKind? value)
  {
    openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMV.InsetMarginKind>(value);
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  private static DM.Base64Binary? GetGfxdata(DXV.Group openXmlElement)
  {
    if (openXmlElement?.Gfxdata?.Value != null)
      return Convert.FromBase64String(openXmlElement.Gfxdata.Value);
    return null;
  }
  
  private static bool CmpGfxdata(DXV.Group openXmlElement, DM.Base64Binary? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Gfxdata?.Value != null && value != null)
      if (Convert.FromBase64String(openXmlElement.Gfxdata.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement?.Gfxdata?.Value == null && value == null) return true;
    diffs?.Add(objName, "Gfxdata", openXmlElement?.Gfxdata?.Value, value);
    return false;
  }
  
  private static void SetGfxdata(DXV.Group openXmlElement, DM.Base64Binary? value)
  {
    if (value != null)
      openXmlElement.Gfxdata = Convert.ToBase64String(value);
    else
      openXmlElement.Gfxdata = null;
  }
  
  /// <summary>
  /// Group Diagram Type
  /// </summary>
  private static DMV.EditAsKind? GetEditAs(DXV.Group openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.EditAsValues, DMV.EditAsKind>(openXmlElement?.EditAs?.Value);
  }
  
  private static bool CmpEditAs(DXV.Group openXmlElement, DMV.EditAsKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.EditAsValues, DMV.EditAsKind>(openXmlElement?.EditAs?.Value, value, diffs, objName);
  }
  
  private static void SetEditAs(DXV.Group openXmlElement, DMV.EditAsKind? value)
  {
    openXmlElement.EditAs = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.EditAsValues, DMV.EditAsKind>(value);
  }
  
  /// <summary>
  /// Table Properties
  /// </summary>
  private static String? GetTableProperties(DXV.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.TableProperties);
  }
  
  private static bool CmpTableProperties(DXV.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.TableProperties, value, diffs, objName, "TableProperties");
  }
  
  private static void SetTableProperties(DXV.Group openXmlElement, String? value)
  {
    openXmlElement.TableProperties = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Table Row Height Limits
  /// </summary>
  private static String? GetTableLimits(DXV.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.TableLimits);
  }
  
  private static bool CmpTableLimits(DXV.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.TableLimits, value, diffs, objName, "TableLimits");
  }
  
  private static void SetTableLimits(DXV.Group openXmlElement, String? value)
  {
    openXmlElement.TableLimits = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMV.Group? GetChildGroup(DXV.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Group>();
    if (element != null)
      return DMXV.GroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildGroup(DXV.Group openXmlElement, DMV.Group? value, DiffList? diffs, string? objName)
  {
    return DMXV.GroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Group>(), value, diffs, objName);
  }
  
  private static void SetChildGroup(DXV.Group openXmlElement, DMV.Group? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Group>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.GroupConverter.CreateOpenXmlElement<DXV.Group>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Shape? GetShape(DXV.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Shape>();
    if (element != null)
      return DMXV.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXV.Group openXmlElement, DMV.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXV.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Shape>(), value, diffs, objName);
  }
  
  private static void SetShape(DXV.Group openXmlElement, DMV.Shape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ShapeConverter.CreateOpenXmlElement<DXV.Shape>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Shapetype? GetShapetype(DXV.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Shapetype>();
    if (element != null)
      return DMXV.ShapetypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapetype(DXV.Group openXmlElement, DMV.Shapetype? value, DiffList? diffs, string? objName)
  {
    return DMXV.ShapetypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Shapetype>(), value, diffs, objName);
  }
  
  private static void SetShapetype(DXV.Group openXmlElement, DMV.Shapetype? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Shapetype>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ShapetypeConverter.CreateOpenXmlElement<DXV.Shapetype>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Arc? GetArc(DXV.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Arc>();
    if (element != null)
      return DMXV.ArcConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArc(DXV.Group openXmlElement, DMV.Arc? value, DiffList? diffs, string? objName)
  {
    return DMXV.ArcConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Arc>(), value, diffs, objName);
  }
  
  private static void SetArc(DXV.Group openXmlElement, DMV.Arc? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Arc>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ArcConverter.CreateOpenXmlElement<DXV.Arc>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Curve? GetCurve(DXV.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Curve>();
    if (element != null)
      return DMXV.CurveConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCurve(DXV.Group openXmlElement, DMV.Curve? value, DiffList? diffs, string? objName)
  {
    return DMXV.CurveConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Curve>(), value, diffs, objName);
  }
  
  private static void SetCurve(DXV.Group openXmlElement, DMV.Curve? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Curve>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.CurveConverter.CreateOpenXmlElement<DXV.Curve>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.ImageFile? GetImageFile(DXV.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.ImageFile>();
    if (element != null)
      return DMXV.ImageFileConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageFile(DXV.Group openXmlElement, DMV.ImageFile? value, DiffList? diffs, string? objName)
  {
    return DMXV.ImageFileConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.ImageFile>(), value, diffs, objName);
  }
  
  private static void SetImageFile(DXV.Group openXmlElement, DMV.ImageFile? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.ImageFile>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ImageFileConverter.CreateOpenXmlElement<DXV.ImageFile>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Line? GetLine(DXV.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Line>();
    if (element != null)
      return DMXV.LineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLine(DXV.Group openXmlElement, DMV.Line? value, DiffList? diffs, string? objName)
  {
    return DMXV.LineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Line>(), value, diffs, objName);
  }
  
  private static void SetLine(DXV.Group openXmlElement, DMV.Line? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Line>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.LineConverter.CreateOpenXmlElement<DXV.Line>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Oval? GetOval(DXV.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Oval>();
    if (element != null)
      return DMXV.OvalConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOval(DXV.Group openXmlElement, DMV.Oval? value, DiffList? diffs, string? objName)
  {
    return DMXV.OvalConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Oval>(), value, diffs, objName);
  }
  
  private static void SetOval(DXV.Group openXmlElement, DMV.Oval? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Oval>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.OvalConverter.CreateOpenXmlElement<DXV.Oval>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.PolyLine? GetPolyLine(DXV.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.PolyLine>();
    if (element != null)
      return DMXV.PolyLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPolyLine(DXV.Group openXmlElement, DMV.PolyLine? value, DiffList? diffs, string? objName)
  {
    return DMXV.PolyLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.PolyLine>(), value, diffs, objName);
  }
  
  private static void SetPolyLine(DXV.Group openXmlElement, DMV.PolyLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.PolyLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.PolyLineConverter.CreateOpenXmlElement<DXV.PolyLine>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Rectangle? GetRectangle(DXV.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Rectangle>();
    if (element != null)
      return DMXV.RectangleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRectangle(DXV.Group openXmlElement, DMV.Rectangle? value, DiffList? diffs, string? objName)
  {
    return DMXV.RectangleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Rectangle>(), value, diffs, objName);
  }
  
  private static void SetRectangle(DXV.Group openXmlElement, DMV.Rectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Rectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.RectangleConverter.CreateOpenXmlElement<DXV.Rectangle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.RoundRectangle? GetRoundRectangle(DXV.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.RoundRectangle>();
    if (element != null)
      return DMXV.RoundRectangleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRoundRectangle(DXV.Group openXmlElement, DMV.RoundRectangle? value, DiffList? diffs, string? objName)
  {
    return DMXV.RoundRectangleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.RoundRectangle>(), value, diffs, objName);
  }
  
  private static void SetRoundRectangle(DXV.Group openXmlElement, DMV.RoundRectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.RoundRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.RoundRectangleConverter.CreateOpenXmlElement<DXV.RoundRectangle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Diagram? GetDiagram(DXV.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.Diagram>();
    if (element != null)
      return DMXV.DiagramConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDiagram(DXV.Group openXmlElement, DMV.Diagram? value, DiffList? diffs, string? objName)
  {
    return DMXV.DiagramConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.Diagram>(), value, diffs, objName);
  }
  
  private static void SetDiagram(DXV.Group openXmlElement, DMV.Diagram? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.Diagram>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.DiagramConverter.CreateOpenXmlElement<DXVO.Diagram>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMV.Lock? GetLock(DXV.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.Lock>();
    if (element != null)
      return DMXV.LockConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLock(DXV.Group openXmlElement, DMV.Lock? value, DiffList? diffs, string? objName)
  {
    return DMXV.LockConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.Lock>(), value, diffs, objName);
  }
  
  private static void SetLock(DXV.Group openXmlElement, DMV.Lock? value)
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
  
  private static DMV.ClipPath? GetClipPath(DXV.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.ClipPath>();
    if (element != null)
      return DMXV.ClipPathConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpClipPath(DXV.Group openXmlElement, DMV.ClipPath? value, DiffList? diffs, string? objName)
  {
    return DMXV.ClipPathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.ClipPath>(), value, diffs, objName);
  }
  
  private static void SetClipPath(DXV.Group openXmlElement, DMV.ClipPath? value)
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
  
  private static DMWV.TextWrap? GetTextWrap(DXV.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVW.TextWrap>();
    if (element != null)
      return DMXWV.TextWrapConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextWrap(DXV.Group openXmlElement, DMWV.TextWrap? value, DiffList? diffs, string? objName)
  {
    return DMXWV.TextWrapConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVW.TextWrap>(), value, diffs, objName);
  }
  
  private static void SetTextWrap(DXV.Group openXmlElement, DMWV.TextWrap? value)
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
  
  private static Boolean? GetAnchorLock(DXV.Group openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXVW.AnchorLock>() != null;
  }
  
  private static bool CmpAnchorLock(DXV.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXVW.AnchorLock>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXVW.AnchorLock", val, value);
    return false;
  }
  
  private static void SetAnchorLock(DXV.Group openXmlElement, Boolean? value)
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
  
  public static DocumentModel.Vml.Group? CreateModelElement(DXV.Group? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Group();
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
      value.DiagramLayout = GetDiagramLayout(openXmlElement);
      value.DiagramNodeKind = GetDiagramNodeKind(openXmlElement);
      value.DiagramLayoutMostRecentUsed = GetDiagramLayoutMostRecentUsed(openXmlElement);
      value.InsetMode = GetInsetMode(openXmlElement);
      value.Gfxdata = GetGfxdata(openXmlElement);
      value.EditAs = GetEditAs(openXmlElement);
      value.TableProperties = GetTableProperties(openXmlElement);
      value.TableLimits = GetTableLimits(openXmlElement);
      value.ChildGroup = GetChildGroup(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.Shapetype = GetShapetype(openXmlElement);
      value.Arc = GetArc(openXmlElement);
      value.Curve = GetCurve(openXmlElement);
      value.ImageFile = GetImageFile(openXmlElement);
      value.Line = GetLine(openXmlElement);
      value.Oval = GetOval(openXmlElement);
      value.PolyLine = GetPolyLine(openXmlElement);
      value.Rectangle = GetRectangle(openXmlElement);
      value.RoundRectangle = GetRoundRectangle(openXmlElement);
      value.Diagram = GetDiagram(openXmlElement);
      value.Lock = GetLock(openXmlElement);
      value.ClipPath = GetClipPath(openXmlElement);
      value.TextWrap = GetTextWrap(openXmlElement);
      value.AnchorLock = GetAnchorLock(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXV.Group? openXmlElement, DMV.Group? value, DiffList? diffs, string? objName)
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
      if (!CmpDiagramLayout(openXmlElement, value.DiagramLayout, diffs, objName))
        ok = false;
      if (!CmpDiagramNodeKind(openXmlElement, value.DiagramNodeKind, diffs, objName))
        ok = false;
      if (!CmpDiagramLayoutMostRecentUsed(openXmlElement, value.DiagramLayoutMostRecentUsed, diffs, objName))
        ok = false;
      if (!CmpInsetMode(openXmlElement, value.InsetMode, diffs, objName))
        ok = false;
      if (!CmpGfxdata(openXmlElement, value.Gfxdata, diffs, objName))
        ok = false;
      if (!CmpEditAs(openXmlElement, value.EditAs, diffs, objName))
        ok = false;
      if (!CmpTableProperties(openXmlElement, value.TableProperties, diffs, objName))
        ok = false;
      if (!CmpTableLimits(openXmlElement, value.TableLimits, diffs, objName))
        ok = false;
      if (!CmpChildGroup(openXmlElement, value.ChildGroup, diffs, objName))
        ok = false;
      if (!CmpShape(openXmlElement, value.Shape, diffs, objName))
        ok = false;
      if (!CmpShapetype(openXmlElement, value.Shapetype, diffs, objName))
        ok = false;
      if (!CmpArc(openXmlElement, value.Arc, diffs, objName))
        ok = false;
      if (!CmpCurve(openXmlElement, value.Curve, diffs, objName))
        ok = false;
      if (!CmpImageFile(openXmlElement, value.ImageFile, diffs, objName))
        ok = false;
      if (!CmpLine(openXmlElement, value.Line, diffs, objName))
        ok = false;
      if (!CmpOval(openXmlElement, value.Oval, diffs, objName))
        ok = false;
      if (!CmpPolyLine(openXmlElement, value.PolyLine, diffs, objName))
        ok = false;
      if (!CmpRectangle(openXmlElement, value.Rectangle, diffs, objName))
        ok = false;
      if (!CmpRoundRectangle(openXmlElement, value.RoundRectangle, diffs, objName))
        ok = false;
      if (!CmpDiagram(openXmlElement, value.Diagram, diffs, objName))
        ok = false;
      if (!CmpLock(openXmlElement, value.Lock, diffs, objName))
        ok = false;
      if (!CmpClipPath(openXmlElement, value.ClipPath, diffs, objName))
        ok = false;
      if (!CmpTextWrap(openXmlElement, value.TextWrap, diffs, objName))
        ok = false;
      if (!CmpAnchorLock(openXmlElement, value.AnchorLock, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Group value)
    where OpenXmlElementType: DXV.Group, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXV.Group openXmlElement, DMV.Group value)
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
    SetDiagramLayout(openXmlElement, value?.DiagramLayout);
    SetDiagramNodeKind(openXmlElement, value?.DiagramNodeKind);
    SetDiagramLayoutMostRecentUsed(openXmlElement, value?.DiagramLayoutMostRecentUsed);
    SetInsetMode(openXmlElement, value?.InsetMode);
    SetGfxdata(openXmlElement, value?.Gfxdata);
    SetEditAs(openXmlElement, value?.EditAs);
    SetTableProperties(openXmlElement, value?.TableProperties);
    SetTableLimits(openXmlElement, value?.TableLimits);
    SetChildGroup(openXmlElement, value?.ChildGroup);
    SetShape(openXmlElement, value?.Shape);
    SetShapetype(openXmlElement, value?.Shapetype);
    SetArc(openXmlElement, value?.Arc);
    SetCurve(openXmlElement, value?.Curve);
    SetImageFile(openXmlElement, value?.ImageFile);
    SetLine(openXmlElement, value?.Line);
    SetOval(openXmlElement, value?.Oval);
    SetPolyLine(openXmlElement, value?.PolyLine);
    SetRectangle(openXmlElement, value?.Rectangle);
    SetRoundRectangle(openXmlElement, value?.RoundRectangle);
    SetDiagram(openXmlElement, value?.Diagram);
    SetLock(openXmlElement, value?.Lock);
    SetClipPath(openXmlElement, value?.ClipPath);
    SetTextWrap(openXmlElement, value?.TextWrap);
    SetAnchorLock(openXmlElement, value?.AnchorLock);
  }
}

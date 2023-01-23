namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Group.
/// </summary>
public static class GroupConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXVml.Group openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXVml.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXVml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  private static String? GetStyle(DXVml.Group openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  private static bool CmpStyle(DXVml.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Style?.Value == value;
  }
  
  private static void SetStyle(DXVml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Style = new StringValue { Value = value };
    else
      openXmlElement.Style = null;
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  private static String? GetHref(DXVml.Group openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }
  
  private static bool CmpHref(DXVml.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Href?.Value == value;
  }
  
  private static void SetHref(DXVml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Href = new StringValue { Value = value };
    else
      openXmlElement.Href = null;
  }
  
  /// <summary>
  /// Hyperlink Display Target
  /// </summary>
  private static String? GetTarget(DXVml.Group openXmlElement)
  {
    return openXmlElement?.Target?.Value;
  }
  
  private static bool CmpTarget(DXVml.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Target?.Value == value;
  }
  
  private static void SetTarget(DXVml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Target = new StringValue { Value = value };
    else
      openXmlElement.Target = null;
  }
  
  /// <summary>
  /// CSS Reference
  /// </summary>
  private static String? GetClass(DXVml.Group openXmlElement)
  {
    return openXmlElement?.Class?.Value;
  }
  
  private static bool CmpClass(DXVml.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Class?.Value == value;
  }
  
  private static void SetClass(DXVml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Class = new StringValue { Value = value };
    else
      openXmlElement.Class = null;
  }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  private static String? GetTitle(DXVml.Group openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static bool CmpTitle(DXVml.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Title?.Value == value;
  }
  
  private static void SetTitle(DXVml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Alternate Text
  /// </summary>
  private static String? GetAlternate(DXVml.Group openXmlElement)
  {
    return openXmlElement?.Alternate?.Value;
  }
  
  private static bool CmpAlternate(DXVml.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Alternate?.Value == value;
  }
  
  private static void SetAlternate(DXVml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Alternate = new StringValue { Value = value };
    else
      openXmlElement.Alternate = null;
  }
  
  /// <summary>
  /// Coordinate Space Size
  /// </summary>
  private static String? GetCoordinateSize(DXVml.Group openXmlElement)
  {
    return openXmlElement?.CoordinateSize?.Value;
  }
  
  private static bool CmpCoordinateSize(DXVml.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.CoordinateSize?.Value == value;
  }
  
  private static void SetCoordinateSize(DXVml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CoordinateSize = new StringValue { Value = value };
    else
      openXmlElement.CoordinateSize = null;
  }
  
  /// <summary>
  /// Coordinate Space Origin
  /// </summary>
  private static String? GetCoordinateOrigin(DXVml.Group openXmlElement)
  {
    return openXmlElement?.CoordinateOrigin?.Value;
  }
  
  private static bool CmpCoordinateOrigin(DXVml.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.CoordinateOrigin?.Value == value;
  }
  
  private static void SetCoordinateOrigin(DXVml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CoordinateOrigin = new StringValue { Value = value };
    else
      openXmlElement.CoordinateOrigin = null;
  }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  private static String? GetWrapCoordinates(DXVml.Group openXmlElement)
  {
    return openXmlElement?.WrapCoordinates?.Value;
  }
  
  private static bool CmpWrapCoordinates(DXVml.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.WrapCoordinates?.Value == value;
  }
  
  private static void SetWrapCoordinates(DXVml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.WrapCoordinates = new StringValue { Value = value };
    else
      openXmlElement.WrapCoordinates = null;
  }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  private static Boolean? GetPrint(DXVml.Group openXmlElement)
  {
    return openXmlElement?.Print?.Value;
  }
  
  private static bool CmpPrint(DXVml.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Print?.Value == value;
  }
  
  private static void SetPrint(DXVml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Print = value;
    else
      openXmlElement.Print = null;
  }
  
  /// <summary>
  /// spid
  /// </summary>
  private static String? GetOptionalString(DXVml.Group openXmlElement)
  {
    return openXmlElement?.OptionalString?.Value;
  }
  
  private static bool CmpOptionalString(DXVml.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.OptionalString?.Value == value;
  }
  
  private static void SetOptionalString(DXVml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OptionalString = new StringValue { Value = value };
    else
      openXmlElement.OptionalString = null;
  }
  
  /// <summary>
  /// oned
  /// </summary>
  private static Boolean? GetOned(DXVml.Group openXmlElement)
  {
    return openXmlElement?.Oned?.Value;
  }
  
  private static bool CmpOned(DXVml.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Oned?.Value == value;
  }
  
  private static void SetOned(DXVml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Oned = value;
    else
      openXmlElement.Oned = null;
  }
  
  /// <summary>
  /// regroupid
  /// </summary>
  private static Int64? GetRegroupId(DXVml.Group openXmlElement)
  {
    return openXmlElement.RegroupId?.Value;
  }
  
  private static bool CmpRegroupId(DXVml.Group openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.RegroupId?.Value == value;
  }
  
  private static void SetRegroupId(DXVml.Group openXmlElement, Int64? value)
  {
    openXmlElement.RegroupId = value;
  }
  
  /// <summary>
  /// doubleclicknotify
  /// </summary>
  private static Boolean? GetDoubleClickNotify(DXVml.Group openXmlElement)
  {
    return openXmlElement?.DoubleClickNotify?.Value;
  }
  
  private static bool CmpDoubleClickNotify(DXVml.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.DoubleClickNotify?.Value == value;
  }
  
  private static void SetDoubleClickNotify(DXVml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DoubleClickNotify = value;
    else
      openXmlElement.DoubleClickNotify = null;
  }
  
  /// <summary>
  /// button
  /// </summary>
  private static Boolean? GetButton(DXVml.Group openXmlElement)
  {
    return openXmlElement?.Button?.Value;
  }
  
  private static bool CmpButton(DXVml.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Button?.Value == value;
  }
  
  private static void SetButton(DXVml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Button = value;
    else
      openXmlElement.Button = null;
  }
  
  /// <summary>
  /// userhidden
  /// </summary>
  private static Boolean? GetUserHidden(DXVml.Group openXmlElement)
  {
    return openXmlElement?.UserHidden?.Value;
  }
  
  private static bool CmpUserHidden(DXVml.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.UserHidden?.Value == value;
  }
  
  private static void SetUserHidden(DXVml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserHidden = value;
    else
      openXmlElement.UserHidden = null;
  }
  
  /// <summary>
  /// bullet
  /// </summary>
  private static Boolean? GetBullet(DXVml.Group openXmlElement)
  {
    return openXmlElement?.Bullet?.Value;
  }
  
  private static bool CmpBullet(DXVml.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Bullet?.Value == value;
  }
  
  private static void SetBullet(DXVml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Bullet = value;
    else
      openXmlElement.Bullet = null;
  }
  
  /// <summary>
  /// hr
  /// </summary>
  private static Boolean? GetHorizontal(DXVml.Group openXmlElement)
  {
    return openXmlElement?.Horizontal?.Value;
  }
  
  private static bool CmpHorizontal(DXVml.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Horizontal?.Value == value;
  }
  
  private static void SetHorizontal(DXVml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Horizontal = value;
    else
      openXmlElement.Horizontal = null;
  }
  
  /// <summary>
  /// hrstd
  /// </summary>
  private static Boolean? GetHorizontalStandard(DXVml.Group openXmlElement)
  {
    return openXmlElement?.HorizontalStandard?.Value;
  }
  
  private static bool CmpHorizontalStandard(DXVml.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.HorizontalStandard?.Value == value;
  }
  
  private static void SetHorizontalStandard(DXVml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalStandard = value;
    else
      openXmlElement.HorizontalStandard = null;
  }
  
  /// <summary>
  /// hrnoshade
  /// </summary>
  private static Boolean? GetHorizontalNoShade(DXVml.Group openXmlElement)
  {
    return openXmlElement?.HorizontalNoShade?.Value;
  }
  
  private static bool CmpHorizontalNoShade(DXVml.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.HorizontalNoShade?.Value == value;
  }
  
  private static void SetHorizontalNoShade(DXVml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalNoShade = value;
    else
      openXmlElement.HorizontalNoShade = null;
  }
  
  /// <summary>
  /// hrpct
  /// </summary>
  private static Single? GetHorizontalPercentage(DXVml.Group openXmlElement)
  {
    return openXmlElement.HorizontalPercentage?.Value;
  }
  
  private static bool CmpHorizontalPercentage(DXVml.Group openXmlElement, Single? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.HorizontalPercentage?.Value == value;
  }
  
  private static void SetHorizontalPercentage(DXVml.Group openXmlElement, Single? value)
  {
    openXmlElement.HorizontalPercentage = value;
  }
  
  /// <summary>
  /// hralign
  /// </summary>
  private static DMVml.HorizontalRuleAlignmentKind? GetHorizontalAlignment(DXVml.Group openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMVml.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value);
  }
  
  private static bool CmpHorizontalAlignment(DXVml.Group openXmlElement, DMVml.HorizontalRuleAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMVml.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHorizontalAlignment(DXVml.Group openXmlElement, DMVml.HorizontalRuleAlignmentKind? value)
  {
    openXmlElement.HorizontalAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMVml.HorizontalRuleAlignmentKind>(value);
  }
  
  /// <summary>
  /// allowincell
  /// </summary>
  private static Boolean? GetAllowInCell(DXVml.Group openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }
  
  private static bool CmpAllowInCell(DXVml.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AllowInCell?.Value == value;
  }
  
  private static void SetAllowInCell(DXVml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowInCell = value;
    else
      openXmlElement.AllowInCell = null;
  }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  private static Boolean? GetAllowOverlap(DXVml.Group openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  private static bool CmpAllowOverlap(DXVml.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AllowOverlap?.Value == value;
  }
  
  private static void SetAllowOverlap(DXVml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowOverlap = value;
    else
      openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// userdrawn
  /// </summary>
  private static Boolean? GetUserDrawn(DXVml.Group openXmlElement)
  {
    return openXmlElement?.UserDrawn?.Value;
  }
  
  private static bool CmpUserDrawn(DXVml.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.UserDrawn?.Value == value;
  }
  
  private static void SetUserDrawn(DXVml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserDrawn = value;
    else
      openXmlElement.UserDrawn = null;
  }
  
  /// <summary>
  /// dgmlayout
  /// </summary>
  private static Int64? GetDiagramLayout(DXVml.Group openXmlElement)
  {
    return openXmlElement.DiagramLayout?.Value;
  }
  
  private static bool CmpDiagramLayout(DXVml.Group openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.DiagramLayout?.Value == value;
  }
  
  private static void SetDiagramLayout(DXVml.Group openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayout = value;
  }
  
  /// <summary>
  /// dgmnodekind
  /// </summary>
  private static Int64? GetDiagramNodeKind(DXVml.Group openXmlElement)
  {
    return openXmlElement.DiagramNodeKind?.Value;
  }
  
  private static bool CmpDiagramNodeKind(DXVml.Group openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.DiagramNodeKind?.Value == value;
  }
  
  private static void SetDiagramNodeKind(DXVml.Group openXmlElement, Int64? value)
  {
    openXmlElement.DiagramNodeKind = value;
  }
  
  /// <summary>
  /// dgmlayoutmru
  /// </summary>
  private static Int64? GetDiagramLayoutMostRecentUsed(DXVml.Group openXmlElement)
  {
    return openXmlElement.DiagramLayoutMostRecentUsed?.Value;
  }
  
  private static bool CmpDiagramLayoutMostRecentUsed(DXVml.Group openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.DiagramLayoutMostRecentUsed?.Value == value;
  }
  
  private static void SetDiagramLayoutMostRecentUsed(DXVml.Group openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayoutMostRecentUsed = value;
  }
  
  /// <summary>
  /// insetmode
  /// </summary>
  private static DMVml.InsetMarginKind? GetInsetMode(DXVml.Group openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }
  
  private static bool CmpInsetMode(DXVml.Group openXmlElement, DMVml.InsetMarginKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(openXmlElement?.InsetMode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetInsetMode(DXVml.Group openXmlElement, DMVml.InsetMarginKind? value)
  {
    openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(value);
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  private static Byte[]? GetGfxdata(DXVml.Group openXmlElement)
  {
    if (openXmlElement.Gfxdata?.Value != null)
      return Convert.FromBase64String(openXmlElement.Gfxdata.Value);
    return null;
  }
  
  private static bool CmpGfxdata(DXVml.Group openXmlElement, Byte[]? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.Gfxdata?.Value != null)
      return Convert.FromBase64String(openXmlElement.Gfxdata.Value) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetGfxdata(DXVml.Group openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.Gfxdata = Convert.ToBase64String(value);
    else
      openXmlElement.Gfxdata = null;
  }
  
  /// <summary>
  /// Group Diagram Type
  /// </summary>
  private static DMVml.EditAsKind? GetEditAs(DXVml.Group openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.EditAsValues, DMVml.EditAsKind>(openXmlElement?.EditAs?.Value);
  }
  
  private static bool CmpEditAs(DXVml.Group openXmlElement, DMVml.EditAsKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.EditAsValues, DMVml.EditAsKind>(openXmlElement?.EditAs?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEditAs(DXVml.Group openXmlElement, DMVml.EditAsKind? value)
  {
    openXmlElement.EditAs = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.EditAsValues, DMVml.EditAsKind>(value);
  }
  
  /// <summary>
  /// Table Properties
  /// </summary>
  private static String? GetTableProperties(DXVml.Group openXmlElement)
  {
    return openXmlElement?.TableProperties?.Value;
  }
  
  private static bool CmpTableProperties(DXVml.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.TableProperties?.Value == value;
  }
  
  private static void SetTableProperties(DXVml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.TableProperties = new StringValue { Value = value };
    else
      openXmlElement.TableProperties = null;
  }
  
  /// <summary>
  /// Table Row Height Limits
  /// </summary>
  private static String? GetTableLimits(DXVml.Group openXmlElement)
  {
    return openXmlElement?.TableLimits?.Value;
  }
  
  private static bool CmpTableLimits(DXVml.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.TableLimits?.Value == value;
  }
  
  private static void SetTableLimits(DXVml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.TableLimits = new StringValue { Value = value };
    else
      openXmlElement.TableLimits = null;
  }
  
  private static DMVml.Group? GetChildGroup(DXVml.Group openXmlElement)
  {
    return DMXVml.GroupConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Group>());
  }
  
  private static bool CmpChildGroup(DXVml.Group openXmlElement, DMVml.Group? value, DiffList? diffs, string? objName)
  {
    return DMXVml.GroupConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVml.Group>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChildGroup(DXVml.Group openXmlElement, DMVml.Group? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Group>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.GroupConverter.CreateOpenXmlElement<DXVml.Group>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Shape? GetShape(DXVml.Group openXmlElement)
  {
    return DMXVml.ShapeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Shape>());
  }
  
  private static bool CmpShape(DXVml.Group openXmlElement, DMVml.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShapeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVml.Shape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShape(DXVml.Group openXmlElement, DMVml.Shape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ShapeConverter.CreateOpenXmlElement<DXVml.Shape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Shapetype? GetShapetype(DXVml.Group openXmlElement)
  {
    return DMXVml.ShapetypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Shapetype>());
  }
  
  private static bool CmpShapetype(DXVml.Group openXmlElement, DMVml.Shapetype? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShapetypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVml.Shapetype>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapetype(DXVml.Group openXmlElement, DMVml.Shapetype? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Shapetype>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ShapetypeConverter.CreateOpenXmlElement<DXVml.Shapetype>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Arc? GetArc(DXVml.Group openXmlElement)
  {
    return DMXVml.ArcConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Arc>());
  }
  
  private static bool CmpArc(DXVml.Group openXmlElement, DMVml.Arc? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ArcConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVml.Arc>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetArc(DXVml.Group openXmlElement, DMVml.Arc? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Arc>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ArcConverter.CreateOpenXmlElement<DXVml.Arc>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Curve? GetCurve(DXVml.Group openXmlElement)
  {
    return DMXVml.CurveConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Curve>());
  }
  
  private static bool CmpCurve(DXVml.Group openXmlElement, DMVml.Curve? value, DiffList? diffs, string? objName)
  {
    return DMXVml.CurveConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVml.Curve>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCurve(DXVml.Group openXmlElement, DMVml.Curve? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Curve>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.CurveConverter.CreateOpenXmlElement<DXVml.Curve>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.ImageFile? GetImageFile(DXVml.Group openXmlElement)
  {
    return DMXVml.ImageFileConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.ImageFile>());
  }
  
  private static bool CmpImageFile(DXVml.Group openXmlElement, DMVml.ImageFile? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ImageFileConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVml.ImageFile>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetImageFile(DXVml.Group openXmlElement, DMVml.ImageFile? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.ImageFile>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ImageFileConverter.CreateOpenXmlElement<DXVml.ImageFile>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Line? GetLine(DXVml.Group openXmlElement)
  {
    return DMXVml.LineConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Line>());
  }
  
  private static bool CmpLine(DXVml.Group openXmlElement, DMVml.Line? value, DiffList? diffs, string? objName)
  {
    return DMXVml.LineConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVml.Line>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLine(DXVml.Group openXmlElement, DMVml.Line? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Line>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.LineConverter.CreateOpenXmlElement<DXVml.Line>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Oval? GetOval(DXVml.Group openXmlElement)
  {
    return DMXVml.OvalConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Oval>());
  }
  
  private static bool CmpOval(DXVml.Group openXmlElement, DMVml.Oval? value, DiffList? diffs, string? objName)
  {
    return DMXVml.OvalConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVml.Oval>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOval(DXVml.Group openXmlElement, DMVml.Oval? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Oval>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.OvalConverter.CreateOpenXmlElement<DXVml.Oval>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.PolyLine? GetPolyLine(DXVml.Group openXmlElement)
  {
    return DMXVml.PolyLineConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.PolyLine>());
  }
  
  private static bool CmpPolyLine(DXVml.Group openXmlElement, DMVml.PolyLine? value, DiffList? diffs, string? objName)
  {
    return DMXVml.PolyLineConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVml.PolyLine>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPolyLine(DXVml.Group openXmlElement, DMVml.PolyLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.PolyLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.PolyLineConverter.CreateOpenXmlElement<DXVml.PolyLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Rectangle? GetRectangle(DXVml.Group openXmlElement)
  {
    return DMXVml.RectangleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Rectangle>());
  }
  
  private static bool CmpRectangle(DXVml.Group openXmlElement, DMVml.Rectangle? value, DiffList? diffs, string? objName)
  {
    return DMXVml.RectangleConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVml.Rectangle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRectangle(DXVml.Group openXmlElement, DMVml.Rectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Rectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.RectangleConverter.CreateOpenXmlElement<DXVml.Rectangle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.RoundRectangle? GetRoundRectangle(DXVml.Group openXmlElement)
  {
    return DMXVml.RoundRectangleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.RoundRectangle>());
  }
  
  private static bool CmpRoundRectangle(DXVml.Group openXmlElement, DMVml.RoundRectangle? value, DiffList? diffs, string? objName)
  {
    return DMXVml.RoundRectangleConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVml.RoundRectangle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRoundRectangle(DXVml.Group openXmlElement, DMVml.RoundRectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.RoundRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.RoundRectangleConverter.CreateOpenXmlElement<DXVml.RoundRectangle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Diagram? GetDiagram(DXVml.Group openXmlElement)
  {
    return DMXVml.DiagramConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.Diagram>());
  }
  
  private static bool CmpDiagram(DXVml.Group openXmlElement, DMVml.Diagram? value, DiffList? diffs, string? objName)
  {
    return DMXVml.DiagramConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVmlO.Diagram>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDiagram(DXVml.Group openXmlElement, DMVml.Diagram? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.Diagram>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.DiagramConverter.CreateOpenXmlElement<DXVmlO.Diagram>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMVml.Lock? GetLock(DXVml.Group openXmlElement)
  {
    return DMXVml.LockConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.Lock>());
  }
  
  private static bool CmpLock(DXVml.Group openXmlElement, DMVml.Lock? value, DiffList? diffs, string? objName)
  {
    return DMXVml.LockConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVmlO.Lock>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLock(DXVml.Group openXmlElement, DMVml.Lock? value)
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
  
  private static DMVml.ClipPath? GetClipPath(DXVml.Group openXmlElement)
  {
    return DMXVml.ClipPathConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.ClipPath>());
  }
  
  private static bool CmpClipPath(DXVml.Group openXmlElement, DMVml.ClipPath? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ClipPathConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVmlO.ClipPath>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetClipPath(DXVml.Group openXmlElement, DMVml.ClipPath? value)
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
  
  private static DMWVml.TextWrap? GetTextWrap(DXVml.Group openXmlElement)
  {
    return DMXWVml.TextWrapConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlW.TextWrap>());
  }
  
  private static bool CmpTextWrap(DXVml.Group openXmlElement, DMWVml.TextWrap? value, DiffList? diffs, string? objName)
  {
    return DMXWVml.TextWrapConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVmlW.TextWrap>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextWrap(DXVml.Group openXmlElement, DMWVml.TextWrap? value)
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
  
  private static Boolean? GetAnchorLock(DXVml.Group openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXVmlW.AnchorLock>() != null;
  }
  
  private static bool CmpAnchorLock(DXVml.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXVmlW.AnchorLock>() != null == value;
  }
  
  private static void SetAnchorLock(DXVml.Group openXmlElement, Boolean? value)
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
  
  public static DMVml.Group? CreateModelElement(DXVml.Group? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Group();
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
  
  public static bool CompareModelElement(DXVml.Group? openXmlElement, DMVml.Group? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Group? value)
    where OpenXmlElementType: DXVml.Group, new()
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
      return openXmlElement;
    }
    return default;
  }
}

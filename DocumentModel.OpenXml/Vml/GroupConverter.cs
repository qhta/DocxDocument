namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Group.
/// </summary>
public static class GroupConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Vml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  private static String? GetStyle(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  private static void SetStyle(DocumentFormat.OpenXml.Vml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Style = new StringValue { Value = value };
    else
      openXmlElement.Style = null;
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  private static String? GetHref(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }
  
  private static void SetHref(DocumentFormat.OpenXml.Vml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Href = new StringValue { Value = value };
    else
      openXmlElement.Href = null;
  }
  
  /// <summary>
  /// Hyperlink Display Target
  /// </summary>
  private static String? GetTarget(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.Target?.Value;
  }
  
  private static void SetTarget(DocumentFormat.OpenXml.Vml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Target = new StringValue { Value = value };
    else
      openXmlElement.Target = null;
  }
  
  /// <summary>
  /// CSS Reference
  /// </summary>
  private static String? GetClass(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.Class?.Value;
  }
  
  private static void SetClass(DocumentFormat.OpenXml.Vml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Class = new StringValue { Value = value };
    else
      openXmlElement.Class = null;
  }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  private static String? GetTitle(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static void SetTitle(DocumentFormat.OpenXml.Vml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Alternate Text
  /// </summary>
  private static String? GetAlternate(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.Alternate?.Value;
  }
  
  private static void SetAlternate(DocumentFormat.OpenXml.Vml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Alternate = new StringValue { Value = value };
    else
      openXmlElement.Alternate = null;
  }
  
  /// <summary>
  /// Coordinate Space Size
  /// </summary>
  private static String? GetCoordinateSize(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.CoordinateSize?.Value;
  }
  
  private static void SetCoordinateSize(DocumentFormat.OpenXml.Vml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CoordinateSize = new StringValue { Value = value };
    else
      openXmlElement.CoordinateSize = null;
  }
  
  /// <summary>
  /// Coordinate Space Origin
  /// </summary>
  private static String? GetCoordinateOrigin(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.CoordinateOrigin?.Value;
  }
  
  private static void SetCoordinateOrigin(DocumentFormat.OpenXml.Vml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CoordinateOrigin = new StringValue { Value = value };
    else
      openXmlElement.CoordinateOrigin = null;
  }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  private static String? GetWrapCoordinates(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.WrapCoordinates?.Value;
  }
  
  private static void SetWrapCoordinates(DocumentFormat.OpenXml.Vml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.WrapCoordinates = new StringValue { Value = value };
    else
      openXmlElement.WrapCoordinates = null;
  }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  private static Boolean? GetPrint(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.Print?.Value;
  }
  
  private static void SetPrint(DocumentFormat.OpenXml.Vml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Print = value;
    else
      openXmlElement.Print = null;
  }
  
  /// <summary>
  /// spid
  /// </summary>
  private static String? GetOptionalString(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.OptionalString?.Value;
  }
  
  private static void SetOptionalString(DocumentFormat.OpenXml.Vml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OptionalString = new StringValue { Value = value };
    else
      openXmlElement.OptionalString = null;
  }
  
  /// <summary>
  /// oned
  /// </summary>
  private static Boolean? GetOned(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.Oned?.Value;
  }
  
  private static void SetOned(DocumentFormat.OpenXml.Vml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Oned = value;
    else
      openXmlElement.Oned = null;
  }
  
  /// <summary>
  /// regroupid
  /// </summary>
  private static Int64? GetRegroupId(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement.RegroupId?.Value;
  }
  
  private static void SetRegroupId(DocumentFormat.OpenXml.Vml.Group openXmlElement, Int64? value)
  {
    openXmlElement.RegroupId = value;
  }
  
  /// <summary>
  /// doubleclicknotify
  /// </summary>
  private static Boolean? GetDoubleClickNotify(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.DoubleClickNotify?.Value;
  }
  
  private static void SetDoubleClickNotify(DocumentFormat.OpenXml.Vml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DoubleClickNotify = value;
    else
      openXmlElement.DoubleClickNotify = null;
  }
  
  /// <summary>
  /// button
  /// </summary>
  private static Boolean? GetButton(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.Button?.Value;
  }
  
  private static void SetButton(DocumentFormat.OpenXml.Vml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Button = value;
    else
      openXmlElement.Button = null;
  }
  
  /// <summary>
  /// userhidden
  /// </summary>
  private static Boolean? GetUserHidden(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.UserHidden?.Value;
  }
  
  private static void SetUserHidden(DocumentFormat.OpenXml.Vml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserHidden = value;
    else
      openXmlElement.UserHidden = null;
  }
  
  /// <summary>
  /// bullet
  /// </summary>
  private static Boolean? GetBullet(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.Bullet?.Value;
  }
  
  private static void SetBullet(DocumentFormat.OpenXml.Vml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Bullet = value;
    else
      openXmlElement.Bullet = null;
  }
  
  /// <summary>
  /// hr
  /// </summary>
  private static Boolean? GetHorizontal(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.Horizontal?.Value;
  }
  
  private static void SetHorizontal(DocumentFormat.OpenXml.Vml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Horizontal = value;
    else
      openXmlElement.Horizontal = null;
  }
  
  /// <summary>
  /// hrstd
  /// </summary>
  private static Boolean? GetHorizontalStandard(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.HorizontalStandard?.Value;
  }
  
  private static void SetHorizontalStandard(DocumentFormat.OpenXml.Vml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalStandard = value;
    else
      openXmlElement.HorizontalStandard = null;
  }
  
  /// <summary>
  /// hrnoshade
  /// </summary>
  private static Boolean? GetHorizontalNoShade(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.HorizontalNoShade?.Value;
  }
  
  private static void SetHorizontalNoShade(DocumentFormat.OpenXml.Vml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalNoShade = value;
    else
      openXmlElement.HorizontalNoShade = null;
  }
  
  /// <summary>
  /// hrpct
  /// </summary>
  private static Single? GetHorizontalPercentage(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement.HorizontalPercentage?.Value;
  }
  
  private static void SetHorizontalPercentage(DocumentFormat.OpenXml.Vml.Group openXmlElement, Single? value)
  {
    openXmlElement.HorizontalPercentage = value;
  }
  
  /// <summary>
  /// hralign
  /// </summary>
  private static DocumentModel.Vml.HorizontalRuleAlignmentKind? GetHorizontalAlignment(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DocumentModel.Vml.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value);
  }
  
  private static void SetHorizontalAlignment(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.HorizontalRuleAlignmentKind? value)
  {
    openXmlElement.HorizontalAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DocumentModel.Vml.HorizontalRuleAlignmentKind>(value);
  }
  
  /// <summary>
  /// allowincell
  /// </summary>
  private static Boolean? GetAllowInCell(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }
  
  private static void SetAllowInCell(DocumentFormat.OpenXml.Vml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowInCell = value;
    else
      openXmlElement.AllowInCell = null;
  }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  private static Boolean? GetAllowOverlap(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  private static void SetAllowOverlap(DocumentFormat.OpenXml.Vml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowOverlap = value;
    else
      openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// userdrawn
  /// </summary>
  private static Boolean? GetUserDrawn(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.UserDrawn?.Value;
  }
  
  private static void SetUserDrawn(DocumentFormat.OpenXml.Vml.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserDrawn = value;
    else
      openXmlElement.UserDrawn = null;
  }
  
  /// <summary>
  /// dgmlayout
  /// </summary>
  private static Int64? GetDiagramLayout(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement.DiagramLayout?.Value;
  }
  
  private static void SetDiagramLayout(DocumentFormat.OpenXml.Vml.Group openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayout = value;
  }
  
  /// <summary>
  /// dgmnodekind
  /// </summary>
  private static Int64? GetDiagramNodeKind(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement.DiagramNodeKind?.Value;
  }
  
  private static void SetDiagramNodeKind(DocumentFormat.OpenXml.Vml.Group openXmlElement, Int64? value)
  {
    openXmlElement.DiagramNodeKind = value;
  }
  
  /// <summary>
  /// dgmlayoutmru
  /// </summary>
  private static Int64? GetDiagramLayoutMostRecentUsed(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement.DiagramLayoutMostRecentUsed?.Value;
  }
  
  private static void SetDiagramLayoutMostRecentUsed(DocumentFormat.OpenXml.Vml.Group openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayoutMostRecentUsed = value;
  }
  
  /// <summary>
  /// insetmode
  /// </summary>
  private static DocumentModel.Vml.InsetMarginKind? GetInsetMode(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DocumentModel.Vml.InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }
  
  private static void SetInsetMode(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.InsetMarginKind? value)
  {
    openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DocumentModel.Vml.InsetMarginKind>(value);
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  private static Byte[]? GetGfxdata(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    if (openXmlElement.Gfxdata?.Value != null)
      return Convert.FromBase64String(openXmlElement.Gfxdata.Value);
    return null;
  }
  
  private static void SetGfxdata(DocumentFormat.OpenXml.Vml.Group openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.Gfxdata = Convert.ToBase64String(value);
    else
      openXmlElement.Gfxdata = null;
  }
  
  /// <summary>
  /// Group Diagram Type
  /// </summary>
  private static DocumentModel.Vml.EditAsKind? GetEditAs(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.EditAsValues, DocumentModel.Vml.EditAsKind>(openXmlElement?.EditAs?.Value);
  }
  
  private static void SetEditAs(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.EditAsKind? value)
  {
    openXmlElement.EditAs = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.EditAsValues, DocumentModel.Vml.EditAsKind>(value);
  }
  
  /// <summary>
  /// Table Properties
  /// </summary>
  private static String? GetTableProperties(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.TableProperties?.Value;
  }
  
  private static void SetTableProperties(DocumentFormat.OpenXml.Vml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.TableProperties = new StringValue { Value = value };
    else
      openXmlElement.TableProperties = null;
  }
  
  /// <summary>
  /// Table Row Height Limits
  /// </summary>
  private static String? GetTableLimits(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    return openXmlElement?.TableLimits?.Value;
  }
  
  private static void SetTableLimits(DocumentFormat.OpenXml.Vml.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.TableLimits = new StringValue { Value = value };
    else
      openXmlElement.TableLimits = null;
  }
  
  private static DocumentModel.Vml.Group? GetChildGroup(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Group>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.GroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChildGroup(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.Group? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Group>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.GroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Group>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Shape? GetShape(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShape(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.Shape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.ShapeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Shape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Shapetype? GetShapetype(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shapetype>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShapetypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapetype(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.Shapetype? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shapetype>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.ShapetypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Shapetype>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Arc? GetArc(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Arc>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ArcConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArc(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.Arc? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Arc>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.ArcConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Arc>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Curve? GetCurve(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Curve>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.CurveConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCurve(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.Curve? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Curve>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.CurveConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Curve>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.ImageFile? GetImageFile(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageFile>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ImageFileConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetImageFile(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.ImageFile? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageFile>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.ImageFileConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.ImageFile>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Line? GetLine(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Line>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.LineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLine(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.Line? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Line>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.LineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Line>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Oval? GetOval(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Oval>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.OvalConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOval(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.Oval? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Oval>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.OvalConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Oval>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.PolyLine? GetPolyLine(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.PolyLine>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.PolyLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPolyLine(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.PolyLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.PolyLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.PolyLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.PolyLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Rectangle? GetRectangle(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Rectangle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.RectangleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRectangle(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.Rectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Rectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.RectangleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Rectangle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.RoundRectangle? GetRoundRectangle(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.RoundRectangle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.RoundRectangleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRoundRectangle(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.RoundRectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.RoundRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.RoundRectangleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.RoundRectangle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Diagram? GetDiagram(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Diagram>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.DiagramConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDiagram(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.Diagram? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Diagram>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.DiagramConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Diagram>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Lock? GetLock(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.LockConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLock(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.Lock? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.LockConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Lock>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.ClipPath? GetClipPath(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ClipPathConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetClipPath(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Vml.ClipPath? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.ClipPathConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.ClipPath>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.Vml.TextWrap? GetTextWrap(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Vml.TextWrapConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextWrap(DocumentFormat.OpenXml.Vml.Group openXmlElement, DocumentModel.Wordprocessing.Vml.TextWrap? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.Vml.TextWrapConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAnchorLock(DocumentFormat.OpenXml.Vml.Group openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
    return itemElement != null;
  }
  
  private static void SetAnchorLock(DocumentFormat.OpenXml.Vml.Group openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.Group? CreateModelElement(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Group? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Group, new()
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

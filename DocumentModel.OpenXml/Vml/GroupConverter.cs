using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml.Vml.Wordprocessing;
using DocumentModel.OpenXml.Wordprocessing.Vml;
using DocumentModel.Vml;
using Arc = DocumentModel.Vml.Arc;
using ClipPath = DocumentModel.Vml.ClipPath;
using Curve = DocumentModel.Vml.Curve;
using Diagram = DocumentModel.Vml.Diagram;
using ImageFile = DocumentModel.Vml.ImageFile;
using Line = DocumentModel.Vml.Line;
using Lock = DocumentModel.Vml.Lock;
using Oval = DocumentModel.Vml.Oval;
using PolyLine = DocumentModel.Vml.PolyLine;
using Rectangle = DocumentModel.Vml.Rectangle;
using RoundRectangle = DocumentModel.Vml.RoundRectangle;
using Shape = DocumentModel.Vml.Shape;
using Shapetype = DocumentModel.Vml.Shapetype;
using TextWrap = DocumentModel.Wordprocessing.Vml.TextWrap;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Shape Group.
/// </summary>
public static class GroupConverter
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Shape Styling Properties
  /// </summary>
  public static String? GetStyle(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }

  public static void SetStyle(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Style = new StringValue { Value = value };
      else
        openXmlElement.Style = null;
  }

  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  public static String? GetHref(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }

  public static void SetHref(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Href = new StringValue { Value = value };
      else
        openXmlElement.Href = null;
  }

  /// <summary>
  ///   Hyperlink Display Target
  /// </summary>
  public static String? GetTarget(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Target?.Value;
  }

  public static void SetTarget(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Target = new StringValue { Value = value };
      else
        openXmlElement.Target = null;
  }

  /// <summary>
  ///   CSS Reference
  /// </summary>
  public static String? GetClass(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Class?.Value;
  }

  public static void SetClass(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Class = new StringValue { Value = value };
      else
        openXmlElement.Class = null;
  }

  /// <summary>
  ///   Shape Title
  /// </summary>
  public static String? GetTitle(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }

  public static void SetTitle(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Title = new StringValue { Value = value };
      else
        openXmlElement.Title = null;
  }

  /// <summary>
  ///   Alternate Text
  /// </summary>
  public static String? GetAlternate(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Alternate?.Value;
  }

  public static void SetAlternate(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Alternate = new StringValue { Value = value };
      else
        openXmlElement.Alternate = null;
  }

  /// <summary>
  ///   Coordinate Space Size
  /// </summary>
  public static String? GetCoordinateSize(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.CoordinateSize?.Value;
  }

  public static void SetCoordinateSize(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CoordinateSize = new StringValue { Value = value };
      else
        openXmlElement.CoordinateSize = null;
  }

  /// <summary>
  ///   Coordinate Space Origin
  /// </summary>
  public static String? GetCoordinateOrigin(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.CoordinateOrigin?.Value;
  }

  public static void SetCoordinateOrigin(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CoordinateOrigin = new StringValue { Value = value };
      else
        openXmlElement.CoordinateOrigin = null;
  }

  /// <summary>
  ///   Shape Bounding Polygon
  /// </summary>
  public static String? GetWrapCoordinates(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.WrapCoordinates?.Value;
  }

  public static void SetWrapCoordinates(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.WrapCoordinates = new StringValue { Value = value };
      else
        openXmlElement.WrapCoordinates = null;
  }

  /// <summary>
  ///   Print Toggle
  /// </summary>
  public static Boolean? GetPrint(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Print?.Value;
  }

  public static void SetPrint(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Print = value;
      else
        openXmlElement.Print = null;
  }

  /// <summary>
  ///   spid
  /// </summary>
  public static String? GetOptionalString(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.OptionalString?.Value;
  }

  public static void SetOptionalString(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OptionalString = new StringValue { Value = value };
      else
        openXmlElement.OptionalString = null;
  }

  /// <summary>
  ///   oned
  /// </summary>
  public static Boolean? GetOned(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Oned?.Value;
  }

  public static void SetOned(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Oned = value;
      else
        openXmlElement.Oned = null;
  }

  /// <summary>
  ///   regroupid
  /// </summary>
  public static Int64? GetRegroupId(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.RegroupId?.Value;
  }

  public static void SetRegroupId(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.RegroupId = value;
  }

  /// <summary>
  ///   doubleclicknotify
  /// </summary>
  public static Boolean? GetDoubleClickNotify(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.DoubleClickNotify?.Value;
  }

  public static void SetDoubleClickNotify(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DoubleClickNotify = value;
      else
        openXmlElement.DoubleClickNotify = null;
  }

  /// <summary>
  ///   button
  /// </summary>
  public static Boolean? GetButton(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Button?.Value;
  }

  public static void SetButton(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Button = value;
      else
        openXmlElement.Button = null;
  }

  /// <summary>
  ///   userhidden
  /// </summary>
  public static Boolean? GetUserHidden(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.UserHidden?.Value;
  }

  public static void SetUserHidden(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UserHidden = value;
      else
        openXmlElement.UserHidden = null;
  }

  /// <summary>
  ///   bullet
  /// </summary>
  public static Boolean? GetBullet(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Bullet?.Value;
  }

  public static void SetBullet(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Bullet = value;
      else
        openXmlElement.Bullet = null;
  }

  /// <summary>
  ///   hr
  /// </summary>
  public static Boolean? GetHorizontal(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Horizontal?.Value;
  }

  public static void SetHorizontal(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Horizontal = value;
      else
        openXmlElement.Horizontal = null;
  }

  /// <summary>
  ///   hrstd
  /// </summary>
  public static Boolean? GetHorizontalStandard(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.HorizontalStandard?.Value;
  }

  public static void SetHorizontalStandard(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HorizontalStandard = value;
      else
        openXmlElement.HorizontalStandard = null;
  }

  /// <summary>
  ///   hrnoshade
  /// </summary>
  public static Boolean? GetHorizontalNoShade(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.HorizontalNoShade?.Value;
  }

  public static void SetHorizontalNoShade(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HorizontalNoShade = value;
      else
        openXmlElement.HorizontalNoShade = null;
  }

  /// <summary>
  ///   hrpct
  /// </summary>
  public static Single? GetHorizontalPercentage(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.HorizontalPercentage?.Value;
  }

  public static void SetHorizontalPercentage(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Single? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalPercentage = value;
  }

  /// <summary>
  ///   hralign
  /// </summary>
  public static HorizontalRuleAlignmentKind? GetHorizontalAlignment(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return EnumValueConverter.GetValue<HorizontalRuleAlignmentValues, HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value);
  }

  public static void SetHorizontalAlignment(DocumentFormat.OpenXml.Vml.Group? openXmlElement, HorizontalRuleAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalAlignment = EnumValueConverter.CreateEnumValue<HorizontalRuleAlignmentValues, HorizontalRuleAlignmentKind>(value);
  }

  /// <summary>
  ///   allowincell
  /// </summary>
  public static Boolean? GetAllowInCell(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }

  public static void SetAllowInCell(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowInCell = value;
      else
        openXmlElement.AllowInCell = null;
  }

  /// <summary>
  ///   allowoverlap
  /// </summary>
  public static Boolean? GetAllowOverlap(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }

  public static void SetAllowOverlap(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowOverlap = value;
      else
        openXmlElement.AllowOverlap = null;
  }

  /// <summary>
  ///   userdrawn
  /// </summary>
  public static Boolean? GetUserDrawn(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.UserDrawn?.Value;
  }

  public static void SetUserDrawn(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UserDrawn = value;
      else
        openXmlElement.UserDrawn = null;
  }

  /// <summary>
  ///   dgmlayout
  /// </summary>
  public static Int64? GetDiagramLayout(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.DiagramLayout?.Value;
  }

  public static void SetDiagramLayout(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DiagramLayout = value;
  }

  /// <summary>
  ///   dgmnodekind
  /// </summary>
  public static Int64? GetDiagramNodeKind(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.DiagramNodeKind?.Value;
  }

  public static void SetDiagramNodeKind(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DiagramNodeKind = value;
  }

  /// <summary>
  ///   dgmlayoutmru
  /// </summary>
  public static Int64? GetDiagramLayoutMostRecentUsed(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.DiagramLayoutMostRecentUsed?.Value;
  }

  public static void SetDiagramLayoutMostRecentUsed(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DiagramLayoutMostRecentUsed = value;
  }

  /// <summary>
  ///   insetmode
  /// </summary>
  public static InsetMarginKind? GetInsetMode(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return EnumValueConverter.GetValue<InsetMarginValues, InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }

  public static void SetInsetMode(DocumentFormat.OpenXml.Vml.Group? openXmlElement, InsetMarginKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<InsetMarginValues, InsetMarginKind>(value);
  }

  /// <summary>
  ///   Encoded Package
  /// </summary>
  public static Byte[]? GetGfxdata(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    if (openXmlElement?.Gfxdata?.Value != null)
      return Convert.FromBase64String(openXmlElement.Gfxdata.Value);
    return null;
  }

  public static void SetGfxdata(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Gfxdata = Convert.ToBase64String(value);
      else
        openXmlElement.Gfxdata = null;
    }
  }

  /// <summary>
  ///   Group Diagram Type
  /// </summary>
  public static EditAsKind? GetEditAs(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return EnumValueConverter.GetValue<EditAsValues, EditAsKind>(openXmlElement?.EditAs?.Value);
  }

  public static void SetEditAs(DocumentFormat.OpenXml.Vml.Group? openXmlElement, EditAsKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EditAs = EnumValueConverter.CreateEnumValue<EditAsValues, EditAsKind>(value);
  }

  /// <summary>
  ///   Table Properties
  /// </summary>
  public static String? GetTableProperties(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.TableProperties?.Value;
  }

  public static void SetTableProperties(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TableProperties = new StringValue { Value = value };
      else
        openXmlElement.TableProperties = null;
  }

  /// <summary>
  ///   Table Row Height Limits
  /// </summary>
  public static String? GetTableLimits(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.TableLimits?.Value;
  }

  public static void SetTableLimits(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TableLimits = new StringValue { Value = value };
      else
        openXmlElement.TableLimits = null;
  }

  public static DocumentModel.Vml.Group? GetChildGroup(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Group>();
    if (itemElement != null)
      return CreateModelElement(itemElement);
    return null;
  }

  public static void SetChildGroup(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.Group? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Group>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Group>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Shape? GetShape(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shape>();
    if (itemElement != null)
      return ShapeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShape(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Shape? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Shape>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Shapetype? GetShapetype(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shapetype>();
    if (itemElement != null)
      return ShapetypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapetype(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Shapetype? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shapetype>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapetypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Shapetype>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Arc? GetArc(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Arc>();
    if (itemElement != null)
      return ArcConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArc(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Arc? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Arc>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArcConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Arc>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Curve? GetCurve(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Curve>();
    if (itemElement != null)
      return CurveConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCurve(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Curve? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Curve>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CurveConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Curve>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ImageFile? GetImageFile(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageFile>();
    if (itemElement != null)
      return ImageFileConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetImageFile(DocumentFormat.OpenXml.Vml.Group? openXmlElement, ImageFile? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageFile>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ImageFileConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.ImageFile>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Line? GetLine(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Line>();
    if (itemElement != null)
      return LineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLine(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Line? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Line>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Line>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Oval? GetOval(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Oval>();
    if (itemElement != null)
      return OvalConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOval(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Oval? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Oval>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OvalConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Oval>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PolyLine? GetPolyLine(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.PolyLine>();
    if (itemElement != null)
      return PolyLineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPolyLine(DocumentFormat.OpenXml.Vml.Group? openXmlElement, PolyLine? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.PolyLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PolyLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.PolyLine>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Rectangle? GetRectangle(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Rectangle>();
    if (itemElement != null)
      return RectangleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRectangle(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Rectangle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Rectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RectangleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Rectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RoundRectangle? GetRoundRectangle(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.RoundRectangle>();
    if (itemElement != null)
      return RoundRectangleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRoundRectangle(DocumentFormat.OpenXml.Vml.Group? openXmlElement, RoundRectangle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.RoundRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RoundRectangleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.RoundRectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Diagram? GetDiagram(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Diagram>();
    if (itemElement != null)
      return DiagramConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDiagram(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Diagram? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Diagram>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DiagramConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Diagram>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Lock? GetLock(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
    if (itemElement != null)
      return LockConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLock(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Lock? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LockConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Lock>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ClipPath? GetClipPath(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
    if (itemElement != null)
      return ClipPathConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetClipPath(DocumentFormat.OpenXml.Vml.Group? openXmlElement, ClipPath? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ClipPathConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.ClipPath>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextWrap? GetTextWrap(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
    if (itemElement != null)
      return TextWrapConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextWrap(DocumentFormat.OpenXml.Vml.Group? openXmlElement, TextWrap? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextWrapConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetAnchorLock(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AnchorLock>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAnchorLock(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AnchorLock>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AnchorLock();
        openXmlElement.AddChild(itemElement);
      }
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
    where OpenXmlElementType : DocumentFormat.OpenXml.Vml.Group, new()
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
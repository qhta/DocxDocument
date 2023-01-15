using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml.Vml.Wordprocessing;
using DocumentModel.OpenXml.Wordprocessing.Vml;
using DocumentModel.Vml;
using BorderType = DocumentModel.Wordprocessing.Vml.BorderType;
using Callout = DocumentModel.Vml.Callout;
using ClipPath = DocumentModel.Vml.ClipPath;
using Extrusion = DocumentModel.Vml.Extrusion;
using Line = DocumentFormat.OpenXml.Vml.Line;
using Lock = DocumentModel.Vml.Lock;
using Path = DocumentModel.Vml.Path;
using SignatureLine = DocumentModel.Vml.SignatureLine;
using Skew = DocumentModel.Vml.Skew;
using TextWrap = DocumentModel.Wordprocessing.Vml.TextWrap;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Line.
/// </summary>
public static class LineConverter
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public static String? GetId(Line? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(Line? openXmlElement, String? value)
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
  public static String? GetStyle(Line? openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }

  public static void SetStyle(Line? openXmlElement, String? value)
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
  public static String? GetHref(Line? openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }

  public static void SetHref(Line? openXmlElement, String? value)
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
  public static String? GetTarget(Line? openXmlElement)
  {
    return openXmlElement?.Target?.Value;
  }

  public static void SetTarget(Line? openXmlElement, String? value)
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
  public static String? GetClass(Line? openXmlElement)
  {
    return openXmlElement?.Class?.Value;
  }

  public static void SetClass(Line? openXmlElement, String? value)
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
  public static String? GetTitle(Line? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }

  public static void SetTitle(Line? openXmlElement, String? value)
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
  public static String? GetAlternate(Line? openXmlElement)
  {
    return openXmlElement?.Alternate?.Value;
  }

  public static void SetAlternate(Line? openXmlElement, String? value)
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
  public static String? GetCoordinateSize(Line? openXmlElement)
  {
    return openXmlElement?.CoordinateSize?.Value;
  }

  public static void SetCoordinateSize(Line? openXmlElement, String? value)
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
  public static String? GetCoordinateOrigin(Line? openXmlElement)
  {
    return openXmlElement?.CoordinateOrigin?.Value;
  }

  public static void SetCoordinateOrigin(Line? openXmlElement, String? value)
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
  public static String? GetWrapCoordinates(Line? openXmlElement)
  {
    return openXmlElement?.WrapCoordinates?.Value;
  }

  public static void SetWrapCoordinates(Line? openXmlElement, String? value)
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
  public static Boolean? GetPrint(Line? openXmlElement)
  {
    return openXmlElement?.Print?.Value;
  }

  public static void SetPrint(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Print = value;
      else
        openXmlElement.Print = null;
  }

  /// <summary>
  ///   Optional String
  /// </summary>
  public static String? GetOptionalString(Line? openXmlElement)
  {
    return openXmlElement?.OptionalString?.Value;
  }

  public static void SetOptionalString(Line? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OptionalString = new StringValue { Value = value };
      else
        openXmlElement.OptionalString = null;
  }

  /// <summary>
  ///   Shape Handle Toggle
  /// </summary>
  public static Boolean? GetOned(Line? openXmlElement)
  {
    return openXmlElement?.Oned?.Value;
  }

  public static void SetOned(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Oned = value;
      else
        openXmlElement.Oned = null;
  }

  /// <summary>
  ///   Regroup ID
  /// </summary>
  public static Int64? GetRegroupId(Line? openXmlElement)
  {
    return openXmlElement?.RegroupId?.Value;
  }

  public static void SetRegroupId(Line? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.RegroupId = value;
  }

  /// <summary>
  ///   Double-click Notification Toggle
  /// </summary>
  public static Boolean? GetDoubleClickNotify(Line? openXmlElement)
  {
    return openXmlElement?.DoubleClickNotify?.Value;
  }

  public static void SetDoubleClickNotify(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DoubleClickNotify = value;
      else
        openXmlElement.DoubleClickNotify = null;
  }

  /// <summary>
  ///   Button Behavior Toggle
  /// </summary>
  public static Boolean? GetButton(Line? openXmlElement)
  {
    return openXmlElement?.Button?.Value;
  }

  public static void SetButton(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Button = value;
      else
        openXmlElement.Button = null;
  }

  /// <summary>
  ///   Hide Script Anchors
  /// </summary>
  public static Boolean? GetUserHidden(Line? openXmlElement)
  {
    return openXmlElement?.UserHidden?.Value;
  }

  public static void SetUserHidden(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UserHidden = value;
      else
        openXmlElement.UserHidden = null;
  }

  /// <summary>
  ///   Graphical Bullet
  /// </summary>
  public static Boolean? GetBullet(Line? openXmlElement)
  {
    return openXmlElement?.Bullet?.Value;
  }

  public static void SetBullet(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Bullet = value;
      else
        openXmlElement.Bullet = null;
  }

  /// <summary>
  ///   Horizontal Rule Toggle
  /// </summary>
  public static Boolean? GetHorizontal(Line? openXmlElement)
  {
    return openXmlElement?.Horizontal?.Value;
  }

  public static void SetHorizontal(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Horizontal = value;
      else
        openXmlElement.Horizontal = null;
  }

  /// <summary>
  ///   Horizontal Rule Standard Display Toggle
  /// </summary>
  public static Boolean? GetHorizontalStandard(Line? openXmlElement)
  {
    return openXmlElement?.HorizontalStandard?.Value;
  }

  public static void SetHorizontalStandard(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HorizontalStandard = value;
      else
        openXmlElement.HorizontalStandard = null;
  }

  /// <summary>
  ///   Horizontal Rule 3D Shading Toggle
  /// </summary>
  public static Boolean? GetHorizontalNoShade(Line? openXmlElement)
  {
    return openXmlElement?.HorizontalNoShade?.Value;
  }

  public static void SetHorizontalNoShade(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HorizontalNoShade = value;
      else
        openXmlElement.HorizontalNoShade = null;
  }

  /// <summary>
  ///   Horizontal Rule Length Percentage
  /// </summary>
  public static Single? GetHorizontalPercentage(Line? openXmlElement)
  {
    return openXmlElement?.HorizontalPercentage?.Value;
  }

  public static void SetHorizontalPercentage(Line? openXmlElement, Single? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalPercentage = value;
  }

  /// <summary>
  ///   Horizontal Rule Alignment
  /// </summary>
  public static HorizontalRuleAlignmentKind? GetHorizontalAlignment(Line? openXmlElement)
  {
    return EnumValueConverter.GetValue<HorizontalRuleAlignmentValues, HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value);
  }

  public static void SetHorizontalAlignment(Line? openXmlElement, HorizontalRuleAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalAlignment = EnumValueConverter.CreateEnumValue<HorizontalRuleAlignmentValues, HorizontalRuleAlignmentKind>(value);
  }

  /// <summary>
  ///   Allow in Table Cell
  /// </summary>
  public static Boolean? GetAllowInCell(Line? openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }

  public static void SetAllowInCell(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowInCell = value;
      else
        openXmlElement.AllowInCell = null;
  }

  /// <summary>
  ///   Allow Shape Overlap
  /// </summary>
  public static Boolean? GetAllowOverlap(Line? openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }

  public static void SetAllowOverlap(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowOverlap = value;
      else
        openXmlElement.AllowOverlap = null;
  }

  /// <summary>
  ///   Exists In Master Slide
  /// </summary>
  public static Boolean? GetUserDrawn(Line? openXmlElement)
  {
    return openXmlElement?.UserDrawn?.Value;
  }

  public static void SetUserDrawn(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UserDrawn = value;
      else
        openXmlElement.UserDrawn = null;
  }

  /// <summary>
  ///   Border Top Color
  /// </summary>
  public static String? GetBorderTopColor(Line? openXmlElement)
  {
    return openXmlElement?.BorderTopColor?.Value;
  }

  public static void SetBorderTopColor(Line? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BorderTopColor = new StringValue { Value = value };
      else
        openXmlElement.BorderTopColor = null;
  }

  /// <summary>
  ///   Border Left Color
  /// </summary>
  public static String? GetBorderLeftColor(Line? openXmlElement)
  {
    return openXmlElement?.BorderLeftColor?.Value;
  }

  public static void SetBorderLeftColor(Line? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BorderLeftColor = new StringValue { Value = value };
      else
        openXmlElement.BorderLeftColor = null;
  }

  /// <summary>
  ///   Bottom Border Color
  /// </summary>
  public static String? GetBorderBottomColor(Line? openXmlElement)
  {
    return openXmlElement?.BorderBottomColor?.Value;
  }

  public static void SetBorderBottomColor(Line? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BorderBottomColor = new StringValue { Value = value };
      else
        openXmlElement.BorderBottomColor = null;
  }

  /// <summary>
  ///   Border Right Color
  /// </summary>
  public static String? GetBorderRightColor(Line? openXmlElement)
  {
    return openXmlElement?.BorderRightColor?.Value;
  }

  public static void SetBorderRightColor(Line? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BorderRightColor = new StringValue { Value = value };
      else
        openXmlElement.BorderRightColor = null;
  }

  /// <summary>
  ///   Diagram Node Layout Identifier
  /// </summary>
  public static Int64? GetDiagramLayout(Line? openXmlElement)
  {
    return openXmlElement?.DiagramLayout?.Value;
  }

  public static void SetDiagramLayout(Line? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DiagramLayout = value;
  }

  /// <summary>
  ///   Diagram Node Identifier
  /// </summary>
  public static Int64? GetDiagramNodeKind(Line? openXmlElement)
  {
    return openXmlElement?.DiagramNodeKind?.Value;
  }

  public static void SetDiagramNodeKind(Line? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DiagramNodeKind = value;
  }

  /// <summary>
  ///   Diagram Node Recent Layout Identifier
  /// </summary>
  public static Int64? GetDiagramLayoutMostRecentUsed(Line? openXmlElement)
  {
    return openXmlElement?.DiagramLayoutMostRecentUsed?.Value;
  }

  public static void SetDiagramLayoutMostRecentUsed(Line? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DiagramLayoutMostRecentUsed = value;
  }

  /// <summary>
  ///   Text Inset Mode
  /// </summary>
  public static InsetMarginKind? GetInsetMode(Line? openXmlElement)
  {
    return EnumValueConverter.GetValue<InsetMarginValues, InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }

  public static void SetInsetMode(Line? openXmlElement, InsetMarginKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<InsetMarginValues, InsetMarginKind>(value);
  }

  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  public static Boolean? GetFilled(Line? openXmlElement)
  {
    return openXmlElement?.Filled?.Value;
  }

  public static void SetFilled(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Filled = value;
      else
        openXmlElement.Filled = null;
  }

  /// <summary>
  ///   Fill Color
  /// </summary>
  public static String? GetFillColor(Line? openXmlElement)
  {
    return openXmlElement?.FillColor?.Value;
  }

  public static void SetFillColor(Line? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FillColor = new StringValue { Value = value };
      else
        openXmlElement.FillColor = null;
  }

  /// <summary>
  ///   Shape Stroke Toggle
  /// </summary>
  public static Boolean? GetStroked(Line? openXmlElement)
  {
    return openXmlElement?.Stroked?.Value;
  }

  public static void SetStroked(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Stroked = value;
      else
        openXmlElement.Stroked = null;
  }

  /// <summary>
  ///   Shape Stroke Color
  /// </summary>
  public static String? GetStrokeColor(Line? openXmlElement)
  {
    return openXmlElement?.StrokeColor?.Value;
  }

  public static void SetStrokeColor(Line? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StrokeColor = new StringValue { Value = value };
      else
        openXmlElement.StrokeColor = null;
  }

  /// <summary>
  ///   Shape Stroke Weight
  /// </summary>
  public static String? GetStrokeWeight(Line? openXmlElement)
  {
    return openXmlElement?.StrokeWeight?.Value;
  }

  public static void SetStrokeWeight(Line? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StrokeWeight = new StringValue { Value = value };
      else
        openXmlElement.StrokeWeight = null;
  }

  /// <summary>
  ///   Inset Border From Path
  /// </summary>
  public static Boolean? GetInsetPen(Line? openXmlElement)
  {
    return openXmlElement?.InsetPen?.Value;
  }

  public static void SetInsetPen(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsetPen = value;
      else
        openXmlElement.InsetPen = null;
  }

  /// <summary>
  ///   Optional Number
  /// </summary>
  public static Int32? GetOptionalNumber(Line? openXmlElement)
  {
    return openXmlElement?.OptionalNumber?.Value;
  }

  public static void SetOptionalNumber(Line? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.OptionalNumber = value;
  }

  /// <summary>
  ///   Shape Connector Type
  /// </summary>
  public static ConnectorKind? GetConnectorType(Line? openXmlElement)
  {
    return EnumValueConverter.GetValue<ConnectorValues, ConnectorKind>(openXmlElement?.ConnectorType?.Value);
  }

  public static void SetConnectorType(Line? openXmlElement, ConnectorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ConnectorType = EnumValueConverter.CreateEnumValue<ConnectorValues, ConnectorKind>(value);
  }

  /// <summary>
  ///   Black-and-White Mode
  /// </summary>
  public static BlackAndWhiteMode? GetBlackWhiteMode(Line? openXmlElement)
  {
    return EnumValueConverter.GetValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }

  public static void SetBlackWhiteMode(Line? openXmlElement, BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(value);
  }

  /// <summary>
  ///   Pure Black-and-White Mode
  /// </summary>
  public static BlackAndWhiteMode? GetPureBlackWhiteMode(Line? openXmlElement)
  {
    return EnumValueConverter.GetValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value);
  }

  public static void SetPureBlackWhiteMode(Line? openXmlElement, BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.PureBlackWhiteMode = EnumValueConverter.CreateEnumValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(value);
  }

  /// <summary>
  ///   Normal Black-and-White Mode
  /// </summary>
  public static BlackAndWhiteMode? GetNormalBlackWhiteMode(Line? openXmlElement)
  {
    return EnumValueConverter.GetValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value);
  }

  public static void SetNormalBlackWhiteMode(Line? openXmlElement, BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.NormalBlackWhiteMode = EnumValueConverter.CreateEnumValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(value);
  }

  /// <summary>
  ///   Force Dashed Outline
  /// </summary>
  public static Boolean? GetForceDash(Line? openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }

  public static void SetForceDash(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ForceDash = value;
      else
        openXmlElement.ForceDash = null;
  }

  /// <summary>
  ///   Embedded Object Icon Toggle
  /// </summary>
  public static Boolean? GetOleIcon(Line? openXmlElement)
  {
    return openXmlElement?.OleIcon?.Value;
  }

  public static void SetOleIcon(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OleIcon = value;
      else
        openXmlElement.OleIcon = null;
  }

  /// <summary>
  ///   Embedded Object Toggle
  /// </summary>
  public static Boolean? GetOle(Line? openXmlElement)
  {
    return openXmlElement?.Ole?.Value;
  }

  public static void SetOle(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Ole = value;
      else
        openXmlElement.Ole = null;
  }

  /// <summary>
  ///   Relative Resize Toggle
  /// </summary>
  public static Boolean? GetPreferRelative(Line? openXmlElement)
  {
    return openXmlElement?.PreferRelative?.Value;
  }

  public static void SetPreferRelative(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PreferRelative = value;
      else
        openXmlElement.PreferRelative = null;
  }

  /// <summary>
  ///   Clip to Wrapping Polygon
  /// </summary>
  public static Boolean? GetClipToWrap(Line? openXmlElement)
  {
    return openXmlElement?.ClipToWrap?.Value;
  }

  public static void SetClipToWrap(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ClipToWrap = value;
      else
        openXmlElement.ClipToWrap = null;
  }

  /// <summary>
  ///   Clipping Toggle
  /// </summary>
  public static Boolean? GetClip(Line? openXmlElement)
  {
    return openXmlElement?.Clip?.Value;
  }

  public static void SetClip(Line? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Clip = value;
      else
        openXmlElement.Clip = null;
  }

  /// <summary>
  ///   Encoded Package
  /// </summary>
  public static Byte[]? GetGfxdata(Line? openXmlElement)
  {
    if (openXmlElement?.Gfxdata?.Value != null)
      return Convert.FromBase64String(openXmlElement.Gfxdata.Value);
    return null;
  }

  public static void SetGfxdata(Line? openXmlElement, Byte[]? value)
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
  ///   Line Start
  /// </summary>
  public static String? GetFrom(Line? openXmlElement)
  {
    return openXmlElement?.From?.Value;
  }

  public static void SetFrom(Line? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.From = new StringValue { Value = value };
      else
        openXmlElement.From = null;
  }

  /// <summary>
  ///   Line End Point
  /// </summary>
  public static String? GetTo(Line? openXmlElement)
  {
    return openXmlElement?.To?.Value;
  }

  public static void SetTo(Line? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.To = new StringValue { Value = value };
      else
        openXmlElement.To = null;
  }

  public static Path? GetPath(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Path>();
    if (itemElement != null)
      return PathConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPath(Line? openXmlElement, Path? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Path>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PathConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Path>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Formulas? GetFormulas(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Formulas>();
    if (itemElement != null)
      return FormulasConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFormulas(Line? openXmlElement, Formulas? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Formulas>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormulasConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Formulas>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ShapeHandles? GetShapeHandles(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
    if (itemElement != null)
      return ShapeHandlesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeHandles(Line? openXmlElement, ShapeHandles? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeHandlesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.ShapeHandles>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Fill? GetFill(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
    if (itemElement != null)
      return FillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFill(Line? openXmlElement, Fill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Fill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Stroke? GetStroke(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Stroke>();
    if (itemElement != null)
      return StrokeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStroke(Line? openXmlElement, Stroke? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Stroke>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrokeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Stroke>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Shadow? GetShadow(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shadow>();
    if (itemElement != null)
      return ShadowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShadow(Line? openXmlElement, Shadow? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shadow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShadowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Shadow>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextBox? GetTextBox(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.TextBox>();
    if (itemElement != null)
      return TextBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextBox(Line? openXmlElement, TextBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.TextBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.TextBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextPath? GetTextPath(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.TextPath>();
    if (itemElement != null)
      return TextPathConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextPath(Line? openXmlElement, TextPath? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.TextPath>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextPathConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.TextPath>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ImageData? GetImageData(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageData>();
    if (itemElement != null)
      return ImageDataConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetImageData(Line? openXmlElement, ImageData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ImageDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.ImageData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Skew? GetSkew(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
    if (itemElement != null)
      return SkewConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSkew(Line? openXmlElement, Skew? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SkewConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Skew>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Extrusion? GetExtrusion(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
    if (itemElement != null)
      return ExtrusionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtrusion(Line? openXmlElement, Extrusion? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtrusionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Extrusion>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Callout? GetCallout(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
    if (itemElement != null)
      return CalloutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCallout(Line? openXmlElement, Callout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CalloutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Callout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Lock? GetLock(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
    if (itemElement != null)
      return LockConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLock(Line? openXmlElement, Lock? value)
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

  public static ClipPath? GetClipPath(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
    if (itemElement != null)
      return ClipPathConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetClipPath(Line? openXmlElement, ClipPath? value)
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

  public static SignatureLine? GetSignatureLine(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
    if (itemElement != null)
      return SignatureLineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSignatureLine(Line? openXmlElement, SignatureLine? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SignatureLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.SignatureLine>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextWrap? GetTextWrap(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
    if (itemElement != null)
      return TextWrapConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextWrap(Line? openXmlElement, TextWrap? value)
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

  public static Boolean? GetAnchorLock(Line? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AnchorLock>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAnchorLock(Line? openXmlElement, Boolean? value)
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

  public static BorderType? GetTopBorder(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TopBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTopBorder(Line? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TopBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<TopBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BorderType? GetBottomBorder(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BottomBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBottomBorder(Line? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BottomBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<BottomBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BorderType? GetLeftBorder(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LeftBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLeftBorder(Line? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LeftBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<LeftBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BorderType? GetRightBorder(Line? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RightBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRightBorder(Line? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RightBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<RightBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Vml.Line? CreateModelElement(Line? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Line();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Line? value)
    where OpenXmlElementType : Line, new()
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
      SetFrom(openXmlElement, value?.From);
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
      return openXmlElement;
    }
    return default;
  }
}
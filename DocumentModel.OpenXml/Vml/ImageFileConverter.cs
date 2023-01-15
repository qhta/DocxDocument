using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml.Vml.Wordprocessing;
using DocumentModel.OpenXml.Wordprocessing.Vml;
using DocumentModel.Vml;
using BorderType = DocumentModel.Wordprocessing.Vml.BorderType;
using Callout = DocumentModel.Vml.Callout;
using ClipPath = DocumentModel.Vml.ClipPath;
using Extrusion = DocumentModel.Vml.Extrusion;
using ImageFile = DocumentFormat.OpenXml.Vml.ImageFile;
using Lock = DocumentModel.Vml.Lock;
using Path = DocumentModel.Vml.Path;
using SignatureLine = DocumentModel.Vml.SignatureLine;
using Skew = DocumentModel.Vml.Skew;
using TextWrap = DocumentModel.Wordprocessing.Vml.TextWrap;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Image File.
/// </summary>
public static class ImageFileConverter
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public static String? GetId(ImageFile? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   style
  /// </summary>
  public static String? GetStyle(ImageFile? openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }

  public static void SetStyle(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Style = new StringValue { Value = value };
      else
        openXmlElement.Style = null;
  }

  /// <summary>
  ///   href
  /// </summary>
  public static String? GetHref(ImageFile? openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }

  public static void SetHref(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Href = new StringValue { Value = value };
      else
        openXmlElement.Href = null;
  }

  /// <summary>
  ///   target
  /// </summary>
  public static String? GetTarget(ImageFile? openXmlElement)
  {
    return openXmlElement?.Target?.Value;
  }

  public static void SetTarget(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Target = new StringValue { Value = value };
      else
        openXmlElement.Target = null;
  }

  /// <summary>
  ///   class
  /// </summary>
  public static String? GetClass(ImageFile? openXmlElement)
  {
    return openXmlElement?.Class?.Value;
  }

  public static void SetClass(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Class = new StringValue { Value = value };
      else
        openXmlElement.Class = null;
  }

  /// <summary>
  ///   title
  /// </summary>
  public static String? GetTitle(ImageFile? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }

  public static void SetTitle(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Title = new StringValue { Value = value };
      else
        openXmlElement.Title = null;
  }

  /// <summary>
  ///   alt
  /// </summary>
  public static String? GetAlternate(ImageFile? openXmlElement)
  {
    return openXmlElement?.Alternate?.Value;
  }

  public static void SetAlternate(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Alternate = new StringValue { Value = value };
      else
        openXmlElement.Alternate = null;
  }

  /// <summary>
  ///   coordsize
  /// </summary>
  public static String? GetCoordinateSize(ImageFile? openXmlElement)
  {
    return openXmlElement?.CoordinateSize?.Value;
  }

  public static void SetCoordinateSize(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CoordinateSize = new StringValue { Value = value };
      else
        openXmlElement.CoordinateSize = null;
  }

  /// <summary>
  ///   wrapcoords
  /// </summary>
  public static String? GetWrapCoordinates(ImageFile? openXmlElement)
  {
    return openXmlElement?.WrapCoordinates?.Value;
  }

  public static void SetWrapCoordinates(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.WrapCoordinates = new StringValue { Value = value };
      else
        openXmlElement.WrapCoordinates = null;
  }

  /// <summary>
  ///   print
  /// </summary>
  public static Boolean? GetPrint(ImageFile? openXmlElement)
  {
    return openXmlElement?.Print?.Value;
  }

  public static void SetPrint(ImageFile? openXmlElement, Boolean? value)
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
  public static String? GetOptionalString(ImageFile? openXmlElement)
  {
    return openXmlElement?.OptionalString?.Value;
  }

  public static void SetOptionalString(ImageFile? openXmlElement, String? value)
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
  public static Boolean? GetOned(ImageFile? openXmlElement)
  {
    return openXmlElement?.Oned?.Value;
  }

  public static void SetOned(ImageFile? openXmlElement, Boolean? value)
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
  public static Int64? GetRegroupId(ImageFile? openXmlElement)
  {
    return openXmlElement?.RegroupId?.Value;
  }

  public static void SetRegroupId(ImageFile? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.RegroupId = value;
  }

  /// <summary>
  ///   Double-click Notification Toggle
  /// </summary>
  public static Boolean? GetDoubleClickNotify(ImageFile? openXmlElement)
  {
    return openXmlElement?.DoubleClickNotify?.Value;
  }

  public static void SetDoubleClickNotify(ImageFile? openXmlElement, Boolean? value)
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
  public static Boolean? GetButton(ImageFile? openXmlElement)
  {
    return openXmlElement?.Button?.Value;
  }

  public static void SetButton(ImageFile? openXmlElement, Boolean? value)
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
  public static Boolean? GetUserHidden(ImageFile? openXmlElement)
  {
    return openXmlElement?.UserHidden?.Value;
  }

  public static void SetUserHidden(ImageFile? openXmlElement, Boolean? value)
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
  public static Boolean? GetBullet(ImageFile? openXmlElement)
  {
    return openXmlElement?.Bullet?.Value;
  }

  public static void SetBullet(ImageFile? openXmlElement, Boolean? value)
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
  public static Boolean? GetHorizontal(ImageFile? openXmlElement)
  {
    return openXmlElement?.Horizontal?.Value;
  }

  public static void SetHorizontal(ImageFile? openXmlElement, Boolean? value)
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
  public static Boolean? GetHorizontalStandard(ImageFile? openXmlElement)
  {
    return openXmlElement?.HorizontalStandard?.Value;
  }

  public static void SetHorizontalStandard(ImageFile? openXmlElement, Boolean? value)
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
  public static Boolean? GetHorizontalNoShade(ImageFile? openXmlElement)
  {
    return openXmlElement?.HorizontalNoShade?.Value;
  }

  public static void SetHorizontalNoShade(ImageFile? openXmlElement, Boolean? value)
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
  public static Single? GetHorizontalPercentage(ImageFile? openXmlElement)
  {
    return openXmlElement?.HorizontalPercentage?.Value;
  }

  public static void SetHorizontalPercentage(ImageFile? openXmlElement, Single? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalPercentage = value;
  }

  /// <summary>
  ///   Horizontal Rule Alignment
  /// </summary>
  public static HorizontalRuleAlignmentKind? GetHorizontalAlignment(ImageFile? openXmlElement)
  {
    return EnumValueConverter.GetValue<HorizontalRuleAlignmentValues, HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value);
  }

  public static void SetHorizontalAlignment(ImageFile? openXmlElement, HorizontalRuleAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalAlignment = EnumValueConverter.CreateEnumValue<HorizontalRuleAlignmentValues, HorizontalRuleAlignmentKind>(value);
  }

  /// <summary>
  ///   Allow in Table Cell
  /// </summary>
  public static Boolean? GetAllowInCell(ImageFile? openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }

  public static void SetAllowInCell(ImageFile? openXmlElement, Boolean? value)
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
  public static Boolean? GetAllowOverlap(ImageFile? openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }

  public static void SetAllowOverlap(ImageFile? openXmlElement, Boolean? value)
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
  public static Boolean? GetUserDrawn(ImageFile? openXmlElement)
  {
    return openXmlElement?.UserDrawn?.Value;
  }

  public static void SetUserDrawn(ImageFile? openXmlElement, Boolean? value)
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
  public static String? GetBorderTopColor(ImageFile? openXmlElement)
  {
    return openXmlElement?.BorderTopColor?.Value;
  }

  public static void SetBorderTopColor(ImageFile? openXmlElement, String? value)
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
  public static String? GetBorderLeftColor(ImageFile? openXmlElement)
  {
    return openXmlElement?.BorderLeftColor?.Value;
  }

  public static void SetBorderLeftColor(ImageFile? openXmlElement, String? value)
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
  public static String? GetBorderBottomColor(ImageFile? openXmlElement)
  {
    return openXmlElement?.BorderBottomColor?.Value;
  }

  public static void SetBorderBottomColor(ImageFile? openXmlElement, String? value)
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
  public static String? GetBorderRightColor(ImageFile? openXmlElement)
  {
    return openXmlElement?.BorderRightColor?.Value;
  }

  public static void SetBorderRightColor(ImageFile? openXmlElement, String? value)
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
  public static Int64? GetDiagramLayout(ImageFile? openXmlElement)
  {
    return openXmlElement?.DiagramLayout?.Value;
  }

  public static void SetDiagramLayout(ImageFile? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DiagramLayout = value;
  }

  /// <summary>
  ///   Diagram Node Identifier
  /// </summary>
  public static Int64? GetDiagramNodeKind(ImageFile? openXmlElement)
  {
    return openXmlElement?.DiagramNodeKind?.Value;
  }

  public static void SetDiagramNodeKind(ImageFile? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DiagramNodeKind = value;
  }

  /// <summary>
  ///   Diagram Node Recent Layout Identifier
  /// </summary>
  public static Int64? GetDiagramLayoutMostRecentUsed(ImageFile? openXmlElement)
  {
    return openXmlElement?.DiagramLayoutMostRecentUsed?.Value;
  }

  public static void SetDiagramLayoutMostRecentUsed(ImageFile? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DiagramLayoutMostRecentUsed = value;
  }

  /// <summary>
  ///   Text Inset Mode
  /// </summary>
  public static InsetMarginKind? GetInsetMode(ImageFile? openXmlElement)
  {
    return EnumValueConverter.GetValue<InsetMarginValues, InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }

  public static void SetInsetMode(ImageFile? openXmlElement, InsetMarginKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<InsetMarginValues, InsetMarginKind>(value);
  }

  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  public static Boolean? GetFilled(ImageFile? openXmlElement)
  {
    return openXmlElement?.Filled?.Value;
  }

  public static void SetFilled(ImageFile? openXmlElement, Boolean? value)
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
  public static String? GetFillColor(ImageFile? openXmlElement)
  {
    return openXmlElement?.FillColor?.Value;
  }

  public static void SetFillColor(ImageFile? openXmlElement, String? value)
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
  public static Boolean? GetStroked(ImageFile? openXmlElement)
  {
    return openXmlElement?.Stroked?.Value;
  }

  public static void SetStroked(ImageFile? openXmlElement, Boolean? value)
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
  public static String? GetStrokeColor(ImageFile? openXmlElement)
  {
    return openXmlElement?.StrokeColor?.Value;
  }

  public static void SetStrokeColor(ImageFile? openXmlElement, String? value)
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
  public static String? GetStrokeWeight(ImageFile? openXmlElement)
  {
    return openXmlElement?.StrokeWeight?.Value;
  }

  public static void SetStrokeWeight(ImageFile? openXmlElement, String? value)
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
  public static Boolean? GetInsetPen(ImageFile? openXmlElement)
  {
    return openXmlElement?.InsetPen?.Value;
  }

  public static void SetInsetPen(ImageFile? openXmlElement, Boolean? value)
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
  public static Int32? GetOptionalNumber(ImageFile? openXmlElement)
  {
    return openXmlElement?.OptionalNumber?.Value;
  }

  public static void SetOptionalNumber(ImageFile? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.OptionalNumber = value;
  }

  /// <summary>
  ///   Shape Connector Type
  /// </summary>
  public static ConnectorKind? GetConnectorType(ImageFile? openXmlElement)
  {
    return EnumValueConverter.GetValue<ConnectorValues, ConnectorKind>(openXmlElement?.ConnectorType?.Value);
  }

  public static void SetConnectorType(ImageFile? openXmlElement, ConnectorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ConnectorType = EnumValueConverter.CreateEnumValue<ConnectorValues, ConnectorKind>(value);
  }

  /// <summary>
  ///   Black-and-White Mode
  /// </summary>
  public static BlackAndWhiteMode? GetBlackWhiteMode(ImageFile? openXmlElement)
  {
    return EnumValueConverter.GetValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }

  public static void SetBlackWhiteMode(ImageFile? openXmlElement, BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(value);
  }

  /// <summary>
  ///   Pure Black-and-White Mode
  /// </summary>
  public static BlackAndWhiteMode? GetPureBlackWhiteMode(ImageFile? openXmlElement)
  {
    return EnumValueConverter.GetValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value);
  }

  public static void SetPureBlackWhiteMode(ImageFile? openXmlElement, BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.PureBlackWhiteMode = EnumValueConverter.CreateEnumValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(value);
  }

  /// <summary>
  ///   Normal Black-and-White Mode
  /// </summary>
  public static BlackAndWhiteMode? GetNormalBlackWhiteMode(ImageFile? openXmlElement)
  {
    return EnumValueConverter.GetValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value);
  }

  public static void SetNormalBlackWhiteMode(ImageFile? openXmlElement, BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.NormalBlackWhiteMode = EnumValueConverter.CreateEnumValue<BlackAndWhiteModeValues, BlackAndWhiteMode>(value);
  }

  /// <summary>
  ///   Force Dashed Outline
  /// </summary>
  public static Boolean? GetForceDash(ImageFile? openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }

  public static void SetForceDash(ImageFile? openXmlElement, Boolean? value)
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
  public static Boolean? GetOleIcon(ImageFile? openXmlElement)
  {
    return openXmlElement?.OleIcon?.Value;
  }

  public static void SetOleIcon(ImageFile? openXmlElement, Boolean? value)
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
  public static Boolean? GetOle(ImageFile? openXmlElement)
  {
    return openXmlElement?.Ole?.Value;
  }

  public static void SetOle(ImageFile? openXmlElement, Boolean? value)
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
  public static Boolean? GetPreferRelative(ImageFile? openXmlElement)
  {
    return openXmlElement?.PreferRelative?.Value;
  }

  public static void SetPreferRelative(ImageFile? openXmlElement, Boolean? value)
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
  public static Boolean? GetClipToWrap(ImageFile? openXmlElement)
  {
    return openXmlElement?.ClipToWrap?.Value;
  }

  public static void SetClipToWrap(ImageFile? openXmlElement, Boolean? value)
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
  public static Boolean? GetClip(ImageFile? openXmlElement)
  {
    return openXmlElement?.Clip?.Value;
  }

  public static void SetClip(ImageFile? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Clip = value;
      else
        openXmlElement.Clip = null;
  }

  /// <summary>
  ///   Image Source
  /// </summary>
  public static String? GetSource(ImageFile? openXmlElement)
  {
    return openXmlElement?.Source?.Value;
  }

  public static void SetSource(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Source = new StringValue { Value = value };
      else
        openXmlElement.Source = null;
  }

  /// <summary>
  ///   Image Left Crop
  /// </summary>
  public static String? GetCropLeft(ImageFile? openXmlElement)
  {
    return openXmlElement?.CropLeft?.Value;
  }

  public static void SetCropLeft(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CropLeft = new StringValue { Value = value };
      else
        openXmlElement.CropLeft = null;
  }

  /// <summary>
  ///   Image Top Crop
  /// </summary>
  public static String? GetCropTop(ImageFile? openXmlElement)
  {
    return openXmlElement?.CropTop?.Value;
  }

  public static void SetCropTop(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CropTop = new StringValue { Value = value };
      else
        openXmlElement.CropTop = null;
  }

  /// <summary>
  ///   Image Right Crop
  /// </summary>
  public static String? GetCropRight(ImageFile? openXmlElement)
  {
    return openXmlElement?.CropRight?.Value;
  }

  public static void SetCropRight(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CropRight = new StringValue { Value = value };
      else
        openXmlElement.CropRight = null;
  }

  /// <summary>
  ///   Image Bottom Crop
  /// </summary>
  public static String? GetCropBottom(ImageFile? openXmlElement)
  {
    return openXmlElement?.CropBottom?.Value;
  }

  public static void SetCropBottom(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CropBottom = new StringValue { Value = value };
      else
        openXmlElement.CropBottom = null;
  }

  /// <summary>
  ///   Image Intensity
  /// </summary>
  public static String? GetGain(ImageFile? openXmlElement)
  {
    return openXmlElement?.Gain?.Value;
  }

  public static void SetGain(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Gain = new StringValue { Value = value };
      else
        openXmlElement.Gain = null;
  }

  /// <summary>
  ///   Image Brightness
  /// </summary>
  public static String? GetBlackLevel(ImageFile? openXmlElement)
  {
    return openXmlElement?.BlackLevel?.Value;
  }

  public static void SetBlackLevel(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BlackLevel = new StringValue { Value = value };
      else
        openXmlElement.BlackLevel = null;
  }

  /// <summary>
  ///   Image Gamma Correction
  /// </summary>
  public static String? GetGamma(ImageFile? openXmlElement)
  {
    return openXmlElement?.Gamma?.Value;
  }

  public static void SetGamma(ImageFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Gamma = new StringValue { Value = value };
      else
        openXmlElement.Gamma = null;
  }

  /// <summary>
  ///   Image Grayscale Toggle
  /// </summary>
  public static Boolean? GetGrayScale(ImageFile? openXmlElement)
  {
    return openXmlElement?.GrayScale?.Value;
  }

  public static void SetGrayScale(ImageFile? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GrayScale = value;
      else
        openXmlElement.GrayScale = null;
  }

  /// <summary>
  ///   Image Bilevel Toggle
  /// </summary>
  public static Boolean? GetBiLevel(ImageFile? openXmlElement)
  {
    return openXmlElement?.BiLevel?.Value;
  }

  public static void SetBiLevel(ImageFile? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BiLevel = value;
      else
        openXmlElement.BiLevel = null;
  }

  /// <summary>
  ///   Encoded Package
  /// </summary>
  public static Byte[]? GetGfxdata(ImageFile? openXmlElement)
  {
    if (openXmlElement?.Gfxdata?.Value != null)
      return Convert.FromBase64String(openXmlElement.Gfxdata.Value);
    return null;
  }

  public static void SetGfxdata(ImageFile? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Gfxdata = Convert.ToBase64String(value);
      else
        openXmlElement.Gfxdata = null;
    }
  }

  public static Path? GetPath(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Path>();
    if (itemElement != null)
      return PathConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPath(ImageFile? openXmlElement, Path? value)
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

  public static Formulas? GetFormulas(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Formulas>();
    if (itemElement != null)
      return FormulasConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFormulas(ImageFile? openXmlElement, Formulas? value)
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

  public static ShapeHandles? GetShapeHandles(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
    if (itemElement != null)
      return ShapeHandlesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeHandles(ImageFile? openXmlElement, ShapeHandles? value)
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

  public static Fill? GetFill(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
    if (itemElement != null)
      return FillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFill(ImageFile? openXmlElement, Fill? value)
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

  public static Stroke? GetStroke(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Stroke>();
    if (itemElement != null)
      return StrokeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStroke(ImageFile? openXmlElement, Stroke? value)
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

  public static Shadow? GetShadow(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shadow>();
    if (itemElement != null)
      return ShadowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShadow(ImageFile? openXmlElement, Shadow? value)
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

  public static TextBox? GetTextBox(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.TextBox>();
    if (itemElement != null)
      return TextBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextBox(ImageFile? openXmlElement, TextBox? value)
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

  public static TextPath? GetTextPath(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.TextPath>();
    if (itemElement != null)
      return TextPathConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextPath(ImageFile? openXmlElement, TextPath? value)
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

  public static ImageData? GetImageData(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageData>();
    if (itemElement != null)
      return ImageDataConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetImageData(ImageFile? openXmlElement, ImageData? value)
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

  public static Skew? GetSkew(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
    if (itemElement != null)
      return SkewConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSkew(ImageFile? openXmlElement, Skew? value)
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

  public static Extrusion? GetExtrusion(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
    if (itemElement != null)
      return ExtrusionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtrusion(ImageFile? openXmlElement, Extrusion? value)
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

  public static Callout? GetCallout(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
    if (itemElement != null)
      return CalloutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCallout(ImageFile? openXmlElement, Callout? value)
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

  public static Lock? GetLock(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
    if (itemElement != null)
      return LockConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLock(ImageFile? openXmlElement, Lock? value)
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

  public static ClipPath? GetClipPath(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
    if (itemElement != null)
      return ClipPathConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetClipPath(ImageFile? openXmlElement, ClipPath? value)
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

  public static SignatureLine? GetSignatureLine(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
    if (itemElement != null)
      return SignatureLineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSignatureLine(ImageFile? openXmlElement, SignatureLine? value)
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

  public static TextWrap? GetTextWrap(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
    if (itemElement != null)
      return TextWrapConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextWrap(ImageFile? openXmlElement, TextWrap? value)
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

  public static Boolean? GetAnchorLock(ImageFile? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AnchorLock>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAnchorLock(ImageFile? openXmlElement, Boolean? value)
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

  public static BorderType? GetTopBorder(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TopBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTopBorder(ImageFile? openXmlElement, BorderType? value)
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

  public static BorderType? GetBottomBorder(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BottomBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBottomBorder(ImageFile? openXmlElement, BorderType? value)
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

  public static BorderType? GetLeftBorder(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LeftBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLeftBorder(ImageFile? openXmlElement, BorderType? value)
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

  public static BorderType? GetRightBorder(ImageFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RightBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRightBorder(ImageFile? openXmlElement, BorderType? value)
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

  public static DocumentModel.Vml.ImageFile? CreateModelElement(ImageFile? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ImageFile();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.ImageFile? value)
    where OpenXmlElementType : ImageFile, new()
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
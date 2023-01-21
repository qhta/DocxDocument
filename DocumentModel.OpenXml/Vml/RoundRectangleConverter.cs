namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Rounded Rectangle.
/// </summary>
public static class RoundRectangleConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// style
  /// </summary>
  private static String? GetStyle(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  private static void SetStyle(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Style = new StringValue { Value = value };
    else
      openXmlElement.Style = null;
  }
  
  /// <summary>
  /// href
  /// </summary>
  private static String? GetHref(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }
  
  private static void SetHref(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Href = new StringValue { Value = value };
    else
      openXmlElement.Href = null;
  }
  
  /// <summary>
  /// target
  /// </summary>
  private static String? GetTarget(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.Target?.Value;
  }
  
  private static void SetTarget(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Target = new StringValue { Value = value };
    else
      openXmlElement.Target = null;
  }
  
  /// <summary>
  /// class
  /// </summary>
  private static String? GetClass(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.Class?.Value;
  }
  
  private static void SetClass(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Class = new StringValue { Value = value };
    else
      openXmlElement.Class = null;
  }
  
  /// <summary>
  /// title
  /// </summary>
  private static String? GetTitle(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static void SetTitle(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// alt
  /// </summary>
  private static String? GetAlternate(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.Alternate?.Value;
  }
  
  private static void SetAlternate(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Alternate = new StringValue { Value = value };
    else
      openXmlElement.Alternate = null;
  }
  
  /// <summary>
  /// coordsize
  /// </summary>
  private static String? GetCoordinateSize(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.CoordinateSize?.Value;
  }
  
  private static void SetCoordinateSize(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CoordinateSize = new StringValue { Value = value };
    else
      openXmlElement.CoordinateSize = null;
  }
  
  /// <summary>
  /// wrapcoords
  /// </summary>
  private static String? GetWrapCoordinates(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.WrapCoordinates?.Value;
  }
  
  private static void SetWrapCoordinates(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.WrapCoordinates = new StringValue { Value = value };
    else
      openXmlElement.WrapCoordinates = null;
  }
  
  /// <summary>
  /// print
  /// </summary>
  private static Boolean? GetPrint(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.Print?.Value;
  }
  
  private static void SetPrint(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Print = value;
    else
      openXmlElement.Print = null;
  }
  
  /// <summary>
  /// Optional String
  /// </summary>
  private static String? GetOptionalString(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.OptionalString?.Value;
  }
  
  private static void SetOptionalString(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OptionalString = new StringValue { Value = value };
    else
      openXmlElement.OptionalString = null;
  }
  
  /// <summary>
  /// Shape Handle Toggle
  /// </summary>
  private static Boolean? GetOned(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.Oned?.Value;
  }
  
  private static void SetOned(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Oned = value;
    else
      openXmlElement.Oned = null;
  }
  
  /// <summary>
  /// Regroup ID
  /// </summary>
  private static Int64? GetRegroupId(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement.RegroupId?.Value;
  }
  
  private static void SetRegroupId(DXVml.RoundRectangle openXmlElement, Int64? value)
  {
    openXmlElement.RegroupId = value;
  }
  
  /// <summary>
  /// Double-click Notification Toggle
  /// </summary>
  private static Boolean? GetDoubleClickNotify(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.DoubleClickNotify?.Value;
  }
  
  private static void SetDoubleClickNotify(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DoubleClickNotify = value;
    else
      openXmlElement.DoubleClickNotify = null;
  }
  
  /// <summary>
  /// Button Behavior Toggle
  /// </summary>
  private static Boolean? GetButton(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.Button?.Value;
  }
  
  private static void SetButton(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Button = value;
    else
      openXmlElement.Button = null;
  }
  
  /// <summary>
  /// Hide Script Anchors
  /// </summary>
  private static Boolean? GetUserHidden(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.UserHidden?.Value;
  }
  
  private static void SetUserHidden(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserHidden = value;
    else
      openXmlElement.UserHidden = null;
  }
  
  /// <summary>
  /// Graphical Bullet
  /// </summary>
  private static Boolean? GetBullet(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.Bullet?.Value;
  }
  
  private static void SetBullet(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Bullet = value;
    else
      openXmlElement.Bullet = null;
  }
  
  /// <summary>
  /// Horizontal Rule Toggle
  /// </summary>
  private static Boolean? GetHorizontal(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.Horizontal?.Value;
  }
  
  private static void SetHorizontal(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Horizontal = value;
    else
      openXmlElement.Horizontal = null;
  }
  
  /// <summary>
  /// Horizontal Rule Standard Display Toggle
  /// </summary>
  private static Boolean? GetHorizontalStandard(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.HorizontalStandard?.Value;
  }
  
  private static void SetHorizontalStandard(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalStandard = value;
    else
      openXmlElement.HorizontalStandard = null;
  }
  
  /// <summary>
  /// Horizontal Rule 3D Shading Toggle
  /// </summary>
  private static Boolean? GetHorizontalNoShade(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.HorizontalNoShade?.Value;
  }
  
  private static void SetHorizontalNoShade(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalNoShade = value;
    else
      openXmlElement.HorizontalNoShade = null;
  }
  
  /// <summary>
  /// Horizontal Rule Length Percentage
  /// </summary>
  private static Single? GetHorizontalPercentage(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement.HorizontalPercentage?.Value;
  }
  
  private static void SetHorizontalPercentage(DXVml.RoundRectangle openXmlElement, Single? value)
  {
    openXmlElement.HorizontalPercentage = value;
  }
  
  /// <summary>
  /// Horizontal Rule Alignment
  /// </summary>
  private static DMVml.HorizontalRuleAlignmentKind? GetHorizontalAlignment(DXVml.RoundRectangle openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMVml.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value);
  }
  
  private static void SetHorizontalAlignment(DXVml.RoundRectangle openXmlElement, DMVml.HorizontalRuleAlignmentKind? value)
  {
    openXmlElement.HorizontalAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DMVml.HorizontalRuleAlignmentKind>(value);
  }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  private static Boolean? GetAllowInCell(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }
  
  private static void SetAllowInCell(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowInCell = value;
    else
      openXmlElement.AllowInCell = null;
  }
  
  /// <summary>
  /// Allow Shape Overlap
  /// </summary>
  private static Boolean? GetAllowOverlap(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  private static void SetAllowOverlap(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowOverlap = value;
    else
      openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// Exists In Master Slide
  /// </summary>
  private static Boolean? GetUserDrawn(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.UserDrawn?.Value;
  }
  
  private static void SetUserDrawn(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserDrawn = value;
    else
      openXmlElement.UserDrawn = null;
  }
  
  /// <summary>
  /// Border Top Color
  /// </summary>
  private static String? GetBorderTopColor(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.BorderTopColor?.Value;
  }
  
  private static void SetBorderTopColor(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BorderTopColor = new StringValue { Value = value };
    else
      openXmlElement.BorderTopColor = null;
  }
  
  /// <summary>
  /// Border Left Color
  /// </summary>
  private static String? GetBorderLeftColor(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.BorderLeftColor?.Value;
  }
  
  private static void SetBorderLeftColor(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BorderLeftColor = new StringValue { Value = value };
    else
      openXmlElement.BorderLeftColor = null;
  }
  
  /// <summary>
  /// Bottom Border Color
  /// </summary>
  private static String? GetBorderBottomColor(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.BorderBottomColor?.Value;
  }
  
  private static void SetBorderBottomColor(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BorderBottomColor = new StringValue { Value = value };
    else
      openXmlElement.BorderBottomColor = null;
  }
  
  /// <summary>
  /// Border Right Color
  /// </summary>
  private static String? GetBorderRightColor(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.BorderRightColor?.Value;
  }
  
  private static void SetBorderRightColor(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BorderRightColor = new StringValue { Value = value };
    else
      openXmlElement.BorderRightColor = null;
  }
  
  /// <summary>
  /// Diagram Node Layout Identifier
  /// </summary>
  private static Int64? GetDiagramLayout(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement.DiagramLayout?.Value;
  }
  
  private static void SetDiagramLayout(DXVml.RoundRectangle openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayout = value;
  }
  
  /// <summary>
  /// Diagram Node Identifier
  /// </summary>
  private static Int64? GetDiagramNodeKind(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement.DiagramNodeKind?.Value;
  }
  
  private static void SetDiagramNodeKind(DXVml.RoundRectangle openXmlElement, Int64? value)
  {
    openXmlElement.DiagramNodeKind = value;
  }
  
  /// <summary>
  /// Diagram Node Recent Layout Identifier
  /// </summary>
  private static Int64? GetDiagramLayoutMostRecentUsed(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement.DiagramLayoutMostRecentUsed?.Value;
  }
  
  private static void SetDiagramLayoutMostRecentUsed(DXVml.RoundRectangle openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayoutMostRecentUsed = value;
  }
  
  /// <summary>
  /// Text Inset Mode
  /// </summary>
  private static DMVml.InsetMarginKind? GetInsetMode(DXVml.RoundRectangle openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }
  
  private static void SetInsetMode(DXVml.RoundRectangle openXmlElement, DMVml.InsetMarginKind? value)
  {
    openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(value);
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  private static Boolean? GetFilled(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.Filled?.Value;
  }
  
  private static void SetFilled(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Filled = value;
    else
      openXmlElement.Filled = null;
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  private static String? GetFillColor(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.FillColor?.Value;
  }
  
  private static void SetFillColor(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FillColor = new StringValue { Value = value };
    else
      openXmlElement.FillColor = null;
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  private static Boolean? GetStroked(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.Stroked?.Value;
  }
  
  private static void SetStroked(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Stroked = value;
    else
      openXmlElement.Stroked = null;
  }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  private static String? GetStrokeColor(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.StrokeColor?.Value;
  }
  
  private static void SetStrokeColor(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StrokeColor = new StringValue { Value = value };
    else
      openXmlElement.StrokeColor = null;
  }
  
  /// <summary>
  /// Shape Stroke Weight
  /// </summary>
  private static String? GetStrokeWeight(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.StrokeWeight?.Value;
  }
  
  private static void SetStrokeWeight(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StrokeWeight = new StringValue { Value = value };
    else
      openXmlElement.StrokeWeight = null;
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  private static Boolean? GetInsetPen(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.InsetPen?.Value;
  }
  
  private static void SetInsetPen(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InsetPen = value;
    else
      openXmlElement.InsetPen = null;
  }
  
  /// <summary>
  /// Optional Number
  /// </summary>
  private static Int32? GetOptionalNumber(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement.OptionalNumber?.Value;
  }
  
  private static void SetOptionalNumber(DXVml.RoundRectangle openXmlElement, Int32? value)
  {
    openXmlElement.OptionalNumber = value;
  }
  
  /// <summary>
  /// Shape Connector Type
  /// </summary>
  private static DMVml.ConnectorKind? GetConnectorType(DXVml.RoundRectangle openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMVml.ConnectorKind>(openXmlElement?.ConnectorType?.Value);
  }
  
  private static void SetConnectorType(DXVml.RoundRectangle openXmlElement, DMVml.ConnectorKind? value)
  {
    openXmlElement.ConnectorType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DMVml.ConnectorKind>(value);
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  private static DMVml.BlackAndWhiteMode? GetBlackWhiteMode(DXVml.RoundRectangle openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static void SetBlackWhiteMode(DXVml.RoundRectangle openXmlElement, DMVml.BlackAndWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  private static DMVml.BlackAndWhiteMode? GetPureBlackWhiteMode(DXVml.RoundRectangle openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value);
  }
  
  private static void SetPureBlackWhiteMode(DXVml.RoundRectangle openXmlElement, DMVml.BlackAndWhiteMode? value)
  {
    openXmlElement.PureBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  private static DMVml.BlackAndWhiteMode? GetNormalBlackWhiteMode(DXVml.RoundRectangle openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value);
  }
  
  private static void SetNormalBlackWhiteMode(DXVml.RoundRectangle openXmlElement, DMVml.BlackAndWhiteMode? value)
  {
    openXmlElement.NormalBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DMVml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  private static Boolean? GetForceDash(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }
  
  private static void SetForceDash(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceDash = value;
    else
      openXmlElement.ForceDash = null;
  }
  
  /// <summary>
  /// Embedded Object Icon Toggle
  /// </summary>
  private static Boolean? GetOleIcon(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.OleIcon?.Value;
  }
  
  private static void SetOleIcon(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.OleIcon = value;
    else
      openXmlElement.OleIcon = null;
  }
  
  /// <summary>
  /// Embedded Object Toggle
  /// </summary>
  private static Boolean? GetOle(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.Ole?.Value;
  }
  
  private static void SetOle(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Ole = value;
    else
      openXmlElement.Ole = null;
  }
  
  /// <summary>
  /// Relative Resize Toggle
  /// </summary>
  private static Boolean? GetPreferRelative(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.PreferRelative?.Value;
  }
  
  private static void SetPreferRelative(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.PreferRelative = value;
    else
      openXmlElement.PreferRelative = null;
  }
  
  /// <summary>
  /// Clip to Wrapping Polygon
  /// </summary>
  private static Boolean? GetClipToWrap(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.ClipToWrap?.Value;
  }
  
  private static void SetClipToWrap(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ClipToWrap = value;
    else
      openXmlElement.ClipToWrap = null;
  }
  
  /// <summary>
  /// Clipping Toggle
  /// </summary>
  private static Boolean? GetClip(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.Clip?.Value;
  }
  
  private static void SetClip(DXVml.RoundRectangle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Clip = value;
    else
      openXmlElement.Clip = null;
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  private static Byte[]? GetGfxdata(DXVml.RoundRectangle openXmlElement)
  {
    if (openXmlElement.Gfxdata?.Value != null)
      return Convert.FromBase64String(openXmlElement.Gfxdata.Value);
    return null;
  }
  
  private static void SetGfxdata(DXVml.RoundRectangle openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.Gfxdata = Convert.ToBase64String(value);
    else
      openXmlElement.Gfxdata = null;
  }
  
  /// <summary>
  /// Rounded Corner Arc Size
  /// </summary>
  private static String? GetArcSize(DXVml.RoundRectangle openXmlElement)
  {
    return openXmlElement?.ArcSize?.Value;
  }
  
  private static void SetArcSize(DXVml.RoundRectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ArcSize = new StringValue { Value = value };
    else
      openXmlElement.ArcSize = null;
  }
  
  private static DMVml.Path? GetPath(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Path>();
    if (itemElement != null)
      return DMXVml.PathConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPath(DXVml.RoundRectangle openXmlElement, DMVml.Path? value)
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
  
  private static DMVml.Formulas? GetFormulas(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Formulas>();
    if (itemElement != null)
      return DMXVml.FormulasConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFormulas(DXVml.RoundRectangle openXmlElement, DMVml.Formulas? value)
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
  
  private static DMVml.ShapeHandles? GetShapeHandles(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.ShapeHandles>();
    if (itemElement != null)
      return DMXVml.ShapeHandlesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeHandles(DXVml.RoundRectangle openXmlElement, DMVml.ShapeHandles? value)
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
  
  private static DMVml.Fill? GetFill(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Fill>();
    if (itemElement != null)
      return DMXVml.FillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFill(DXVml.RoundRectangle openXmlElement, DMVml.Fill? value)
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
  
  private static DMVml.Stroke? GetStroke(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Stroke>();
    if (itemElement != null)
      return DMXVml.StrokeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStroke(DXVml.RoundRectangle openXmlElement, DMVml.Stroke? value)
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
  
  private static DMVml.Shadow? GetShadow(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Shadow>();
    if (itemElement != null)
      return DMXVml.ShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShadow(DXVml.RoundRectangle openXmlElement, DMVml.Shadow? value)
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
  
  private static DMVml.TextBox? GetTextBox(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.TextBox>();
    if (itemElement != null)
      return DMXVml.TextBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextBox(DXVml.RoundRectangle openXmlElement, DMVml.TextBox? value)
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
  
  private static DMVml.TextPath? GetTextPath(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.TextPath>();
    if (itemElement != null)
      return DMXVml.TextPathConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextPath(DXVml.RoundRectangle openXmlElement, DMVml.TextPath? value)
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
  
  private static DMVml.ImageData? GetImageData(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.ImageData>();
    if (itemElement != null)
      return DMXVml.ImageDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetImageData(DXVml.RoundRectangle openXmlElement, DMVml.ImageData? value)
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
  
  private static DMVml.Skew? GetSkew(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.Skew>();
    if (itemElement != null)
      return DMXVml.SkewConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSkew(DXVml.RoundRectangle openXmlElement, DMVml.Skew? value)
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
  
  private static DMVml.Extrusion? GetExtrusion(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.Extrusion>();
    if (itemElement != null)
      return DMXVml.ExtrusionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtrusion(DXVml.RoundRectangle openXmlElement, DMVml.Extrusion? value)
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
  
  private static DMVml.Callout? GetCallout(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.Callout>();
    if (itemElement != null)
      return DMXVml.CalloutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCallout(DXVml.RoundRectangle openXmlElement, DMVml.Callout? value)
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
  
  private static DMVml.Lock? GetLock(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.Lock>();
    if (itemElement != null)
      return DMXVml.LockConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLock(DXVml.RoundRectangle openXmlElement, DMVml.Lock? value)
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
  
  private static DMVml.ClipPath? GetClipPath(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.ClipPath>();
    if (itemElement != null)
      return DMXVml.ClipPathConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetClipPath(DXVml.RoundRectangle openXmlElement, DMVml.ClipPath? value)
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
  
  private static DMVml.SignatureLine? GetSignatureLine(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.SignatureLine>();
    if (itemElement != null)
      return DMXVml.SignatureLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSignatureLine(DXVml.RoundRectangle openXmlElement, DMVml.SignatureLine? value)
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
  
  private static DMWVml.TextWrap? GetTextWrap(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlW.TextWrap>();
    if (itemElement != null)
      return DMXWVml.TextWrapConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextWrap(DXVml.RoundRectangle openXmlElement, DMWVml.TextWrap? value)
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
  
  private static Boolean? GetAnchorLock(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlW.AnchorLock>();
    return itemElement != null;
  }
  
  private static void SetAnchorLock(DXVml.RoundRectangle openXmlElement, Boolean? value)
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
  
  private static DMWVml.BorderType? GetTopBorder(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlW.TopBorder>();
    if (itemElement != null)
      return DMXWVml.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTopBorder(DXVml.RoundRectangle openXmlElement, DMWVml.BorderType? value)
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
  
  private static DMWVml.BorderType? GetBottomBorder(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlW.BottomBorder>();
    if (itemElement != null)
      return DMXWVml.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBottomBorder(DXVml.RoundRectangle openXmlElement, DMWVml.BorderType? value)
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
  
  private static DMWVml.BorderType? GetLeftBorder(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlW.LeftBorder>();
    if (itemElement != null)
      return DMXWVml.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLeftBorder(DXVml.RoundRectangle openXmlElement, DMWVml.BorderType? value)
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
  
  private static DMWVml.BorderType? GetRightBorder(DXVml.RoundRectangle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlW.RightBorder>();
    if (itemElement != null)
      return DMXWVml.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRightBorder(DXVml.RoundRectangle openXmlElement, DMWVml.BorderType? value)
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
  
  public static DMVml.RoundRectangle? CreateModelElement(DXVml.RoundRectangle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.RoundRectangle();
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
      value.Gfxdata = GetGfxdata(openXmlElement);
      value.ArcSize = GetArcSize(openXmlElement);
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.RoundRectangle? value)
    where OpenXmlElementType: DXVml.RoundRectangle, new()
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
      SetGfxdata(openXmlElement, value?.Gfxdata);
      SetArcSize(openXmlElement, value?.ArcSize);
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

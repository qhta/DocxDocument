namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Image File.
/// </summary>
public static class ImageFileConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// style
  /// </summary>
  private static String? GetStyle(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  private static void SetStyle(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Style = new StringValue { Value = value };
    else
      openXmlElement.Style = null;
  }
  
  /// <summary>
  /// href
  /// </summary>
  private static String? GetHref(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }
  
  private static void SetHref(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Href = new StringValue { Value = value };
    else
      openXmlElement.Href = null;
  }
  
  /// <summary>
  /// target
  /// </summary>
  private static String? GetTarget(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Target?.Value;
  }
  
  private static void SetTarget(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Target = new StringValue { Value = value };
    else
      openXmlElement.Target = null;
  }
  
  /// <summary>
  /// class
  /// </summary>
  private static String? GetClass(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Class?.Value;
  }
  
  private static void SetClass(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Class = new StringValue { Value = value };
    else
      openXmlElement.Class = null;
  }
  
  /// <summary>
  /// title
  /// </summary>
  private static String? GetTitle(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static void SetTitle(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// alt
  /// </summary>
  private static String? GetAlternate(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Alternate?.Value;
  }
  
  private static void SetAlternate(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Alternate = new StringValue { Value = value };
    else
      openXmlElement.Alternate = null;
  }
  
  /// <summary>
  /// coordsize
  /// </summary>
  private static String? GetCoordinateSize(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.CoordinateSize?.Value;
  }
  
  private static void SetCoordinateSize(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CoordinateSize = new StringValue { Value = value };
    else
      openXmlElement.CoordinateSize = null;
  }
  
  /// <summary>
  /// wrapcoords
  /// </summary>
  private static String? GetWrapCoordinates(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.WrapCoordinates?.Value;
  }
  
  private static void SetWrapCoordinates(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.WrapCoordinates = new StringValue { Value = value };
    else
      openXmlElement.WrapCoordinates = null;
  }
  
  /// <summary>
  /// print
  /// </summary>
  private static Boolean? GetPrint(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Print?.Value;
  }
  
  private static void SetPrint(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Print = value;
    else
      openXmlElement.Print = null;
  }
  
  /// <summary>
  /// Optional String
  /// </summary>
  private static String? GetOptionalString(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.OptionalString?.Value;
  }
  
  private static void SetOptionalString(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OptionalString = new StringValue { Value = value };
    else
      openXmlElement.OptionalString = null;
  }
  
  /// <summary>
  /// Shape Handle Toggle
  /// </summary>
  private static Boolean? GetOned(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Oned?.Value;
  }
  
  private static void SetOned(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Oned = value;
    else
      openXmlElement.Oned = null;
  }
  
  /// <summary>
  /// Regroup ID
  /// </summary>
  private static Int64? GetRegroupId(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement.RegroupId?.Value;
  }
  
  private static void SetRegroupId(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Int64? value)
  {
    openXmlElement.RegroupId = value;
  }
  
  /// <summary>
  /// Double-click Notification Toggle
  /// </summary>
  private static Boolean? GetDoubleClickNotify(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.DoubleClickNotify?.Value;
  }
  
  private static void SetDoubleClickNotify(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DoubleClickNotify = value;
    else
      openXmlElement.DoubleClickNotify = null;
  }
  
  /// <summary>
  /// Button Behavior Toggle
  /// </summary>
  private static Boolean? GetButton(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Button?.Value;
  }
  
  private static void SetButton(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Button = value;
    else
      openXmlElement.Button = null;
  }
  
  /// <summary>
  /// Hide Script Anchors
  /// </summary>
  private static Boolean? GetUserHidden(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.UserHidden?.Value;
  }
  
  private static void SetUserHidden(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserHidden = value;
    else
      openXmlElement.UserHidden = null;
  }
  
  /// <summary>
  /// Graphical Bullet
  /// </summary>
  private static Boolean? GetBullet(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Bullet?.Value;
  }
  
  private static void SetBullet(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Bullet = value;
    else
      openXmlElement.Bullet = null;
  }
  
  /// <summary>
  /// Horizontal Rule Toggle
  /// </summary>
  private static Boolean? GetHorizontal(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Horizontal?.Value;
  }
  
  private static void SetHorizontal(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Horizontal = value;
    else
      openXmlElement.Horizontal = null;
  }
  
  /// <summary>
  /// Horizontal Rule Standard Display Toggle
  /// </summary>
  private static Boolean? GetHorizontalStandard(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.HorizontalStandard?.Value;
  }
  
  private static void SetHorizontalStandard(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalStandard = value;
    else
      openXmlElement.HorizontalStandard = null;
  }
  
  /// <summary>
  /// Horizontal Rule 3D Shading Toggle
  /// </summary>
  private static Boolean? GetHorizontalNoShade(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.HorizontalNoShade?.Value;
  }
  
  private static void SetHorizontalNoShade(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalNoShade = value;
    else
      openXmlElement.HorizontalNoShade = null;
  }
  
  /// <summary>
  /// Horizontal Rule Length Percentage
  /// </summary>
  private static Single? GetHorizontalPercentage(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement.HorizontalPercentage?.Value;
  }
  
  private static void SetHorizontalPercentage(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Single? value)
  {
    openXmlElement.HorizontalPercentage = value;
  }
  
  /// <summary>
  /// Horizontal Rule Alignment
  /// </summary>
  private static DocumentModel.Vml.HorizontalRuleAlignmentKind? GetHorizontalAlignment(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DocumentModel.Vml.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value);
  }
  
  private static void SetHorizontalAlignment(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.HorizontalRuleAlignmentKind? value)
  {
    openXmlElement.HorizontalAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DocumentModel.Vml.HorizontalRuleAlignmentKind>(value);
  }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  private static Boolean? GetAllowInCell(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }
  
  private static void SetAllowInCell(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowInCell = value;
    else
      openXmlElement.AllowInCell = null;
  }
  
  /// <summary>
  /// Allow Shape Overlap
  /// </summary>
  private static Boolean? GetAllowOverlap(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  private static void SetAllowOverlap(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowOverlap = value;
    else
      openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// Exists In Master Slide
  /// </summary>
  private static Boolean? GetUserDrawn(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.UserDrawn?.Value;
  }
  
  private static void SetUserDrawn(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UserDrawn = value;
    else
      openXmlElement.UserDrawn = null;
  }
  
  /// <summary>
  /// Border Top Color
  /// </summary>
  private static String? GetBorderTopColor(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.BorderTopColor?.Value;
  }
  
  private static void SetBorderTopColor(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BorderTopColor = new StringValue { Value = value };
    else
      openXmlElement.BorderTopColor = null;
  }
  
  /// <summary>
  /// Border Left Color
  /// </summary>
  private static String? GetBorderLeftColor(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.BorderLeftColor?.Value;
  }
  
  private static void SetBorderLeftColor(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BorderLeftColor = new StringValue { Value = value };
    else
      openXmlElement.BorderLeftColor = null;
  }
  
  /// <summary>
  /// Bottom Border Color
  /// </summary>
  private static String? GetBorderBottomColor(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.BorderBottomColor?.Value;
  }
  
  private static void SetBorderBottomColor(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BorderBottomColor = new StringValue { Value = value };
    else
      openXmlElement.BorderBottomColor = null;
  }
  
  /// <summary>
  /// Border Right Color
  /// </summary>
  private static String? GetBorderRightColor(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.BorderRightColor?.Value;
  }
  
  private static void SetBorderRightColor(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BorderRightColor = new StringValue { Value = value };
    else
      openXmlElement.BorderRightColor = null;
  }
  
  /// <summary>
  /// Diagram Node Layout Identifier
  /// </summary>
  private static Int64? GetDiagramLayout(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement.DiagramLayout?.Value;
  }
  
  private static void SetDiagramLayout(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayout = value;
  }
  
  /// <summary>
  /// Diagram Node Identifier
  /// </summary>
  private static Int64? GetDiagramNodeKind(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement.DiagramNodeKind?.Value;
  }
  
  private static void SetDiagramNodeKind(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Int64? value)
  {
    openXmlElement.DiagramNodeKind = value;
  }
  
  /// <summary>
  /// Diagram Node Recent Layout Identifier
  /// </summary>
  private static Int64? GetDiagramLayoutMostRecentUsed(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement.DiagramLayoutMostRecentUsed?.Value;
  }
  
  private static void SetDiagramLayoutMostRecentUsed(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Int64? value)
  {
    openXmlElement.DiagramLayoutMostRecentUsed = value;
  }
  
  /// <summary>
  /// Text Inset Mode
  /// </summary>
  private static DocumentModel.Vml.InsetMarginKind? GetInsetMode(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DocumentModel.Vml.InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }
  
  private static void SetInsetMode(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.InsetMarginKind? value)
  {
    openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DocumentModel.Vml.InsetMarginKind>(value);
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  private static Boolean? GetFilled(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Filled?.Value;
  }
  
  private static void SetFilled(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Filled = value;
    else
      openXmlElement.Filled = null;
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  private static String? GetFillColor(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.FillColor?.Value;
  }
  
  private static void SetFillColor(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FillColor = new StringValue { Value = value };
    else
      openXmlElement.FillColor = null;
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  private static Boolean? GetStroked(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Stroked?.Value;
  }
  
  private static void SetStroked(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Stroked = value;
    else
      openXmlElement.Stroked = null;
  }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  private static String? GetStrokeColor(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.StrokeColor?.Value;
  }
  
  private static void SetStrokeColor(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StrokeColor = new StringValue { Value = value };
    else
      openXmlElement.StrokeColor = null;
  }
  
  /// <summary>
  /// Shape Stroke Weight
  /// </summary>
  private static String? GetStrokeWeight(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.StrokeWeight?.Value;
  }
  
  private static void SetStrokeWeight(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StrokeWeight = new StringValue { Value = value };
    else
      openXmlElement.StrokeWeight = null;
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  private static Boolean? GetInsetPen(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.InsetPen?.Value;
  }
  
  private static void SetInsetPen(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InsetPen = value;
    else
      openXmlElement.InsetPen = null;
  }
  
  /// <summary>
  /// Optional Number
  /// </summary>
  private static Int32? GetOptionalNumber(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement.OptionalNumber?.Value;
  }
  
  private static void SetOptionalNumber(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Int32? value)
  {
    openXmlElement.OptionalNumber = value;
  }
  
  /// <summary>
  /// Shape Connector Type
  /// </summary>
  private static DocumentModel.Vml.ConnectorKind? GetConnectorType(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DocumentModel.Vml.ConnectorKind>(openXmlElement?.ConnectorType?.Value);
  }
  
  private static void SetConnectorType(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.ConnectorKind? value)
  {
    openXmlElement.ConnectorType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DocumentModel.Vml.ConnectorKind>(value);
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  private static DocumentModel.Vml.BlackAndWhiteMode? GetBlackWhiteMode(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static void SetBlackWhiteMode(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.BlackAndWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  private static DocumentModel.Vml.BlackAndWhiteMode? GetPureBlackWhiteMode(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value);
  }
  
  private static void SetPureBlackWhiteMode(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.BlackAndWhiteMode? value)
  {
    openXmlElement.PureBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  private static DocumentModel.Vml.BlackAndWhiteMode? GetNormalBlackWhiteMode(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value);
  }
  
  private static void SetNormalBlackWhiteMode(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.BlackAndWhiteMode? value)
  {
    openXmlElement.NormalBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  private static Boolean? GetForceDash(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }
  
  private static void SetForceDash(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceDash = value;
    else
      openXmlElement.ForceDash = null;
  }
  
  /// <summary>
  /// Embedded Object Icon Toggle
  /// </summary>
  private static Boolean? GetOleIcon(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.OleIcon?.Value;
  }
  
  private static void SetOleIcon(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.OleIcon = value;
    else
      openXmlElement.OleIcon = null;
  }
  
  /// <summary>
  /// Embedded Object Toggle
  /// </summary>
  private static Boolean? GetOle(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Ole?.Value;
  }
  
  private static void SetOle(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Ole = value;
    else
      openXmlElement.Ole = null;
  }
  
  /// <summary>
  /// Relative Resize Toggle
  /// </summary>
  private static Boolean? GetPreferRelative(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.PreferRelative?.Value;
  }
  
  private static void SetPreferRelative(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.PreferRelative = value;
    else
      openXmlElement.PreferRelative = null;
  }
  
  /// <summary>
  /// Clip to Wrapping Polygon
  /// </summary>
  private static Boolean? GetClipToWrap(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.ClipToWrap?.Value;
  }
  
  private static void SetClipToWrap(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ClipToWrap = value;
    else
      openXmlElement.ClipToWrap = null;
  }
  
  /// <summary>
  /// Clipping Toggle
  /// </summary>
  private static Boolean? GetClip(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Clip?.Value;
  }
  
  private static void SetClip(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Clip = value;
    else
      openXmlElement.Clip = null;
  }
  
  /// <summary>
  /// Image Source
  /// </summary>
  private static String? GetSource(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Source?.Value;
  }
  
  private static void SetSource(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Source = new StringValue { Value = value };
    else
      openXmlElement.Source = null;
  }
  
  /// <summary>
  /// Image Left Crop
  /// </summary>
  private static String? GetCropLeft(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.CropLeft?.Value;
  }
  
  private static void SetCropLeft(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CropLeft = new StringValue { Value = value };
    else
      openXmlElement.CropLeft = null;
  }
  
  /// <summary>
  /// Image Top Crop
  /// </summary>
  private static String? GetCropTop(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.CropTop?.Value;
  }
  
  private static void SetCropTop(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CropTop = new StringValue { Value = value };
    else
      openXmlElement.CropTop = null;
  }
  
  /// <summary>
  /// Image Right Crop
  /// </summary>
  private static String? GetCropRight(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.CropRight?.Value;
  }
  
  private static void SetCropRight(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CropRight = new StringValue { Value = value };
    else
      openXmlElement.CropRight = null;
  }
  
  /// <summary>
  /// Image Bottom Crop
  /// </summary>
  private static String? GetCropBottom(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.CropBottom?.Value;
  }
  
  private static void SetCropBottom(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CropBottom = new StringValue { Value = value };
    else
      openXmlElement.CropBottom = null;
  }
  
  /// <summary>
  /// Image Intensity
  /// </summary>
  private static String? GetGain(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Gain?.Value;
  }
  
  private static void SetGain(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Gain = new StringValue { Value = value };
    else
      openXmlElement.Gain = null;
  }
  
  /// <summary>
  /// Image Brightness
  /// </summary>
  private static String? GetBlackLevel(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.BlackLevel?.Value;
  }
  
  private static void SetBlackLevel(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BlackLevel = new StringValue { Value = value };
    else
      openXmlElement.BlackLevel = null;
  }
  
  /// <summary>
  /// Image Gamma Correction
  /// </summary>
  private static String? GetGamma(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.Gamma?.Value;
  }
  
  private static void SetGamma(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Gamma = new StringValue { Value = value };
    else
      openXmlElement.Gamma = null;
  }
  
  /// <summary>
  /// Image Grayscale Toggle
  /// </summary>
  private static Boolean? GetGrayScale(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.GrayScale?.Value;
  }
  
  private static void SetGrayScale(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.GrayScale = value;
    else
      openXmlElement.GrayScale = null;
  }
  
  /// <summary>
  /// Image Bilevel Toggle
  /// </summary>
  private static Boolean? GetBiLevel(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    return openXmlElement?.BiLevel?.Value;
  }
  
  private static void SetBiLevel(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BiLevel = value;
    else
      openXmlElement.BiLevel = null;
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  private static Byte[]? GetGfxdata(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    if (openXmlElement.Gfxdata?.Value != null)
      return Convert.FromBase64String(openXmlElement.Gfxdata.Value);
    return null;
  }
  
  private static void SetGfxdata(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.Gfxdata = Convert.ToBase64String(value);
    else
      openXmlElement.Gfxdata = null;
  }
  
  private static DocumentModel.Vml.Path? GetPath(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Path>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.PathConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPath(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.Path? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Path>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.PathConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Path>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Formulas? GetFormulas(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Formulas>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.FormulasConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFormulas(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.Formulas? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Formulas>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.FormulasConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Formulas>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.ShapeHandles? GetShapeHandles(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShapeHandlesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeHandles(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.ShapeHandles? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.ShapeHandlesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.ShapeHandles>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Fill? GetFill(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.FillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFill(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.Fill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.FillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Fill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Stroke? GetStroke(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Stroke>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.StrokeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStroke(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.Stroke? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Stroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.StrokeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Stroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Shadow? GetShadow(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shadow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShadow(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.Shadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.ShadowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Shadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.TextBox? GetTextBox(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.TextBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.TextBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextBox(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.TextBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.TextBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.TextBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.TextBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.TextPath? GetTextPath(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.TextPath>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.TextPathConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextPath(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.TextPath? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.TextPath>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.TextPathConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.TextPath>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.ImageData? GetImageData(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ImageDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetImageData(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.ImageData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.ImageDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.ImageData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Skew? GetSkew(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.SkewConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSkew(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.Skew? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.SkewConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Skew>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Extrusion? GetExtrusion(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ExtrusionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtrusion(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.Extrusion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.ExtrusionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Extrusion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Callout? GetCallout(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.CalloutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCallout(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.Callout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.CalloutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Callout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Vml.Lock? GetLock(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.LockConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLock(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.Lock? value)
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
  
  private static DocumentModel.Vml.ClipPath? GetClipPath(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ClipPathConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetClipPath(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.ClipPath? value)
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
  
  private static DocumentModel.Vml.SignatureLine? GetSignatureLine(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.SignatureLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSignatureLine(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Vml.SignatureLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.SignatureLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.SignatureLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.Vml.TextWrap? GetTextWrap(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Vml.TextWrapConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextWrap(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Wordprocessing.Vml.TextWrap? value)
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
  
  private static Boolean? GetAnchorLock(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
    return itemElement != null;
  }
  
  private static void SetAnchorLock(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, Boolean? value)
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
  
  private static DocumentModel.Wordprocessing.Vml.BorderType? GetTopBorder(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Vml.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTopBorder(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Wordprocessing.Vml.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.Vml.BorderTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.Vml.BorderType? GetBottomBorder(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Vml.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBottomBorder(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Wordprocessing.Vml.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.Vml.BorderTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.Vml.BorderType? GetLeftBorder(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Vml.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLeftBorder(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Wordprocessing.Vml.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.Vml.BorderTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.Vml.BorderType? GetRightBorder(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Vml.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRightBorder(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement, DocumentModel.Wordprocessing.Vml.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.Vml.BorderTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.ImageFile? CreateModelElement(DocumentFormat.OpenXml.Vml.ImageFile? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.ImageFile, new()
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

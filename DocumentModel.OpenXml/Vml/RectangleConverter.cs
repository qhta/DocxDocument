namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Rectangle.
/// </summary>
public static class RectangleConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  public static String? GetStyle(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  public static void SetStyle(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Style = new StringValue { Value = value };
      else
        openXmlElement.Style = null;
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  public static String? GetHref(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }
  
  public static void SetHref(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Href = new StringValue { Value = value };
      else
        openXmlElement.Href = null;
  }
  
  /// <summary>
  /// Hyperlink Display Target
  /// </summary>
  public static String? GetTarget(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.Target?.Value;
  }
  
  public static void SetTarget(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Target = new StringValue { Value = value };
      else
        openXmlElement.Target = null;
  }
  
  /// <summary>
  /// CSS Reference
  /// </summary>
  public static String? GetClass(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.Class?.Value;
  }
  
  public static void SetClass(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Class = new StringValue { Value = value };
      else
        openXmlElement.Class = null;
  }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  public static String? GetTitle(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  public static void SetTitle(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Title = new StringValue { Value = value };
      else
        openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Alternate Text
  /// </summary>
  public static String? GetAlternate(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.Alternate?.Value;
  }
  
  public static void SetAlternate(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Alternate = new StringValue { Value = value };
      else
        openXmlElement.Alternate = null;
  }
  
  /// <summary>
  /// Coordinate Space Size
  /// </summary>
  public static String? GetCoordinateSize(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.CoordinateSize?.Value;
  }
  
  public static void SetCoordinateSize(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CoordinateSize = new StringValue { Value = value };
      else
        openXmlElement.CoordinateSize = null;
  }
  
  /// <summary>
  /// Coordinate Space Origin
  /// </summary>
  public static String? GetCoordinateOrigin(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.CoordinateOrigin?.Value;
  }
  
  public static void SetCoordinateOrigin(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CoordinateOrigin = new StringValue { Value = value };
      else
        openXmlElement.CoordinateOrigin = null;
  }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  public static String? GetWrapCoordinates(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.WrapCoordinates?.Value;
  }
  
  public static void SetWrapCoordinates(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.WrapCoordinates = new StringValue { Value = value };
      else
        openXmlElement.WrapCoordinates = null;
  }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  public static Boolean? GetPrint(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.Print?.Value;
  }
  
  public static void SetPrint(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Print = value;
      else
        openXmlElement.Print = null;
  }
  
  /// <summary>
  /// Optional String
  /// </summary>
  public static String? GetOptionalString(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.OptionalString?.Value;
  }
  
  public static void SetOptionalString(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OptionalString = new StringValue { Value = value };
      else
        openXmlElement.OptionalString = null;
  }
  
  /// <summary>
  /// Shape Handle Toggle
  /// </summary>
  public static Boolean? GetOned(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.Oned?.Value;
  }
  
  public static void SetOned(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Oned = value;
      else
        openXmlElement.Oned = null;
  }
  
  /// <summary>
  /// Regroup ID
  /// </summary>
  public static Int64? GetRegroupId(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.RegroupId?.Value;
  }
  
  public static void SetRegroupId(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.RegroupId = value;
  }
  
  /// <summary>
  /// Double-click Notification Toggle
  /// </summary>
  public static Boolean? GetDoubleClickNotify(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.DoubleClickNotify?.Value;
  }
  
  public static void SetDoubleClickNotify(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DoubleClickNotify = value;
      else
        openXmlElement.DoubleClickNotify = null;
  }
  
  /// <summary>
  /// Button Behavior Toggle
  /// </summary>
  public static Boolean? GetButton(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.Button?.Value;
  }
  
  public static void SetButton(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Button = value;
      else
        openXmlElement.Button = null;
  }
  
  /// <summary>
  /// Hide Script Anchors
  /// </summary>
  public static Boolean? GetUserHidden(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.UserHidden?.Value;
  }
  
  public static void SetUserHidden(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UserHidden = value;
      else
        openXmlElement.UserHidden = null;
  }
  
  /// <summary>
  /// Graphical Bullet
  /// </summary>
  public static Boolean? GetBullet(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.Bullet?.Value;
  }
  
  public static void SetBullet(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Bullet = value;
      else
        openXmlElement.Bullet = null;
  }
  
  /// <summary>
  /// Horizontal Rule Toggle
  /// </summary>
  public static Boolean? GetHorizontal(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.Horizontal?.Value;
  }
  
  public static void SetHorizontal(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Horizontal = value;
      else
        openXmlElement.Horizontal = null;
  }
  
  /// <summary>
  /// Horizontal Rule Standard Display Toggle
  /// </summary>
  public static Boolean? GetHorizontalStandard(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.HorizontalStandard?.Value;
  }
  
  public static void SetHorizontalStandard(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HorizontalStandard = value;
      else
        openXmlElement.HorizontalStandard = null;
  }
  
  /// <summary>
  /// Horizontal Rule 3D Shading Toggle
  /// </summary>
  public static Boolean? GetHorizontalNoShade(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.HorizontalNoShade?.Value;
  }
  
  public static void SetHorizontalNoShade(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HorizontalNoShade = value;
      else
        openXmlElement.HorizontalNoShade = null;
  }
  
  /// <summary>
  /// Horizontal Rule Length Percentage
  /// </summary>
  public static Single? GetHorizontalPercentage(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.HorizontalPercentage?.Value;
  }
  
  public static void SetHorizontalPercentage(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Single? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalPercentage = value;
  }
  
  /// <summary>
  /// Horizontal Rule Alignment
  /// </summary>
  public static DocumentModel.Vml.HorizontalRuleAlignmentKind? GetHorizontalAlignment(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DocumentModel.Vml.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value);
  }
  
  public static void SetHorizontalAlignment(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.HorizontalRuleAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DocumentModel.Vml.HorizontalRuleAlignmentKind>(value);
  }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  public static Boolean? GetAllowInCell(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }
  
  public static void SetAllowInCell(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowInCell = value;
      else
        openXmlElement.AllowInCell = null;
  }
  
  /// <summary>
  /// Allow Shape Overlap
  /// </summary>
  public static Boolean? GetAllowOverlap(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  public static void SetAllowOverlap(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowOverlap = value;
      else
        openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// Exists In Master Slide
  /// </summary>
  public static Boolean? GetUserDrawn(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.UserDrawn?.Value;
  }
  
  public static void SetUserDrawn(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UserDrawn = value;
      else
        openXmlElement.UserDrawn = null;
  }
  
  /// <summary>
  /// Border Top Color
  /// </summary>
  public static String? GetBorderTopColor(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.BorderTopColor?.Value;
  }
  
  public static void SetBorderTopColor(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BorderTopColor = new StringValue { Value = value };
      else
        openXmlElement.BorderTopColor = null;
  }
  
  /// <summary>
  /// Border Left Color
  /// </summary>
  public static String? GetBorderLeftColor(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.BorderLeftColor?.Value;
  }
  
  public static void SetBorderLeftColor(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BorderLeftColor = new StringValue { Value = value };
      else
        openXmlElement.BorderLeftColor = null;
  }
  
  /// <summary>
  /// Bottom Border Color
  /// </summary>
  public static String? GetBorderBottomColor(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.BorderBottomColor?.Value;
  }
  
  public static void SetBorderBottomColor(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BorderBottomColor = new StringValue { Value = value };
      else
        openXmlElement.BorderBottomColor = null;
  }
  
  /// <summary>
  /// Border Right Color
  /// </summary>
  public static String? GetBorderRightColor(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.BorderRightColor?.Value;
  }
  
  public static void SetBorderRightColor(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BorderRightColor = new StringValue { Value = value };
      else
        openXmlElement.BorderRightColor = null;
  }
  
  /// <summary>
  /// Diagram Node Layout Identifier
  /// </summary>
  public static Int64? GetDiagramLayout(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.DiagramLayout?.Value;
  }
  
  public static void SetDiagramLayout(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DiagramLayout = value;
  }
  
  /// <summary>
  /// Diagram Node Identifier
  /// </summary>
  public static Int64? GetDiagramNodeKind(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.DiagramNodeKind?.Value;
  }
  
  public static void SetDiagramNodeKind(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DiagramNodeKind = value;
  }
  
  /// <summary>
  /// Diagram Node Recent Layout Identifier
  /// </summary>
  public static Int64? GetDiagramLayoutMostRecentUsed(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.DiagramLayoutMostRecentUsed?.Value;
  }
  
  public static void SetDiagramLayoutMostRecentUsed(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DiagramLayoutMostRecentUsed = value;
  }
  
  /// <summary>
  /// Text Inset Mode
  /// </summary>
  public static DocumentModel.Vml.InsetMarginKind? GetInsetMode(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DocumentModel.Vml.InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }
  
  public static void SetInsetMode(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.InsetMarginKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DocumentModel.Vml.InsetMarginKind>(value);
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public static Boolean? GetFilled(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.Filled?.Value;
  }
  
  public static void SetFilled(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Filled = value;
      else
        openXmlElement.Filled = null;
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  public static String? GetFillColor(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.FillColor?.Value;
  }
  
  public static void SetFillColor(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FillColor = new StringValue { Value = value };
      else
        openXmlElement.FillColor = null;
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  public static Boolean? GetStroked(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.Stroked?.Value;
  }
  
  public static void SetStroked(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Stroked = value;
      else
        openXmlElement.Stroked = null;
  }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  public static String? GetStrokeColor(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.StrokeColor?.Value;
  }
  
  public static void SetStrokeColor(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StrokeColor = new StringValue { Value = value };
      else
        openXmlElement.StrokeColor = null;
  }
  
  /// <summary>
  /// Shape Stroke Weight
  /// </summary>
  public static String? GetStrokeWeight(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.StrokeWeight?.Value;
  }
  
  public static void SetStrokeWeight(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StrokeWeight = new StringValue { Value = value };
      else
        openXmlElement.StrokeWeight = null;
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public static Boolean? GetInsetPen(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.InsetPen?.Value;
  }
  
  public static void SetInsetPen(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsetPen = value;
      else
        openXmlElement.InsetPen = null;
  }
  
  /// <summary>
  /// Optional Number
  /// </summary>
  public static Int32? GetOptionalNumber(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.OptionalNumber?.Value;
  }
  
  public static void SetOptionalNumber(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.OptionalNumber = value;
  }
  
  /// <summary>
  /// Shape Connector Type
  /// </summary>
  public static DocumentModel.Vml.ConnectorKind? GetConnectorType(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DocumentModel.Vml.ConnectorKind>(openXmlElement?.ConnectorType?.Value);
  }
  
  public static void SetConnectorType(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.ConnectorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ConnectorType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues, DocumentModel.Vml.ConnectorKind>(value);
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public static DocumentModel.Vml.BlackAndWhiteMode? GetBlackWhiteMode(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  public static void SetBlackWhiteMode(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public static DocumentModel.Vml.BlackAndWhiteMode? GetPureBlackWhiteMode(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value);
  }
  
  public static void SetPureBlackWhiteMode(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.PureBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public static DocumentModel.Vml.BlackAndWhiteMode? GetNormalBlackWhiteMode(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value);
  }
  
  public static void SetNormalBlackWhiteMode(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.NormalBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  public static Boolean? GetForceDash(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }
  
  public static void SetForceDash(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ForceDash = value;
      else
        openXmlElement.ForceDash = null;
  }
  
  /// <summary>
  /// Embedded Object Icon Toggle
  /// </summary>
  public static Boolean? GetOleIcon(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.OleIcon?.Value;
  }
  
  public static void SetOleIcon(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OleIcon = value;
      else
        openXmlElement.OleIcon = null;
  }
  
  /// <summary>
  /// Embedded Object Toggle
  /// </summary>
  public static Boolean? GetOle(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.Ole?.Value;
  }
  
  public static void SetOle(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Ole = value;
      else
        openXmlElement.Ole = null;
  }
  
  /// <summary>
  /// Relative Resize Toggle
  /// </summary>
  public static Boolean? GetPreferRelative(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.PreferRelative?.Value;
  }
  
  public static void SetPreferRelative(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PreferRelative = value;
      else
        openXmlElement.PreferRelative = null;
  }
  
  /// <summary>
  /// Clip to Wrapping Polygon
  /// </summary>
  public static Boolean? GetClipToWrap(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.ClipToWrap?.Value;
  }
  
  public static void SetClipToWrap(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ClipToWrap = value;
      else
        openXmlElement.ClipToWrap = null;
  }
  
  /// <summary>
  /// Clipping Toggle
  /// </summary>
  public static Boolean? GetClip(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    return openXmlElement?.Clip?.Value;
  }
  
  public static void SetClip(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Clip = value;
      else
        openXmlElement.Clip = null;
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  public static Byte[]? GetGfxdata(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    if (openXmlElement?.Gfxdata?.Value != null)
      return Convert.FromBase64String(openXmlElement.Gfxdata.Value);
    return null;
  }
  
  public static void SetGfxdata(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Gfxdata = Convert.ToBase64String(value);
      else
        openXmlElement.Gfxdata = null;
    }
  }
  
  public static DocumentModel.Vml.Path? GetPath(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Path>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.PathConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPath(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.Path? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Vml.Formulas? GetFormulas(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Formulas>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.FormulasConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFormulas(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.Formulas? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Vml.ShapeHandles? GetShapeHandles(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShapeHandlesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeHandles(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.ShapeHandles? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Vml.Fill? GetFill(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.FillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFill(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.Fill? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Vml.Stroke? GetStroke(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Stroke>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.StrokeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStroke(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.Stroke? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Vml.Shadow? GetShadow(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shadow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShadow(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.Shadow? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Vml.TextBox? GetTextBox(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.TextBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.TextBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextBox(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.TextBox? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Vml.TextPath? GetTextPath(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.TextPath>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.TextPathConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextPath(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.TextPath? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Vml.ImageData? GetImageData(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ImageDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetImageData(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.ImageData? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Vml.Skew? GetSkew(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.SkewConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSkew(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.Skew? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Vml.Extrusion? GetExtrusion(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ExtrusionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtrusion(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.Extrusion? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Vml.Callout? GetCallout(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.CalloutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCallout(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.Callout? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Vml.Lock? GetLock(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.LockConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLock(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.Lock? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Vml.ClipPath? GetClipPath(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ClipPathConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetClipPath(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.ClipPath? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Vml.SignatureLine? GetSignatureLine(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.SignatureLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSignatureLine(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Vml.SignatureLine? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.Vml.TextWrap? GetTextWrap(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Vml.TextWrapConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextWrap(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Wordprocessing.Vml.TextWrap? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetAnchorLock(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAnchorLock(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.Vml.BorderType? GetTopBorder(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Vml.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTopBorder(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Wordprocessing.Vml.BorderType? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.Vml.BorderType? GetBottomBorder(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Vml.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBottomBorder(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Wordprocessing.Vml.BorderType? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.Vml.BorderType? GetLeftBorder(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Vml.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLeftBorder(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Wordprocessing.Vml.BorderType? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.Vml.BorderType? GetRightBorder(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Vml.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRightBorder(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement, DocumentModel.Wordprocessing.Vml.BorderType? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Vml.Rectangle? CreateModelElement(DocumentFormat.OpenXml.Vml.Rectangle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Rectangle();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Rectangle? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Rectangle, new()
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

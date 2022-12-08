namespace DocumentModel.Vml;

/// <summary>
/// Shape Template.
/// </summary>
public class ShapetypeImpl: ModelElementImpl, Shapetype
{
  public DocumentFormat.OpenXml.Vml.Shapetype? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Shapetype?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  public String? Style
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  public String? Href
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hyperlink Display Target
  /// </summary>
  public String? Target
  {
    get;
    set;
  }
  
  /// <summary>
  /// CSS Reference
  /// </summary>
  public String? Class
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  public String? Title
  {
    get;
    set;
  }
  
  /// <summary>
  /// Alternate Text
  /// </summary>
  public String? Alternate
  {
    get;
    set;
  }
  
  /// <summary>
  /// Coordinate Space Size
  /// </summary>
  public String? CoordinateSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// Coordinate Space Origin
  /// </summary>
  public String? CoordinateOrigin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  public String? WrapCoordinates
  {
    get;
    set;
  }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  public Boolean? Print
  {
    get;
    set;
  }
  
  /// <summary>
  /// Optional String
  /// </summary>
  public String? OptionalString
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Handle Toggle
  /// </summary>
  public Boolean? Oned
  {
    get;
    set;
  }
  
  /// <summary>
  /// Regroup ID
  /// </summary>
  public Int32? RegroupId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Double-click Notification Toggle
  /// </summary>
  public Boolean? DoubleClickNotify
  {
    get;
    set;
  }
  
  /// <summary>
  /// Button Behavior Toggle
  /// </summary>
  public Boolean? Button
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hide Script Anchors
  /// </summary>
  public Boolean? UserHidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// Graphical Bullet
  /// </summary>
  public Boolean? Bullet
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Rule Toggle
  /// </summary>
  public Boolean? Horizontal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Rule Standard Display Toggle
  /// </summary>
  public Boolean? HorizontalStandard
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Rule 3D Shading Toggle
  /// </summary>
  public Boolean? HorizontalNoShade
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Rule Length Percentage
  /// </summary>
  public Single? HorizontalPercentage
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Rule Alignment
  /// </summary>
  public HorizontalRuleAlignmentKind? HorizontalAlignment
  {
    get => (HorizontalRuleAlignmentKind?)OpenXmlElement?.HorizontalAlignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalAlignment = (DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  public Boolean? AllowInCell
  {
    get;
    set;
  }
  
  /// <summary>
  /// Allow Shape Overlap
  /// </summary>
  public Boolean? AllowOverlap
  {
    get;
    set;
  }
  
  /// <summary>
  /// Exists In Master Slide
  /// </summary>
  public Boolean? UserDrawn
  {
    get;
    set;
  }
  
  /// <summary>
  /// Border Top Color
  /// </summary>
  public String? BorderTopColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Border Left Color
  /// </summary>
  public String? BorderLeftColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom Border Color
  /// </summary>
  public String? BorderBottomColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Border Right Color
  /// </summary>
  public String? BorderRightColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Node Layout Identifier
  /// </summary>
  public Int32? DiagramLayout
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Node Identifier
  /// </summary>
  public Int32? DiagramNodeKind
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Node Recent Layout Identifier
  /// </summary>
  public Int32? DiagramLayoutMostRecentUsed
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Inset Mode
  /// </summary>
  public InsetMarginKind? InsetMode
  {
    get => (InsetMarginKind?)OpenXmlElement?.InsetMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsetMode = (DocumentFormat.OpenXml.Vml.Office.InsetMarginValues?)value;
    }
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public Boolean? Filled
  {
    get;
    set;
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  public String? FillColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  public Boolean? Stroked
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  public String? StrokeColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Stroke Weight
  /// </summary>
  public String? StrokeWeight
  {
    get;
    set;
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public Boolean? InsetPen
  {
    get;
    set;
  }
  
  /// <summary>
  /// Optional Number
  /// </summary>
  public Int32? OptionalNumber
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Connector Type
  /// </summary>
  public ConnectorKind? ConnectorType
  {
    get => (ConnectorKind?)OpenXmlElement?.ConnectorType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ConnectorType = (DocumentFormat.OpenXml.Vml.Office.ConnectorValues?)value;
    }
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? BlackWhiteMode
  {
    get => (BlackAndWhiteMode?)OpenXmlElement?.BlackWhiteMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlackWhiteMode = (DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? PureBlackWhiteMode
  {
    get => (BlackAndWhiteMode?)OpenXmlElement?.PureBlackWhiteMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PureBlackWhiteMode = (DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? NormalBlackWhiteMode
  {
    get => (BlackAndWhiteMode?)OpenXmlElement?.NormalBlackWhiteMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NormalBlackWhiteMode = (DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  public Boolean? ForceDash
  {
    get;
    set;
  }
  
  /// <summary>
  /// Embedded Object Icon Toggle
  /// </summary>
  public Boolean? OleIcon
  {
    get;
    set;
  }
  
  /// <summary>
  /// Embedded Object Toggle
  /// </summary>
  public Boolean? Ole
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relative Resize Toggle
  /// </summary>
  public Boolean? PreferRelative
  {
    get;
    set;
  }
  
  /// <summary>
  /// Clip to Wrapping Polygon
  /// </summary>
  public Boolean? ClipToWrap
  {
    get;
    set;
  }
  
  /// <summary>
  /// Clipping Toggle
  /// </summary>
  public Boolean? Clip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Adjustment Parameters
  /// </summary>
  public String? Adjustment
  {
    get;
    set;
  }
  
  /// <summary>
  /// Edge Path
  /// </summary>
  public String? EdgePath
  {
    get;
    set;
  }
  
  /// <summary>
  /// Master Element Toggle
  /// </summary>
  public String? Master
  {
    get;
    set;
  }
  
  public Collection<Path>? Paths
  {
    get;
    set;
  }
  
  public Collection<Formulas>? Formulases
  {
    get;
    set;
  }
  
  public Collection<ShapeHandles>? ShapeHandleses
  {
    get;
    set;
  }
  
  public Collection<Fill>? Fills
  {
    get;
    set;
  }
  
  public Collection<Stroke>? Strokes
  {
    get;
    set;
  }
  
  public Collection<Shadow>? Shadows
  {
    get;
    set;
  }
  
  public Collection<TextBox>? TextBoxs
  {
    get;
    set;
  }
  
  public Collection<TextPath>? TextPaths
  {
    get;
    set;
  }
  
  public Collection<ImageData>? ImageDatas
  {
    get;
    set;
  }
  
  public Collection<Skew>? Skews
  {
    get;
    set;
  }
  
  public Collection<Extrusion>? Extrusions
  {
    get;
    set;
  }
  
  public Collection<Callout>? Callouts
  {
    get;
    set;
  }
  
  public Collection<Lock>? Locks
  {
    get;
    set;
  }
  
  public Collection<ClipPath>? ClipPaths
  {
    get;
    set;
  }
  
  public Collection<SignatureLine>? SignatureLines
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.Vml.TextWrap>? TextWraps
  {
    get;
    set;
  }
  
  public Collection<Boolean>? AnchorLocks
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.Vml.BorderType>? TopBorders
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.Vml.BorderType>? BottomBorders
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.Vml.BorderType>? LeftBorders
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.Vml.BorderType>? RightBorders
  {
    get;
    set;
  }
  
  public Complex? Complex
  {
    get;
    set;
  }
  
}

namespace DocumentModel.Vml;

/// <summary>
/// Multiple Path Line.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.Office.ICallout))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IClipPath))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IExtrusion))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IInk))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.ILock))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.ISignatureLine))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.ISkew))]
[ChildElementInfo(typeof(DocumentModel.Vml.Presentation.ITextData))]
[ChildElementInfo(typeof(DocumentModel.Vml.IFill))]
[ChildElementInfo(typeof(DocumentModel.Vml.IFormulas))]
[ChildElementInfo(typeof(DocumentModel.Vml.IShapeHandles))]
[ChildElementInfo(typeof(DocumentModel.Vml.IImageData))]
[ChildElementInfo(typeof(DocumentModel.Vml.IPath))]
[ChildElementInfo(typeof(DocumentModel.Vml.IShadow))]
[ChildElementInfo(typeof(DocumentModel.Vml.IStroke))]
[ChildElementInfo(typeof(DocumentModel.Vml.ITextBox))]
[ChildElementInfo(typeof(DocumentModel.Vml.ITextPath))]
[ChildElementInfo(typeof(DocumentModel.Vml.Wordprocessing.IAnchorLock))]
[ChildElementInfo(typeof(DocumentModel.Vml.Wordprocessing.ITopBorder))]
[ChildElementInfo(typeof(DocumentModel.Vml.Wordprocessing.IBottomBorder))]
[ChildElementInfo(typeof(DocumentModel.Vml.Wordprocessing.ILeftBorder))]
[ChildElementInfo(typeof(DocumentModel.Vml.Wordprocessing.IRightBorder))]
[ChildElementInfo(typeof(DocumentModel.Vml.Wordprocessing.ITextWrap))]
[ChildElementInfo(typeof(DocumentModel.Vml.Spreadsheet.IClientData))]
public class PolyLine: IPolyLine
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  public string? Style
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  public string? Href
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hyperlink Display Target
  /// </summary>
  public string? Target
  {
    get;
    set;
  }
  
  /// <summary>
  /// CSS Reference
  /// </summary>
  public string? Class
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  public string? Title
  {
    get;
    set;
  }
  
  /// <summary>
  /// Alternate Text
  /// </summary>
  public string? Alternate
  {
    get;
    set;
  }
  
  /// <summary>
  /// Coordinate Space Size
  /// </summary>
  public string? CoordinateSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// Coordinate Space Origin
  /// </summary>
  public string? CoordinateOrigin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  public string? WrapCoordinates
  {
    get;
    set;
  }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  public ITrueFalseValue? Print
  {
    get;
    set;
  }
  
  /// <summary>
  /// Optional String
  /// </summary>
  public string? OptionalString
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Handle Toggle
  /// </summary>
  public ITrueFalseValue? Oned
  {
    get;
    set;
  }
  
  /// <summary>
  /// Regroup ID
  /// </summary>
  public int? RegroupId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Double-click Notification Toggle
  /// </summary>
  public ITrueFalseValue? DoubleClickNotify
  {
    get;
    set;
  }
  
  /// <summary>
  /// Button Behavior Toggle
  /// </summary>
  public ITrueFalseValue? Button
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hide Script Anchors
  /// </summary>
  public ITrueFalseValue? UserHidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// Graphical Bullet
  /// </summary>
  public ITrueFalseValue? Bullet
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Rule Toggle
  /// </summary>
  public ITrueFalseValue? Horizontal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Rule Standard Display Toggle
  /// </summary>
  public ITrueFalseValue? HorizontalStandard
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Rule 3D Shading Toggle
  /// </summary>
  public ITrueFalseValue? HorizontalNoShade
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Rule Length Percentage
  /// </summary>
  public float? HorizontalPercentage
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Rule Alignment
  /// </summary>
  public HorizontalRuleAlignmentValues? HorizontalAlignment
  {
    get;
    set;
  }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  public ITrueFalseValue? AllowInCell
  {
    get;
    set;
  }
  
  /// <summary>
  /// Allow Shape Overlap
  /// </summary>
  public ITrueFalseValue? AllowOverlap
  {
    get;
    set;
  }
  
  /// <summary>
  /// Exists In Master Slide
  /// </summary>
  public ITrueFalseValue? UserDrawn
  {
    get;
    set;
  }
  
  /// <summary>
  /// Border Top Color
  /// </summary>
  public string? BorderTopColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Border Left Color
  /// </summary>
  public string? BorderLeftColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom Border Color
  /// </summary>
  public string? BorderBottomColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Border Right Color
  /// </summary>
  public string? BorderRightColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Node Layout Identifier
  /// </summary>
  public int? DiagramLayout
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Node Identifier
  /// </summary>
  public int? DiagramNodeKind
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagram Node Recent Layout Identifier
  /// </summary>
  public int? DiagramLayoutMostRecentUsed
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Inset Mode
  /// </summary>
  public InsetMarginValues? InsetMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public ITrueFalseValue? Filled
  {
    get;
    set;
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  public string? FillColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  public ITrueFalseValue? Stroked
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  public string? StrokeColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Stroke Weight
  /// </summary>
  public string? StrokeWeight
  {
    get;
    set;
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public ITrueFalseValue? InsetPen
  {
    get;
    set;
  }
  
  /// <summary>
  /// Optional Number
  /// </summary>
  public int? OptionalNumber
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Connector Type
  /// </summary>
  public ConnectorValues? ConnectorType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public BlackAndWhiteModeValues? BlackWhiteMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public BlackAndWhiteModeValues? PureBlackWhiteMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public BlackAndWhiteModeValues? NormalBlackWhiteMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  public ITrueFalseValue? ForceDash
  {
    get;
    set;
  }
  
  /// <summary>
  /// Embedded Object Icon Toggle
  /// </summary>
  public ITrueFalseValue? OleIcon
  {
    get;
    set;
  }
  
  /// <summary>
  /// Embedded Object Toggle
  /// </summary>
  public ITrueFalseBlankValue? Ole
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relative Resize Toggle
  /// </summary>
  public ITrueFalseValue? PreferRelative
  {
    get;
    set;
  }
  
  /// <summary>
  /// Clip to Wrapping Polygon
  /// </summary>
  public ITrueFalseValue? ClipToWrap
  {
    get;
    set;
  }
  
  /// <summary>
  /// Clipping Toggle
  /// </summary>
  public ITrueFalseValue? Clip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  public IBase64BinaryValue? Gfxdata
  {
    get;
    set;
  }
  
  /// <summary>
  /// Points for Compound Line
  /// </summary>
  public string? Points
  {
    get;
    set;
  }
  
}

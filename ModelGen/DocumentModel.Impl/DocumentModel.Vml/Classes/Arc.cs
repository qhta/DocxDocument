namespace DocumentModel.Vml;

/// <summary>
/// Arc Segment.
/// </summary>
public class ArcImpl: ModelElementImpl, Arc
{
  public DocumentFormat.OpenXml.Vml.Arc? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Arc?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Optional String
  /// </summary>
  public String? OptionalString
  {
    get => (String?)OpenXmlElement?.OptionalString?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OptionalString = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Handle Toggle
  /// </summary>
  public Boolean? Oned
  {
    get => (Boolean?)OpenXmlElement?.Oned?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Oned = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Regroup ID
  /// </summary>
  public Int32? RegroupId
  {
    get => (Int32?)OpenXmlElement?.RegroupId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RegroupId = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Double-click Notification Toggle
  /// </summary>
  public Boolean? DoubleClickNotify
  {
    get => (Boolean?)OpenXmlElement?.DoubleClickNotify?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DoubleClickNotify = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Button Behavior Toggle
  /// </summary>
  public Boolean? Button
  {
    get => (Boolean?)OpenXmlElement?.Button?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Button = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Hide Script Anchors
  /// </summary>
  public Boolean? UserHidden
  {
    get => (Boolean?)OpenXmlElement?.UserHidden?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UserHidden = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Graphical Bullet
  /// </summary>
  public Boolean? Bullet
  {
    get => (Boolean?)OpenXmlElement?.Bullet?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Bullet = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Horizontal Rule Toggle
  /// </summary>
  public Boolean? Horizontal
  {
    get => (Boolean?)OpenXmlElement?.Horizontal?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Horizontal = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Horizontal Rule Standard Display Toggle
  /// </summary>
  public Boolean? HorizontalStandard
  {
    get => (Boolean?)OpenXmlElement?.HorizontalStandard?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalStandard = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Horizontal Rule 3D Shading Toggle
  /// </summary>
  public Boolean? HorizontalNoShade
  {
    get => (Boolean?)OpenXmlElement?.HorizontalNoShade?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalNoShade = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Horizontal Rule Length Percentage
  /// </summary>
  public Single? HorizontalPercentage
  {
    get => (Single?)OpenXmlElement?.HorizontalPercentage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalPercentage = (System.Single?)value;
    }
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
    get => (Boolean?)OpenXmlElement?.AllowInCell?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowInCell = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Allow Shape Overlap
  /// </summary>
  public Boolean? AllowOverlap
  {
    get => (Boolean?)OpenXmlElement?.AllowOverlap?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowOverlap = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Exists In Master Slide
  /// </summary>
  public Boolean? UserDrawn
  {
    get => (Boolean?)OpenXmlElement?.UserDrawn?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UserDrawn = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Border Top Color
  /// </summary>
  public String? BorderTopColor
  {
    get => (String?)OpenXmlElement?.BorderTopColor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BorderTopColor = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Border Left Color
  /// </summary>
  public String? BorderLeftColor
  {
    get => (String?)OpenXmlElement?.BorderLeftColor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BorderLeftColor = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Bottom Border Color
  /// </summary>
  public String? BorderBottomColor
  {
    get => (String?)OpenXmlElement?.BorderBottomColor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BorderBottomColor = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Border Right Color
  /// </summary>
  public String? BorderRightColor
  {
    get => (String?)OpenXmlElement?.BorderRightColor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BorderRightColor = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Diagram Node Layout Identifier
  /// </summary>
  public Int32? DiagramLayout
  {
    get => (Int32?)OpenXmlElement?.DiagramLayout?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DiagramLayout = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Diagram Node Identifier
  /// </summary>
  public Int32? DiagramNodeKind
  {
    get => (Int32?)OpenXmlElement?.DiagramNodeKind?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DiagramNodeKind = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Diagram Node Recent Layout Identifier
  /// </summary>
  public Int32? DiagramLayoutMostRecentUsed
  {
    get => (Int32?)OpenXmlElement?.DiagramLayoutMostRecentUsed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DiagramLayoutMostRecentUsed = (System.Int32?)value;
    }
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
    get => (Boolean?)OpenXmlElement?.Filled?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Filled = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  public String? FillColor
  {
    get => (String?)OpenXmlElement?.FillColor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FillColor = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  public Boolean? Stroked
  {
    get => (Boolean?)OpenXmlElement?.Stroked?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Stroked = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  public String? StrokeColor
  {
    get => (String?)OpenXmlElement?.StrokeColor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StrokeColor = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Stroke Weight
  /// </summary>
  public String? StrokeWeight
  {
    get => (String?)OpenXmlElement?.StrokeWeight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StrokeWeight = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public Boolean? InsetPen
  {
    get => (Boolean?)OpenXmlElement?.InsetPen?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsetPen = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Optional Number
  /// </summary>
  public Int32? OptionalNumber
  {
    get => (Int32?)OpenXmlElement?.OptionalNumber?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OptionalNumber = (System.Int32?)value;
    }
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
    get => (Boolean?)OpenXmlElement?.ForceDash?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ForceDash = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Embedded Object Icon Toggle
  /// </summary>
  public Boolean? OleIcon
  {
    get => (Boolean?)OpenXmlElement?.OleIcon?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OleIcon = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Embedded Object Toggle
  /// </summary>
  public Boolean? Ole
  {
    get => (Boolean?)OpenXmlElement?.Ole?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Ole = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Relative Resize Toggle
  /// </summary>
  public Boolean? PreferRelative
  {
    get => (Boolean?)OpenXmlElement?.PreferRelative?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PreferRelative = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Clip to Wrapping Polygon
  /// </summary>
  public Boolean? ClipToWrap
  {
    get => (Boolean?)OpenXmlElement?.ClipToWrap?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ClipToWrap = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Clipping Toggle
  /// </summary>
  public Boolean? Clip
  {
    get => (Boolean?)OpenXmlElement?.Clip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Clip = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  public DocumentModel.Base64BinaryValue? Gfxdata
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id
  {
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  public String? Style
  {
    get => (String?)OpenXmlElement?.Style?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Style = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  public String? Href
  {
    get => (String?)OpenXmlElement?.Href?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Href = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Hyperlink Display Target
  /// </summary>
  public String? Target
  {
    get => (String?)OpenXmlElement?.Target?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Target = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  public String? Title
  {
    get => (String?)OpenXmlElement?.Title?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Title = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Alternate Text
  /// </summary>
  public String? Alternate
  {
    get => (String?)OpenXmlElement?.Alternate?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alternate = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Coordinate Space Size
  /// </summary>
  public String? CoordinateSize
  {
    get => (String?)OpenXmlElement?.CoordinateSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CoordinateSize = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Coordinate Space Origin
  /// </summary>
  public String? CoordinateOrigin
  {
    get => (String?)OpenXmlElement?.CoordinateOrigin?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CoordinateOrigin = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  public String? Wrapcoords
  {
    get => (String?)OpenXmlElement?.Wrapcoords?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Wrapcoords = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  public Boolean? Print
  {
    get => (Boolean?)OpenXmlElement?.Print?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Print = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Starting Angle
  /// </summary>
  public Decimal? StartAngle
  {
    get => (Decimal?)OpenXmlElement?.StartAngle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartAngle = (System.Decimal?)value;
    }
  }
  
  /// <summary>
  /// Ending Angle
  /// </summary>
  public Decimal? EndAngle
  {
    get => (Decimal?)OpenXmlElement?.EndAngle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EndAngle = (System.Decimal?)value;
    }
  }
  
  public Collection<Path>? Paths
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Formulas>? Formulases
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<ShapeHandles>? ShapeHandleses
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Fill>? Fills
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Stroke>? Strokes
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Shadow>? Shadows
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<TextBox>? TextBoxs
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<TextPath>? TextPaths
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<ImageData>? ImageDatas
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Skew>? Skews
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Extrusion>? Extrusions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Callout>? Callouts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Lock>? Locks
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<ClipPath>? ClipPaths
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<SignatureLine>? SignatureLines
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DocumentModel.Wordprocessing.Vml.TextWrap>? TextWraps
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Boolean>? AnchorLocks
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DocumentModel.Wordprocessing.Vml.BorderType>? TopBorders
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DocumentModel.Wordprocessing.Vml.BorderType>? BottomBorders
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DocumentModel.Wordprocessing.Vml.BorderType>? LeftBorders
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DocumentModel.Wordprocessing.Vml.BorderType>? RightBorders
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

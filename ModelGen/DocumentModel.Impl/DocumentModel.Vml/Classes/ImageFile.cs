namespace DocumentModel.Vml;

/// <summary>
/// Image File.
/// </summary>
public class ImageFileImpl: ModelElementImpl, ImageFile
{
  public DocumentFormat.OpenXml.Vml.ImageFile? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.ImageFile?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ImageFileImpl(): base() {}
  
  public ImageFileImpl(DocumentFormat.OpenXml.Vml.ImageFile openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  /// style
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
  /// href
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
  /// target
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
  /// class
  /// </summary>
  public String? Class
  {
    get => (String?)OpenXmlElement?.Class?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Class = (System.String?)value;
    }
  }
  
  /// <summary>
  /// title
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
  /// alt
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
  /// coordsize
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
  /// wrapcoords
  /// </summary>
  public String? WrapCoordinates
  {
    get => (String?)OpenXmlElement?.WrapCoordinates?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.WrapCoordinates = (System.String?)value;
    }
  }
  
  /// <summary>
  /// print
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
  /// Image Source
  /// </summary>
  public String? Source
  {
    get => (String?)OpenXmlElement?.Source?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Source = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Left Crop
  /// </summary>
  public String? CropLeft
  {
    get => (String?)OpenXmlElement?.CropLeft?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CropLeft = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Top Crop
  /// </summary>
  public String? CropTop
  {
    get => (String?)OpenXmlElement?.CropTop?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CropTop = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Right Crop
  /// </summary>
  public String? CropRight
  {
    get => (String?)OpenXmlElement?.CropRight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CropRight = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Bottom Crop
  /// </summary>
  public String? CropBottom
  {
    get => (String?)OpenXmlElement?.CropBottom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CropBottom = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Intensity
  /// </summary>
  public String? Gain
  {
    get => (String?)OpenXmlElement?.Gain?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Gain = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Brightness
  /// </summary>
  public String? BlackLevel
  {
    get => (String?)OpenXmlElement?.BlackLevel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlackLevel = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Gamma Correction
  /// </summary>
  public String? Gamma
  {
    get => (String?)OpenXmlElement?.Gamma?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Gamma = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Grayscale Toggle
  /// </summary>
  public Boolean? GrayScale
  {
    get => (Boolean?)OpenXmlElement?.GrayScale?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GrayScale = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Image Bilevel Toggle
  /// </summary>
  public Boolean? BiLevel
  {
    get => (Boolean?)OpenXmlElement?.BiLevel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BiLevel = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  public Base64BinaryValue? Gfxdata
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Path? Path
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Formulas? Formulas
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ShapeHandles? ShapeHandles
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Fill? Fill
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Stroke? Stroke
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Shadow? Shadow
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public TextBox? TextBox
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public TextPath? TextPath
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ImageData? ImageData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Skew? Skew
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Extrusion? Extrusion
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Callout? Callout
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Lock? Lock
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ClipPath? ClipPath
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public SignatureLine? SignatureLine
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.Vml.TextWrap? TextWrap
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Boolean? AnchorLock
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.Vml.BorderType? TopBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.Vml.BorderType? BottomBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.Vml.BorderType? LeftBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.Vml.BorderType? RightBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}

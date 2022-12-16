namespace DocumentModel.Vml;

/// <summary>
/// Bezier Curve.
/// </summary>
public class CurveImpl: ModelElementImpl, Curve
{
  public DocumentFormat.OpenXml.Vml.Curve? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Curve?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CurveImpl(): base() {}
  
  public CurveImpl(DocumentFormat.OpenXml.Vml.Curve openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
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
    get => (System.String?)OpenXmlElement?.Style?.Value;
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
    get => (System.String?)OpenXmlElement?.Href?.Value;
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
    get => (System.String?)OpenXmlElement?.Target?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Target = (System.String?)value;
    }
  }
  
  /// <summary>
  /// CSS Reference
  /// </summary>
  public String? Class
  {
    get => (System.String?)OpenXmlElement?.Class?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Class = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  public String? Title
  {
    get => (System.String?)OpenXmlElement?.Title?.Value;
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
    get => (System.String?)OpenXmlElement?.Alternate?.Value;
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
    get => (System.String?)OpenXmlElement?.CoordinateSize?.Value;
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
    get => (System.String?)OpenXmlElement?.CoordinateOrigin?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CoordinateOrigin = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  public String? WrapCoordinates
  {
    get => (System.String?)OpenXmlElement?.WrapCoordinates?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.WrapCoordinates = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  public Boolean? Print
  {
    get => (System.Boolean?)OpenXmlElement?.Print?.Value;
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
    get => (System.String?)OpenXmlElement?.OptionalString?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Oned?.Value;
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
    get => (System.Int32?)OpenXmlElement?.RegroupId?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.DoubleClickNotify?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Button?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.UserHidden?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Bullet?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Horizontal?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.HorizontalStandard?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.HorizontalNoShade?.Value;
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
    get => (System.Single?)OpenXmlElement?.HorizontalPercentage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalPercentage = (System.Single?)value;
    }
  }
  
  /// <summary>
  /// Horizontal Rule Alignment
  /// </summary>
  public DocumentModel.Vml.HorizontalRuleAlignmentKind? HorizontalAlignment
  {
    get => (DocumentModel.Vml.HorizontalRuleAlignmentKind?)OpenXmlElement?.HorizontalAlignment?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.AllowInCell?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.AllowOverlap?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.UserDrawn?.Value;
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
    get => (System.String?)OpenXmlElement?.BorderTopColor?.Value;
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
    get => (System.String?)OpenXmlElement?.BorderLeftColor?.Value;
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
    get => (System.String?)OpenXmlElement?.BorderBottomColor?.Value;
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
    get => (System.String?)OpenXmlElement?.BorderRightColor?.Value;
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
    get => (System.Int32?)OpenXmlElement?.DiagramLayout?.Value;
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
    get => (System.Int32?)OpenXmlElement?.DiagramNodeKind?.Value;
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
    get => (System.Int32?)OpenXmlElement?.DiagramLayoutMostRecentUsed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DiagramLayoutMostRecentUsed = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Text Inset Mode
  /// </summary>
  public DocumentModel.Vml.InsetMarginKind? InsetMode
  {
    get => (DocumentModel.Vml.InsetMarginKind?)OpenXmlElement?.InsetMode?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Filled?.Value;
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
    get => (System.String?)OpenXmlElement?.FillColor?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Stroked?.Value;
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
    get => (System.String?)OpenXmlElement?.StrokeColor?.Value;
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
    get => (System.String?)OpenXmlElement?.StrokeWeight?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.InsetPen?.Value;
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
    get => (System.Int32?)OpenXmlElement?.OptionalNumber?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OptionalNumber = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Shape Connector Type
  /// </summary>
  public DocumentModel.Vml.ConnectorKind? ConnectorType
  {
    get => (DocumentModel.Vml.ConnectorKind?)OpenXmlElement?.ConnectorType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ConnectorType = (DocumentFormat.OpenXml.Vml.Office.ConnectorValues?)value;
    }
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.BlackAndWhiteMode? BlackWhiteMode
  {
    get => (DocumentModel.Vml.BlackAndWhiteMode?)OpenXmlElement?.BlackWhiteMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlackWhiteMode = (DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.BlackAndWhiteMode? PureBlackWhiteMode
  {
    get => (DocumentModel.Vml.BlackAndWhiteMode?)OpenXmlElement?.PureBlackWhiteMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PureBlackWhiteMode = (DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.BlackAndWhiteMode? NormalBlackWhiteMode
  {
    get => (DocumentModel.Vml.BlackAndWhiteMode?)OpenXmlElement?.NormalBlackWhiteMode?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.ForceDash?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.OleIcon?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Ole?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.PreferRelative?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.ClipToWrap?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Clip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Clip = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  public DocumentModel.Base64Binary? Gfxdata
  {
    get
    {
      if (OpenXmlElement?.Gfxdata?.Value != null)
        return (DocumentModel.Base64Binary)OpenXmlElement.Gfxdata.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.Gfxdata = new DocumentFormat.OpenXml.Base64BinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.Gfxdata = null;
      }
    }
  }
  
  /// <summary>
  /// Curve Starting Point
  /// </summary>
  public String? From
  {
    get => (System.String?)OpenXmlElement?.From?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.From = (System.String?)value;
    }
  }
  
  /// <summary>
  /// First Curve Control Point
  /// </summary>
  public String? Control1
  {
    get => (System.String?)OpenXmlElement?.Control1?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Control1 = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Second Curve Control Point
  /// </summary>
  public String? Control2
  {
    get => (System.String?)OpenXmlElement?.Control2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Control2 = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Curve Ending Point
  /// </summary>
  public String? To
  {
    get => (System.String?)OpenXmlElement?.To?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.To = (System.String?)value;
    }
  }
  
  public DocumentModel.Vml.Path? Path
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Path>();
        if (item != null)
          return new DocumentModel.Vml.PathImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Path>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.PathImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Formulas? Formulas
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Formulas>();
        if (item != null)
          return new DocumentModel.Vml.FormulasImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Formulas>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.FormulasImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.ShapeHandles? ShapeHandles
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
        if (item != null)
          return new DocumentModel.Vml.ShapeHandlesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ShapeHandlesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Fill? Fill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
        if (item != null)
          return new DocumentModel.Vml.FillImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.FillImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Stroke? Stroke
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Stroke>();
        if (item != null)
          return new DocumentModel.Vml.StrokeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Stroke>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.StrokeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Shadow? Shadow
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shadow>();
        if (item != null)
          return new DocumentModel.Vml.ShadowImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shadow>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ShadowImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.TextBox? TextBox
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.TextBox>();
        if (item != null)
          return new DocumentModel.Vml.TextBoxImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.TextBox>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.TextBoxImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.TextPath? TextPath
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.TextPath>();
        if (item != null)
          return new DocumentModel.Vml.TextPathImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.TextPath>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.TextPathImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.ImageData? ImageData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageData>();
        if (item != null)
          return new DocumentModel.Vml.ImageDataImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageData>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ImageDataImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Skew? Skew
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
        if (item != null)
          return new DocumentModel.Vml.SkewImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.SkewImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Extrusion? Extrusion
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
        if (item != null)
          return new DocumentModel.Vml.ExtrusionImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ExtrusionImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Callout? Callout
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
        if (item != null)
          return new DocumentModel.Vml.CalloutImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.CalloutImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.Lock? Lock
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
        if (item != null)
          return new DocumentModel.Vml.LockImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.LockImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.ClipPath? ClipPath
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
        if (item != null)
          return new DocumentModel.Vml.ClipPathImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ClipPathImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Vml.SignatureLine? SignatureLine
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
        if (item != null)
          return new DocumentModel.Vml.SignatureLineImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.SignatureLineImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.Vml.TextWrap? TextWrap
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
        if (item != null)
          return new DocumentModel.Wordprocessing.Vml.TextWrapImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.Vml.TextWrapImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.Vml.BorderTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.Vml.BorderTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.Vml.BorderType? BottomBorder
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.Vml.BorderTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.Vml.BorderTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.Vml.BorderType? LeftBorder
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.Vml.BorderTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.Vml.BorderTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.Vml.BorderType? RightBorder
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.Vml.BorderTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.Vml.BorderTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}

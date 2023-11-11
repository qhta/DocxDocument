namespace DocumentModel.Vml;


/// <summary>
///   Line.
/// </summary>
public partial class Line: ModelElement<DXV.Line>
{
  public Line(): base(){ }
  
  public Line(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Line(DXV.Line openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Styling Properties
  /// </summary>
  [DataMember]
  public String? Style
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Style);
    }
    set
    {
      _ExistingElement.Style = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  [DataMember]
  public String? Href
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Href);
    }
    set
    {
      _ExistingElement.Href = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Hyperlink Display Target
  /// </summary>
  [DataMember]
  public String? Target
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Target);
    }
    set
    {
      _ExistingElement.Target = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   CSS Reference
  /// </summary>
  [DataMember]
  public String? Class
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Class);
    }
    set
    {
      _ExistingElement.Class = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Title
  /// </summary>
  [DataMember]
  public String? Title
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Title);
    }
    set
    {
      _ExistingElement.Title = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Alternate Text
  /// </summary>
  [DataMember]
  public String? Alternate
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Alternate);
    }
    set
    {
      _ExistingElement.Alternate = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Coordinate Space Size
  /// </summary>
  [DataMember]
  public String? CoordinateSize
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.CoordinateSize);
    }
    set
    {
      _ExistingElement.CoordinateSize = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Coordinate Space Origin
  /// </summary>
  [DataMember]
  public String? CoordinateOrigin
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.CoordinateOrigin);
    }
    set
    {
      _ExistingElement.CoordinateOrigin = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Bounding Polygon
  /// </summary>
  [DataMember]
  public String? WrapCoordinates
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.WrapCoordinates);
    }
    set
    {
      _ExistingElement.WrapCoordinates = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Print Toggle
  /// </summary>
  [DataMember]
  public Boolean? Print
  {
    get
    {
      return _Element?.Print?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Print = value;
      else
        _ExistingElement.Print = null;
    }
  }
  
  
  /// <summary>
  ///   Optional String
  /// </summary>
  [DataMember]
  public String? OptionalString
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.OptionalString);
    }
    set
    {
      _ExistingElement.OptionalString = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Handle Toggle
  /// </summary>
  [DataMember]
  public Boolean? Oned
  {
    get
    {
      return _Element?.Oned?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Oned = value;
      else
        _ExistingElement.Oned = null;
    }
  }
  
  
  /// <summary>
  ///   Regroup ID
  /// </summary>
  [DataMember]
  public Int64? RegroupId
  {
    get
    {
      return _Element?.RegroupId?.Value;
    }
    set
    {
      _ExistingElement.RegroupId = value;
    }
  }
  
  
  /// <summary>
  ///   Double-click Notification Toggle
  /// </summary>
  [DataMember]
  public Boolean? DoubleClickNotify
  {
    get
    {
      return _Element?.DoubleClickNotify?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.DoubleClickNotify = value;
      else
        _ExistingElement.DoubleClickNotify = null;
    }
  }
  
  
  /// <summary>
  ///   Button Behavior Toggle
  /// </summary>
  [DataMember]
  public Boolean? Button
  {
    get
    {
      return _Element?.Button?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Button = value;
      else
        _ExistingElement.Button = null;
    }
  }
  
  
  /// <summary>
  ///   Hide Script Anchors
  /// </summary>
  [DataMember]
  public Boolean? UserHidden
  {
    get
    {
      return _Element?.UserHidden?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.UserHidden = value;
      else
        _ExistingElement.UserHidden = null;
    }
  }
  
  
  /// <summary>
  ///   Graphical Bullet
  /// </summary>
  [DataMember]
  public Boolean? Bullet
  {
    get
    {
      return _Element?.Bullet?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Bullet = value;
      else
        _ExistingElement.Bullet = null;
    }
  }
  
  
  /// <summary>
  ///   Horizontal Rule Toggle
  /// </summary>
  [DataMember]
  public Boolean? Horizontal
  {
    get
    {
      return _Element?.Horizontal?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Horizontal = value;
      else
        _ExistingElement.Horizontal = null;
    }
  }
  
  
  /// <summary>
  ///   Horizontal Rule Standard Display Toggle
  /// </summary>
  [DataMember]
  public Boolean? HorizontalStandard
  {
    get
    {
      return _Element?.HorizontalStandard?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.HorizontalStandard = value;
      else
        _ExistingElement.HorizontalStandard = null;
    }
  }
  
  
  /// <summary>
  ///   Horizontal Rule 3D Shading Toggle
  /// </summary>
  [DataMember]
  public Boolean? HorizontalNoShade
  {
    get
    {
      return _Element?.HorizontalNoShade?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.HorizontalNoShade = value;
      else
        _ExistingElement.HorizontalNoShade = null;
    }
  }
  
  
  /// <summary>
  ///   Horizontal Rule Length Percentage
  /// </summary>
  [DataMember]
  public Single? HorizontalPercentage
  {
    get
    {
      return _Element?.HorizontalPercentage?.Value;
    }
    set
    {
      _ExistingElement.HorizontalPercentage = value;
    }
  }
  
  
  /// <summary>
  ///   Allow in Table Cell
  /// </summary>
  [DataMember]
  public Boolean? AllowInCell
  {
    get
    {
      return _Element?.AllowInCell?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AllowInCell = value;
      else
        _ExistingElement.AllowInCell = null;
    }
  }
  
  
  /// <summary>
  ///   Allow Shape Overlap
  /// </summary>
  [DataMember]
  public Boolean? AllowOverlap
  {
    get
    {
      return _Element?.AllowOverlap?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AllowOverlap = value;
      else
        _ExistingElement.AllowOverlap = null;
    }
  }
  
  
  /// <summary>
  ///   Exists In Master Slide
  /// </summary>
  [DataMember]
  public Boolean? UserDrawn
  {
    get
    {
      return _Element?.UserDrawn?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.UserDrawn = value;
      else
        _ExistingElement.UserDrawn = null;
    }
  }
  
  
  /// <summary>
  ///   Border Top Color
  /// </summary>
  [DataMember]
  public String? BorderTopColor
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.BorderTopColor);
    }
    set
    {
      _ExistingElement.BorderTopColor = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Border Left Color
  /// </summary>
  [DataMember]
  public String? BorderLeftColor
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.BorderLeftColor);
    }
    set
    {
      _ExistingElement.BorderLeftColor = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Bottom Border Color
  /// </summary>
  [DataMember]
  public String? BorderBottomColor
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.BorderBottomColor);
    }
    set
    {
      _ExistingElement.BorderBottomColor = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Border Right Color
  /// </summary>
  [DataMember]
  public String? BorderRightColor
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.BorderRightColor);
    }
    set
    {
      _ExistingElement.BorderRightColor = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Diagram Node Layout Identifier
  /// </summary>
  [DataMember]
  public Int64? DiagramLayout
  {
    get
    {
      return _Element?.DiagramLayout?.Value;
    }
    set
    {
      _ExistingElement.DiagramLayout = value;
    }
  }
  
  
  /// <summary>
  ///   Diagram Node Identifier
  /// </summary>
  [DataMember]
  public Int64? DiagramNodeKind
  {
    get
    {
      return _Element?.DiagramNodeKind?.Value;
    }
    set
    {
      _ExistingElement.DiagramNodeKind = value;
    }
  }
  
  
  /// <summary>
  ///   Diagram Node Recent Layout Identifier
  /// </summary>
  [DataMember]
  public Int64? DiagramLayoutMostRecentUsed
  {
    get
    {
      return _Element?.DiagramLayoutMostRecentUsed?.Value;
    }
    set
    {
      _ExistingElement.DiagramLayoutMostRecentUsed = value;
    }
  }
  
  
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  [DataMember]
  public Boolean? Filled
  {
    get
    {
      return _Element?.Filled?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Filled = value;
      else
        _ExistingElement.Filled = null;
    }
  }
  
  
  /// <summary>
  ///   Fill Color
  /// </summary>
  [DataMember]
  public String? FillColor
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.FillColor);
    }
    set
    {
      _ExistingElement.FillColor = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Stroke Toggle
  /// </summary>
  [DataMember]
  public Boolean? Stroked
  {
    get
    {
      return _Element?.Stroked?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Stroked = value;
      else
        _ExistingElement.Stroked = null;
    }
  }
  
  
  /// <summary>
  ///   Shape Stroke Color
  /// </summary>
  [DataMember]
  public String? StrokeColor
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.StrokeColor);
    }
    set
    {
      _ExistingElement.StrokeColor = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Stroke Weight
  /// </summary>
  [DataMember]
  public String? StrokeWeight
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.StrokeWeight);
    }
    set
    {
      _ExistingElement.StrokeWeight = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Inset Border From Path
  /// </summary>
  [DataMember]
  public Boolean? InsetPen
  {
    get
    {
      return _Element?.InsetPen?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.InsetPen = value;
      else
        _ExistingElement.InsetPen = null;
    }
  }
  
  
  /// <summary>
  ///   Optional Number
  /// </summary>
  [DataMember]
  public Int32? OptionalNumber
  {
    get
    {
      return _Element?.OptionalNumber?.Value;
    }
    set
    {
      _ExistingElement.OptionalNumber = value;
    }
  }
  
  
  /// <summary>
  ///   Force Dashed Outline
  /// </summary>
  [DataMember]
  public Boolean? ForceDash
  {
    get
    {
      return _Element?.ForceDash?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.ForceDash = value;
      else
        _ExistingElement.ForceDash = null;
    }
  }
  
  
  /// <summary>
  ///   Embedded Object Icon Toggle
  /// </summary>
  [DataMember]
  public Boolean? OleIcon
  {
    get
    {
      return _Element?.OleIcon?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.OleIcon = value;
      else
        _ExistingElement.OleIcon = null;
    }
  }
  
  
  /// <summary>
  ///   Embedded Object Toggle
  /// </summary>
  [DataMember]
  public Boolean? Ole
  {
    get
    {
      return _Element?.Ole?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Ole = value;
      else
        _ExistingElement.Ole = null;
    }
  }
  
  
  /// <summary>
  ///   Relative Resize Toggle
  /// </summary>
  [DataMember]
  public Boolean? PreferRelative
  {
    get
    {
      return _Element?.PreferRelative?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.PreferRelative = value;
      else
        _ExistingElement.PreferRelative = null;
    }
  }
  
  
  /// <summary>
  ///   Clip to Wrapping Polygon
  /// </summary>
  [DataMember]
  public Boolean? ClipToWrap
  {
    get
    {
      return _Element?.ClipToWrap?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.ClipToWrap = value;
      else
        _ExistingElement.ClipToWrap = null;
    }
  }
  
  
  /// <summary>
  ///   Clipping Toggle
  /// </summary>
  [DataMember]
  public Boolean? Clip
  {
    get
    {
      return _Element?.Clip?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Clip = value;
      else
        _ExistingElement.Clip = null;
    }
  }
  
  
  /// <summary>
  ///   Encoded Package
  /// </summary>
  [DataMember]
  public DM.Base64Binary? Gfxdata
  {
    get
    {
      return Base64BinaryConverter.GetValue(_Element?.Gfxdata);
    }
    set
    {
      _ExistingElement.Gfxdata = Base64BinaryConverter.CreateBase64BinaryValue(value);
    }
  }
  
  
  /// <summary>
  ///   Line Start
  /// </summary>
  [DataMember]
  public String? From
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.From);
    }
    set
    {
      _ExistingElement.From = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Line End Point
  /// </summary>
  [DataMember]
  public String? To
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.To);
    }
    set
    {
      _ExistingElement.To = StringValueConverter.CreateStringValue(value);
    }
  }
  
}

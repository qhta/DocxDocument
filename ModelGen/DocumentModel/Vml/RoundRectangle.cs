namespace DocumentModel.Vml;


/// <summary>
///   Rounded Rectangle.
/// </summary>
public partial class RoundRectangle: ModelElement<DXV.RoundRectangle>
{
  public RoundRectangle(): base(){ }
  
  public RoundRectangle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RoundRectangle(DXV.RoundRectangle openXmlElement): base(openXmlElement) { }
  
  
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
  ///   style
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
  ///   href
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
  ///   target
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
  ///   class
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
  ///   title
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
  ///   alt
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
  ///   coordsize
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
  ///   wrapcoords
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
  ///   print
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? Print
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
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
  public DM.TrueFalseValue? Oned
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
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
  public DM.TrueFalseValue? DoubleClickNotify
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Button Behavior Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? Button
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Hide Script Anchors
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? UserHidden
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Graphical Bullet
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? Bullet
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Horizontal Rule Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? Horizontal
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Horizontal Rule Standard Display Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? HorizontalStandard
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Horizontal Rule 3D Shading Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? HorizontalNoShade
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
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
  public DM.TrueFalseValue? AllowInCell
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Allow Shape Overlap
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? AllowOverlap
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Exists In Master Slide
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? UserDrawn
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
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
  public DM.TrueFalseValue? Filled
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
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
  public DM.TrueFalseValue? Stroked
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
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
  public DM.TrueFalseValue? InsetPen
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
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
  public DM.TrueFalseValue? ForceDash
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Embedded Object Icon Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? OleIcon
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Embedded Object Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseBlankValue? Ole
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseBlankValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseBlankValue,DocumentFormat.OpenXml.TrueFalseBlankValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Relative Resize Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? PreferRelative
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Clip to Wrapping Polygon
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? ClipToWrap
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Clipping Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? Clip
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
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
      if (_Element?.Gfxdata?.Value != null)
        return Convert.FromBase64String(_ExistingElement.Gfxdata.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.Gfxdata = Convert.ToBase64String(value);
      else
        _ExistingElement.Gfxdata = null;
    }
  }
  
  
  /// <summary>
  ///   Rounded Corner Arc Size
  /// </summary>
  [DataMember]
  public String? ArcSize
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ArcSize);
    }
    set
    {
      _ExistingElement.ArcSize = StringValueConverter.CreateStringValue(value);
    }
  }
  
}

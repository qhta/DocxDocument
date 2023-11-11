namespace DocumentModel.Vml;


/// <summary>
///   Defines the Fill Class.
/// </summary>
public partial class Fill: ModelElement<DXV.Fill>
{
  public Fill(): base(){ }
  
  public Fill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Fill(DXV.Fill openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Fill Toggle
  /// </summary>
  [DataMember]
  public Boolean? On
  {
    get
    {
      return _Element?.On?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.On = value;
      else
        _ExistingElement.On = null;
    }
  }
  
  
  /// <summary>
  ///   Primary Color
  /// </summary>
  [DataMember]
  public String? Color
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Color);
    }
    set
    {
      _ExistingElement.Color = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Primary Color Opacity
  /// </summary>
  [DataMember]
  public String? Opacity
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Opacity);
    }
    set
    {
      _ExistingElement.Opacity = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Secondary Color
  /// </summary>
  [DataMember]
  public String? Color2
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Color2);
    }
    set
    {
      _ExistingElement.Color2 = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Fill Image Source
  /// </summary>
  [DataMember]
  public String? Source
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Source);
    }
    set
    {
      _ExistingElement.Source = StringValueConverter.CreateStringValue(value);
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
  ///   Alternate Image Reference Location
  /// </summary>
  [DataMember]
  public String? AlternateImageReference
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.AlternateImageReference);
    }
    set
    {
      _ExistingElement.AlternateImageReference = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Fill Image Size
  /// </summary>
  [DataMember]
  public String? Size
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Size);
    }
    set
    {
      _ExistingElement.Size = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Fill Image Origin
  /// </summary>
  [DataMember]
  public String? Origin
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Origin);
    }
    set
    {
      _ExistingElement.Origin = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Fill Image Position
  /// </summary>
  [DataMember]
  public String? Position
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Position);
    }
    set
    {
      _ExistingElement.Position = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Intermediate Colors
  /// </summary>
  [DataMember]
  public String? Colors
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Colors);
    }
    set
    {
      _ExistingElement.Colors = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Gradient Angle
  /// </summary>
  [DataMember]
  public Decimal? Angle
  {
    get
    {
      return _Element?.Angle?.Value;
    }
    set
    {
      _ExistingElement.Angle = value;
    }
  }
  
  
  /// <summary>
  ///   Align Image With Shape
  /// </summary>
  [DataMember]
  public Boolean? AlignShape
  {
    get
    {
      return _Element?.AlignShape?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AlignShape = value;
      else
        _ExistingElement.AlignShape = null;
    }
  }
  
  
  /// <summary>
  ///   Gradient Center
  /// </summary>
  [DataMember]
  public String? Focus
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Focus);
    }
    set
    {
      _ExistingElement.Focus = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Radial Gradient Size
  /// </summary>
  [DataMember]
  public String? FocusSize
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.FocusSize);
    }
    set
    {
      _ExistingElement.FocusSize = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Radial Gradient Center
  /// </summary>
  [DataMember]
  public String? FocusPosition
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.FocusPosition);
    }
    set
    {
      _ExistingElement.FocusPosition = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Detect Mouse Click
  /// </summary>
  [DataMember]
  public Boolean? DetectMouseClick
  {
    get
    {
      return _Element?.DetectMouseClick?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.DetectMouseClick = value;
      else
        _ExistingElement.DetectMouseClick = null;
    }
  }
  
  
  /// <summary>
  ///   Title
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
  ///   Secondary Color Opacity
  /// </summary>
  [DataMember]
  public String? Opacity2
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Opacity2);
    }
    set
    {
      _ExistingElement.Opacity2 = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Recolor Fill as Picture
  /// </summary>
  [DataMember]
  public Boolean? Recolor
  {
    get
    {
      return _Element?.Recolor?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Recolor = value;
      else
        _ExistingElement.Recolor = null;
    }
  }
  
  
  /// <summary>
  ///   Rotate Fill with Shape
  /// </summary>
  [DataMember]
  public Boolean? Rotate
  {
    get
    {
      return _Element?.Rotate?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Rotate = value;
      else
        _ExistingElement.Rotate = null;
    }
  }
  
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [DataMember]
  public String? RelationshipId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.RelationshipId);
    }
    set
    {
      _ExistingElement.RelationshipId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   FillExtendedProperties.
  /// </summary>
  [DataMember]
  public DMVML.FillExtendedProperties? FillExtendedProperties
  {
    get
    {
      return _Element?.GetObject<DMVML.FillExtendedProperties,DXVO.FillExtendedProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.FillExtendedProperties,DXVO.FillExtendedProperties>(value);
    }
  }
  
}

namespace DocumentModel.Vml;


/// <summary>
///   Defines the Stroke Class.
/// </summary>
public partial class Stroke: ModelElement<DXV.Stroke>
{
  public Stroke(): base(){ }
  
  public Stroke(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Stroke(DXV.Stroke openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Stroke Toggle
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
  ///   Stroke Weight
  /// </summary>
  [DataMember]
  public String? Weight
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Weight);
    }
    set
    {
      _ExistingElement.Weight = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Stroke Color
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
  ///   Stroke Opacity
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
  ///   Miter Joint Limit
  /// </summary>
  [DataMember]
  public String? Miterlimit
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Miterlimit);
    }
    set
    {
      _ExistingElement.Miterlimit = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Stroke Dash Pattern
  /// </summary>
  [DataMember]
  public String? DashStyle
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.DashStyle);
    }
    set
    {
      _ExistingElement.DashStyle = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Stroke Image Location
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
  ///   Stroke Image Size
  /// </summary>
  [DataMember]
  public String? ImageSize
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ImageSize);
    }
    set
    {
      _ExistingElement.ImageSize = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Stoke Image Alignment
  /// </summary>
  [DataMember]
  public Boolean? ImageAlignShape
  {
    get
    {
      return _Element?.ImageAlignShape?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.ImageAlignShape = value;
      else
        _ExistingElement.ImageAlignShape = null;
    }
  }
  
  
  /// <summary>
  ///   Stroke Alternate Pattern Color
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
  ///   Original Image Reference
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
  ///   Alternate Image Reference
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
  ///   Stroke Title
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
  ///   Relationship
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
  ///   Inset Border From Path
  /// </summary>
  [DataMember]
  public Boolean? Insetpen
  {
    get
    {
      return _Element?.Insetpen?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Insetpen = value;
      else
        _ExistingElement.Insetpen = null;
    }
  }
  
  
  /// <summary>
  ///   LeftStroke.
  /// </summary>
  [DataMember]
  public DMVML.LeftStroke? LeftStroke
  {
    get
    {
      return _Element?.GetObject<DMVML.LeftStroke,DXVO.LeftStroke>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.LeftStroke,DXVO.LeftStroke>(value);
    }
  }
  
  
  /// <summary>
  ///   TopStroke.
  /// </summary>
  [DataMember]
  public DMVML.TopStroke? TopStroke
  {
    get
    {
      return _Element?.GetObject<DMVML.TopStroke,DXVO.TopStroke>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.TopStroke,DXVO.TopStroke>(value);
    }
  }
  
  
  /// <summary>
  ///   RightStroke.
  /// </summary>
  [DataMember]
  public DMVML.RightStroke? RightStroke
  {
    get
    {
      return _Element?.GetObject<DMVML.RightStroke,DXVO.RightStroke>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.RightStroke,DXVO.RightStroke>(value);
    }
  }
  
  
  /// <summary>
  ///   BottomStroke.
  /// </summary>
  [DataMember]
  public DMVML.BottomStroke? BottomStroke
  {
    get
    {
      return _Element?.GetObject<DMVML.BottomStroke,DXVO.BottomStroke>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.BottomStroke,DXVO.BottomStroke>(value);
    }
  }
  
  
  /// <summary>
  ///   ColumnStroke.
  /// </summary>
  [DataMember]
  public DMVML.ColumnStroke? ColumnStroke
  {
    get
    {
      return _Element?.GetObject<DMVML.ColumnStroke,DXVO.ColumnStroke>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.ColumnStroke,DXVO.ColumnStroke>(value);
    }
  }
  
}

namespace DocumentModel.Vml;


/// <summary>
///   Defines the StrokeChildType Class.
/// </summary>
public partial class StrokeChildType: ModelElement<DXVO.StrokeChildType>
{
  public StrokeChildType(): base(){ }
  
  public StrokeChildType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StrokeChildType(DXVO.StrokeChildType openXmlElement): base(openXmlElement) { }
  
  
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
  public Decimal? MiterLimit
  {
    get
    {
      return _Element?.MiterLimit?.Value;
    }
    set
    {
      _ExistingElement.MiterLimit = value;
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
  
}

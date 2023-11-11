namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the shadow effect. By default, text does not have shadow.
/// </summary>
public partial class Shadow: ModelElement<DXO10W.Shadow>
{
  public Shadow(): base(){ }
  
  public Shadow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Shadow(DXO10W.Shadow openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? BlurRadius
  {
    get
    {
      return _Element?.BlurRadius?.Value;
    }
    set
    {
      _ExistingElement.BlurRadius = value;
    }
  }
  
  
  /// <summary>
  ///   dist, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? DistanceFromText
  {
    get
    {
      return _Element?.DistanceFromText?.Value;
    }
    set
    {
      _ExistingElement.DistanceFromText = value;
    }
  }
  
  
  /// <summary>
  ///   dir, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? DirectionAngle
  {
    get
    {
      return _Element?.DirectionAngle?.Value;
    }
    set
    {
      _ExistingElement.DirectionAngle = value;
    }
  }
  
  
  /// <summary>
  ///   sx, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? HorizontalScalingFactor
  {
    get
    {
      return _Element?.HorizontalScalingFactor?.Value;
    }
    set
    {
      _ExistingElement.HorizontalScalingFactor = value;
    }
  }
  
  
  /// <summary>
  ///   sy, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? VerticalScalingFactor
  {
    get
    {
      return _Element?.VerticalScalingFactor?.Value;
    }
    set
    {
      _ExistingElement.VerticalScalingFactor = value;
    }
  }
  
  
  /// <summary>
  ///   kx, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? HorizontalSkewAngle
  {
    get
    {
      return _Element?.HorizontalSkewAngle?.Value;
    }
    set
    {
      _ExistingElement.HorizontalSkewAngle = value;
    }
  }
  
  
  /// <summary>
  ///   ky, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? VerticalSkewAngle
  {
    get
    {
      return _Element?.VerticalSkewAngle?.Value;
    }
    set
    {
      _ExistingElement.VerticalSkewAngle = value;
    }
  }
  
  
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  [DataMember]
  public DM.HexBinary? RgbColorModelHex
  {
    get
    {
      return _Element?.GetObject<DM.HexBinary,DXO10W.RgbColorModelHex>();
    }
    set
    {
      _ExistingElement.SetObject<DM.HexBinary,DXO10W.RgbColorModelHex>(value);
    }
  }
  
  
  /// <summary>
  ///   SchemeColor.
  /// </summary>
  [DataMember]
  public DMW10.SchemeColorKind? SchemeColor
  {
    get
    {
      throw new NotImplementedException("Not implemented in GenerateEnumPropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.SchemeColor");
    }
    set
    {
      throw new NotImplementedException("Not implemented in GenerateEnumPropertySetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.SchemeColor");
    }
  }
  
}

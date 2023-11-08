namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the reflection effect.
/// </summary>
public partial class Reflection: ModelElement<DXO10W.Reflection>
{
  public Reflection(): base(){ }
  
  public Reflection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Reflection(DXO10W.Reflection openXmlElement): base(openXmlElement) { }
  
  
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
  ///   stA, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? StartingOpacity
  {
    get
    {
      return _Element?.StartingOpacity?.Value;
    }
    set
    {
      _ExistingElement.StartingOpacity = value;
    }
  }
  
  
  /// <summary>
  ///   stPos, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? StartPosition
  {
    get
    {
      return _Element?.StartPosition?.Value;
    }
    set
    {
      _ExistingElement.StartPosition = value;
    }
  }
  
  
  /// <summary>
  ///   endA, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? EndingOpacity
  {
    get
    {
      return _Element?.EndingOpacity?.Value;
    }
    set
    {
      _ExistingElement.EndingOpacity = value;
    }
  }
  
  
  /// <summary>
  ///   endPos, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? EndPosition
  {
    get
    {
      return _Element?.EndPosition?.Value;
    }
    set
    {
      _ExistingElement.EndPosition = value;
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
  ///   fadeDir, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? FadeDirection
  {
    get
    {
      return _Element?.FadeDirection?.Value;
    }
    set
    {
      _ExistingElement.FadeDirection = value;
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
  
}

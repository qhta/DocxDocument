namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a blur effect that is applied to the entire shape, including its fill. All color channels, including alpha, are affected.
/// </summary>
public partial class Blur: ModelElement<DXD.Blur>
{
  public Blur(): base(){ }
  
  public Blur(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Blur(DXD.Blur openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the radius of blur.
  /// </summary>
  [DataMember]
  public Int64? Radius
  {
    get
    {
      return _Element?.Radius?.Value;
    }
    set
    {
      _ExistingElement.Radius = value;
    }
  }
  
  
  /// <summary>
  ///   Specifies whether the bounds of the object should be grown as a result of the blurring. True indicates the bounds are grown while false indicates that they are not.
  /// </summary>
  [DataMember]
  public Boolean? Grow
  {
    get
    {
      return _Element?.Grow?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Grow = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Grow = null;
    }
  }
  
}

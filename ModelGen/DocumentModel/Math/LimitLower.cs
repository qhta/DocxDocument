namespace DocumentModel.Math;


/// <summary>
///   Lower-Limit Function.
/// </summary>
public partial class LimitLower: ModelElement<DXM.LimitLower>
{
  public LimitLower(): base(){ }
  
  public LimitLower(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LimitLower(DXM.LimitLower openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Lower Limit Properties.
  /// </summary>
  [DataMember]
  public DMM.LimitLowerProperties? LimitLowerProperties
  {
    get
    {
      return _Element?.GetObject<DMM.LimitLowerProperties,DXM.LimitLowerProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.LimitLowerProperties,DXM.LimitLowerProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Base.
  /// </summary>
  [DataMember]
  public DMM.Base? Base
  {
    get
    {
      return _Element?.GetObject<DMM.Base,DXM.Base>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Base,DXM.Base>(value);
    }
  }
  
  
  /// <summary>
  ///   Limit (Lower).
  /// </summary>
  [DataMember]
  public DMM.Limit? Limit
  {
    get
    {
      return _Element?.GetObject<DMM.Limit,DXM.Limit>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Limit,DXM.Limit>(value);
    }
  }
  
}

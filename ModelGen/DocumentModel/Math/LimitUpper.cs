namespace DocumentModel.Math;


/// <summary>
///   Upper-Limit Function.
/// </summary>
public partial class LimitUpper: ModelElement<DXM.LimitUpper>
{
  public LimitUpper(): base(){ }
  
  public LimitUpper(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LimitUpper(DXM.LimitUpper openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Upper Limit Properties.
  /// </summary>
  [DataMember]
  public DMM.LimitUpperProperties? LimitUpperProperties
  {
    get
    {
      return _Element?.GetObject<DMM.LimitUpperProperties,DXM.LimitUpperProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.LimitUpperProperties,DXM.LimitUpperProperties>(value);
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
  ///   Limit (Upper).
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

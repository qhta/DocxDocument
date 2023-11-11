namespace DocumentModel.Math;


/// <summary>
///   Border-Box Function.
/// </summary>
public partial class BorderBox: ModelElement<DXM.BorderBox>
{
  public BorderBox(): base(){ }
  
  public BorderBox(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BorderBox(DXM.BorderBox openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Border Box Properties.
  /// </summary>
  [DataMember]
  public DMM.BorderBoxProperties? BorderBoxProperties
  {
    get
    {
      return _Element?.GetObject<DMM.BorderBoxProperties,DXM.BorderBoxProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.BorderBoxProperties,DXM.BorderBoxProperties>(value);
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
  
}

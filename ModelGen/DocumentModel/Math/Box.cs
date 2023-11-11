namespace DocumentModel.Math;


/// <summary>
///   Box Function.
/// </summary>
public partial class Box: ModelElement<DXM.Box>
{
  public Box(): base(){ }
  
  public Box(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Box(DXM.Box openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Box Properties.
  /// </summary>
  [DataMember]
  public DMM.BoxProperties? BoxProperties
  {
    get
    {
      return _Element?.GetObject<DMM.BoxProperties,DXM.BoxProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.BoxProperties,DXM.BoxProperties>(value);
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

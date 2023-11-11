namespace DocumentModel.Math;


/// <summary>
///   Phantom Function.
/// </summary>
public partial class Phantom: ModelElement<DXM.Phantom>
{
  public Phantom(): base(){ }
  
  public Phantom(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Phantom(DXM.Phantom openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Phantom Properties.
  /// </summary>
  [DataMember]
  public DMM.PhantomProperties? PhantomProperties
  {
    get
    {
      return _Element?.GetObject<DMM.PhantomProperties,DXM.PhantomProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.PhantomProperties,DXM.PhantomProperties>(value);
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

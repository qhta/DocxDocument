namespace DocumentModel.Math;


/// <summary>
///   Pre-Sub-Superscript Function.
/// </summary>
public partial class PreSubSuper: ModelElement<DXM.PreSubSuper>
{
  public PreSubSuper(): base(){ }
  
  public PreSubSuper(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PreSubSuper(DXM.PreSubSuper openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Pre-Sub-Superscript Properties.
  /// </summary>
  [DataMember]
  public DMM.PreSubSuperProperties? PreSubSuperProperties
  {
    get
    {
      return _Element?.GetObject<DMM.PreSubSuperProperties,DXM.PreSubSuperProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.PreSubSuperProperties,DXM.PreSubSuperProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Subscript (Pre-Sub-Superscript).
  /// </summary>
  [DataMember]
  public DMM.SubArgument? SubArgument
  {
    get
    {
      return _Element?.GetObject<DMM.SubArgument,DXM.SubArgument>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.SubArgument,DXM.SubArgument>(value);
    }
  }
  
  
  /// <summary>
  ///   Superscript(Pre-Sub-Superscript function).
  /// </summary>
  [DataMember]
  public DMM.SuperArgument? SuperArgument
  {
    get
    {
      return _Element?.GetObject<DMM.SuperArgument,DXM.SuperArgument>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.SuperArgument,DXM.SuperArgument>(value);
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

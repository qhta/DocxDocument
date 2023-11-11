namespace DocumentModel.Math;


/// <summary>
///   n-ary Operator Function.
/// </summary>
public partial class Nary: ModelElement<DXM.Nary>
{
  public Nary(): base(){ }
  
  public Nary(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Nary(DXM.Nary openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   n-ary Properties.
  /// </summary>
  [DataMember]
  public DMM.NaryProperties? NaryProperties
  {
    get
    {
      return _Element?.GetObject<DMM.NaryProperties,DXM.NaryProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.NaryProperties,DXM.NaryProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Lower limit (n-ary) .
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
  ///   Upper limit (n-ary).
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
  ///   Base (Argument).
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

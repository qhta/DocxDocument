namespace DocumentModel.Math;


/// <summary>
///   Subscript Function.
/// </summary>
public partial class Subscript: ModelElement<DXM.Subscript>
{
  public Subscript(): base(){ }
  
  public Subscript(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Subscript(DXM.Subscript openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Subscript Properties.
  /// </summary>
  [DataMember]
  public DMM.SubscriptProperties? SubscriptProperties
  {
    get
    {
      return _Element?.GetObject<DMM.SubscriptProperties,DXM.SubscriptProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.SubscriptProperties,DXM.SubscriptProperties>(value);
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
  ///   Subscript (Subscript function).
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
  
}

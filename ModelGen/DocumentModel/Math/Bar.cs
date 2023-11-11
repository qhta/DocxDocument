namespace DocumentModel.Math;


/// <summary>
///   Bar.
/// </summary>
public partial class Bar: ModelElement<DXM.Bar>
{
  public Bar(): base(){ }
  
  public Bar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Bar(DXM.Bar openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Bar Properties.
  /// </summary>
  [DataMember]
  public DMM.BarProperties? BarProperties
  {
    get
    {
      return _Element?.GetObject<DMM.BarProperties,DXM.BarProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.BarProperties,DXM.BarProperties>(value);
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

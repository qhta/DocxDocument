namespace DocumentModel.Math;


/// <summary>
///   Radical Function.
/// </summary>
public partial class Radical: ModelElement<DXM.Radical>
{
  public Radical(): base(){ }
  
  public Radical(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Radical(DXM.Radical openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Radical Properties.
  /// </summary>
  [DataMember]
  public DMM.RadicalProperties? RadicalProperties
  {
    get
    {
      return _Element?.GetObject<DMM.RadicalProperties,DXM.RadicalProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.RadicalProperties,DXM.RadicalProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Degree.
  /// </summary>
  [DataMember]
  public DMM.Degree? Degree
  {
    get
    {
      return _Element?.GetObject<DMM.Degree,DXM.Degree>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Degree,DXM.Degree>(value);
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

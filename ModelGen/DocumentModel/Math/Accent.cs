namespace DocumentModel.Math;


/// <summary>
///   Accent.
/// </summary>
public partial class Accent: ModelElement<DXM.Accent>
{
  public Accent(): base(){ }
  
  public Accent(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Accent(DXM.Accent openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Accent Properties.
  /// </summary>
  [DataMember]
  public DMM.AccentProperties? AccentProperties
  {
    get
    {
      return _Element?.GetObject<DMM.AccentProperties,DXM.AccentProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.AccentProperties,DXM.AccentProperties>(value);
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

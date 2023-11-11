namespace DocumentModel.Math;


/// <summary>
///   Accent Properties.
/// </summary>
public partial class AccentProperties: ModelElement<DXM.AccentProperties>
{
  public AccentProperties(): base(){ }
  
  public AccentProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AccentProperties(DXM.AccentProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Accent Character.
  /// </summary>
  [DataMember]
  public DMM.AccentChar? AccentChar
  {
    get
    {
      return _Element?.GetObject<DMM.AccentChar,DXM.AccentChar>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.AccentChar,DXM.AccentChar>(value);
    }
  }
  
  
  /// <summary>
  ///   Control Properties.
  /// </summary>
  [DataMember]
  public DMM.ControlProperties? ControlProperties
  {
    get
    {
      return _Element?.GetObject<DMM.ControlProperties,DXM.ControlProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ControlProperties,DXM.ControlProperties>(value);
    }
  }
  
}

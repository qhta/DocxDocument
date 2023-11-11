namespace DocumentModel.Math;


/// <summary>
///   Bar Properties.
/// </summary>
public partial class BarProperties: ModelElement<DXM.BarProperties>
{
  public BarProperties(): base(){ }
  
  public BarProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BarProperties(DXM.BarProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Position (Bar).
  /// </summary>
  [DataMember]
  public DMM.Position? Position
  {
    get
    {
      return _Element?.GetObject<DMM.Position,DXM.Position>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Position,DXM.Position>(value);
    }
  }
  
  
  /// <summary>
  ///   ControlProperties.
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

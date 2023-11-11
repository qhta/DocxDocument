namespace DocumentModel.Math;


/// <summary>
///   Radical Properties.
/// </summary>
public partial class RadicalProperties: ModelElement<DXM.RadicalProperties>
{
  public RadicalProperties(): base(){ }
  
  public RadicalProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RadicalProperties(DXM.RadicalProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Hide Degree.
  /// </summary>
  [DataMember]
  public DMM.HideDegree? HideDegree
  {
    get
    {
      return _Element?.GetObject<DMM.HideDegree,DXM.HideDegree>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.HideDegree,DXM.HideDegree>(value);
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

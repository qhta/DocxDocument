namespace DocumentModel.Math;


/// <summary>
///   Lower Limit Properties.
/// </summary>
public partial class LimitLowerProperties: ModelElement<DXM.LimitLowerProperties>
{
  public LimitLowerProperties(): base(){ }
  
  public LimitLowerProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LimitLowerProperties(DXM.LimitLowerProperties openXmlElement): base(openXmlElement) { }
  
  
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

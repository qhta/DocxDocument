namespace DocumentModel.Math;


/// <summary>
///   Upper Limit Properties.
/// </summary>
public partial class LimitUpperProperties: ModelElement<DXM.LimitUpperProperties>
{
  public LimitUpperProperties(): base(){ }
  
  public LimitUpperProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LimitUpperProperties(DXM.LimitUpperProperties openXmlElement): base(openXmlElement) { }
  
  
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

namespace DocumentModel.Math;


/// <summary>
///   Pre-Sub-Superscript Properties.
/// </summary>
public partial class PreSubSuperProperties: ModelElement<DXM.PreSubSuperProperties>
{
  public PreSubSuperProperties(): base(){ }
  
  public PreSubSuperProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PreSubSuperProperties(DXM.PreSubSuperProperties openXmlElement): base(openXmlElement) { }
  
  
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

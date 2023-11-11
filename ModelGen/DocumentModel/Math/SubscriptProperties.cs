namespace DocumentModel.Math;


/// <summary>
///   Subscript Properties.
/// </summary>
public partial class SubscriptProperties: ModelElement<DXM.SubscriptProperties>
{
  public SubscriptProperties(): base(){ }
  
  public SubscriptProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SubscriptProperties(DXM.SubscriptProperties openXmlElement): base(openXmlElement) { }
  
  
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

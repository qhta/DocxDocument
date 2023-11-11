namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the lighting properties associated with the scene.
/// </summary>
public partial class LightRig: ModelElement<DXO10W.LightRig>
{
  public LightRig(): base(){ }
  
  public LightRig(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LightRig(DXO10W.LightRig openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   SphereCoordinates.
  /// </summary>
  [DataMember]
  public DMW10.SphereCoordinates? SphereCoordinates
  {
    get
    {
      return _Element?.GetObject<DMW10.SphereCoordinates,DXO10W.SphereCoordinates>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.SphereCoordinates,DXO10W.SphereCoordinates>(value);
    }
  }
  
}

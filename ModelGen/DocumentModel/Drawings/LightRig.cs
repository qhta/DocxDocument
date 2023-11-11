namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the light rig associated with the table.  The light rig comes into play when there is a 3D bevel applied to a cell.  When 3D is used, the light rig defines the lighting properties associated with the scene.
/// </summary>
public partial class LightRig: ModelElement<DXD.LightRig>
{
  public LightRig(): base(){ }
  
  public LightRig(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LightRig(DXD.LightRig openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Rotation.
  /// </summary>
  [DataMember]
  public DMD.Rotation? Rotation
  {
    get
    {
      return _Element?.GetObject<DMD.Rotation,DXD.Rotation>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Rotation,DXD.Rotation>(value);
    }
  }
  
}

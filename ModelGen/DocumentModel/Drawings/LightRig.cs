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
      var element = _Element?.GetFirstChild<DXD.Rotation>();
      if (element != null)
        return RotationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Rotation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RotationConverter.CreateOpenXmlElement<DXD.Rotation>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}

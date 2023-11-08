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
      var element = _Element?.GetFirstChild<DXO10W.SphereCoordinates>();
      if (element != null)
        return SphereCoordinatesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.SphereCoordinates>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SphereCoordinatesConverter.CreateOpenXmlElement<DXO10W.SphereCoordinates>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}

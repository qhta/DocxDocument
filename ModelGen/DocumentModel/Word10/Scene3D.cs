namespace DocumentModel.Word10;


/// <summary>
///   This element specifies 3-D scene properties of text, including camera and lighting. By default, text does not have 3-D scene properties
/// </summary>
public partial class Scene3D: ModelElement<DXO10W.Scene3D>
{
  public Scene3D(): base(){ }
  
  public Scene3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Scene3D(DXO10W.Scene3D openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Camera.
  /// </summary>
  [DataMember]
  public DMW10.Camera? Camera
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.Camera>();
      if (element != null)
        return CameraConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.Camera>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CameraConverter.CreateOpenXmlElement<DXO10W.Camera>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   LightRig.
  /// </summary>
  [DataMember]
  public DMW10.LightRig? LightRig
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.LightRig>();
      if (element != null)
        return LightRigConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.LightRig>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LightRigConverter.CreateOpenXmlElement<DXO10W.LightRig>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}

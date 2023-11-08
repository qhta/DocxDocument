namespace DocumentModel.Drawings;


/// <summary>
///   This element defines optional scene-level 3D properties to apply to an object.
/// </summary>
public partial class Scene3DType: ModelElement<DXD.Scene3DType>
{
  public Scene3DType(): base(){ }
  
  public Scene3DType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Scene3DType(DXD.Scene3DType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Camera.
  /// </summary>
  [DataMember]
  public DMD.Camera? Camera
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Camera>();
      if (element != null)
        return CameraConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Camera>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CameraConverter.CreateOpenXmlElement<DXD.Camera>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Light Rig.
  /// </summary>
  [DataMember]
  public DMD.LightRig? LightRig
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.LightRig>();
      if (element != null)
        return LightRigConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.LightRig>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LightRigConverter.CreateOpenXmlElement<DXD.LightRig>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Backdrop Plane.
  /// </summary>
  [DataMember]
  public DMD.Backdrop? Backdrop
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Backdrop>();
      if (element != null)
        return BackdropConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Backdrop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackdropConverter.CreateOpenXmlElement<DXD.Backdrop>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}

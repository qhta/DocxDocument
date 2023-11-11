namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   3-D Scene.
/// </summary>
public partial class Scene3D: ModelElement<DXDDD.Scene3D>
{
  public Scene3D(): base(){ }
  
  public Scene3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Scene3D(DXDDD.Scene3D openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Camera.
  /// </summary>
  [DataMember]
  public DMD.Camera? Camera
  {
    get
    {
      return _Element?.GetObject<DMD.Camera,DXD.Camera>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Camera,DXD.Camera>(value);
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
      return _Element?.GetObject<DMD.LightRig,DXD.LightRig>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.LightRig,DXD.LightRig>(value);
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
      return _Element?.GetObject<DMD.Backdrop,DXD.Backdrop>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Backdrop,DXD.Backdrop>(value);
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
      return _Element?.GetObject<DMD.ExtensionList,DXD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtensionList,DXD.ExtensionList>(value);
    }
  }
  
}

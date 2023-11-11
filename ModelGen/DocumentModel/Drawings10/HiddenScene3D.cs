namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the HiddenScene3D Class.
/// </summary>
public partial class HiddenScene3D: ModelElement<DXO10D.HiddenScene3D>
{
  public HiddenScene3D(): base(){ }
  
  public HiddenScene3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HiddenScene3D(DXO10D.HiddenScene3D openXmlElement): base(openXmlElement) { }
  
  
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

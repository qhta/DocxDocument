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
      return _Element?.GetObject<DMW10.Camera,DXO10W.Camera>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.Camera,DXO10W.Camera>(value);
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
      return _Element?.GetObject<DMW10.LightRig,DXO10W.LightRig>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.LightRig,DXO10W.LightRig>(value);
    }
  }
  
}

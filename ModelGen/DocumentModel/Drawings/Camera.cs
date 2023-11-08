namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the placement and properties of the camera in the 3D scene.  The camera position and properties modify the view of the scene.
/// </summary>
public partial class Camera: ModelElement<DXD.Camera>
{
  public Camera(): base(){ }
  
  public Camera(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Camera(DXD.Camera openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Provides an override for the default field of view for the camera.  Different perspectives can be obtained by modifying this attribute.
  /// </summary>
  [DataMember]
  public Int32? FieldOfView
  {
    get
    {
      return _Element?.FieldOfView?.Value;
    }
    set
    {
      _ExistingElement.FieldOfView = value;
    }
  }
  
  
  /// <summary>
  ///   Defines the zoom factor of a given camera element.  The zoom modifies the scene as a whole and zooms in or out accordingly.
  /// </summary>
  [DataMember]
  public Int32? Zoom
  {
    get
    {
      return _Element?.Zoom?.Value;
    }
    set
    {
      _ExistingElement.Zoom = value;
    }
  }
  
  
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

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// 3-D Scene.
/// </summary>
public static class Scene3DConverter
{
  /// <summary>
  /// Camera.
  /// </summary>
  private static DMDraws.Camera? GetCamera(DXDrawDgms.Scene3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Camera>();
    if (itemElement != null)
      return DMXDraws.CameraConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCamera(DXDrawDgms.Scene3D openXmlElement, DMDraws.Camera? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Camera>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.CameraConverter.CreateOpenXmlElement<DXDraw.Camera>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Light Rig.
  /// </summary>
  private static DMDraws.LightRig? GetLightRig(DXDrawDgms.Scene3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LightRig>();
    if (itemElement != null)
      return DMXDraws.LightRigConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLightRig(DXDrawDgms.Scene3D openXmlElement, DMDraws.LightRig? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LightRig>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LightRigConverter.CreateOpenXmlElement<DXDraw.LightRig>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Backdrop Plane.
  /// </summary>
  private static DMDraws.Backdrop? GetBackdrop(DXDrawDgms.Scene3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Backdrop>();
    if (itemElement != null)
      return DMXDraws.BackdropConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackdrop(DXDrawDgms.Scene3D openXmlElement, DMDraws.Backdrop? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Backdrop>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BackdropConverter.CreateOpenXmlElement<DXDraw.Backdrop>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDrawDgms.Scene3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawDgms.Scene3D openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsDgms.Scene3D? CreateModelElement(DXDrawDgms.Scene3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.Scene3D();
      value.Camera = GetCamera(openXmlElement);
      value.LightRig = GetLightRig(openXmlElement);
      value.Backdrop = GetBackdrop(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Scene3D? value)
    where OpenXmlElementType: DXDrawDgms.Scene3D, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCamera(openXmlElement, value?.Camera);
      SetLightRig(openXmlElement, value?.LightRig);
      SetBackdrop(openXmlElement, value?.Backdrop);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}

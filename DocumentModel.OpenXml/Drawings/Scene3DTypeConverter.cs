namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// 3D Scene Properties.
/// </summary>
public static class Scene3DTypeConverter
{
  /// <summary>
  /// Camera.
  /// </summary>
  private static DMDraws.Camera? GetCamera(DXDraw.Scene3DType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Camera>();
    if (itemElement != null)
      return DMXDraws.CameraConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCamera(DXDraw.Scene3DType openXmlElement, DMDraws.Camera? value)
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
  private static DMDraws.LightRig? GetLightRig(DXDraw.Scene3DType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LightRig>();
    if (itemElement != null)
      return DMXDraws.LightRigConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLightRig(DXDraw.Scene3DType openXmlElement, DMDraws.LightRig? value)
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
  private static DMDraws.Backdrop? GetBackdrop(DXDraw.Scene3DType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Backdrop>();
    if (itemElement != null)
      return DMXDraws.BackdropConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackdrop(DXDraw.Scene3DType openXmlElement, DMDraws.Backdrop? value)
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
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.Scene3DType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDraw.Scene3DType openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDraws.Scene3DType? CreateModelElement(DXDraw.Scene3DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Scene3DType();
      value.Camera = GetCamera(openXmlElement);
      value.LightRig = GetLightRig(openXmlElement);
      value.Backdrop = GetBackdrop(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Scene3DType? value)
    where OpenXmlElementType: DXDraw.Scene3DType, new()
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

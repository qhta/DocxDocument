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
    var element = openXmlElement?.GetFirstChild<DXDraw.Camera>();
    if (element != null)
      return DMXDraws.CameraConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCamera(DXDraw.Scene3DType openXmlElement, DMDraws.Camera? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.CameraConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Camera>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.LightRig>();
    if (element != null)
      return DMXDraws.LightRigConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLightRig(DXDraw.Scene3DType openXmlElement, DMDraws.LightRig? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LightRigConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.LightRig>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.Backdrop>();
    if (element != null)
      return DMXDraws.BackdropConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackdrop(DXDraw.Scene3DType openXmlElement, DMDraws.Backdrop? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BackdropConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Backdrop>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (element != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDraw.Scene3DType openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.Scene3DType? CreateModelElement(DXDraw.Scene3DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Scene3DType();
      value.Camera = GetCamera(openXmlElement);
      value.LightRig = GetLightRig(openXmlElement);
      value.Backdrop = GetBackdrop(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.Scene3DType? openXmlElement, DMDraws.Scene3DType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCamera(openXmlElement, value.Camera, diffs, objName))
        ok = false;
      if (!CmpLightRig(openXmlElement, value.LightRig, diffs, objName))
        ok = false;
      if (!CmpBackdrop(openXmlElement, value.Backdrop, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Scene3DType value)
    where OpenXmlElementType: DXDraw.Scene3DType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.Scene3DType openXmlElement, DMDraws.Scene3DType value)
  {
    SetCamera(openXmlElement, value?.Camera);
    SetLightRig(openXmlElement, value?.LightRig);
    SetBackdrop(openXmlElement, value?.Backdrop);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}

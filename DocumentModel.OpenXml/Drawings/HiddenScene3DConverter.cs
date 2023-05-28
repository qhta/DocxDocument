namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HiddenScene3D Class.
/// </summary>
public static class HiddenScene3DConverter
{
  /// <summary>
  /// Camera.
  /// </summary>
  private static DMD.Camera? GetCamera(DXO10D.HiddenScene3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Camera>();
    if (element != null)
      return DMXD.CameraConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCamera(DXO10D.HiddenScene3D openXmlElement, DMD.Camera? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.CameraConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Camera>(), value, diffs, objName, propName);
  }
  
  private static void SetCamera(DXO10D.HiddenScene3D openXmlElement, DMD.Camera? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Camera>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.CameraConverter.CreateOpenXmlElement<DXD.Camera>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Light Rig.
  /// </summary>
  private static DMD.LightRig? GetLightRig(DXO10D.HiddenScene3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LightRig>();
    if (element != null)
      return DMXD.LightRigConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLightRig(DXO10D.HiddenScene3D openXmlElement, DMD.LightRig? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LightRigConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LightRig>(), value, diffs, objName, propName);
  }
  
  private static void SetLightRig(DXO10D.HiddenScene3D openXmlElement, DMD.LightRig? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LightRig>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LightRigConverter.CreateOpenXmlElement<DXD.LightRig>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Backdrop Plane.
  /// </summary>
  private static DMD.Backdrop? GetBackdrop(DXO10D.HiddenScene3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Backdrop>();
    if (element != null)
      return DMXD.BackdropConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackdrop(DXO10D.HiddenScene3D openXmlElement, DMD.Backdrop? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.BackdropConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Backdrop>(), value, diffs, objName, propName);
  }
  
  private static void SetBackdrop(DXO10D.HiddenScene3D openXmlElement, DMD.Backdrop? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Backdrop>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BackdropConverter.CreateOpenXmlElement<DXD.Backdrop>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXO10D.HiddenScene3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO10D.HiddenScene3D openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXO10D.HiddenScene3D openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.HiddenScene3D? CreateModelElement(DXO10D.HiddenScene3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.HiddenScene3D();
      value.Camera = GetCamera(openXmlElement);
      value.LightRig = GetLightRig(openXmlElement);
      value.Backdrop = GetBackdrop(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.HiddenScene3D? openXmlElement, DMD.HiddenScene3D? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCamera(openXmlElement, value.Camera, diffs, objName, propName))
        ok = false;
      if (!CmpLightRig(openXmlElement, value.LightRig, diffs, objName, propName))
        ok = false;
      if (!CmpBackdrop(openXmlElement, value.Backdrop, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.HiddenScene3D value)
    where OpenXmlElementType: DXO10D.HiddenScene3D, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.HiddenScene3D openXmlElement, DMD.HiddenScene3D value)
  {
    SetCamera(openXmlElement, value?.Camera);
    SetLightRig(openXmlElement, value?.LightRig);
    SetBackdrop(openXmlElement, value?.Backdrop);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}

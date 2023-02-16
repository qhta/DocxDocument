namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Scene3D Class.
/// </summary>
public static class Scene3DConverter
{
  /// <summary>
  /// Camera.
  /// </summary>
  private static DMW.Camera? GetCamera(DXO2010W.Scene3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.Camera>();
    if (element != null)
      return DMXW.CameraConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCamera(DXO2010W.Scene3D openXmlElement, DMW.Camera? value, DiffList? diffs, string? objName)
  {
    return DMXW.CameraConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.Camera>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCamera(DXO2010W.Scene3D openXmlElement, DMW.Camera? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Camera>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CameraConverter.CreateOpenXmlElement<DXO2010W.Camera>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// LightRig.
  /// </summary>
  private static DMW.LightRig? GetLightRig(DXO2010W.Scene3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.LightRig>();
    if (element != null)
      return DMXW.LightRigConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLightRig(DXO2010W.Scene3D openXmlElement, DMW.LightRig? value, DiffList? diffs, string? objName)
  {
    return DMXW.LightRigConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.LightRig>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLightRig(DXO2010W.Scene3D openXmlElement, DMW.LightRig? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.LightRig>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.LightRigConverter.CreateOpenXmlElement<DXO2010W.LightRig>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.Scene3D? CreateModelElement(DXO2010W.Scene3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Scene3D();
      value.Camera = GetCamera(openXmlElement);
      value.LightRig = GetLightRig(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010W.Scene3D? openXmlElement, DMW.Scene3D? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCamera(openXmlElement, value.Camera, diffs, objName))
        ok = false;
      if (!CmpLightRig(openXmlElement, value.LightRig, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Scene3D? value)
    where OpenXmlElementType: DXO2010W.Scene3D, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCamera(openXmlElement, value?.Camera);
      SetLightRig(openXmlElement, value?.LightRig);
      return openXmlElement;
    }
    return default;
  }
}

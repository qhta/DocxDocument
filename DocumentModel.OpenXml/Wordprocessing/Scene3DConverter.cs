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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.Camera>();
    if (itemElement != null)
      return DMXW.CameraConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.LightRig>();
    if (itemElement != null)
      return DMXW.LightRigConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMW.Scene3D? CreateModelElement(DXO2010W.Scene3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Scene3D();
      value.Camera = GetCamera(openXmlElement);
      value.LightRig = GetLightRig(openXmlElement);
      return value;
    }
    return null;
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

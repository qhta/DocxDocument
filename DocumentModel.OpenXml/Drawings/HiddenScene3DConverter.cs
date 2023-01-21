namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HiddenScene3D Class.
/// </summary>
public static class HiddenScene3DConverter
{
  /// <summary>
  /// Camera.
  /// </summary>
  private static DMDraws.Camera? GetCamera(DXO2010Draw.HiddenScene3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Camera>();
    if (itemElement != null)
      return DMXDraws.CameraConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCamera(DXO2010Draw.HiddenScene3D openXmlElement, DMDraws.Camera? value)
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
  private static DMDraws.LightRig? GetLightRig(DXO2010Draw.HiddenScene3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LightRig>();
    if (itemElement != null)
      return DMXDraws.LightRigConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLightRig(DXO2010Draw.HiddenScene3D openXmlElement, DMDraws.LightRig? value)
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
  private static DMDraws.Backdrop? GetBackdrop(DXO2010Draw.HiddenScene3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Backdrop>();
    if (itemElement != null)
      return DMXDraws.BackdropConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackdrop(DXO2010Draw.HiddenScene3D openXmlElement, DMDraws.Backdrop? value)
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
  private static DMDraws.ExtensionList? GetExtensionList(DXO2010Draw.HiddenScene3D openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXO2010Draw.HiddenScene3D openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDraws.HiddenScene3D? CreateModelElement(DXO2010Draw.HiddenScene3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.HiddenScene3D();
      value.Camera = GetCamera(openXmlElement);
      value.LightRig = GetLightRig(openXmlElement);
      value.Backdrop = GetBackdrop(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.HiddenScene3D? value)
    where OpenXmlElementType: DXO2010Draw.HiddenScene3D, new()
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

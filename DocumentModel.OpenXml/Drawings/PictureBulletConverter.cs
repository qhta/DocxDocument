namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Picture Bullet.
/// </summary>
public static class PictureBulletConverter
{
  /// <summary>
  /// Blip.
  /// </summary>
  private static DMD.Blip? GetBlip(DXD.PictureBullet openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Blip>();
    if (element != null)
      return DMXD.BlipConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlip(DXD.PictureBullet openXmlElement, DMD.Blip? value, DiffList? diffs, string? objName)
  {
    return DMXD.BlipConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Blip>(), value, diffs, objName);
  }
  
  private static void SetBlip(DXD.PictureBullet openXmlElement, DMD.Blip? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Blip>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BlipConverter.CreateOpenXmlElement<DXD.Blip>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.PictureBullet? CreateModelElement(DXD.PictureBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PictureBullet();
      value.Blip = GetBlip(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.PictureBullet? openXmlElement, DMD.PictureBullet? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBlip(openXmlElement, value.Blip, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.PictureBullet value)
    where OpenXmlElementType: DXD.PictureBullet, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.PictureBullet openXmlElement, DMD.PictureBullet value)
  {
    SetBlip(openXmlElement, value?.Blip);
  }
}

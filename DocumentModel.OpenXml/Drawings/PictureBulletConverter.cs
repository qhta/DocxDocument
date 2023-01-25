namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Picture Bullet.
/// </summary>
public static class PictureBulletConverter
{
  /// <summary>
  /// Blip.
  /// </summary>
  private static DMDraws.Blip? GetBlip(DXDraw.PictureBullet openXmlElement)
  {
    return DMXDraws.BlipConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Blip>());
  }
  
  private static bool CmpBlip(DXDraw.PictureBullet openXmlElement, DMDraws.Blip? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BlipConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Blip>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBlip(DXDraw.PictureBullet openXmlElement, DMDraws.Blip? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Blip>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BlipConverter.CreateOpenXmlElement<DXDraw.Blip>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.PictureBullet? CreateModelElement(DXDraw.PictureBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.PictureBullet();
      value.Blip = GetBlip(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.PictureBullet? openXmlElement, DMDraws.PictureBullet? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PictureBullet? value)
    where OpenXmlElementType: DXDraw.PictureBullet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlip(openXmlElement, value?.Blip);
      return openXmlElement;
    }
    return default;
  }
}

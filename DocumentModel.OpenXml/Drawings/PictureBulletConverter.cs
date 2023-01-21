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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Blip>();
    if (itemElement != null)
      return DMXDraws.BlipConverter.CreateModelElement(itemElement);
    return null;
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

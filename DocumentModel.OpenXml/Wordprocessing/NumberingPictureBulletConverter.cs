namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Picture Numbering Symbol Definition.
/// </summary>
public static class NumberingPictureBulletConverter
{
  /// <summary>
  /// numPicBulletId
  /// </summary>
  private static Int32? GetNumberingPictureBulletId(DXW.NumberingPictureBullet openXmlElement)
  {
    return openXmlElement.NumberingPictureBulletId?.Value;
  }
  
  private static void SetNumberingPictureBulletId(DXW.NumberingPictureBullet openXmlElement, Int32? value)
  {
    openXmlElement.NumberingPictureBulletId = value;
  }
  
  /// <summary>
  /// PictureBulletBase.
  /// </summary>
  private static DMW.PictureBulletBase? GetPictureBulletBase(DXW.NumberingPictureBullet openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PictureBulletBase>();
    if (itemElement != null)
      return DMXW.PictureBulletBaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPictureBulletBase(DXW.NumberingPictureBullet openXmlElement, DMW.PictureBulletBase? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PictureBulletBase>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PictureBulletBaseConverter.CreateOpenXmlElement<DXW.PictureBulletBase>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Drawing.
  /// </summary>
  private static DMW.Drawing? GetDrawing(DXW.NumberingPictureBullet openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Drawing>();
    if (itemElement != null)
      return DMXW.DrawingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDrawing(DXW.NumberingPictureBullet openXmlElement, DMW.Drawing? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Drawing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DrawingConverter.CreateOpenXmlElement<DXW.Drawing>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.NumberingPictureBullet? CreateModelElement(DXW.NumberingPictureBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.NumberingPictureBullet();
      value.NumberingPictureBulletId = GetNumberingPictureBulletId(openXmlElement);
      value.PictureBulletBase = GetPictureBulletBase(openXmlElement);
      value.Drawing = GetDrawing(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.NumberingPictureBullet? value)
    where OpenXmlElementType: DXW.NumberingPictureBullet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberingPictureBulletId(openXmlElement, value?.NumberingPictureBulletId);
      SetPictureBulletBase(openXmlElement, value?.PictureBulletBase);
      SetDrawing(openXmlElement, value?.Drawing);
      return openXmlElement;
    }
    return default;
  }
}

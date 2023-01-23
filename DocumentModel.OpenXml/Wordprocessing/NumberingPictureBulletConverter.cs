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
  
  private static bool CmpNumberingPictureBulletId(DXW.NumberingPictureBullet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.NumberingPictureBulletId?.Value == value;
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
    return DMXW.PictureBulletBaseConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PictureBulletBase>());
  }
  
  private static bool CmpPictureBulletBase(DXW.NumberingPictureBullet openXmlElement, DMW.PictureBulletBase? value, DiffList? diffs, string? objName)
  {
    return DMXW.PictureBulletBaseConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.PictureBulletBase>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.DrawingConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Drawing>());
  }
  
  private static bool CmpDrawing(DXW.NumberingPictureBullet openXmlElement, DMW.Drawing? value, DiffList? diffs, string? objName)
  {
    return DMXW.DrawingConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.Drawing>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXW.NumberingPictureBullet? openXmlElement, DMW.NumberingPictureBullet? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNumberingPictureBulletId(openXmlElement, value.NumberingPictureBulletId, diffs, objName))
        ok = false;
      if (!CmpPictureBulletBase(openXmlElement, value.PictureBulletBase, diffs, objName))
        ok = false;
      if (!CmpDrawing(openXmlElement, value.Drawing, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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

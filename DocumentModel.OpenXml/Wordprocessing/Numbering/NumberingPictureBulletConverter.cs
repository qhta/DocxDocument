namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.NumberingPictureBullet"/> class from/to OpenXml converter.
/// </summary>
public static class NumberingPictureBulletConverter
{
  #region NumberingPictureBullerId conversion.
  private static Int32? GetNumberingPictureBulletId(DXW.NumberingPictureBullet openXmlElement)
  {
    return openXmlElement?.NumberingPictureBulletId?.Value;
  }
  
  private static bool CmpNumberingPictureBulletId(DXW.NumberingPictureBullet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NumberingPictureBulletId?.Value == value) return true;
    diffs?.Add(objName, "NumberingPictureBulletId", openXmlElement?.NumberingPictureBulletId?.Value, value);
    return false;
  }
  
  private static void SetNumberingPictureBulletId(DXW.NumberingPictureBullet openXmlElement, Int32? value)
  {
    openXmlElement.NumberingPictureBulletId = value;
  }
  #endregion

  #region PictureBulletBase conversion.
  private static DMW.PictureBulletBase? GetPictureBulletBase(DXW.NumberingPictureBullet openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PictureBulletBase>();
    if (element != null)
      return DMXW.PictureBulletBaseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureBulletBase(DXW.NumberingPictureBullet openXmlElement, DMW.PictureBulletBase? value, DiffList? diffs, string? objName)
  {
    return DMXW.PictureBulletBaseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PictureBulletBase>(), value, diffs, objName);
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
  #endregion

  #region Drawing.
  private static DMW.Drawing? GetDrawing(DXW.NumberingPictureBullet openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Drawing>();
    if (element != null)
      return DMXW.DrawingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDrawing(DXW.NumberingPictureBullet openXmlElement, DMW.Drawing? value, DiffList? diffs, string? objName)
  {
    return DMXW.DrawingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Drawing>(), value, diffs, objName);
  }
  
  private static void SetDrawing(DXW.NumberingPictureBullet openXmlElement, DMW.Drawing? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Drawing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DrawingConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region NumberingPictureBullet model conversion.
  public static DMW.NumberingPictureBullet? CreateModelElement(DXW.NumberingPictureBullet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.NumberingPictureBullet();
      model.NumberingPictureBulletId = GetNumberingPictureBulletId(openXmlElement);
      model.PictureBulletBase = GetPictureBulletBase(openXmlElement);
      model.Drawing = GetDrawing(openXmlElement);
      return model;
    }
    return null;
  }
  public static bool CompareModelElement(DXW.NumberingPictureBullet? openXmlElement, DMW.NumberingPictureBullet? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpNumberingPictureBulletId(openXmlElement, model.NumberingPictureBulletId, diffs, objName))
        ok = false;
      if (!CmpPictureBulletBase(openXmlElement, model.PictureBulletBase, diffs, objName))
        ok = false;
      if (!CmpDrawing(openXmlElement, model.Drawing, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NumberingPictureBullet model)
    where OpenXmlElementType: DXW.NumberingPictureBullet, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.NumberingPictureBullet openXmlElement, DMW.NumberingPictureBullet model)
  {
    SetNumberingPictureBulletId(openXmlElement, model?.NumberingPictureBulletId);
    SetPictureBulletBase(openXmlElement, model?.PictureBulletBase);
    SetDrawing(openXmlElement, model?.Drawing);
  }
  #endregion
}

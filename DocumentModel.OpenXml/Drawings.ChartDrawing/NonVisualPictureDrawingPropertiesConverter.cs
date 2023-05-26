namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Picture Drawing Properties.
/// </summary>
public static class NonVisualPictureDrawingPropertiesConverter
{
  /// <summary>
  /// preferRelativeResize
  /// </summary>
  private static Boolean? GetPreferRelativeResize(DXDCD.NonVisualPictureDrawingProperties openXmlElement)
  {
    return openXmlElement?.PreferRelativeResize?.Value;
  }
  
  private static bool CmpPreferRelativeResize(DXDCD.NonVisualPictureDrawingProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.PreferRelativeResize?.Value == value) return true;
    diffs?.Add(objName, "PreferRelativeResize", openXmlElement?.PreferRelativeResize?.Value, value);
    return false;
  }
  
  private static void SetPreferRelativeResize(DXDCD.NonVisualPictureDrawingProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.PreferRelativeResize = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.PreferRelativeResize = null;
  }
  
  /// <summary>
  /// PictureLocks.
  /// </summary>
  private static DMD.PictureLocks? GetPictureLocks(DXDCD.NonVisualPictureDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PictureLocks>();
    if (element != null)
      return DMXD.PictureLocksConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureLocks(DXDCD.NonVisualPictureDrawingProperties openXmlElement, DMD.PictureLocks? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.PictureLocksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PictureLocks>(), value, diffs, objName, propName);
  }
  
  private static void SetPictureLocks(DXDCD.NonVisualPictureDrawingProperties openXmlElement, DMD.PictureLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PictureLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PictureLocksConverter.CreateOpenXmlElement<DXD.PictureLocks>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// NonVisualPicturePropertiesExtensionList.
  /// </summary>
  private static DMD.NonVisualPicturePropertiesExtensionList? GetNonVisualPicturePropertiesExtensionList(DXDCD.NonVisualPictureDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.NonVisualPicturePropertiesExtensionList>();
    if (element != null)
      return DMXD.NonVisualPicturePropertiesExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualPicturePropertiesExtensionList(DXDCD.NonVisualPictureDrawingProperties openXmlElement, DMD.NonVisualPicturePropertiesExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.NonVisualPicturePropertiesExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.NonVisualPicturePropertiesExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetNonVisualPicturePropertiesExtensionList(DXDCD.NonVisualPictureDrawingProperties openXmlElement, DMD.NonVisualPicturePropertiesExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.NonVisualPicturePropertiesExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.NonVisualPicturePropertiesExtensionListConverter.CreateOpenXmlElement<DXD.NonVisualPicturePropertiesExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualPictureDrawingProperties? CreateModelElement(DXDCD.NonVisualPictureDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualPictureDrawingProperties();
      value.PreferRelativeResize = GetPreferRelativeResize(openXmlElement);
      value.PictureLocks = GetPictureLocks(openXmlElement);
      value.NonVisualPicturePropertiesExtensionList = GetNonVisualPicturePropertiesExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDCD.NonVisualPictureDrawingProperties? openXmlElement, DMDCD.NonVisualPictureDrawingProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPreferRelativeResize(openXmlElement, value.PreferRelativeResize, diffs, objName, propName))
        ok = false;
      if (!CmpPictureLocks(openXmlElement, value.PictureLocks, diffs, objName, propName))
        ok = false;
      if (!CmpNonVisualPicturePropertiesExtensionList(openXmlElement, value.NonVisualPicturePropertiesExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.NonVisualPictureDrawingProperties value)
    where OpenXmlElementType: DXDCD.NonVisualPictureDrawingProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.NonVisualPictureDrawingProperties openXmlElement, DMDCD.NonVisualPictureDrawingProperties value)
  {
    SetPreferRelativeResize(openXmlElement, value?.PreferRelativeResize);
    SetPictureLocks(openXmlElement, value?.PictureLocks);
    SetNonVisualPicturePropertiesExtensionList(openXmlElement, value?.NonVisualPicturePropertiesExtensionList);
  }
}

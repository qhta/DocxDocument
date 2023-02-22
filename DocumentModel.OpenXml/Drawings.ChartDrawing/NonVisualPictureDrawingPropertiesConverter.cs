namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Picture Drawing Properties.
/// </summary>
public static class NonVisualPictureDrawingPropertiesConverter
{
  /// <summary>
  /// preferRelativeResize
  /// </summary>
  private static Boolean? GetPreferRelativeResize(DXDrawChartDraw.NonVisualPictureDrawingProperties openXmlElement)
  {
    return openXmlElement?.PreferRelativeResize?.Value;
  }
  
  private static bool CmpPreferRelativeResize(DXDrawChartDraw.NonVisualPictureDrawingProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PreferRelativeResize?.Value == value) return true;
    diffs?.Add(objName, "PreferRelativeResize", openXmlElement?.PreferRelativeResize?.Value, value);
    return false;
  }
  
  private static void SetPreferRelativeResize(DXDrawChartDraw.NonVisualPictureDrawingProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.PreferRelativeResize = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.PreferRelativeResize = null;
  }
  
  /// <summary>
  /// PictureLocks.
  /// </summary>
  private static DMDraws.PictureLocks? GetPictureLocks(DXDrawChartDraw.NonVisualPictureDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.PictureLocks>();
    if (element != null)
      return DMXDraws.PictureLocksConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureLocks(DXDrawChartDraw.NonVisualPictureDrawingProperties openXmlElement, DMDraws.PictureLocks? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PictureLocksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PictureLocks>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPictureLocks(DXDrawChartDraw.NonVisualPictureDrawingProperties openXmlElement, DMDraws.PictureLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PictureLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PictureLocksConverter.CreateOpenXmlElement<DXDraw.PictureLocks>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NonVisualPicturePropertiesExtensionList.
  /// </summary>
  private static DMDraws.NonVisualPicturePropertiesExtensionList? GetNonVisualPicturePropertiesExtensionList(DXDrawChartDraw.NonVisualPictureDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.NonVisualPicturePropertiesExtensionList>();
    if (element != null)
      return DMXDraws.NonVisualPicturePropertiesExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualPicturePropertiesExtensionList(DXDrawChartDraw.NonVisualPictureDrawingProperties openXmlElement, DMDraws.NonVisualPicturePropertiesExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.NonVisualPicturePropertiesExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.NonVisualPicturePropertiesExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualPicturePropertiesExtensionList(DXDrawChartDraw.NonVisualPictureDrawingProperties openXmlElement, DMDraws.NonVisualPicturePropertiesExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.NonVisualPicturePropertiesExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.NonVisualPicturePropertiesExtensionListConverter.CreateOpenXmlElement<DXDraw.NonVisualPicturePropertiesExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualPictureDrawingProperties? CreateModelElement(DXDrawChartDraw.NonVisualPictureDrawingProperties? openXmlElement)
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
  
  public static bool CompareModelElement(DXDrawChartDraw.NonVisualPictureDrawingProperties? openXmlElement, DMDrawsChartDraw.NonVisualPictureDrawingProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPreferRelativeResize(openXmlElement, value.PreferRelativeResize, diffs, objName))
        ok = false;
      if (!CmpPictureLocks(openXmlElement, value.PictureLocks, diffs, objName))
        ok = false;
      if (!CmpNonVisualPicturePropertiesExtensionList(openXmlElement, value.NonVisualPicturePropertiesExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.NonVisualPictureDrawingProperties value)
    where OpenXmlElementType: DXDrawChartDraw.NonVisualPictureDrawingProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawChartDraw.NonVisualPictureDrawingProperties openXmlElement, DMDrawsChartDraw.NonVisualPictureDrawingProperties value)
  {
    SetPreferRelativeResize(openXmlElement, value?.PreferRelativeResize);
    SetPictureLocks(openXmlElement, value?.PictureLocks);
    SetNonVisualPicturePropertiesExtensionList(openXmlElement, value?.NonVisualPicturePropertiesExtensionList);
    }
  }

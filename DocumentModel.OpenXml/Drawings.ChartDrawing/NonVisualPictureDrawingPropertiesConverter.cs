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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.PictureLocks>();
    if (itemElement != null)
      return DMXDraws.PictureLocksConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.NonVisualPicturePropertiesExtensionList>();
    if (itemElement != null)
      return DMXDraws.NonVisualPicturePropertiesExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsChartDraw.NonVisualPictureDrawingProperties? CreateModelElement(DXDrawChartDraw.NonVisualPictureDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.NonVisualPictureDrawingProperties();
      value.PreferRelativeResize = GetPreferRelativeResize(openXmlElement);
      value.PictureLocks = GetPictureLocks(openXmlElement);
      value.NonVisualPicturePropertiesExtensionList = GetNonVisualPicturePropertiesExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.NonVisualPictureDrawingProperties? value)
    where OpenXmlElementType: DXDrawChartDraw.NonVisualPictureDrawingProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPreferRelativeResize(openXmlElement, value?.PreferRelativeResize);
      SetPictureLocks(openXmlElement, value?.PictureLocks);
      SetNonVisualPicturePropertiesExtensionList(openXmlElement, value?.NonVisualPicturePropertiesExtensionList);
      return openXmlElement;
    }
    return default;
  }
}

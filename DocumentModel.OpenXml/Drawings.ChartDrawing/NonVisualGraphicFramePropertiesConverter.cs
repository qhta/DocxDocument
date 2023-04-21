namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Graphic Frame Properties.
/// </summary>
public static class NonVisualGraphicFramePropertiesConverter
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  private static DMDCD.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXDCD.NonVisualGraphicFrameProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.NonVisualDrawingProperties>();
    if (element != null)
      return DMXDCD.NonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingProperties(DXDCD.NonVisualGraphicFrameProperties openXmlElement, DMDCD.NonVisualDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.NonVisualDrawingProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualDrawingProperties(DXDCD.NonVisualGraphicFrameProperties openXmlElement, DMDCD.NonVisualDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.NonVisualDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  private static DMDCD.NonVisualGraphicFrameDrawingProperties? GetNonVisualGraphicFrameDrawingProperties(DXDCD.NonVisualGraphicFrameProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.NonVisualGraphicFrameDrawingProperties>();
    if (element != null)
      return DMXDCD.NonVisualGraphicFrameDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualGraphicFrameDrawingProperties(DXDCD.NonVisualGraphicFrameProperties openXmlElement, DMDCD.NonVisualGraphicFrameDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.NonVisualGraphicFrameDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.NonVisualGraphicFrameDrawingProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualGraphicFrameDrawingProperties(DXDCD.NonVisualGraphicFrameProperties openXmlElement, DMDCD.NonVisualGraphicFrameDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.NonVisualGraphicFrameDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.NonVisualGraphicFrameDrawingPropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualGraphicFrameDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameProperties? CreateModelElement(DXDCD.NonVisualGraphicFrameProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualGraphicFrameDrawingProperties = GetNonVisualGraphicFrameDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDCD.NonVisualGraphicFrameProperties? openXmlElement, DMDCD.NonVisualGraphicFrameProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualDrawingProperties(openXmlElement, value.NonVisualDrawingProperties, diffs, objName))
        ok = false;
      if (!CmpNonVisualGraphicFrameDrawingProperties(openXmlElement, value.NonVisualGraphicFrameDrawingProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.NonVisualGraphicFrameProperties value)
    where OpenXmlElementType: DXDCD.NonVisualGraphicFrameProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.NonVisualGraphicFrameProperties openXmlElement, DMDCD.NonVisualGraphicFrameProperties value)
  {
    SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
    SetNonVisualGraphicFrameDrawingProperties(openXmlElement, value?.NonVisualGraphicFrameDrawingProperties);
  }
}

namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Group Shape Properties.
/// </summary>
public static class NonVisualGroupShapePropertiesConverter
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  private static DMDCD.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXDCD.NonVisualGroupShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.NonVisualDrawingProperties>();
    if (element != null)
      return DMXDCD.NonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingProperties(DXDCD.NonVisualGroupShapeProperties openXmlElement, DMDCD.NonVisualDrawingProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.NonVisualDrawingProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetNonVisualDrawingProperties(DXDCD.NonVisualGroupShapeProperties openXmlElement, DMDCD.NonVisualDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.NonVisualDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Non-Visual Group Shape Drawing Properties.
  /// </summary>
  private static DMDCD.NonVisualGroupShapeDrawingProperties? GetNonVisualGroupShapeDrawingProperties(DXDCD.NonVisualGroupShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.NonVisualGroupShapeDrawingProperties>();
    if (element != null)
      return DMXDCD.NonVisualGroupShapeDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualGroupShapeDrawingProperties(DXDCD.NonVisualGroupShapeProperties openXmlElement, DMDCD.NonVisualGroupShapeDrawingProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.NonVisualGroupShapeDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.NonVisualGroupShapeDrawingProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetNonVisualGroupShapeDrawingProperties(DXDCD.NonVisualGroupShapeProperties openXmlElement, DMDCD.NonVisualGroupShapeDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.NonVisualGroupShapeDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.NonVisualGroupShapeDrawingPropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualGroupShapeDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.ChartDrawing.NonVisualGroupShapeProperties? CreateModelElement(DXDCD.NonVisualGroupShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ChartDrawing.NonVisualGroupShapeProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualGroupShapeDrawingProperties = GetNonVisualGroupShapeDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDCD.NonVisualGroupShapeProperties? openXmlElement, DMDCD.NonVisualGroupShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualDrawingProperties(openXmlElement, value.NonVisualDrawingProperties, diffs, objName, propName))
        ok = false;
      if (!CmpNonVisualGroupShapeDrawingProperties(openXmlElement, value.NonVisualGroupShapeDrawingProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.NonVisualGroupShapeProperties value)
    where OpenXmlElementType: DXDCD.NonVisualGroupShapeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.NonVisualGroupShapeProperties openXmlElement, DMDCD.NonVisualGroupShapeProperties value)
  {
    SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
    SetNonVisualGroupShapeDrawingProperties(openXmlElement, value?.NonVisualGroupShapeDrawingProperties);
  }
}

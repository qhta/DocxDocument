namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Shape Properties.
/// </summary>
public static class NonVisualShapePropertiesConverter
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  private static DMDCD.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXDCD.NonVisualShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.NonVisualDrawingProperties>();
    if (element != null)
      return DMXDCD.NonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingProperties(DXDCD.NonVisualShapeProperties openXmlElement, DMDCD.NonVisualDrawingProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.NonVisualDrawingProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetNonVisualDrawingProperties(DXDCD.NonVisualShapeProperties openXmlElement, DMDCD.NonVisualDrawingProperties? value)
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
  /// Non-Visual Shape Drawing Properties.
  /// </summary>
  private static DMDCD.NonVisualShapeDrawingProperties? GetNonVisualShapeDrawingProperties(DXDCD.NonVisualShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.NonVisualShapeDrawingProperties>();
    if (element != null)
      return DMXDCD.NonVisualShapeDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualShapeDrawingProperties(DXDCD.NonVisualShapeProperties openXmlElement, DMDCD.NonVisualShapeDrawingProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.NonVisualShapeDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.NonVisualShapeDrawingProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetNonVisualShapeDrawingProperties(DXDCD.NonVisualShapeProperties openXmlElement, DMDCD.NonVisualShapeDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.NonVisualShapeDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.NonVisualShapeDrawingPropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualShapeDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.ChartDrawing.NonVisualShapeProperties? CreateModelElement(DXDCD.NonVisualShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ChartDrawing.NonVisualShapeProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualShapeDrawingProperties = GetNonVisualShapeDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDCD.NonVisualShapeProperties? openXmlElement, DMDCD.NonVisualShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualDrawingProperties(openXmlElement, value.NonVisualDrawingProperties, diffs, objName, propName))
        ok = false;
      if (!CmpNonVisualShapeDrawingProperties(openXmlElement, value.NonVisualShapeDrawingProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.NonVisualShapeProperties value)
    where OpenXmlElementType: DXDCD.NonVisualShapeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.NonVisualShapeProperties openXmlElement, DMDCD.NonVisualShapeProperties value)
  {
    SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
    SetNonVisualShapeDrawingProperties(openXmlElement, value?.NonVisualShapeDrawingProperties);
  }
}

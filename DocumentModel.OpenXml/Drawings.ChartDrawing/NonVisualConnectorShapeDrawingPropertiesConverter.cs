namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Connector Non Visual Properties.
/// </summary>
public static class NonVisualConnectorShapeDrawingPropertiesConverter
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  private static DMDCD.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXDCD.NonVisualConnectorShapeDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.NonVisualDrawingProperties>();
    if (element != null)
      return DMXDCD.NonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingProperties(DXDCD.NonVisualConnectorShapeDrawingProperties openXmlElement, DMDCD.NonVisualDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.NonVisualDrawingProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualDrawingProperties(DXDCD.NonVisualConnectorShapeDrawingProperties openXmlElement, DMDCD.NonVisualDrawingProperties? value)
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
  /// Non-Visual Connection Shape Drawing Properties.
  /// </summary>
  private static DMDCD.NonVisualConnectionShapeProperties? GetNonVisualConnectionShapeProperties(DXDCD.NonVisualConnectorShapeDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.NonVisualConnectionShapeProperties>();
    if (element != null)
      return DMXDCD.NonVisualConnectionShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualConnectionShapeProperties(DXDCD.NonVisualConnectorShapeDrawingProperties openXmlElement, DMDCD.NonVisualConnectionShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.NonVisualConnectionShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.NonVisualConnectionShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualConnectionShapeProperties(DXDCD.NonVisualConnectorShapeDrawingProperties openXmlElement, DMDCD.NonVisualConnectionShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.NonVisualConnectionShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.NonVisualConnectionShapePropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualConnectionShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingProperties? CreateModelElement(DXDCD.NonVisualConnectorShapeDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualConnectionShapeProperties = GetNonVisualConnectionShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDCD.NonVisualConnectorShapeDrawingProperties? openXmlElement, DMDCD.NonVisualConnectorShapeDrawingProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualDrawingProperties(openXmlElement, value.NonVisualDrawingProperties, diffs, objName))
        ok = false;
      if (!CmpNonVisualConnectionShapeProperties(openXmlElement, value.NonVisualConnectionShapeProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.NonVisualConnectorShapeDrawingProperties value)
    where OpenXmlElementType: DXDCD.NonVisualConnectorShapeDrawingProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.NonVisualConnectorShapeDrawingProperties openXmlElement, DMDCD.NonVisualConnectorShapeDrawingProperties value)
  {
    SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
    SetNonVisualConnectionShapeProperties(openXmlElement, value?.NonVisualConnectionShapeProperties);
  }
}

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
public static class NonVisualContentPartPropertiesConverter
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  private static DMDCDs.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXO10DCD.NonVisualContentPartProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10DCD.NonVisualDrawingProperties>();
    if (element != null)
      return DMXDCDs.NonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingProperties(DXO10DCD.NonVisualContentPartProperties openXmlElement, DMDCDs.NonVisualDrawingProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10DCD.NonVisualDrawingProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetNonVisualDrawingProperties(DXO10DCD.NonVisualContentPartProperties openXmlElement, DMDCDs.NonVisualDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10DCD.NonVisualDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXO10DCD.NonVisualDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  private static DMDCDs.NonVisualInkContentPartProperties? GetNonVisualInkContentPartProperties(DXO10DCD.NonVisualContentPartProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10DCD.NonVisualInkContentPartProperties>();
    if (element != null)
      return DMXDCDs.NonVisualInkContentPartPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualInkContentPartProperties(DXO10DCD.NonVisualContentPartProperties openXmlElement, DMDCDs.NonVisualInkContentPartProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.NonVisualInkContentPartPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10DCD.NonVisualInkContentPartProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetNonVisualInkContentPartProperties(DXO10DCD.NonVisualContentPartProperties openXmlElement, DMDCDs.NonVisualInkContentPartProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10DCD.NonVisualInkContentPartProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.NonVisualInkContentPartPropertiesConverter.CreateOpenXmlElement<DXO10DCD.NonVisualInkContentPartProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDCDs.NonVisualContentPartProperties? CreateModelElement(DXO10DCD.NonVisualContentPartProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.NonVisualContentPartProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualInkContentPartProperties = GetNonVisualInkContentPartProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10DCD.NonVisualContentPartProperties? openXmlElement, DMDCDs.NonVisualContentPartProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualDrawingProperties(openXmlElement, value.NonVisualDrawingProperties, diffs, objName, propName))
        ok = false;
      if (!CmpNonVisualInkContentPartProperties(openXmlElement, value.NonVisualInkContentPartProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.NonVisualContentPartProperties value)
    where OpenXmlElementType: DXO10DCD.NonVisualContentPartProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10DCD.NonVisualContentPartProperties openXmlElement, DMDCDs.NonVisualContentPartProperties value)
  {
    SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
    SetNonVisualInkContentPartProperties(openXmlElement, value?.NonVisualInkContentPartProperties);
  }
}

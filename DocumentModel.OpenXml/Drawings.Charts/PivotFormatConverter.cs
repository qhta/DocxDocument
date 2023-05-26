namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Pivot Format.
/// </summary>
public static class PivotFormatConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXDC.PivotFormat openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val);
  }
  
  private static bool CmpIndex(DXDC.PivotFormat openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val, value, diffs, objName, "Index");
  }
  
  private static void SetIndex(DXDC.PivotFormat openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Index,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDC.ShapeProperties? GetShapeProperties(DXDC.PivotFormat openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ShapeProperties>();
    if (element != null)
      return DMXDC.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDC.PivotFormat openXmlElement, DMDC.ShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXDC.PivotFormat openXmlElement, DMDC.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ShapePropertiesConverter.CreateOpenXmlElement<DXDC.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  private static DMDC.Marker? GetMarker(DXDC.PivotFormat openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Marker>();
    if (element != null)
      return DMXDC.MarkerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMarker(DXDC.PivotFormat openXmlElement, DMDC.Marker? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.MarkerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Marker>(), value, diffs, objName, propName);
  }
  
  private static void SetMarker(DXDC.PivotFormat openXmlElement, DMDC.Marker? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Marker>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.MarkerConverter.CreateOpenXmlElement<DXDC.Marker>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Data Label.
  /// </summary>
  private static DMDC.DataLabel? GetDataLabel(DXDC.PivotFormat openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabel>();
    if (element != null)
      return DMXDC.DataLabelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabel(DXDC.PivotFormat openXmlElement, DMDC.DataLabel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabel>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabel(DXDC.PivotFormat openXmlElement, DMDC.DataLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DataLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DataLabelConverter.CreateOpenXmlElement<DXDC.DataLabel>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDC.ExtensionList? GetExtensionList(DXDC.PivotFormat openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.PivotFormat openXmlElement, DMDC.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDC.PivotFormat openXmlElement, DMDC.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.PivotFormat? CreateModelElement(DXDC.PivotFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PivotFormat();
      value.Index = GetIndex(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Marker = GetMarker(openXmlElement);
      value.DataLabel = GetDataLabel(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.PivotFormat? openXmlElement, DMDC.PivotFormat? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName, propName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpMarker(openXmlElement, value.Marker, diffs, objName, propName))
        ok = false;
      if (!CmpDataLabel(openXmlElement, value.DataLabel, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.PivotFormat value)
    where OpenXmlElementType: DXDC.PivotFormat, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.PivotFormat openXmlElement, DMDC.PivotFormat value)
  {
    SetIndex(openXmlElement, value?.Index);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetMarker(openXmlElement, value?.Marker);
    SetDataLabel(openXmlElement, value?.DataLabel);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}

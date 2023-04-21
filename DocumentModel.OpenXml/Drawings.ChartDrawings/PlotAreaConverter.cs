namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PlotArea Class.
/// </summary>
public static class PlotAreaConverter
{
  /// <summary>
  /// PlotAreaRegion.
  /// </summary>
  private static DMDCDs.PlotAreaRegion? GetPlotAreaRegion(DXO16DCD.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.PlotAreaRegion>();
    if (element != null)
      return DMXDCDs.PlotAreaRegionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPlotAreaRegion(DXO16DCD.PlotArea openXmlElement, DMDCDs.PlotAreaRegion? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.PlotAreaRegionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.PlotAreaRegion>(), value, diffs, objName);
  }
  
  private static void SetPlotAreaRegion(DXO16DCD.PlotArea openXmlElement, DMDCDs.PlotAreaRegion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.PlotAreaRegion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.PlotAreaRegionConverter.CreateOpenXmlElement<DXO16DCD.PlotAreaRegion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDCDs.Axis>? GetAxis(DXO16DCD.PlotArea openXmlElement)
  {
    var collection = new Collection<DMDCDs.Axis>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.Axis>())
    {
      var newItem = DMXDCDs.AxisConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAxis(DXO16DCD.PlotArea openXmlElement, Collection<DMDCDs.Axis>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.Axis>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDCDs.AxisConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetAxis(DXO16DCD.PlotArea openXmlElement, Collection<DMDCDs.Axis>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.Axis>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.AxisConverter.CreateOpenXmlElement<DXO16DCD.Axis>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDCDs.ShapeProperties? GetShapeProperties(DXO16DCD.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ShapeProperties>();
    if (element != null)
      return DMXDCDs.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO16DCD.PlotArea openXmlElement, DMDCDs.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetShapeProperties(DXO16DCD.PlotArea openXmlElement, DMDCDs.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ShapePropertiesConverter.CreateOpenXmlElement<DXO16DCD.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.PlotArea openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO16DCD.PlotArea openXmlElement, DMDCDs.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.PlotArea? CreateModelElement(DXO16DCD.PlotArea? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.PlotArea();
      value.PlotAreaRegion = GetPlotAreaRegion(openXmlElement);
      value.Axis = GetAxis(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.PlotArea? openXmlElement, DMDCDs.PlotArea? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPlotAreaRegion(openXmlElement, value.PlotAreaRegion, diffs, objName))
        ok = false;
      if (!CmpAxis(openXmlElement, value.Axis, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.PlotArea value)
    where OpenXmlElementType: DXO16DCD.PlotArea, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.PlotArea openXmlElement, DMDCDs.PlotArea value)
  {
    SetPlotAreaRegion(openXmlElement, value?.PlotAreaRegion);
    SetAxis(openXmlElement, value?.Axis);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}

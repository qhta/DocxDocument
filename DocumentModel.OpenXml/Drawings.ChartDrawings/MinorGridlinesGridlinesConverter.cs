namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the MinorGridlinesGridlines Class.
/// </summary>
public static class MinorGridlinesGridlinesConverter
{
  private static DMDCDs.ShapeProperties? GetShapeProperties(DXO16DCD.MinorGridlinesGridlines openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ShapeProperties>();
    if (element != null)
      return DMXDCDs.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO16DCD.MinorGridlinesGridlines openXmlElement, DMDCDs.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetShapeProperties(DXO16DCD.MinorGridlinesGridlines openXmlElement, DMDCDs.ShapeProperties? value)
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
  
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.MinorGridlinesGridlines openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.MinorGridlinesGridlines openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO16DCD.MinorGridlinesGridlines openXmlElement, DMDCDs.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.MinorGridlinesGridlines? CreateModelElement(DXO16DCD.MinorGridlinesGridlines? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.MinorGridlinesGridlines();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.MinorGridlinesGridlines? openXmlElement, DMDCDs.MinorGridlinesGridlines? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.MinorGridlinesGridlines value)
    where OpenXmlElementType: DXO16DCD.MinorGridlinesGridlines, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.MinorGridlinesGridlines openXmlElement, DMDCDs.MinorGridlinesGridlines value)
  {
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}

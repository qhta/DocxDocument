namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the MajorGridlinesGridlines Class.
/// </summary>
public static class MajorGridlinesGridlinesConverter
{
  private static DMDCDs.ShapeProperties? GetShapeProperties(DXO16DCD.MajorGridlinesGridlines openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ShapeProperties>();
    if (element != null)
      return DMXDCDs.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO16DCD.MajorGridlinesGridlines openXmlElement, DMDCDs.ShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXO16DCD.MajorGridlinesGridlines openXmlElement, DMDCDs.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ShapePropertiesConverter.CreateOpenXmlElement<DXO16DCD.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.MajorGridlinesGridlines openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.MajorGridlinesGridlines openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXO16DCD.MajorGridlinesGridlines openXmlElement, DMDCDs.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.MajorGridlinesGridlines? CreateModelElement(DXO16DCD.MajorGridlinesGridlines? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.MajorGridlinesGridlines();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.MajorGridlinesGridlines? openXmlElement, DMDCDs.MajorGridlinesGridlines? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.MajorGridlinesGridlines value)
    where OpenXmlElementType: DXO16DCD.MajorGridlinesGridlines, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.MajorGridlinesGridlines openXmlElement, DMDCDs.MajorGridlinesGridlines value)
  {
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}

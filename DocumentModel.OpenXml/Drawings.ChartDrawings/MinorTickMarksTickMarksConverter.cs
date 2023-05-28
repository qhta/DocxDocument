namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the MinorTickMarksTickMarks Class.
/// </summary>
public static class MinorTickMarksTickMarksConverter
{
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.MinorTickMarksTickMarks openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.MinorTickMarksTickMarks openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXO16DCD.MinorTickMarksTickMarks openXmlElement, DMDCDs.ExtensionList? value)
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
  
  public static DMDCDs.MinorTickMarksTickMarks? CreateModelElement(DXO16DCD.MinorTickMarksTickMarks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.MinorTickMarksTickMarks();
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.MinorTickMarksTickMarks? openXmlElement, DMDCDs.MinorTickMarksTickMarks? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.MinorTickMarksTickMarks value)
    where OpenXmlElementType: DXO16DCD.MinorTickMarksTickMarks, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.MinorTickMarksTickMarks openXmlElement, DMDCDs.MinorTickMarksTickMarks value)
  {
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}

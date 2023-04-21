namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the MajorTickMarksTickMarks Class.
/// </summary>
public static class MajorTickMarksTickMarksConverter
{
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.MajorTickMarksTickMarks openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.MajorTickMarksTickMarks openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO16DCD.MajorTickMarksTickMarks openXmlElement, DMDCDs.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.MajorTickMarksTickMarks? CreateModelElement(DXO16DCD.MajorTickMarksTickMarks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.MajorTickMarksTickMarks();
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.MajorTickMarksTickMarks? openXmlElement, DMDCDs.MajorTickMarksTickMarks? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.MajorTickMarksTickMarks value)
    where OpenXmlElementType: DXO16DCD.MajorTickMarksTickMarks, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.MajorTickMarksTickMarks openXmlElement, DMDCDs.MajorTickMarksTickMarks value)
  {
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}

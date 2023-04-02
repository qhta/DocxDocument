namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Shape Adjust.
/// </summary>
public static class AdjustConverter
{
  /// <summary>
  /// Adjust Handle Index
  /// </summary>
  private static UInt32? GetIndex(DXDrawDgms.Adjust openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }
  
  private static bool CmpIndex(DXDrawDgms.Adjust openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Index?.Value == value) return true;
    diffs?.Add(objName, "Index", openXmlElement?.Index?.Value, value);
    return false;
  }
  
  private static void SetIndex(DXDrawDgms.Adjust openXmlElement, UInt32? value)
  {
    openXmlElement.Index = value;
  }
  
  /// <summary>
  /// Value
  /// </summary>
  private static Double? GetVal(DXDrawDgms.Adjust openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXDrawDgms.Adjust openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetVal(DXDrawDgms.Adjust openXmlElement, Double? value)
  {
    openXmlElement.Val = value;
  }
  
  public static DocumentModel.Drawings.Diagrams.Adjust? CreateModelElement(DXDrawDgms.Adjust? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Adjust();
      value.Index = GetIndex(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.Adjust? openXmlElement, DMDrawsDgms.Adjust? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Adjust value)
    where OpenXmlElementType: DXDrawDgms.Adjust, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.Adjust openXmlElement, DMDrawsDgms.Adjust value)
  {
    SetIndex(openXmlElement, value?.Index);
    SetVal(openXmlElement, value?.Val);
  }
}

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
    return openXmlElement.Index?.Value;
  }
  
  private static bool CmpIndex(DXDrawDgms.Adjust openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Index?.Value == value;
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
    return openXmlElement.Val?.Value;
  }
  
  private static bool CmpVal(DXDrawDgms.Adjust openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Val?.Value == value;
  }
  
  private static void SetVal(DXDrawDgms.Adjust openXmlElement, Double? value)
  {
    openXmlElement.Val = value;
  }
  
  public static DMDrawsDgms.Adjust? CreateModelElement(DXDrawDgms.Adjust? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.Adjust();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Adjust? value)
    where OpenXmlElementType: DXDrawDgms.Adjust, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}

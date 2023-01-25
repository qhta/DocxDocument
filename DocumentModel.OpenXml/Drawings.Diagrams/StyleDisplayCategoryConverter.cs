namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Category.
/// </summary>
public static class StyleDisplayCategoryConverter
{
  /// <summary>
  /// Category Type
  /// </summary>
  private static String? GetType(DXDrawDgms.StyleDisplayCategory openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }
  
  private static bool CmpType(DXDrawDgms.StyleDisplayCategory openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Type?.Value == value;
  }
  
  private static void SetType(DXDrawDgms.StyleDisplayCategory openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Type = new StringValue { Value = value };
    else
      openXmlElement.Type = null;
  }
  
  /// <summary>
  /// Priority
  /// </summary>
  private static UInt32? GetPriority(DXDrawDgms.StyleDisplayCategory openXmlElement)
  {
    return openXmlElement?.Priority?.Value;
  }
  
  private static bool CmpPriority(DXDrawDgms.StyleDisplayCategory openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Priority?.Value == value) return true;
    diffs?.Add(objName, "Priority", openXmlElement?.Priority?.Value, value);
    return false;
  }
  
  private static void SetPriority(DXDrawDgms.StyleDisplayCategory openXmlElement, UInt32? value)
  {
    openXmlElement.Priority = value;
  }
  
  public static DMDrawsDgms.StyleDisplayCategory? CreateModelElement(DXDrawDgms.StyleDisplayCategory? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.StyleDisplayCategory();
      value.Type = GetType(openXmlElement);
      value.Priority = GetPriority(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.StyleDisplayCategory? openXmlElement, DMDrawsDgms.StyleDisplayCategory? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpPriority(openXmlElement, value.Priority, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.StyleDisplayCategory? value)
    where OpenXmlElementType: DXDrawDgms.StyleDisplayCategory, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetPriority(openXmlElement, value?.Priority);
      return openXmlElement;
    }
    return default;
  }
}

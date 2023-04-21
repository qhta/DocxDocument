namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Color Transform Category.
/// </summary>
public static class ColorTransformCategoryConverter
{
  /// <summary>
  /// Category Type
  /// </summary>
  private static String? GetType(DXDD.ColorTransformCategory openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Type);
  }
  
  private static bool CmpType(DXDD.ColorTransformCategory openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Type, value, diffs, objName, "Type");
  }
  
  private static void SetType(DXDD.ColorTransformCategory openXmlElement, String? value)
  {
    openXmlElement.Type = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Priority
  /// </summary>
  private static UInt32? GetPriority(DXDD.ColorTransformCategory openXmlElement)
  {
    return openXmlElement?.Priority?.Value;
  }
  
  private static bool CmpPriority(DXDD.ColorTransformCategory openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Priority?.Value == value) return true;
    diffs?.Add(objName, "Priority", openXmlElement?.Priority?.Value, value);
    return false;
  }
  
  private static void SetPriority(DXDD.ColorTransformCategory openXmlElement, UInt32? value)
  {
    openXmlElement.Priority = value;
  }
  
  public static DocumentModel.Drawings.Diagrams.ColorTransformCategory? CreateModelElement(DXDD.ColorTransformCategory? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorTransformCategory();
      value.Type = GetType(openXmlElement);
      value.Priority = GetPriority(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.ColorTransformCategory? openXmlElement, DMDD.ColorTransformCategory? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.ColorTransformCategory value)
    where OpenXmlElementType: DXDD.ColorTransformCategory, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.ColorTransformCategory openXmlElement, DMDD.ColorTransformCategory value)
  {
    SetType(openXmlElement, value?.Type);
    SetPriority(openXmlElement, value?.Priority);
  }
}

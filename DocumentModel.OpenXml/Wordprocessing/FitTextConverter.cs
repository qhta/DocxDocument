namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FitText Class.
/// </summary>
public static class FitTextConverter
{
  /// <summary>
  /// Value
  /// </summary>
  private static UInt32? GetVal(DXW.FitText openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXW.FitText openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetVal(DXW.FitText openXmlElement, UInt32? value)
  {
    openXmlElement.Val = value;
  }
  
  /// <summary>
  /// Fit Text Run ID
  /// </summary>
  private static Int32? GetId(DXW.FitText openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.FitText openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXW.FitText openXmlElement, Int32? value)
  {
    openXmlElement.Id = value;
  }
  
  public static DMW.FitText? CreateModelElement(DXW.FitText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FitText();
      value.Value = GetVal(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FitText? openXmlElement, DMW.FitText? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Value, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.FitText value)
    where OpenXmlElementType: DXW.FitText, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.FitText openXmlElement, DMW.FitText value)
  {
    SetVal(openXmlElement, value?.Value);
    SetId(openXmlElement, value?.Id);
  }
}

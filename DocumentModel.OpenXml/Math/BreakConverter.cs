namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Break.
/// </summary>
public static class BreakConverter
{
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  private static Int64? GetAlignAt(DXMath.Break openXmlElement)
  {
    return openXmlElement.AlignAt?.Value;
  }
  
  private static bool CmpAlignAt(DXMath.Break openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.AlignAt?.Value == value;
  }
  
  private static void SetAlignAt(DXMath.Break openXmlElement, Int64? value)
  {
    openXmlElement.AlignAt = value;
  }
  
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  private static Int64? GetVal(DXMath.Break openXmlElement)
  {
    return openXmlElement.Val?.Value;
  }
  
  private static bool CmpVal(DXMath.Break openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Val?.Value == value;
  }
  
  private static void SetVal(DXMath.Break openXmlElement, Int64? value)
  {
    openXmlElement.Val = value;
  }
  
  public static DMMath.Break? CreateModelElement(DXMath.Break? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Break();
      value.AlignAt = GetAlignAt(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.Break? openXmlElement, DMMath.Break? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAlignAt(openXmlElement, value.AlignAt, diffs, objName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.Break? value)
    where OpenXmlElementType: DXMath.Break, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAlignAt(openXmlElement, value?.AlignAt);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}

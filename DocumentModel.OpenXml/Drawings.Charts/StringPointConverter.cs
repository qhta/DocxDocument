namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// String Point.
/// </summary>
public static class StringPointConverter
{
  /// <summary>
  /// Index
  /// </summary>
  private static UInt32? GetIndex(DXDC.StringPoint openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }
  
  private static bool CmpIndex(DXDC.StringPoint openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Index?.Value == value) return true;
    diffs?.Add(objName, "Index", openXmlElement?.Index?.Value, value);
    return false;
  }
  
  private static void SetIndex(DXDC.StringPoint openXmlElement, UInt32? value)
  {
    openXmlElement.Index = value;
  }
  
  /// <summary>
  /// Text Value.
  /// </summary>
  private static String? GetNumericValue(DXDC.StringPoint openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.NumericValue>()?.Text;
  }
  
  private static bool CmpNumericValue(DXDC.StringPoint openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXDC.NumericValue>()?.Text == value;
  }
  
  private static void SetNumericValue(DXDC.StringPoint openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.NumericValue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDC.NumericValue { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.StringPoint? CreateModelElement(DXDC.StringPoint? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.StringPoint();
      value.Index = GetIndex(openXmlElement);
      value.NumericValue = GetNumericValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.StringPoint? openXmlElement, DMDC.StringPoint? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName, propName))
        ok = false;
      if (!CmpNumericValue(openXmlElement, value.NumericValue, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.StringPoint value)
    where OpenXmlElementType: DXDC.StringPoint, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.StringPoint openXmlElement, DMDC.StringPoint value)
  {
    SetIndex(openXmlElement, value?.Index);
    SetNumericValue(openXmlElement, value?.NumericValue);
  }
}

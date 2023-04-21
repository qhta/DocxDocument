namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the StyleReference Class.
/// </summary>
public static class StyleReferenceConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetIndex(DXO13DCS.StyleReference openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }
  
  private static bool CmpIndex(DXO13DCS.StyleReference openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Index?.Value == value) return true;
    diffs?.Add(objName, "Index", openXmlElement?.Index?.Value, value);
    return false;
  }
  
  private static void SetIndex(DXO13DCS.StyleReference openXmlElement, UInt32? value)
  {
    openXmlElement.Index = value;
  }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  private static DM.ListOf<String>? GetModifiers(DXO13DCS.StyleReference openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Modifiers);
  }
  
  private static bool CmpModifiers(DXO13DCS.StyleReference openXmlElement, DM.ListOf<String>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.CmpValue(openXmlElement?.Modifiers, value, diffs, objName);
  }
  
  private static void SetModifiers(DXO13DCS.StyleReference openXmlElement, DM.ListOf<String>? value)
  {
    if (value != null)
      openXmlElement.Modifiers = ListValueConverter.CreateListValue<DX.StringValue>(value);
    else
      openXmlElement.Modifiers = null;
  }
  
  public static DocumentModel.Drawings.ChartsStyle.StyleReference? CreateModelElement(DXO13DCS.StyleReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.StyleReference();
      value.Index = GetIndex(openXmlElement);
      value.Modifiers = GetModifiers(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DCS.StyleReference? openXmlElement, DMDCS.StyleReference? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName))
        ok = false;
      if (!CmpModifiers(openXmlElement, value.Modifiers, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCS.StyleReference value)
    where OpenXmlElementType: DXO13DCS.StyleReference, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DCS.StyleReference openXmlElement, DMDCS.StyleReference value)
  {
    SetIndex(openXmlElement, value?.Index);
    SetModifiers(openXmlElement, value?.Modifiers);
  }
}

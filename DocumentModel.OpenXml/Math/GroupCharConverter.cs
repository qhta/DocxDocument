namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Group-Character Function.
/// </summary>
public static class GroupCharConverter
{
  /// <summary>
  /// Group-Character Properties.
  /// </summary>
  private static DMMath.GroupCharProperties? GetGroupCharProperties(DXMath.GroupChar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.GroupCharProperties>();
    if (element != null)
      return DMXMath.GroupCharPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupCharProperties(DXMath.GroupChar openXmlElement, DMMath.GroupCharProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.GroupCharPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.GroupCharProperties>(), value, diffs, objName);
  }
  
  private static void SetGroupCharProperties(DXMath.GroupChar openXmlElement, DMMath.GroupCharProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.GroupCharProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.GroupCharPropertiesConverter.CreateOpenXmlElement<DXMath.GroupCharProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.GroupChar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (element != null)
      return DMXMath.BaseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBase(DXMath.GroupChar openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Base>(), value, diffs, objName);
  }
  
  private static void SetBase(DXMath.GroupChar openXmlElement, DMMath.Base? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BaseConverter.CreateOpenXmlElement<DXMath.Base>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.GroupChar? CreateModelElement(DXMath.GroupChar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.GroupChar();
      value.GroupCharProperties = GetGroupCharProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.GroupChar? openXmlElement, DMMath.GroupChar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGroupCharProperties(openXmlElement, value.GroupCharProperties, diffs, objName))
        ok = false;
      if (!CmpBase(openXmlElement, value.Base, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.GroupChar value)
    where OpenXmlElementType: DXMath.GroupChar, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.GroupChar openXmlElement, DMMath.GroupChar value)
  {
    SetGroupCharProperties(openXmlElement, value?.GroupCharProperties);
    SetBase(openXmlElement, value?.Base);
  }
}

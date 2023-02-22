namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Custom XML Attribute.
/// </summary>
public static class CustomXmlAttributeConverter
{
  /// <summary>
  /// uri
  /// </summary>
  private static String? GetUri(DXW.CustomXmlAttribute openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXW.CustomXmlAttribute openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXW.CustomXmlAttribute openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// name
  /// </summary>
  private static String? GetName(DXW.CustomXmlAttribute openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXW.CustomXmlAttribute openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXW.CustomXmlAttribute openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// val
  /// </summary>
  private static String? GetVal(DXW.CustomXmlAttribute openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXW.CustomXmlAttribute openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Val");
  }
  
  private static void SetVal(DXW.CustomXmlAttribute openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Wordprocessing.CustomXmlAttribute? CreateModelElement(DXW.CustomXmlAttribute? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CustomXmlAttribute();
      value.Uri = GetUri(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.CustomXmlAttribute? openXmlElement, DMW.CustomXmlAttribute? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.CustomXmlAttribute value)
    where OpenXmlElementType: DXW.CustomXmlAttribute, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.CustomXmlAttribute openXmlElement, DMW.CustomXmlAttribute value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetName(openXmlElement, value?.Name);
    SetVal(openXmlElement, value?.Val);
  }
}

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
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXW.CustomXmlAttribute openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXW.CustomXmlAttribute openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  /// <summary>
  /// name
  /// </summary>
  private static String? GetName(DXW.CustomXmlAttribute openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXW.CustomXmlAttribute openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Name?.Value == value;
  }
  
  private static void SetName(DXW.CustomXmlAttribute openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// val
  /// </summary>
  private static String? GetVal(DXW.CustomXmlAttribute openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXW.CustomXmlAttribute openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Val?.Value == value;
  }
  
  private static void SetVal(DXW.CustomXmlAttribute openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  public static DMW.CustomXmlAttribute? CreateModelElement(DXW.CustomXmlAttribute? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.CustomXmlAttribute();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.CustomXmlAttribute? value)
    where OpenXmlElementType: DXW.CustomXmlAttribute, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetName(openXmlElement, value?.Name);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Single Document Variable.
/// </summary>
public static class DocumentVariableConverter
{
  /// <summary>
  /// Document Variable Name
  /// </summary>
  private static String? GetName(DXW.DocumentVariable openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXW.DocumentVariable openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Document Variable Value
  /// </summary>
  private static String? GetVal(DXW.DocumentVariable openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DXW.DocumentVariable openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  public static DMW.DocumentVariable? CreateModelElement(DXW.DocumentVariable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocumentVariable();
      value.Name = GetName(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DocumentVariable? value)
    where OpenXmlElementType: DXW.DocumentVariable, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}

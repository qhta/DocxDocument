namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Entry Name.
/// </summary>
public static class DocPartNameConverter
{
  /// <summary>
  /// Name Value
  /// </summary>
  private static String? GetVal(DXW.DocPartName openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DXW.DocPartName openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  /// <summary>
  /// Built-In Entry
  /// </summary>
  private static Boolean? GetDecorated(DXW.DocPartName openXmlElement)
  {
    return openXmlElement?.Decorated?.Value;
  }
  
  private static void SetDecorated(DXW.DocPartName openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Decorated = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Decorated = null;
  }
  
  public static DMW.DocPartName? CreateModelElement(DXW.DocPartName? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocPartName();
      value.Val = GetVal(openXmlElement);
      value.Decorated = GetDecorated(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DocPartName? value)
    where OpenXmlElementType: DXW.DocPartName, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetDecorated(openXmlElement, value?.Decorated);
      return openXmlElement;
    }
    return default;
  }
}

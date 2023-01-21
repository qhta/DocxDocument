namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Associated Help Text.
/// </summary>
public static class HelpTextConverter
{
  /// <summary>
  /// Help Text Type
  /// </summary>
  private static DMW.InfoTextKind? GetType(DXW.HelpText openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.InfoTextValues, DMW.InfoTextKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXW.HelpText openXmlElement, DMW.InfoTextKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.InfoTextValues, DMW.InfoTextKind>(value);
  }
  
  /// <summary>
  /// Help Text Value
  /// </summary>
  private static String? GetVal(DXW.HelpText openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DXW.HelpText openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  public static DMW.HelpText? CreateModelElement(DXW.HelpText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.HelpText();
      value.Type = GetType(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.HelpText? value)
    where OpenXmlElementType: DXW.HelpText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}

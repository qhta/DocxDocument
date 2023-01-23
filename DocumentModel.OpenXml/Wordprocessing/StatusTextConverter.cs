namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Associated Status Text.
/// </summary>
public static class StatusTextConverter
{
  /// <summary>
  /// Status Text Type
  /// </summary>
  private static DMW.InfoTextKind? GetType(DXW.StatusText openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.InfoTextValues, DMW.InfoTextKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.StatusText openXmlElement, DMW.InfoTextKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.InfoTextValues, DMW.InfoTextKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXW.StatusText openXmlElement, DMW.InfoTextKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.InfoTextValues, DMW.InfoTextKind>(value);
  }
  
  /// <summary>
  /// Status Text Value
  /// </summary>
  private static String? GetVal(DXW.StatusText openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXW.StatusText openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Val?.Value == value;
  }
  
  private static void SetVal(DXW.StatusText openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  public static DMW.StatusText? CreateModelElement(DXW.StatusText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.StatusText();
      value.Type = GetType(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.StatusText? openXmlElement, DMW.StatusText? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.StatusText? value)
    where OpenXmlElementType: DXW.StatusText, new()
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

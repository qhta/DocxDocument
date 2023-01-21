namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the DocGrid Class.
/// </summary>
public static class DocGridConverter
{
  /// <summary>
  /// Document Grid Type
  /// </summary>
  private static DMW.DocGridKind? GetType(DXW.DocGrid openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocGridValues, DMW.DocGridKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXW.DocGrid openXmlElement, DMW.DocGridKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DocGridValues, DMW.DocGridKind>(value);
  }
  
  /// <summary>
  /// Document Grid Line Pitch
  /// </summary>
  private static Int32? GetLinePitch(DXW.DocGrid openXmlElement)
  {
    return openXmlElement.LinePitch?.Value;
  }
  
  private static void SetLinePitch(DXW.DocGrid openXmlElement, Int32? value)
  {
    openXmlElement.LinePitch = value;
  }
  
  /// <summary>
  /// Document Grid Character Pitch
  /// </summary>
  private static Int32? GetCharacterSpace(DXW.DocGrid openXmlElement)
  {
    return openXmlElement.CharacterSpace?.Value;
  }
  
  private static void SetCharacterSpace(DXW.DocGrid openXmlElement, Int32? value)
  {
    openXmlElement.CharacterSpace = value;
  }
  
  public static DMW.DocGrid? CreateModelElement(DXW.DocGrid? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocGrid();
      value.Type = GetType(openXmlElement);
      value.LinePitch = GetLinePitch(openXmlElement);
      value.CharacterSpace = GetCharacterSpace(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DocGrid? value)
    where OpenXmlElementType: DXW.DocGrid, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetLinePitch(openXmlElement, value?.LinePitch);
      SetCharacterSpace(openXmlElement, value?.CharacterSpace);
      return openXmlElement;
    }
    return default;
  }
}

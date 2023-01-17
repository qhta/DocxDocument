namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the DocGrid Class.
/// </summary>
public static class DocGridConverter
{
  /// <summary>
  /// Document Grid Type
  /// </summary>
  private static DocumentModel.Wordprocessing.DocGridKind? GetType(DocumentFormat.OpenXml.Wordprocessing.DocGrid openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocGridValues, DocumentModel.Wordprocessing.DocGridKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Wordprocessing.DocGrid openXmlElement, DocumentModel.Wordprocessing.DocGridKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DocGridValues, DocumentModel.Wordprocessing.DocGridKind>(value);
  }
  
  /// <summary>
  /// Document Grid Line Pitch
  /// </summary>
  private static Int32? GetLinePitch(DocumentFormat.OpenXml.Wordprocessing.DocGrid openXmlElement)
  {
    return openXmlElement.LinePitch?.Value;
  }
  
  private static void SetLinePitch(DocumentFormat.OpenXml.Wordprocessing.DocGrid openXmlElement, Int32? value)
  {
    openXmlElement.LinePitch = value;
  }
  
  /// <summary>
  /// Document Grid Character Pitch
  /// </summary>
  private static Int32? GetCharacterSpace(DocumentFormat.OpenXml.Wordprocessing.DocGrid openXmlElement)
  {
    return openXmlElement.CharacterSpace?.Value;
  }
  
  private static void SetCharacterSpace(DocumentFormat.OpenXml.Wordprocessing.DocGrid openXmlElement, Int32? value)
  {
    openXmlElement.CharacterSpace = value;
  }
  
  public static DocumentModel.Wordprocessing.DocGrid? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.DocGrid? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocGrid();
      value.Type = GetType(openXmlElement);
      value.LinePitch = GetLinePitch(openXmlElement);
      value.CharacterSpace = GetCharacterSpace(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DocGrid? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.DocGrid, new()
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

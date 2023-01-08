namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the DocGrid Class.
/// </summary>
public static class DocGridConverter
{
  /// <summary>
  /// Document Grid Type
  /// </summary>
  public static DocumentModel.Wordprocessing.DocGridKind? GetType(DocumentFormat.OpenXml.Wordprocessing.DocGrid? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocGridValues, DocumentModel.Wordprocessing.DocGridKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Wordprocessing.DocGrid? openXmlElement, DocumentModel.Wordprocessing.DocGridKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DocGridValues, DocumentModel.Wordprocessing.DocGridKind>(value);
  }
  
  /// <summary>
  /// Document Grid Line Pitch
  /// </summary>
  public static Int32? GetLinePitch(DocumentFormat.OpenXml.Wordprocessing.DocGrid? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLinePitch(DocumentFormat.OpenXml.Wordprocessing.DocGrid? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Document Grid Character Pitch
  /// </summary>
  public static Int32? GetCharacterSpace(DocumentFormat.OpenXml.Wordprocessing.DocGrid? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCharacterSpace(DocumentFormat.OpenXml.Wordprocessing.DocGrid? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

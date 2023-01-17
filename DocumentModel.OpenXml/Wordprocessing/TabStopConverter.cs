namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Custom Tab Stop.
/// </summary>
public static class TabStopConverter
{
  /// <summary>
  /// Tab Stop Type
  /// </summary>
  private static DocumentModel.Wordprocessing.TabStopKind? GetVal(DocumentFormat.OpenXml.Wordprocessing.TabStop openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TabStopValues, DocumentModel.Wordprocessing.TabStopKind>(openXmlElement?.Val?.Value);
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Wordprocessing.TabStop openXmlElement, DocumentModel.Wordprocessing.TabStopKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TabStopValues, DocumentModel.Wordprocessing.TabStopKind>(value);
  }
  
  /// <summary>
  /// Tab Leader Character
  /// </summary>
  private static DocumentModel.Wordprocessing.TabStopLeaderCharKind? GetLeader(DocumentFormat.OpenXml.Wordprocessing.TabStop openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TabStopLeaderCharValues, DocumentModel.Wordprocessing.TabStopLeaderCharKind>(openXmlElement?.Leader?.Value);
  }
  
  private static void SetLeader(DocumentFormat.OpenXml.Wordprocessing.TabStop openXmlElement, DocumentModel.Wordprocessing.TabStopLeaderCharKind? value)
  {
    openXmlElement.Leader = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TabStopLeaderCharValues, DocumentModel.Wordprocessing.TabStopLeaderCharKind>(value);
  }
  
  /// <summary>
  /// Tab Stop Position
  /// </summary>
  private static Int32? GetPosition(DocumentFormat.OpenXml.Wordprocessing.TabStop openXmlElement)
  {
    return openXmlElement.Position?.Value;
  }
  
  private static void SetPosition(DocumentFormat.OpenXml.Wordprocessing.TabStop openXmlElement, Int32? value)
  {
    openXmlElement.Position = value;
  }
  
  public static DocumentModel.Wordprocessing.TabStop? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TabStop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TabStop();
      value.Val = GetVal(openXmlElement);
      value.Leader = GetLeader(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TabStop? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TabStop, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetLeader(openXmlElement, value?.Leader);
      SetPosition(openXmlElement, value?.Position);
      return openXmlElement;
    }
    return default;
  }
}

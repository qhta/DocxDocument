namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Absolute Position Tab Character.
/// </summary>
public static class PositionalTabConverter
{
  /// <summary>
  /// Positional Tab Stop Alignment
  /// </summary>
  public static DocumentModel.Wordprocessing.AbsolutePositionTabAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Wordprocessing.PositionalTab? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabAlignmentValues, DocumentModel.Wordprocessing.AbsolutePositionTabAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  public static void SetAlignment(DocumentFormat.OpenXml.Wordprocessing.PositionalTab? openXmlElement, DocumentModel.Wordprocessing.AbsolutePositionTabAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabAlignmentValues, DocumentModel.Wordprocessing.AbsolutePositionTabAlignmentKind>(value);
  }
  
  /// <summary>
  /// Positional Tab Base
  /// </summary>
  public static DocumentModel.Wordprocessing.AbsolutePositionTabPositioningBaseKind? GetRelativeTo(DocumentFormat.OpenXml.Wordprocessing.PositionalTab? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabPositioningBaseValues, DocumentModel.Wordprocessing.AbsolutePositionTabPositioningBaseKind>(openXmlElement?.RelativeTo?.Value);
  }
  
  public static void SetRelativeTo(DocumentFormat.OpenXml.Wordprocessing.PositionalTab? openXmlElement, DocumentModel.Wordprocessing.AbsolutePositionTabPositioningBaseKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.RelativeTo = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabPositioningBaseValues, DocumentModel.Wordprocessing.AbsolutePositionTabPositioningBaseKind>(value);
  }
  
  /// <summary>
  /// Tab Leader Character
  /// </summary>
  public static DocumentModel.Wordprocessing.AbsolutePositionTabLeaderCharKind? GetLeader(DocumentFormat.OpenXml.Wordprocessing.PositionalTab? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabLeaderCharValues, DocumentModel.Wordprocessing.AbsolutePositionTabLeaderCharKind>(openXmlElement?.Leader?.Value);
  }
  
  public static void SetLeader(DocumentFormat.OpenXml.Wordprocessing.PositionalTab? openXmlElement, DocumentModel.Wordprocessing.AbsolutePositionTabLeaderCharKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Leader = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabLeaderCharValues, DocumentModel.Wordprocessing.AbsolutePositionTabLeaderCharKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.PositionalTab? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.PositionalTab? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PositionalTab();
      value.Alignment = GetAlignment(openXmlElement);
      value.RelativeTo = GetRelativeTo(openXmlElement);
      value.Leader = GetLeader(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PositionalTab? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.PositionalTab, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

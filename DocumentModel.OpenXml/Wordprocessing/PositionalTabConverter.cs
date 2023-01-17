namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Absolute Position Tab Character.
/// </summary>
public static class PositionalTabConverter
{
  /// <summary>
  /// Positional Tab Stop Alignment
  /// </summary>
  private static DocumentModel.Wordprocessing.AbsolutePositionTabAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Wordprocessing.PositionalTab openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabAlignmentValues, DocumentModel.Wordprocessing.AbsolutePositionTabAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static void SetAlignment(DocumentFormat.OpenXml.Wordprocessing.PositionalTab openXmlElement, DocumentModel.Wordprocessing.AbsolutePositionTabAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabAlignmentValues, DocumentModel.Wordprocessing.AbsolutePositionTabAlignmentKind>(value);
  }
  
  /// <summary>
  /// Positional Tab Base
  /// </summary>
  private static DocumentModel.Wordprocessing.AbsolutePositionTabPositioningBaseKind? GetRelativeTo(DocumentFormat.OpenXml.Wordprocessing.PositionalTab openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabPositioningBaseValues, DocumentModel.Wordprocessing.AbsolutePositionTabPositioningBaseKind>(openXmlElement?.RelativeTo?.Value);
  }
  
  private static void SetRelativeTo(DocumentFormat.OpenXml.Wordprocessing.PositionalTab openXmlElement, DocumentModel.Wordprocessing.AbsolutePositionTabPositioningBaseKind? value)
  {
    openXmlElement.RelativeTo = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabPositioningBaseValues, DocumentModel.Wordprocessing.AbsolutePositionTabPositioningBaseKind>(value);
  }
  
  /// <summary>
  /// Tab Leader Character
  /// </summary>
  private static DocumentModel.Wordprocessing.AbsolutePositionTabLeaderCharKind? GetLeader(DocumentFormat.OpenXml.Wordprocessing.PositionalTab openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabLeaderCharValues, DocumentModel.Wordprocessing.AbsolutePositionTabLeaderCharKind>(openXmlElement?.Leader?.Value);
  }
  
  private static void SetLeader(DocumentFormat.OpenXml.Wordprocessing.PositionalTab openXmlElement, DocumentModel.Wordprocessing.AbsolutePositionTabLeaderCharKind? value)
  {
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAlignment(openXmlElement, value?.Alignment);
      SetRelativeTo(openXmlElement, value?.RelativeTo);
      SetLeader(openXmlElement, value?.Leader);
      return openXmlElement;
    }
    return default;
  }
}

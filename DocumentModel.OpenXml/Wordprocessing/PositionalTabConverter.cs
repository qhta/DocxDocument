namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Absolute Position Tab Character.
/// </summary>
public static class PositionalTabConverter
{
  /// <summary>
  /// Positional Tab Stop Alignment
  /// </summary>
  private static DMW.AbsolutePositionTabAlignmentKind? GetAlignment(DXW.PositionalTab openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabAlignmentValues, DMW.AbsolutePositionTabAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static void SetAlignment(DXW.PositionalTab openXmlElement, DMW.AbsolutePositionTabAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabAlignmentValues, DMW.AbsolutePositionTabAlignmentKind>(value);
  }
  
  /// <summary>
  /// Positional Tab Base
  /// </summary>
  private static DMW.AbsolutePositionTabPositioningBaseKind? GetRelativeTo(DXW.PositionalTab openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabPositioningBaseValues, DMW.AbsolutePositionTabPositioningBaseKind>(openXmlElement?.RelativeTo?.Value);
  }
  
  private static void SetRelativeTo(DXW.PositionalTab openXmlElement, DMW.AbsolutePositionTabPositioningBaseKind? value)
  {
    openXmlElement.RelativeTo = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabPositioningBaseValues, DMW.AbsolutePositionTabPositioningBaseKind>(value);
  }
  
  /// <summary>
  /// Tab Leader Character
  /// </summary>
  private static DMW.AbsolutePositionTabLeaderCharKind? GetLeader(DXW.PositionalTab openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabLeaderCharValues, DMW.AbsolutePositionTabLeaderCharKind>(openXmlElement?.Leader?.Value);
  }
  
  private static void SetLeader(DXW.PositionalTab openXmlElement, DMW.AbsolutePositionTabLeaderCharKind? value)
  {
    openXmlElement.Leader = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabLeaderCharValues, DMW.AbsolutePositionTabLeaderCharKind>(value);
  }
  
  public static DMW.PositionalTab? CreateModelElement(DXW.PositionalTab? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PositionalTab();
      value.Alignment = GetAlignment(openXmlElement);
      value.RelativeTo = GetRelativeTo(openXmlElement);
      value.Leader = GetLeader(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PositionalTab? value)
    where OpenXmlElementType: DXW.PositionalTab, new()
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

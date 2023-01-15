using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using PositionalTab = DocumentFormat.OpenXml.Wordprocessing.PositionalTab;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Absolute Position Tab Character.
/// </summary>
public static class PositionalTabConverter
{
  /// <summary>
  ///   Positional Tab Stop Alignment
  /// </summary>
  public static AbsolutePositionTabAlignmentKind? GetAlignment(PositionalTab? openXmlElement)
  {
    return EnumValueConverter.GetValue<AbsolutePositionTabAlignmentValues, AbsolutePositionTabAlignmentKind>(openXmlElement?.Alignment?.Value);
  }

  public static void SetAlignment(PositionalTab? openXmlElement, AbsolutePositionTabAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<AbsolutePositionTabAlignmentValues, AbsolutePositionTabAlignmentKind>(value);
  }

  /// <summary>
  ///   Positional Tab Base
  /// </summary>
  public static AbsolutePositionTabPositioningBaseKind? GetRelativeTo(PositionalTab? openXmlElement)
  {
    return EnumValueConverter.GetValue<AbsolutePositionTabPositioningBaseValues, AbsolutePositionTabPositioningBaseKind>(openXmlElement?.RelativeTo?.Value);
  }

  public static void SetRelativeTo(PositionalTab? openXmlElement, AbsolutePositionTabPositioningBaseKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.RelativeTo = EnumValueConverter.CreateEnumValue<AbsolutePositionTabPositioningBaseValues, AbsolutePositionTabPositioningBaseKind>(value);
  }

  /// <summary>
  ///   Tab Leader Character
  /// </summary>
  public static AbsolutePositionTabLeaderCharKind? GetLeader(PositionalTab? openXmlElement)
  {
    return EnumValueConverter.GetValue<AbsolutePositionTabLeaderCharValues, AbsolutePositionTabLeaderCharKind>(openXmlElement?.Leader?.Value);
  }

  public static void SetLeader(PositionalTab? openXmlElement, AbsolutePositionTabLeaderCharKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Leader = EnumValueConverter.CreateEnumValue<AbsolutePositionTabLeaderCharValues, AbsolutePositionTabLeaderCharKind>(value);
  }

  public static DocumentModel.Wordprocessing.PositionalTab? CreateModelElement(PositionalTab? openXmlElement)
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
    where OpenXmlElementType : PositionalTab, new()
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
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using TabStop = DocumentFormat.OpenXml.Wordprocessing.TabStop;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Custom Tab Stop.
/// </summary>
public static class TabStopConverter
{
  /// <summary>
  ///   Tab Stop Type
  /// </summary>
  public static TabStopKind? GetVal(TabStop? openXmlElement)
  {
    return EnumValueConverter.GetValue<TabStopValues, TabStopKind>(openXmlElement?.Val?.Value);
  }

  public static void SetVal(TabStop? openXmlElement, TabStopKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = EnumValueConverter.CreateEnumValue<TabStopValues, TabStopKind>(value);
  }

  /// <summary>
  ///   Tab Leader Character
  /// </summary>
  public static TabStopLeaderCharKind? GetLeader(TabStop? openXmlElement)
  {
    return EnumValueConverter.GetValue<TabStopLeaderCharValues, TabStopLeaderCharKind>(openXmlElement?.Leader?.Value);
  }

  public static void SetLeader(TabStop? openXmlElement, TabStopLeaderCharKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Leader = EnumValueConverter.CreateEnumValue<TabStopLeaderCharValues, TabStopLeaderCharKind>(value);
  }

  /// <summary>
  ///   Tab Stop Position
  /// </summary>
  public static Int32? GetPosition(TabStop? openXmlElement)
  {
    return openXmlElement?.Position?.Value;
  }

  public static void SetPosition(TabStop? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Position = value;
  }

  public static DocumentModel.Wordprocessing.TabStop? CreateModelElement(TabStop? openXmlElement)
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
    where OpenXmlElementType : TabStop, new()
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
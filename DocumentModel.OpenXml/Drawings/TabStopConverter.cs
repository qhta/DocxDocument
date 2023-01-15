using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using TabStop = DocumentFormat.OpenXml.Drawing.TabStop;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Tab Stop.
/// </summary>
public static class TabStopConverter
{
  /// <summary>
  ///   Tab Position
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

  /// <summary>
  ///   Tab Alignment
  /// </summary>
  public static TextTabAlignmentKind? GetAlignment(TabStop? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextTabAlignmentValues, TextTabAlignmentKind>(openXmlElement?.Alignment?.Value);
  }

  public static void SetAlignment(TabStop? openXmlElement, TextTabAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<TextTabAlignmentValues, TextTabAlignmentKind>(value);
  }

  public static DocumentModel.Drawings.TabStop? CreateModelElement(TabStop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TabStop();
      value.Position = GetPosition(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.TabStop? value)
    where OpenXmlElementType : TabStop, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPosition(openXmlElement, value?.Position);
      SetAlignment(openXmlElement, value?.Alignment);
      return openXmlElement;
    }
    return default;
  }
}
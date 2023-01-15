using DocumentFormat.OpenXml.Math;
using DocumentModel.Math;
using ParagraphProperties = DocumentFormat.OpenXml.Math.ParagraphProperties;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Office Math Paragraph Properties.
/// </summary>
public static class ParagraphPropertiesConverter
{
  /// <summary>
  ///   Justification.
  /// </summary>
  public static JustificationKind? GetJustification(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Justification>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<JustificationValues, JustificationKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetJustification(ParagraphProperties? openXmlElement, JustificationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Justification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Justification, JustificationValues, JustificationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.ParagraphProperties? CreateModelElement(ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.ParagraphProperties();
      value.Justification = GetJustification(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.ParagraphProperties? value)
    where OpenXmlElementType : ParagraphProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetJustification(openXmlElement, value?.Justification);
      return openXmlElement;
    }
    return default;
  }
}
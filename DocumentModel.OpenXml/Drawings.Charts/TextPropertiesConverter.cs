using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the TextProperties Class.
/// </summary>
public static class TextPropertiesConverter
{
  public static BodyProperties? GetBodyProperties(TextProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
    if (itemElement != null)
      return BodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBodyProperties(TextProperties? openXmlElement, BodyProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BodyPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BodyProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ListStyle? GetListStyle(TextProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
    if (itemElement != null)
      return ListStyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetListStyle(TextProperties? openXmlElement, ListStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ListStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ListStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Paragraph? GetParagraph(TextProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
    if (itemElement != null)
      return ParagraphConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetParagraph(TextProperties? openXmlElement, Paragraph? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Paragraph>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.TextProperties? CreateModelElement(TextProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.TextProperties();
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.Paragraph = GetParagraph(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.TextProperties? value)
    where OpenXmlElementType : TextProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBodyProperties(openXmlElement, value?.BodyProperties);
      SetListStyle(openXmlElement, value?.ListStyle);
      SetParagraph(openXmlElement, value?.Paragraph);
      return openXmlElement;
    }
    return default;
  }
}
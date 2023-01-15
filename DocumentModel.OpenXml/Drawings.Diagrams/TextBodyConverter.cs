using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Text Body.
/// </summary>
public static class TextBodyConverter
{
  /// <summary>
  ///   Body Properties.
  /// </summary>
  public static BodyProperties? GetBodyProperties(TextBody? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
    if (itemElement != null)
      return BodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBodyProperties(TextBody? openXmlElement, BodyProperties? value)
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

  /// <summary>
  ///   Text List Styles.
  /// </summary>
  public static ListStyle? GetListStyle(TextBody? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
    if (itemElement != null)
      return ListStyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetListStyle(TextBody? openXmlElement, ListStyle? value)
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

  public static Paragraph? GetParagraph(TextBody? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
    if (itemElement != null)
      return ParagraphConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetParagraph(TextBody? openXmlElement, Paragraph? value)
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

  public static DocumentModel.Drawings.Diagrams.TextBody? CreateModelElement(TextBody? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.TextBody();
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.Paragraph = GetParagraph(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.TextBody? value)
    where OpenXmlElementType : TextBody, new()
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
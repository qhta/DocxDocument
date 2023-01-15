using DocumentFormat.OpenXml.Office2010.Drawing;
using DocumentModel.Drawings;
using Paragraph = DocumentFormat.OpenXml.Drawing.Paragraph;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Text Paragraphs.
/// </summary>
public static class ParagraphConverter
{
  /// <summary>
  ///   Text Paragraph Properties.
  /// </summary>
  public static ParagraphProperties? GetParagraphProperties(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ParagraphProperties>();
    if (itemElement != null)
      return ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetParagraphProperties(Paragraph? openXmlElement, ParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Run? GetRun(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Run>();
    if (itemElement != null)
      return RunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRun(Paragraph? openXmlElement, Run? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Run>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Run>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Break? GetBreak(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Break>();
    if (itemElement != null)
      return BreakConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBreak(Paragraph? openXmlElement, Break? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Break>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BreakConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Break>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Field? GetField(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Field>();
    if (itemElement != null)
      return FieldConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetField(Paragraph? openXmlElement, Field? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Field>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FieldConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Field>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetTextMath(Paragraph? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextMath>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetTextMath(Paragraph? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<TextMath>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new TextMath();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static EndParagraphRunProperties? GetEndParagraphRunProperties(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EndParagraphRunProperties>();
    if (itemElement != null)
      return EndParagraphRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEndParagraphRunProperties(Paragraph? openXmlElement, EndParagraphRunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EndParagraphRunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EndParagraphRunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EndParagraphRunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Paragraph? CreateModelElement(Paragraph? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Paragraph();
      value.ParagraphProperties = GetParagraphProperties(openXmlElement);
      value.Run = GetRun(openXmlElement);
      value.Break = GetBreak(openXmlElement);
      value.Field = GetField(openXmlElement);
      value.TextMath = GetTextMath(openXmlElement);
      value.EndParagraphRunProperties = GetEndParagraphRunProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Paragraph? value)
    where OpenXmlElementType : Paragraph, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParagraphProperties(openXmlElement, value?.ParagraphProperties);
      SetRun(openXmlElement, value?.Run);
      SetBreak(openXmlElement, value?.Break);
      SetField(openXmlElement, value?.Field);
      SetTextMath(openXmlElement, value?.TextMath);
      SetEndParagraphRunProperties(openXmlElement, value?.EndParagraphRunProperties);
      return openXmlElement;
    }
    return default;
  }
}
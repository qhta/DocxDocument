namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Text Paragraphs.
/// </summary>
public static class ParagraphConverter
{
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public static DocumentModel.Drawings.ParagraphProperties? GetParagraphProperties(DocumentFormat.OpenXml.Drawing.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ParagraphProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetParagraphProperties(DocumentFormat.OpenXml.Drawing.Paragraph? openXmlElement, DocumentModel.Drawings.ParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Run? GetRun(DocumentFormat.OpenXml.Drawing.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Run>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRun(DocumentFormat.OpenXml.Drawing.Paragraph? openXmlElement, DocumentModel.Drawings.Run? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Run>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.RunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Run>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Break? GetBreak(DocumentFormat.OpenXml.Drawing.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Break>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BreakConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBreak(DocumentFormat.OpenXml.Drawing.Paragraph? openXmlElement, DocumentModel.Drawings.Break? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Break>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.BreakConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Break>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Field? GetField(DocumentFormat.OpenXml.Drawing.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Field>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FieldConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetField(DocumentFormat.OpenXml.Drawing.Paragraph? openXmlElement, DocumentModel.Drawings.Field? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Field>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.FieldConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Field>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetTextMath(DocumentFormat.OpenXml.Drawing.Paragraph? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.TextMath>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetTextMath(DocumentFormat.OpenXml.Drawing.Paragraph? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.TextMath>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Office2010.Drawing.TextMath();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.EndParagraphRunProperties? GetEndParagraphRunProperties(DocumentFormat.OpenXml.Drawing.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EndParagraphRunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EndParagraphRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEndParagraphRunProperties(DocumentFormat.OpenXml.Drawing.Paragraph? openXmlElement, DocumentModel.Drawings.EndParagraphRunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EndParagraphRunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.EndParagraphRunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EndParagraphRunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Paragraph? CreateModelElement(DocumentFormat.OpenXml.Drawing.Paragraph? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Paragraph, new()
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

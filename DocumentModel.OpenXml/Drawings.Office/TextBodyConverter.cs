namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the TextBody Class.
/// </summary>
public static class TextBodyConverter
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  private static DocumentModel.Drawings.BodyProperties? GetBodyProperties(DocumentFormat.OpenXml.Office.Drawing.TextBody openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBodyProperties(DocumentFormat.OpenXml.Office.Drawing.TextBody openXmlElement, DocumentModel.Drawings.BodyProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BodyPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BodyProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  private static DocumentModel.Drawings.ListStyle? GetListStyle(DocumentFormat.OpenXml.Office.Drawing.TextBody openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ListStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetListStyle(DocumentFormat.OpenXml.Office.Drawing.TextBody openXmlElement, DocumentModel.Drawings.ListStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ListStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ListStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Paragraph? GetParagraph(DocumentFormat.OpenXml.Office.Drawing.TextBody openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ParagraphConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetParagraph(DocumentFormat.OpenXml.Office.Drawing.TextBody openXmlElement, DocumentModel.Drawings.Paragraph? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ParagraphConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Paragraph>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Office.TextBody? CreateModelElement(DocumentFormat.OpenXml.Office.Drawing.TextBody? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.TextBody();
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.Paragraph = GetParagraph(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.TextBody? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Drawing.TextBody, new()
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

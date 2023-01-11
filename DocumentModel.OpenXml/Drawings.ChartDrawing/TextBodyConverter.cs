namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Shape Text Body.
/// </summary>
public static class TextBodyConverter
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  public static DocumentModel.Drawings.BodyProperties? GetBodyProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBodyProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody? openXmlElement, DocumentModel.Drawings.BodyProperties? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public static DocumentModel.Drawings.ListStyle? GetListStyle(DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ListStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetListStyle(DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody? openXmlElement, DocumentModel.Drawings.ListStyle? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Paragraph? GetParagraph(DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ParagraphConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetParagraph(DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody? openXmlElement, DocumentModel.Drawings.Paragraph? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.ChartDrawing.TextBody? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.TextBody();
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.Paragraph = GetParagraph(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.TextBody? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

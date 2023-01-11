namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the RichTextBody Class.
/// </summary>
public static class RichTextBodyConverter
{
  public static DocumentModel.Drawings.BodyProperties? GetBodyProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBodyProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody? openXmlElement, DocumentModel.Drawings.BodyProperties? value)
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
  
  public static DocumentModel.Drawings.ListStyle? GetListStyle(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ListStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetListStyle(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody? openXmlElement, DocumentModel.Drawings.ListStyle? value)
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
  
  public static DocumentModel.Drawings.Paragraph? GetParagraph(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ParagraphConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetParagraph(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody? openXmlElement, DocumentModel.Drawings.Paragraph? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.RichTextBody? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.RichTextBody();
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.Paragraph = GetParagraph(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.RichTextBody? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

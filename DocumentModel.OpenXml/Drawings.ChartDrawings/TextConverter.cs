namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Text Class.
/// </summary>
public static class TextConverter
{
  /// <summary>
  /// TextData.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.TextData? GetTextData(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.TextDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextData(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text? openXmlElement, DocumentModel.Drawings.ChartDrawings.TextData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.TextDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// RichTextBody.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.RichTextBody? GetRichTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.RichTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRichTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text? openXmlElement, DocumentModel.Drawings.ChartDrawings.RichTextBody? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.RichTextBodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Text? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Text();
      value.TextData = GetTextData(openXmlElement);
      value.RichTextBody = GetRichTextBody(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Text? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

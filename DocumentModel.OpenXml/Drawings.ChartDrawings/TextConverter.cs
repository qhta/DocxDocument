namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Text Class.
/// </summary>
public static class TextConverter
{
  /// <summary>
  /// TextData.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.TextData? GetTextData(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.TextDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextData(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text openXmlElement, DocumentModel.Drawings.ChartDrawings.TextData? value)
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
  
  /// <summary>
  /// RichTextBody.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.RichTextBody? GetRichTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.RichTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRichTextBody(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text openXmlElement, DocumentModel.Drawings.ChartDrawings.RichTextBody? value)
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTextData(openXmlElement, value?.TextData);
      SetRichTextBody(openXmlElement, value?.RichTextBody);
      return openXmlElement;
    }
    return default;
  }
}

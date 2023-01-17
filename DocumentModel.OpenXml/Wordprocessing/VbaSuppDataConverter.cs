namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the VbaSuppData Class.
/// </summary>
public static class VbaSuppDataConverter
{
  /// <summary>
  /// DocEvents.
  /// </summary>
  private static DocumentModel.Wordprocessing.DocEvents? GetDocEvents(DocumentFormat.OpenXml.Office.Word.VbaSuppData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.DocEvents>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DocEventsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDocEvents(DocumentFormat.OpenXml.Office.Word.VbaSuppData openXmlElement, DocumentModel.Wordprocessing.DocEvents? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.DocEvents>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DocEventsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.DocEvents>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Mcds.
  /// </summary>
  private static DocumentModel.Wordprocessing.Mcds? GetMcds(DocumentFormat.OpenXml.Office.Word.VbaSuppData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Mcds>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.McdsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMcds(DocumentFormat.OpenXml.Office.Word.VbaSuppData openXmlElement, DocumentModel.Wordprocessing.Mcds? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Mcds>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.McdsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.Mcds>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.VbaSuppData? CreateModelElement(DocumentFormat.OpenXml.Office.Word.VbaSuppData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.VbaSuppData();
      value.DocEvents = GetDocEvents(openXmlElement);
      value.Mcds = GetMcds(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.VbaSuppData? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.VbaSuppData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDocEvents(openXmlElement, value?.DocEvents);
      SetMcds(openXmlElement, value?.Mcds);
      return openXmlElement;
    }
    return default;
  }
}

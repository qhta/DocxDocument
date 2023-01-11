namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// DrawingML Object.
/// </summary>
public static class DrawingConverter
{
  /// <summary>
  /// Drawing Element Anchor.
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.Anchor? GetAnchor(DocumentFormat.OpenXml.Wordprocessing.Drawing? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.AnchorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAnchor(DocumentFormat.OpenXml.Wordprocessing.Drawing? openXmlElement, DocumentModel.Drawings.Wordprocessing.Anchor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.AnchorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Inline Drawing Object.
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.Inline? GetInline(DocumentFormat.OpenXml.Wordprocessing.Drawing? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.InlineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetInline(DocumentFormat.OpenXml.Wordprocessing.Drawing? openXmlElement, DocumentModel.Drawings.Wordprocessing.Inline? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.InlineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Drawing? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Drawing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Drawing();
      value.Anchor = GetAnchor(openXmlElement);
      value.Inline = GetInline(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Drawing? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Drawing, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

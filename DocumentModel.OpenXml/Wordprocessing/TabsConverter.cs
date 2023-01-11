namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Tabs Class.
/// </summary>
public static class TabsConverter
{
  public static DocumentModel.Wordprocessing.TabStop? GetTabStop(DocumentFormat.OpenXml.Wordprocessing.Tabs? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TabStop>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TabStopConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTabStop(DocumentFormat.OpenXml.Wordprocessing.Tabs? openXmlElement, DocumentModel.Wordprocessing.TabStop? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TabStop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TabStopConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TabStop>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Tabs? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Tabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Tabs();
      value.TabStop = GetTabStop(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Tabs? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Tabs, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

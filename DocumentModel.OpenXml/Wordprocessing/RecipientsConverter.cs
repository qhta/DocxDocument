namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines Recipients.
/// </summary>
public static class RecipientsConverter
{
  private static DocumentModel.Wordprocessing.RecipientData? GetRecipientData(DocumentFormat.OpenXml.Wordprocessing.Recipients openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RecipientData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RecipientDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRecipientData(DocumentFormat.OpenXml.Wordprocessing.Recipients openXmlElement, DocumentModel.Wordprocessing.RecipientData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RecipientData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RecipientDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RecipientData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.Recipients? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Recipients? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Recipients();
      value.RecipientData = GetRecipientData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Recipients? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Recipients, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRecipientData(openXmlElement, value?.RecipientData);
      return openXmlElement;
    }
    return default;
  }
}

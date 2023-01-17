namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Audio from File.
/// </summary>
public static class AudioFromFileConverter
{
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  private static String? GetLink(DocumentFormat.OpenXml.Drawing.AudioFromFile openXmlElement)
  {
    return openXmlElement?.Link?.Value;
  }
  
  private static void SetLink(DocumentFormat.OpenXml.Drawing.AudioFromFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Link = new StringValue { Value = value };
    else
      openXmlElement.Link = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.AudioFromFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.AudioFromFile openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.AudioFromFile? CreateModelElement(DocumentFormat.OpenXml.Drawing.AudioFromFile? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AudioFromFile();
      value.Link = GetLink(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AudioFromFile? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.AudioFromFile, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLink(openXmlElement, value?.Link);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}

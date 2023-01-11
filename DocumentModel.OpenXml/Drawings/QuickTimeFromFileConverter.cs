namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// QuickTime from File.
/// </summary>
public static class QuickTimeFromFileConverter
{
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  public static String? GetLink(DocumentFormat.OpenXml.Drawing.QuickTimeFromFile? openXmlElement)
  {
    return openXmlElement?.Link?.Value;
  }
  
  public static void SetLink(DocumentFormat.OpenXml.Drawing.QuickTimeFromFile? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Link = new StringValue { Value = value };
      else
        openXmlElement.Link = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.QuickTimeFromFile? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.QuickTimeFromFile? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.QuickTimeFromFile? CreateModelElement(DocumentFormat.OpenXml.Drawing.QuickTimeFromFile? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.QuickTimeFromFile();
      value.Link = GetLink(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.QuickTimeFromFile? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.QuickTimeFromFile, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

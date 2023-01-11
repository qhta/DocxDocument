namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Default Run Properties.
/// </summary>
public static class RunPropertiesDefaultConverter
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.RunPropertiesBaseStyle? GetRunPropertiesBaseStyle(DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesBaseStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunPropertiesBaseStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunPropertiesBaseStyle(DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault? openXmlElement, DocumentModel.Wordprocessing.RunPropertiesBaseStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesBaseStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.RunPropertiesBaseStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesBaseStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.RunPropertiesDefault? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.RunPropertiesDefault();
      value.RunPropertiesBaseStyle = GetRunPropertiesBaseStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.RunPropertiesDefault? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ClassificationExtensionList Class.
/// </summary>
public static class ClassificationExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.ClassificationExtension>? GetClassificationExtensions(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.ClassificationExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension>())
      {
        var newItem = DocumentModel.OpenXml.ClassificationExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetClassificationExtensions(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.ClassificationExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.ClassificationExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.ClassificationExtensionList? CreateModelElement(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ClassificationExtensionList();
      value.ClassificationExtensions = GetClassificationExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.ClassificationExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}

namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ClassificationLabelList Class.
/// </summary>
public static class ClassificationLabelListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.ClassificationLabel>? GetClassificationLabels(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.ClassificationLabel>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel>())
      {
        var newItem = DocumentModel.OpenXml.ClassificationLabelConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetClassificationLabels(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.ClassificationLabel>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.ClassificationLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.ClassificationExtensionList? GetClassificationExtensionList(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ClassificationExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetClassificationExtensionList(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList? openXmlElement, DocumentModel.ClassificationExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.ClassificationExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.ClassificationLabelList? CreateModelElement(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ClassificationLabelList();
      value.ClassificationLabels = GetClassificationLabels(openXmlElement);
      value.ClassificationExtensionList = GetClassificationExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.ClassificationLabelList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}

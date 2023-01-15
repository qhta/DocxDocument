namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the ClassificationLabelList Class.
/// </summary>
public static class ClassificationLabelListConverter
{
  public static Collection<ClassificationLabel>? GetClassificationLabels(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ClassificationLabel>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel>())
      {
        var newItem = ClassificationLabelConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetClassificationLabels(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList? openXmlElement, Collection<ClassificationLabel>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ClassificationLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static ClassificationExtensionList? GetClassificationExtensionList(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList>();
    if (itemElement != null)
      return ClassificationExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetClassificationExtensionList(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList? openXmlElement, ClassificationExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ClassificationExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ClassificationLabelList? CreateModelElement(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new ClassificationLabelList();
      value.ClassificationLabels = GetClassificationLabels(openXmlElement);
      value.ClassificationExtensionList = GetClassificationExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(ClassificationLabelList? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabelList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetClassificationLabels(openXmlElement, value?.ClassificationLabels);
      SetClassificationExtensionList(openXmlElement, value?.ClassificationExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
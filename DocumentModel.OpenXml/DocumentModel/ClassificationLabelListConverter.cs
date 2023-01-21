namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ClassificationLabelList Class.
/// </summary>
public static class ClassificationLabelListConverter
{
  private static Collection<DM.ClassificationLabel> GetClassificationLabels(DXO2021MipLabelMeta.ClassificationLabelList openXmlElement)
  {
    var collection = new Collection<DM.ClassificationLabel>();
    foreach (var item in openXmlElement.Elements<DXO2021MipLabelMeta.ClassificationLabel>())
    {
      var newItem = DMX.ClassificationLabelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetClassificationLabels(DXO2021MipLabelMeta.ClassificationLabelList openXmlElement, Collection<DM.ClassificationLabel>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2021MipLabelMeta.ClassificationLabel>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.ClassificationLabelConverter.CreateOpenXmlElement<DXO2021MipLabelMeta.ClassificationLabel>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DM.ClassificationExtensionList? GetClassificationExtensionList(DXO2021MipLabelMeta.ClassificationLabelList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021MipLabelMeta.ClassificationExtensionList>();
    if (itemElement != null)
      return DMX.ClassificationExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetClassificationExtensionList(DXO2021MipLabelMeta.ClassificationLabelList openXmlElement, DM.ClassificationExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021MipLabelMeta.ClassificationExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ClassificationExtensionListConverter.CreateOpenXmlElement<DXO2021MipLabelMeta.ClassificationExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DM.ClassificationLabelList? CreateModelElement(DXO2021MipLabelMeta.ClassificationLabelList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.ClassificationLabelList();
      value.ClassificationLabels = GetClassificationLabels(openXmlElement);
      value.ClassificationExtensionList = GetClassificationExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.ClassificationLabelList? value)
    where OpenXmlElementType: DXO2021MipLabelMeta.ClassificationLabelList, new()
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

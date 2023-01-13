namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the MultiLvlStrRefExtensionList Class.
/// </summary>
public static class MultiLvlStrRefExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.MultiLvlStrRefExtension>? GetMultiLvlStrRefExtensions(DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.MultiLvlStrRefExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.MultiLvlStrRefExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetMultiLvlStrRefExtensions(DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.MultiLvlStrRefExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.MultiLvlStrRefExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList();
      value.MultiLvlStrRefExtensions = GetMultiLvlStrRefExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMultiLvlStrRefExtensions(openXmlElement, value?.MultiLvlStrRefExtensions);
      return openXmlElement;
    }
    return default;
  }
}

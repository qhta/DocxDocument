namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public static class ExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Extension>? GetExtensions(DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Extension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension>())
      {
        var newItem = DocumentModel.OpenXml.ExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetExtensions(DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Extension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.ExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.ExtensionList? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ExtensionList();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.ExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}

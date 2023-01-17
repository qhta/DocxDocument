namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the DataModelExtensionList Class.
/// </summary>
public static class DataModelExtensionListConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.DataModelExtension> GetDataModelExtensions(DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.DataModelExtension>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.DataModelExtension>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.DataModelExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetDataModelExtensions(DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.DataModelExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.DataModelExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.DataModelExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.DataModelExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.DataModelExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.DataModelExtensionList();
      value.DataModelExtensions = GetDataModelExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.DataModelExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDataModelExtensions(openXmlElement, value?.DataModelExtensions);
      return openXmlElement;
    }
    return default;
  }
}

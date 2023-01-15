using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Defines the DataModelExtensionList Class.
/// </summary>
public static class DataModelExtensionListConverter
{
  public static Collection<DataModelExtension>? GetDataModelExtensions(DataModelExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DataModelExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.DataModelExtension>())
      {
        var newItem = DataModelExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetDataModelExtensions(DataModelExtensionList? openXmlElement, Collection<DataModelExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.DataModelExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = DataModelExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.DataModelExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Diagrams.DataModelExtensionList? CreateModelElement(DataModelExtensionList? openXmlElement)
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
    where OpenXmlElementType : DataModelExtensionList, new()
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
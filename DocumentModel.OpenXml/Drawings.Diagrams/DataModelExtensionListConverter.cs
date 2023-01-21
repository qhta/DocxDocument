namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the DataModelExtensionList Class.
/// </summary>
public static class DataModelExtensionListConverter
{
  private static Collection<DMDraws.DataModelExtension> GetDataModelExtensions(DXDrawDgms.DataModelExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.DataModelExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.DataModelExtension>())
    {
      var newItem = DMXDraws.DataModelExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetDataModelExtensions(DXDrawDgms.DataModelExtensionList openXmlElement, Collection<DMDraws.DataModelExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.DataModelExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.DataModelExtensionConverter.CreateOpenXmlElement<DXDraw.DataModelExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsDgms.DataModelExtensionList? CreateModelElement(DXDrawDgms.DataModelExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.DataModelExtensionList();
      value.DataModelExtensions = GetDataModelExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.DataModelExtensionList? value)
    where OpenXmlElementType: DXDrawDgms.DataModelExtensionList, new()
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

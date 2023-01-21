namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// List of extensions to the CT_DiagramDefintions type..
/// </summary>
public static class DiagramDefinitionExtensionListConverter
{
  private static Collection<DMDrawsDgms.DiagramDefinitionExtension> GetDiagramDefinitionExtensions(DXDrawDgms.DiagramDefinitionExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.DiagramDefinitionExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.DiagramDefinitionExtension>())
    {
      var newItem = DMXDrawsDgms.DiagramDefinitionExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetDiagramDefinitionExtensions(DXDrawDgms.DiagramDefinitionExtensionList openXmlElement, Collection<DMDrawsDgms.DiagramDefinitionExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.DiagramDefinitionExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.DiagramDefinitionExtensionConverter.CreateOpenXmlElement<DXDrawDgms.DiagramDefinitionExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsDgms.DiagramDefinitionExtensionList? CreateModelElement(DXDrawDgms.DiagramDefinitionExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.DiagramDefinitionExtensionList();
      value.DiagramDefinitionExtensions = GetDiagramDefinitionExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.DiagramDefinitionExtensionList? value)
    where OpenXmlElementType: DXDrawDgms.DiagramDefinitionExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDiagramDefinitionExtensions(openXmlElement, value?.DiagramDefinitionExtensions);
      return openXmlElement;
    }
    return default;
  }
}

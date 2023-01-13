namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// List of extensions to the CT_DiagramDefintions type..
/// </summary>
public static class DiagramDefinitionExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension>? GetDiagramDefinitionExtensions(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.DiagramDefinitionExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetDiagramDefinitionExtensions(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.DiagramDefinitionExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Diagrams.DiagramDefinitionExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.DiagramDefinitionExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.DiagramDefinitionExtensionList();
      value.DiagramDefinitionExtensions = GetDiagramDefinitionExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.DiagramDefinitionExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList, new()
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

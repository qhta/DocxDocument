using DocumentModel.Drawings.Diagrams;
using DiagramDefinitionExtensionList = DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   List of extensions to the CT_DiagramDefintions type..
/// </summary>
public static class DiagramDefinitionExtensionListConverter
{
  public static Collection<DiagramDefinitionExtension>? GetDiagramDefinitionExtensions(DiagramDefinitionExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DiagramDefinitionExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension>())
      {
        var newItem = DiagramDefinitionExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetDiagramDefinitionExtensions(DiagramDefinitionExtensionList? openXmlElement, Collection<DiagramDefinitionExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = DiagramDefinitionExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Diagrams.DiagramDefinitionExtensionList? CreateModelElement(DiagramDefinitionExtensionList? openXmlElement)
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
    where OpenXmlElementType : DiagramDefinitionExtensionList, new()
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
namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the PtExtensionList Class.
/// </summary>
public static class PtExtensionListConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.PtExtension> GetPtExtensions(DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.PtExtension>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.PtExtension>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.PtExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetPtExtensions(DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.PtExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.PtExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.PtExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PtExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.PtExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.PtExtensionList();
      value.PtExtensions = GetPtExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.PtExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPtExtensions(openXmlElement, value?.PtExtensions);
      return openXmlElement;
    }
    return default;
  }
}

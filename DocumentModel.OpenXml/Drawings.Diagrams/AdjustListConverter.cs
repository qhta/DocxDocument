namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Shape Adjust List.
/// </summary>
public static class AdjustListConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Adjust> GetAdjusts(DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Adjust>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Adjust>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Diagrams.AdjustConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetAdjusts(DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Adjust>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Adjust>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.AdjustConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Adjust>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.AdjustList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.AdjustList();
      value.Adjusts = GetAdjusts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.AdjustList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAdjusts(openXmlElement, value?.Adjusts);
      return openXmlElement;
    }
    return default;
  }
}

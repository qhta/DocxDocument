namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleSerExtensionList Class.
/// </summary>
public static class BubbleSerExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BubbleSerExtension>? GetBubbleSerExtensions(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BubbleSerExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.BubbleSerExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetBubbleSerExtensions(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BubbleSerExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.BubbleSerExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BubbleSerExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BubbleSerExtensionList();
      value.BubbleSerExtensions = GetBubbleSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BubbleSerExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

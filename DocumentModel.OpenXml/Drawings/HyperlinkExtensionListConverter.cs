namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Future extensions..
/// </summary>
public static class HyperlinkExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.HyperlinkExtension>? GetHyperlinkExtensions(DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.HyperlinkExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.HyperlinkExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.HyperlinkExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetHyperlinkExtensions(DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.HyperlinkExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.HyperlinkExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.HyperlinkExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HyperlinkExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.HyperlinkExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HyperlinkExtensionList();
      value.HyperlinkExtensions = GetHyperlinkExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.HyperlinkExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}

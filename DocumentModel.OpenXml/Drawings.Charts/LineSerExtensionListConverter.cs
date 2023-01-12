namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the LineSerExtensionList Class.
/// </summary>
public static class LineSerExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LineSerExtension>? GetLineSerExtensions(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LineSerExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.LineSerExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetLineSerExtensions(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LineSerExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.LineSerExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.LineSerExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.LineSerExtensionList();
      value.LineSerExtensions = GetLineSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.LineSerExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}

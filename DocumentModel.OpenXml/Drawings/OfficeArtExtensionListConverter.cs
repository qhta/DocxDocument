namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public static class OfficeArtExtensionListConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Extension> GetExtensions(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Extension>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Extension>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.ExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetExtensions(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Extension>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Extension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.ExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Extension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.OfficeArtExtensionList? CreateModelElement(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.OfficeArtExtensionList();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.OfficeArtExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtensions(openXmlElement, value?.Extensions);
      return openXmlElement;
    }
    return default;
  }
}

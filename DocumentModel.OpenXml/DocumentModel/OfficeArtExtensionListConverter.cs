namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public static class OfficeArtExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Extension>? GetExtensions(DocumentFormat.OpenXml.Office2013.Theme.OfficeArtExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static void SetExtensions(DocumentFormat.OpenXml.Office2013.Theme.OfficeArtExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Extension>? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.OfficeArtExtensionList? CreateModelElement(DocumentFormat.OpenXml.Office2013.Theme.OfficeArtExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.OfficeArtExtensionList();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.OfficeArtExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Theme.OfficeArtExtensionList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

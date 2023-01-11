namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public static class ExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Extension>? GetExtensions(DocumentFormat.OpenXml.Drawing.ExtensionList? openXmlElement)
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
  
  public static void SetExtensions(DocumentFormat.OpenXml.Drawing.ExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Extension>? value)
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
  
  public static DocumentModel.Drawings.ExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ExtensionList();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ExtensionList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

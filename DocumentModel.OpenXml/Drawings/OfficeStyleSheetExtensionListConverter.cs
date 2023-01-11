namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the OfficeStyleSheetExtensionList Class.
/// </summary>
public static class OfficeStyleSheetExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.OfficeStyleSheetExtension>? GetOfficeStyleSheetExtensions(DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.OfficeStyleSheetExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.OfficeStyleSheetExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetOfficeStyleSheetExtensions(DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.OfficeStyleSheetExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.OfficeStyleSheetExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.OfficeStyleSheetExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.OfficeStyleSheetExtensionList();
      value.OfficeStyleSheetExtensions = GetOfficeStyleSheetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.OfficeStyleSheetExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

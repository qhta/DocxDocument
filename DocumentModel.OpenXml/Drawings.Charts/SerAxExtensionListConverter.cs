namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SerAxExtensionList Class.
/// </summary>
public static class SerAxExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SerAxExtension>? GetSerAxExtensions(DocumentFormat.OpenXml.Drawing.Charts.SerAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SerAxExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.SerAxExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetSerAxExtensions(DocumentFormat.OpenXml.Drawing.Charts.SerAxExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SerAxExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.SerAxExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.SerAxExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.SerAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SerAxExtensionList();
      value.SerAxExtensions = GetSerAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.SerAxExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.SerAxExtensionList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DLblExtensionList Class.
/// </summary>
public static class DLblExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DLblExtension>? GetDLblExtensions(DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DLblExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DLblExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.DLblExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetDLblExtensions(DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DLblExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DLblExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.DLblExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DLblExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DLblExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DLblExtensionList();
      value.DLblExtensions = GetDLblExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DLblExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDLblExtensions(openXmlElement, value?.DLblExtensions);
      return openXmlElement;
    }
    return default;
  }
}

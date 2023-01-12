namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ValAxExtensionList Class.
/// </summary>
public static class ValAxExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.ValAxExtension>? GetValAxExtensions(DocumentFormat.OpenXml.Drawing.Charts.ValAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.ValAxExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.ValAxExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetValAxExtensions(DocumentFormat.OpenXml.Drawing.Charts.ValAxExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.ValAxExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.ValAxExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ValAxExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.ValAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ValAxExtensionList();
      value.ValAxExtensions = GetValAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ValAxExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.ValAxExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DateAxExtensionList Class.
/// </summary>
public static class DateAxExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DateAxExtension>? GetDateAxExtensions(DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DateAxExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.DateAxExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetDateAxExtensions(DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DateAxExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.DateAxExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DateAxExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DateAxExtensionList();
      value.DateAxExtensions = GetDateAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DateAxExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

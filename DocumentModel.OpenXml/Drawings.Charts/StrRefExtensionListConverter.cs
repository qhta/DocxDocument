namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StrRefExtensionList Class.
/// </summary>
public static class StrRefExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.StrRefExtension>? GetStrRefExtensions(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.StrRefExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.StrRefExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetStrRefExtensions(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.StrRefExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.StrRefExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.StrRefExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StrRefExtensionList();
      value.StrRefExtensions = GetStrRefExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StrRefExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}

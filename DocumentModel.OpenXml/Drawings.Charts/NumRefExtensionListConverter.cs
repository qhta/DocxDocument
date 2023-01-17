namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the NumRefExtensionList Class.
/// </summary>
public static class NumRefExtensionListConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.NumRefExtension> GetNumRefExtensions(DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.NumRefExtension>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.NumRefExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetNumRefExtensions(DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.NumRefExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.NumRefExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.NumRefExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumRefExtensionList();
      value.NumRefExtensions = GetNumRefExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.NumRefExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumRefExtensions(openXmlElement, value?.NumRefExtensions);
      return openXmlElement;
    }
    return default;
  }
}

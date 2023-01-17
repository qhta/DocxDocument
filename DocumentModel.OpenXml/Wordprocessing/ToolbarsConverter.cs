namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Toolbars Class.
/// </summary>
public static class ToolbarsConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AllocatedCommandManifest> GetAllocatedCommandManifests(DocumentFormat.OpenXml.Office.Word.Toolbars openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AllocatedCommandManifest>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest>())
    {
      var newItem = DocumentModel.OpenXml.Wordprocessing.AllocatedCommandManifestConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetAllocatedCommandManifests(DocumentFormat.OpenXml.Office.Word.Toolbars openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AllocatedCommandManifest>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.AllocatedCommandManifestConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ToolbarData> GetToolbarDatas(DocumentFormat.OpenXml.Office.Word.Toolbars openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ToolbarData>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.ToolbarData>())
    {
      var newItem = DocumentModel.OpenXml.Wordprocessing.ToolbarDataConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetToolbarDatas(DocumentFormat.OpenXml.Office.Word.Toolbars openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ToolbarData>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.ToolbarData>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.ToolbarDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.ToolbarData>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Toolbars? CreateModelElement(DocumentFormat.OpenXml.Office.Word.Toolbars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Toolbars();
      value.AllocatedCommandManifests = GetAllocatedCommandManifests(openXmlElement);
      value.ToolbarDatas = GetToolbarDatas(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Toolbars? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.Toolbars, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAllocatedCommandManifests(openXmlElement, value?.AllocatedCommandManifests);
      SetToolbarDatas(openXmlElement, value?.ToolbarDatas);
      return openXmlElement;
    }
    return default;
  }
}

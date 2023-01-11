namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommandManifest Class.
/// </summary>
public static class AllocatedCommandManifestConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AcceleratorKeymapType>? GetAllocatedCommandManifestEntries(DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AcceleratorKeymapType>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifestEntry>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.AcceleratorKeymapTypeConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetAllocatedCommandManifestEntries(DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AcceleratorKeymapType>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifestEntry>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.AcceleratorKeymapTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifestEntry>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.AllocatedCommandManifest? CreateModelElement(DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AllocatedCommandManifest();
      value.AllocatedCommandManifestEntries = GetAllocatedCommandManifestEntries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.AllocatedCommandManifest? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

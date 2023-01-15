using DocumentFormat.OpenXml.Office.Word;
using AcceleratorKeymapType = DocumentModel.Wordprocessing.AcceleratorKeymapType;
using AllocatedCommandManifest = DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the AllocatedCommandManifest Class.
/// </summary>
public static class AllocatedCommandManifestConverter
{
  public static Collection<AcceleratorKeymapType>? GetAllocatedCommandManifestEntries(AllocatedCommandManifest? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<AcceleratorKeymapType>();
      foreach (var item in openXmlElement.Elements<AllocatedCommandManifestEntry>())
      {
        var newItem = AcceleratorKeymapTypeConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetAllocatedCommandManifestEntries(AllocatedCommandManifest? openXmlElement, Collection<AcceleratorKeymapType>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<AllocatedCommandManifestEntry>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = AcceleratorKeymapTypeConverter.CreateOpenXmlElement<AllocatedCommandManifestEntry>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.AllocatedCommandManifest? CreateModelElement(AllocatedCommandManifest? openXmlElement)
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
    where OpenXmlElementType : AllocatedCommandManifest, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAllocatedCommandManifestEntries(openXmlElement, value?.AllocatedCommandManifestEntries);
      return openXmlElement;
    }
    return default;
  }
}
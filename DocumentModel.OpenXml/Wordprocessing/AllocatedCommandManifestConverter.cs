namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommandManifest Class.
/// </summary>
public static class AllocatedCommandManifestConverter
{
  private static Collection<DMW.AcceleratorKeymapType> GetAllocatedCommandManifestEntries(DXOW.AllocatedCommandManifest openXmlElement)
  {
    var collection = new Collection<DMW.AcceleratorKeymapType>();
    foreach (var item in openXmlElement.Elements<DXOW.AllocatedCommandManifestEntry>())
    {
      var newItem = DMXW.AcceleratorKeymapTypeConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpAllocatedCommandManifestEntries(DXOW.AllocatedCommandManifest openXmlElement, Collection<DMW.AcceleratorKeymapType>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetAllocatedCommandManifestEntries(DXOW.AllocatedCommandManifest openXmlElement, Collection<DMW.AcceleratorKeymapType>? value)
  {
    openXmlElement.RemoveAllChildren<DXOW.AllocatedCommandManifestEntry>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.AcceleratorKeymapTypeConverter.CreateOpenXmlElement<DXOW.AllocatedCommandManifestEntry>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.AllocatedCommandManifest? CreateModelElement(DXOW.AllocatedCommandManifest? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.AllocatedCommandManifest();
      value.AllocatedCommandManifestEntries = GetAllocatedCommandManifestEntries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOW.AllocatedCommandManifest? openXmlElement, DMW.AllocatedCommandManifest? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAllocatedCommandManifestEntries(openXmlElement, value.AllocatedCommandManifestEntries, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.AllocatedCommandManifest? value)
    where OpenXmlElementType: DXOW.AllocatedCommandManifest, new()
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

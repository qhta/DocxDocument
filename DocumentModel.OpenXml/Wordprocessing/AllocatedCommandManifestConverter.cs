namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommandManifest Class.
/// </summary>
public static class AllocatedCommandManifestConverter
{
  private static Collection<DMW.AcceleratorKeymapType>? GetAllocatedCommandManifestEntries(DXOW.AllocatedCommandManifest openXmlElement)
  {
    var collection = new Collection<DMW.AcceleratorKeymapType>();
    foreach (var item in openXmlElement.Elements<DXOW.AllocatedCommandManifestEntry>())
    {
      var newItem = DMXW.AcceleratorKeymapTypeConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAllocatedCommandManifestEntries(DXOW.AllocatedCommandManifest openXmlElement, Collection<DMW.AcceleratorKeymapType>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXOW.AllocatedCommandManifestEntry>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.AcceleratorKeymapTypeConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.AllocatedCommandManifest value)
    where OpenXmlElementType: DXOW.AllocatedCommandManifest, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOW.AllocatedCommandManifest openXmlElement, DMW.AllocatedCommandManifest value)
  {
    SetAllocatedCommandManifestEntries(openXmlElement, value?.AllocatedCommandManifestEntries);
  }
}

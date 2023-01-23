namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Toolbars Class.
/// </summary>
public static class ToolbarsConverter
{
  private static Collection<DMW.AllocatedCommandManifest> GetAllocatedCommandManifests(DXOW.Toolbars openXmlElement)
  {
    var collection = new Collection<DMW.AllocatedCommandManifest>();
    foreach (var item in openXmlElement.Elements<DXOW.AllocatedCommandManifest>())
    {
      var newItem = DMXW.AllocatedCommandManifestConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpAllocatedCommandManifests(DXOW.Toolbars openXmlElement, Collection<DMW.AllocatedCommandManifest>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetAllocatedCommandManifests(DXOW.Toolbars openXmlElement, Collection<DMW.AllocatedCommandManifest>? value)
  {
    openXmlElement.RemoveAllChildren<DXOW.AllocatedCommandManifest>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.AllocatedCommandManifestConverter.CreateOpenXmlElement<DXOW.AllocatedCommandManifest>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<DMW.ToolbarData> GetToolbarDatas(DXOW.Toolbars openXmlElement)
  {
    var collection = new Collection<DMW.ToolbarData>();
    foreach (var item in openXmlElement.Elements<DXOW.ToolbarData>())
    {
      var newItem = DMXW.ToolbarDataConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpToolbarDatas(DXOW.Toolbars openXmlElement, Collection<DMW.ToolbarData>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetToolbarDatas(DXOW.Toolbars openXmlElement, Collection<DMW.ToolbarData>? value)
  {
    openXmlElement.RemoveAllChildren<DXOW.ToolbarData>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.ToolbarDataConverter.CreateOpenXmlElement<DXOW.ToolbarData>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.Toolbars? CreateModelElement(DXOW.Toolbars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Toolbars();
      value.AllocatedCommandManifests = GetAllocatedCommandManifests(openXmlElement);
      value.ToolbarDatas = GetToolbarDatas(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOW.Toolbars? openXmlElement, DMW.Toolbars? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAllocatedCommandManifests(openXmlElement, value.AllocatedCommandManifests, diffs, objName))
        ok = false;
      if (!CmpToolbarDatas(openXmlElement, value.ToolbarDatas, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Toolbars? value)
    where OpenXmlElementType: DXOW.Toolbars, new()
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

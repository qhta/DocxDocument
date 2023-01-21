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

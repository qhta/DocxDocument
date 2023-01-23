namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public static class ExtensionListConverter
{
  private static Collection<DM.Extension> GetExtensions(DXO2021DocTasks.ExtensionList openXmlElement)
  {
    var collection = new Collection<DM.Extension>();
    foreach (var item in openXmlElement.Elements<DXO2021OExtLst.Extension>())
    {
      var newItem = DMX.ExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpExtensions(DXO2021DocTasks.ExtensionList openXmlElement, Collection<DM.Extension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetExtensions(DXO2021DocTasks.ExtensionList openXmlElement, Collection<DM.Extension>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2021OExtLst.Extension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.ExtensionConverter.CreateOpenXmlElement<DXO2021OExtLst.Extension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DM.ExtensionList? CreateModelElement(DXO2021DocTasks.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.ExtensionList();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021DocTasks.ExtensionList? openXmlElement, DM.ExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtensions(openXmlElement, value.Extensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.ExtensionList? value)
    where OpenXmlElementType: DXO2021DocTasks.ExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtensions(openXmlElement, value?.Extensions);
      return openXmlElement;
    }
    return default;
  }
}

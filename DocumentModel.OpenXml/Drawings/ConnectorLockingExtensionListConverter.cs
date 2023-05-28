namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ConnectorLockingExtensionList Class.
/// </summary>
public static class ConnectorLockingExtensionListConverter
{
  private static Collection<DMD.ConnectorLockingExtension>? GetConnectorLockingExtensions(DXD.ConnectorLockingExtensionList openXmlElement)
  {
    var collection = new Collection<DMD.ConnectorLockingExtension>();
    foreach (var item in openXmlElement.Elements<DXD.ConnectorLockingExtension>())
    {
      var newItem = DMXD.ConnectorLockingExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpConnectorLockingExtensions(DXD.ConnectorLockingExtensionList openXmlElement, Collection<DMD.ConnectorLockingExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXD.ConnectorLockingExtension>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXD.ConnectorLockingExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetConnectorLockingExtensions(DXD.ConnectorLockingExtensionList openXmlElement, Collection<DMD.ConnectorLockingExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.ConnectorLockingExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.ConnectorLockingExtensionConverter.CreateOpenXmlElement<DXD.ConnectorLockingExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMD.ConnectorLockingExtensionList? CreateModelElement(DXD.ConnectorLockingExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ConnectorLockingExtensionList();
      value.ConnectorLockingExtensions = GetConnectorLockingExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.ConnectorLockingExtensionList? openXmlElement, DMD.ConnectorLockingExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpConnectorLockingExtensions(openXmlElement, value.ConnectorLockingExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ConnectorLockingExtensionList value)
    where OpenXmlElementType: DXD.ConnectorLockingExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ConnectorLockingExtensionList openXmlElement, DMD.ConnectorLockingExtensionList value)
  {
    SetConnectorLockingExtensions(openXmlElement, value?.ConnectorLockingExtensions);
  }
}

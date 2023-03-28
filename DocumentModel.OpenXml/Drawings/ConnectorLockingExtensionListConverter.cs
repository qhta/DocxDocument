namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ConnectorLockingExtensionList Class converter from/to OpenXml.
///</summary>
public static class ConnectorLockingExtensionListConverter
{
  private static Collection<DMDraws.ConnectorLockingExtension>? GetConnectorLockingExtensions(DXDraw.ConnectorLockingExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.ConnectorLockingExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.ConnectorLockingExtension>())
    {
      var newItem = DMXDraws.ConnectorLockingExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpConnectorLockingExtensions(DXDraw.ConnectorLockingExtensionList openXmlElement, Collection<DMDraws.ConnectorLockingExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDraw.ConnectorLockingExtension>();
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
        if (!DMXDraws.ConnectorLockingExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetConnectorLockingExtensions(DXDraw.ConnectorLockingExtensionList openXmlElement, Collection<DMDraws.ConnectorLockingExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.ConnectorLockingExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.ConnectorLockingExtensionConverter.CreateOpenXmlElement<DXDraw.ConnectorLockingExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ConnectorLockingExtensionList? CreateModelElement(DXDraw.ConnectorLockingExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ConnectorLockingExtensionList();
      value.ConnectorLockingExtensions = GetConnectorLockingExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ConnectorLockingExtensionList? openXmlElement, DMDraws.ConnectorLockingExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpConnectorLockingExtensions(openXmlElement, value.ConnectorLockingExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ConnectorLockingExtensionList value)
    where OpenXmlElementType: DXDraw.ConnectorLockingExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.ConnectorLockingExtensionList openXmlElement, DMDraws.ConnectorLockingExtensionList value)
  {
    SetConnectorLockingExtensions(openXmlElement, value?.ConnectorLockingExtensions);
  }
}
